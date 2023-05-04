using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace VidroArte.Pages.Shared
{
    public class _LayoutModel : PageModel
    {        public string bemvindomensagem = "";
        public string completarcadastro = "";
        public void OnGet()
        {
            string nomeUsuario = HttpContext.Session.GetString("nomeUsuario");
            if (string.IsNullOrEmpty(nomeUsuario))
            {
                HttpContext.Response.Redirect("/Index");
            }
            else
            {
                bemvindomensagem = $"Bem-vindo, {nomeUsuario}.";

                string connectionString = "Data Source=LAPTOP-B2EBJ1MT;Initial Catalog=vidroarte;Integrated Security=True";
                //string connectionString = "Data Source=vidroarte.database.windows.net;Initial Catalog=vidroarte;User ID=vidroarte;Password='Jato@12345'";
                SqlConnection conexao = new(connectionString);
                conexao.Open();
                string sql = "SELECT COUNT(*) FROM cliente WHERE nome = @nome and cpf_cnpj is not null";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", nomeUsuario);

                int resultado = (int)comando.ExecuteScalar();

                if (resultado == 0)
                {
                    completarcadastro = "complete seu cadastro";
                }
            }
        }

        public void OnPost()
        {
            HttpContext.Session.Clear();
            HttpContext.Response.Redirect("/Index");
        }

    }
}

