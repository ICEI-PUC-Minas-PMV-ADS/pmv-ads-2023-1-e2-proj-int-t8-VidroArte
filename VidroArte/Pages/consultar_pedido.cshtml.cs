using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace VidroArte.Pages
{
    public class consultar_pedidoModel : PageModel
    {
        public List<ClientInfo> ListClients = new List<ClientInfo>();

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
                            ClientInfo clientInfo = new ClientInfo();

                            clientInfo.id = "" + leitor.GetString(0);
                            clientInfo.RazaoSocial = leitor.GetString(1);
                            clientInfo.Nome = leitor.GetString(2);
                            clientInfo.CPF_CNPJ = leitor.GetString(3);
                            clientInfo.InscEstadual = leitor.GetString(4);
                            clientInfo.Responsavel = leitor.GetString(5);
                            clientInfo.RG = leitor.GetString(6);
                            clientInfo.DtNascimento = leitor.GetString(7);
                            clientInfo.Email = leitor.GetString(8);
                            clientInfo.Telefone = leitor.GetString(9);
                            clientInfo.Celular = leitor.GetString(10);
                            clientInfo.CEP = leitor.GetString(11);
                            clientInfo.Rua = leitor.GetString(12);
                            clientInfo.Numero = leitor.GetString(13);
                            clientInfo.Complemento = leitor.GetString(14);
                            clientInfo.Bairro = leitor.GetString(15);
                            clientInfo.Cidade = leitor.GetString(16);
                            clientInfo.UF = leitor.GetString(17);
                            clientInfo.Usuario = leitor.GetString(18);
                            clientInfo.Senha = leitor.GetString(19);
                            clientInfo.Banco = leitor.GetString(20);
                            clientInfo.Agencia = leitor.GetString(21);
                            clientInfo.Conta = leitor.GetString(22);
                            clientInfo.TipoConta = leitor.GetString(23);




                            ListClients.Add(clientInfo);
                        }

                    }
                }
                     conexao.Close();
            }

        }

    }
    public class ClientInfo
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
