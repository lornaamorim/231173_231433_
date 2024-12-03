using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231173_231433_.Models
{
    public class VendaDet
    {
        public int Id { get; set; }
        public int idVendaCab {  get; set; }
        public int idProduto {  get; set; }
        public double qtde {  get; set; }
        public double valorUnitario { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO vendaDet (idVendaCab, idProduto, qtde, valorUnitario)" +
                    "VALUES (@idVendaCab, @idProduto, @qtde, @valorUnitario)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idVendaCab", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@idProduto", idProduto);
                Banco.Comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("@valorUnitario", valorUnitario);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
