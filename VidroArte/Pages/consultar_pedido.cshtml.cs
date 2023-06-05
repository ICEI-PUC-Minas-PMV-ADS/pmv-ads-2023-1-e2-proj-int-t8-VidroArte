using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace VidroArte.Pages
{
    public class consultar_clienteModel : PageModel
    {

        public void OnPost(string salvar_orcamento)
        {

            using (SqlConnection conexao = DatabaseConnection.GetConnection())
            {
                string selectQuery = "SELECT RazaoSocial, Nome, CPF_CNPJ, InscEstadual, Responsavel, RG, DtNascimento, Email, Telefone, Celular, CEP, Rua, Numero, Complemento, Bairro, Cidade, UF, Usuario, Senha, Banco, Agencia, Conta, Digito, TipoConta " +
                                     "FROM cliente";

                SqlCommand comando = new SqlCommand(selectQuery, conexao);

                conexao.Open();

                SqlDataReader leitor = comando.ExecuteReader();

                // Preencher a tabela com os dados recuperados
                while (leitor.Read())
                {
                    tabela.Rows.Add(leitor["RazaoSocial"], leitor["Nome"], leitor["CPF_CNPJ"], leitor["InscEstadual"], leitor["Responsavel"], leitor["RG"], leitor["DtNascimento"], leitor["Email"], leitor["Telefone"], leitor["Celular"], leitor["CEP"], leitor["Rua"], leitor["Numero"], leitor["Complemento"], leitor["Bairro"], leitor["Cidade"], leitor["UF"], leitor["Usuario"], leitor["Senha"], leitor["Banco"], leitor["Agencia"], leitor["Conta"], leitor["Digito"], leitor["TipoConta"]);
                }

                leitor.Close();

                // Adicionar a tabela ao formulário
                Controls.Add(tabela);
            }

        }

        }
    }
}
