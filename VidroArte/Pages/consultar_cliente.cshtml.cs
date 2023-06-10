using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace VidroArte.Pages
{
    public class consultar_clienteModel : PageModel
    {
        public List<ClientInfo2> ListClients2 = new List<ClientInfo2>();

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
                            ClientInfo2 clientInfo2 = new ClientInfo2();

                            clientInfo2.id = "" + leitor.GetString(0);
                            clientInfo2.RazaoSocial = leitor.GetString(1);
                            clientInfo2.Nome = leitor.GetString(2);
                            clientInfo2.CPF_CNPJ = leitor.GetString(3);
                            clientInfo2.InscEstadual = leitor.GetString(4);
                            clientInfo2.Responsavel = leitor.GetString(5);
                            clientInfo2.RG = leitor.GetString(6);
                            clientInfo2.DtNascimento = leitor.GetString(7);
                            clientInfo2.Email = leitor.GetString(8);
                            clientInfo2.Telefone = leitor.GetString(9);
                            clientInfo2.Celular = leitor.GetString(10);
                            clientInfo2.CEP = leitor.GetString(11);
                            clientInfo2.Rua = leitor.GetString(12);
                            clientInfo2.Numero = leitor.GetString(13);
                            clientInfo2.Complemento = leitor.GetString(14);
                            clientInfo2.Bairro = leitor.GetString(15);
                            clientInfo2.Cidade = leitor.GetString(16);
                            clientInfo2.UF = leitor.GetString(17);
                            clientInfo2.Usuario = leitor.GetString(18);
                            clientInfo2.Senha = leitor.GetString(19);
                            clientInfo2.Banco = leitor.GetString(20);
                            clientInfo2.Agencia = leitor.GetString(21);
                            clientInfo2.Conta = leitor.GetString(22);
                            clientInfo2.TipoConta = leitor.GetString(23);




                            ListClients2.Add(clientInfo2);
                        }

                    }
                }
                conexao.Close();
            }

        }

    }
    public class ClientInfo2
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
