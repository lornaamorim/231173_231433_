using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _231173_231433_.Models
{
    public class VendaCab
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public DateTime data {  get; set; }
        public double total { get; set; }

        public int Incluir()
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO vendaCab (idCliente, data, total)" +
                    "VALUES (@idCliente, @data, @total)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }

}
