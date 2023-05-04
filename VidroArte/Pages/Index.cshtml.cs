using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace vidroarte.Views.Home
{
    public class Usuario
    {
        public string Nome { get; set; }

    }
    public class IndexModel : PageModel
    {
        public string errorMessage = "";
        public string errorMessagecadastro = "";
        public void OnGet()
        {

        }
        public void OnPost(string Logar, string cadastrar)
        {
            string connectionString = "Data Source=LAPTOP-B2EBJ1MT;Initial Catalog=vidroarte;Integrated Security=True";
            //string connectionString = "Data Source=vidroarte.database.windows.net;Initial Catalog=vidroarte;User ID=vidroarte;Password='Jato@12345'";
            SqlConnection conexao = new(connectionString);

            if (!string.IsNullOrEmpty(Logar))
            {
                string email = Request.Form["email"];
                string senha = Request.Form["senha"];

                    try
                    {
                        conexao.Open();

                        string sql = "SELECT nome FROM cliente WHERE Email = @email AND Senha = @senha";
                        SqlCommand comando = new SqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@senha", senha);

                        string resultado = (string)comando.ExecuteScalar();

                        if (!string.IsNullOrEmpty(resultado))
                        {
                            HttpContext.Session.SetString("nomeUsuario", resultado);
                            Response.Redirect("/Inicio");
                        }
                        else
                        {
                            errorMessage = "Usuário ou senha inválido!";
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessage = "Erro ao autenticar usuário, tente Novamente";
                    }
                    finally
                    {
                        conexao.Close();
                    }
            }
            else if (!string.IsNullOrEmpty(cadastrar))
            {
                string nome_comp_cad = Request.Form["nome_comp_cad"];
                string nome_cad = Request.Form["nome_cad"];
                string email_cad = Request.Form["email_cad"];
                string senha_cad = Request.Form["senha_cad"];
                string conf_senha_cad = Request.Form["conf_senha_cad"];

                Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@_])[A-Za-z\\d@_]{8,}$");

                try
                {
                    conexao.Open();

                    string sql = "SELECT email FROM cliente WHERE email = @email_cad";
                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@email_cad", email_cad);


                    string resultado = (string)comando.ExecuteScalar();

                    if (string.IsNullOrEmpty(resultado))
                    {
                        if (senha_cad != conf_senha_cad) 
                        {
                            errorMessagecadastro = "as senhas digitadas estão diferentes";
                        }
                        else if (senha_cad.Length < 8 || !regex.IsMatch(senha_cad))
                        {
                            errorMessagecadastro = "Senha deve conter:\n - 8 caracteres \n - pelo menos uma letra Maiúscula \n - pelo menos uma letra Minuscula \n- pelo menos um caracter especial";
                        }
                        else
                        {
                            sql = "INSERT INTO cliente (nome_completo, nome, email,  senha) VALUES (@nome_comp_cad,@nome_cad,@email_cad,@senha_cad)";
                            comando = new SqlCommand(sql, conexao);
                            comando.Parameters.AddWithValue("@nome_comp_cad", nome_comp_cad);
                            comando.Parameters.AddWithValue("@nome_cad", nome_cad);
                            comando.Parameters.AddWithValue("@email_cad", email_cad);
                            comando.Parameters.AddWithValue("@senha_cad", senha_cad);


                            resultado = (string)comando.ExecuteScalar();
                            errorMessagecadastro = "Usuário cadastrado com Sucesso, faça Login!";

                        }
                    }
                    else
                    {
                        errorMessagecadastro = "E-mail já cadastrado!";
                    }
                }
                catch (Exception ex)
                {
                    errorMessagecadastro = "Erro de conexão, tente Novamente";
                }
                finally
                {
                    conexao.Close();
                }

            }
        }
    }
}
