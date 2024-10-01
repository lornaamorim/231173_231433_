﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

    namespace _231173_231433_
    {
        public class Banco
        {
            public static MySqlConnection Conexao;

            public static MySqlCommand Comando;

            public static MySqlDataAdapter Adaptador;

            public static DataTable datTabela;
        }

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxButtons.Error);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXIST vendas; USE vendas", Conexao);
                Comando.ExecuteNonQuery();

                FecharConexao();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void CriarBanco()
        {
             try
             {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXIST vendas; USE vendas", Conexao);

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXIST Cidades " +
                                                "(id integer auto_increment primary key, " +
                                                "nome char(40), " +
                                                "uf char (02))", Conexao);

                Comando.ExecuteNonQuery();

                FecharConexao();

             }
             catch (Exception e)
             {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

    }
