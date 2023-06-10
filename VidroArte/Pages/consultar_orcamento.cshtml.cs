using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace VidroArte.Pages
{
    public class consultar_orcamentoModel : PageModel
    {
        public List<ClientInfo1> ListClients1 = new List<ClientInfo1>();

        public void onGet()
        {

            using (SqlConnection conexao = DatabaseConnection.GetConnection())
            {
                conexao.Open();
                string selectQuery = "SELECT * from pedidos";

                using SqlCommand comando = new SqlCommand(selectQuery, conexao);
                {
                    using SqlDataReader leitor = comando.ExecuteReader();
                    {
                        while (leitor.Read())
                        {
                            ClientInfo1 clientInfo1 = new ClientInfo1();

                            clientInfo1.id = "" + leitor.GetString(0);
                            clientInfo1.RazaoSocial = leitor.GetString(1);
                            clientInfo1.Nome = leitor.GetString(2);
                            clientInfo1.CPF_CNPJ = leitor.GetString(3);
                            clientInfo1.InscEstadual = leitor.GetString(4);
                            clientInfo1.Responsavel = leitor.GetString(5);
                            clientInfo1.RG = leitor.GetString(6);
                            clientInfo1.DtNascimento = leitor.GetString(7);
                            clientInfo1.Email = leitor.GetString(8);
                            clientInfo1.Telefone = leitor.GetString(9);
                            clientInfo1.Celular = leitor.GetString(10);
                            clientInfo1.CEP = leitor.GetString(11);
                            clientInfo1.Rua = leitor.GetString(12);
                            clientInfo1.Numero = leitor.GetString(13);
                            clientInfo1.Complemento = leitor.GetString(14);
                            clientInfo1.Bairro = leitor.GetString(15);
                            clientInfo1.Cidade = leitor.GetString(16);
                            clientInfo1.UF = leitor.GetString(17);
                            clientInfo1.Usuario = leitor.GetString(18);
                            clientInfo1.Senha = leitor.GetString(19);
                            clientInfo1.Banco = leitor.GetString(20);
                            clientInfo1.Agencia = leitor.GetString(21);
                            clientInfo1.Conta = leitor.GetString(22);
                            clientInfo1.TipoConta = leitor.GetString(23);
    



                            ListClients1.Add(clientInfo1);
                        }

                    }
                }
                conexao.Close();
            }

        }

    }
    public class ClientInfo1
    {
        public string id;
        public string RazaoSocial;
        public string Nome;
        public string CPF_CNPJ;
        public string InscEstadual;
        public string Responsavel;
        public string RG;
        public string DtNascimento;
        public string Email;
        public string Telefone;
        public string Celular;
        public string CEP;
        public string Rua;
        public string Numero;
        public string Complemento;
        public string Bairro;
        public string Cidade;
        public string UF;
        public string Usuario;
        public string Senha;
        public string Banco;
        public string Agencia;
        public string Conta;
        public string Digito;
        public string TipoConta;

    }

}
