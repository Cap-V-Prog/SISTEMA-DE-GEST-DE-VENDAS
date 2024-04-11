using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ficha001
{
    public class ClientManager
    {
        private static MySql.Data.MySqlClient.MySqlConnection Conexao;
        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Tipo { get; set; }
            public string Email { get; set; }
            public int Telefone { get; set; }
            public string Morada { get; set; }
            public DateTime DataInicio { get; set; }
            public string Estado { get; set; }
        
            public Cliente(int id, string nome, string tipo, string email, int telefone, string morada, DateTime dataInicio, string estado)
            {
                Id = id;
                Nome = nome;
                Tipo = tipo;
                Email = email;
                Telefone = telefone;
                Morada = morada;
                DataInicio = dataInicio;
                Estado = estado;
            }
        }

        public static void RegisterClient(Cliente obj)
        {
            try
            {
                Conexao = new ConnectionFactory().GetConnection();
                string sql = @"Insert into tb_clientes(estadoCli,nome_cliente,email,telefone,morada,dataInicio) values (@estadoCli,@nome_cliente,@email,@telefone,@morada,@dataInicio)";
                MySqlCommand execcmd = new MySqlCommand(sql, Conexao);
                execcmd.Parameters.AddWithValue("@estadoCli", obj.Estado);
                execcmd.Parameters.AddWithValue("@nome_cliente", obj.Nome);
                execcmd.Parameters.AddWithValue("@email", obj.Email);
                execcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                execcmd.Parameters.AddWithValue("@morada", obj.Morada);
                execcmd.Parameters.AddWithValue("@dataInicio", obj.DataInicio);
                
                Conexao.Open();
                execcmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Registrado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a registar o cliente" + e);
                throw;
            }
        }
    }
}