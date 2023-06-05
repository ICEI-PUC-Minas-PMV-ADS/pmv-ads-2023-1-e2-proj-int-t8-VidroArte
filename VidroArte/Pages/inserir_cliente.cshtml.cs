using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using vidroarte.Views.Home;

namespace VidroArte.Pages
{
    public class inserir_clienteModel : PageModel
    {

        public void OnPost(string salvar_cliente)
        {

            using (SqlConnection conexao = DatabaseConnection.GetConnection())
            {

                if (!string.IsNullOrEmpty(salvar_cliente))
                {
                    string razaosocial = Request.Form["razaosocial"];
                    string nome = Request.Form["nome"];
                    string cpfCnpj = Request.Form["cpf-Cnpj"];
                    string inscestadual = Request.Form["inscestadual"];
                    string responsavel = Request.Form["responsavel"];
                    string rg = Request.Form["rg"];
                    string dtnascimento = Request.Form["dtnascimento"];
                    string email = Request.Form["email"];
                    string telefone = Request.Form["telefone"];
                    string celular = Request.Form["celular"];
                    string cep = Request.Form["cep"];
                    string rua = Request.Form["rua"];
                    string num = Request.Form["num"];
                    string numcomp = Request.Form["numcomp"];
                    string bairro = Request.Form["bairro"];
                    string cidade = Request.Form["cidade"];
                    string uf = Request.Form["uf"];
                    string usuario = Request.Form["usuario"];
                    string senha = Request.Form["senha"];
                    string banco = Request.Form["banco"];
                    string agencia = Request.Form["agencia"];
                    string conta = Request.Form["conta"];
                    string digito = Request.Form["digito"];
                    string tipoconta = Request.Form["tipoconta"];

                    try
                    {
                        conexao.Open();

                        string sql = "INSERT INTO SuaTabela (RazaoSocial, Nome, CPF_CNPJ, InscEstadual, Responsavel, RG, DtNascimento, Email, Telefone, Celular, CEP, Rua, Numero, Complemento, Bairro, Cidade, UF, Usuario, Senha, Banco, Agencia, Conta, Digito, TipoConta) " +
           "VALUES (@RazaoSocial, @Nome, @CPF_CNPJ, @InscEstadual, @Responsavel, @RG, @DtNascimento, @Email, @Telefone, @Celular, @CEP, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @UF, @Usuario, @Senha, @Banco, @Agencia, @Conta, @Digito, @TipoConta)";

                        SqlCommand comando = new SqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@RazaoSocial", razaosocial);
                        comando.Parameters.AddWithValue("@Nome", nome);
                        comando.Parameters.AddWithValue("@CPF_CNPJ", cpfCnpj);
                        comando.Parameters.AddWithValue("@InscEstadual", inscestadual);
                        comando.Parameters.AddWithValue("@Responsavel", responsavel);
                        comando.Parameters.AddWithValue("@RG", rg);
                        comando.Parameters.AddWithValue("@DtNascimento", dtnascimento);
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@Telefone", telefone);
                        comando.Parameters.AddWithValue("@Celular", celular);
                        comando.Parameters.AddWithValue("@CEP", cep);
                        comando.Parameters.AddWithValue("@Rua", rua);
                        comando.Parameters.AddWithValue("@Numero", num);
                        comando.Parameters.AddWithValue("@Complemento", numcomp);
                        comando.Parameters.AddWithValue("@Bairro", bairro);
                        comando.Parameters.AddWithValue("@Cidade", cidade);
                        comando.Parameters.AddWithValue("@UF", uf);
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Senha", senha);
                        comando.Parameters.AddWithValue("@Banco", banco);
                        comando.Parameters.AddWithValue("@Agencia", agencia);
                        comando.Parameters.AddWithValue("@Conta", conta);
                        comando.Parameters.AddWithValue("@Digito", digito);
                        comando.Parameters.AddWithValue("@TipoConta", tipoconta);


                        string resultado = (string)comando.ExecuteScalar();


                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        conexao.Close();
                    }

                }
            }

        }
    }
}
