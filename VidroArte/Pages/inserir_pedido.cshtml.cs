using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace VidroArte.Pages
{
    public class inserir_pedidoModel : PageModel
    {

        public void OnPost(string salvar_pedido)
        {

            using (SqlConnection conexao = DatabaseConnection.GetConnection())
            {

                if (!string.IsNullOrEmpty(salvar_pedido))
                {
                    string total_pedido = Request.Form["total_pedido"];
                    string area = Request.Form["area"];
                    string num_pedido = Request.Form["num_pedido"];
                    string cliente = Request.Form["cliente"];
                    string pedido_cliente = Request.Form["pedido_cliente"];
                    string dt_pedido = Request.Form["dt_pedido"];
                    string dt_pagamento = Request.Form["dt_pagamento"];
                    string dt_entrega = Request.Form["dt_entrega"];
                    string pix = Request.Form["pix"];
                    string credito = Request.Form["credito"];
                    string debito = Request.Form["debito"];
                    string dinheiro = Request.Form["dinheiro"];
                    string comprovante = Request.Form["comprovante"];
                    string obs = Request.Form["obs"];

                    try
                    {
                        conexao.Open();

                        string sql = "INSERT INTO nome_da_tabela (total_pedido, area, num_pedido, cliente, pedido_cliente, dt_pedido, dt_pagamento, dt_entrega, pix, credito, debito, dinheiro, comprovante, obs) VALUES (@total_pedido, @area, @num_pedido, @cliente, @pedido_cliente, @dt_pedido, @dt_pagamento, @dt_entrega, @pix, @credito, @debito, @dinheiro, @comprovante, @obs)";

                        SqlCommand comando = new SqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@total_pedido", total_pedido);
                        comando.Parameters.AddWithValue("@area", area);
                        comando.Parameters.AddWithValue("@num_pedido", num_pedido);
                        comando.Parameters.AddWithValue("@cliente", cliente);
                        comando.Parameters.AddWithValue("@pedido_cliente", pedido_cliente);
                        comando.Parameters.AddWithValue("@dt_pedido", dt_pedido);
                        comando.Parameters.AddWithValue("@dt_pagamento", dt_pagamento);
                        comando.Parameters.AddWithValue("@dt_entrega", dt_entrega);
                        comando.Parameters.AddWithValue("@pix", pix);
                        comando.Parameters.AddWithValue("@credito", credito);
                        comando.Parameters.AddWithValue("@debito", debito);
                        comando.Parameters.AddWithValue("@dinheiro", dinheiro);
                        comando.Parameters.AddWithValue("@comprovante", comprovante);
                        comando.Parameters.AddWithValue("@obs", obs);

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
