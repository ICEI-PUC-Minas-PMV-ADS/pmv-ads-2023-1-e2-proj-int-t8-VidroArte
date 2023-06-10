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

                using (SqlConnection conexao = DatabaseConnection.GetConnection())
                {
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
        }

        public void OnPost(string logout)
        {
            {
                if (!string.IsNullOrEmpty(logout))
                {
                    HttpContext.Session.Clear();
                    HttpContext.Response.Redirect("/Index");
                }
            }
        }
    }
}

