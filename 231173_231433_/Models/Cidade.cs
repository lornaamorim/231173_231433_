using _231173_231433_;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace _31173_231433_.Models
{
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
    }

    public void Incluir()
    {
        try
        {
            Banco.AbrirConexao();

            Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome,  @uf", Banco.Conexao);

            Banco.Comando.Parameters.AddWithValue("@nome", nome);

            Banco.Comando.Parameters.AddWithValue("@uf", uf);

            Banco.Comando.ExecuteNonQuery();

            Banco.FecharConexao();
        }
         
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
