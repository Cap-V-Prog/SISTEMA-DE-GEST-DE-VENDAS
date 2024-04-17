using System;
using System.Data;
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
            public int NIF { get; set; }
        
            public Cliente(int id, string nome, string tipo, string email, int telefone, string morada, DateTime dataInicio, string estado,int nif)
            {
                Id = id;
                Nome = nome;
                Tipo = tipo;
                Email = email;
                Telefone = telefone;
                Morada = morada;
                DataInicio = dataInicio;
                Estado = estado;
                NIF = nif;
            }
        }

        public static void DelClient(int ID)
        {
            try
            {
                Conexao = new ConnectionFactory().GetConnection();
                string sql = @"DELETE FROM clients WHERE id=(@ID)";
                MySqlCommand execcmd = new MySqlCommand(sql, Conexao);
                execcmd.Parameters.AddWithValue("@ID", ID);

                Conexao.Open();
                execcmd.ExecuteNonQuery();
                MessageBox.Show("Cliente removido com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a remover o cliente" + e);
                throw;
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
   

        public static void Search(string SearchKey, int SearchType,DataGridView dataGridView)
        {
            
            Cliente obj;
            
            try
            {
                Conexao = new ConnectionFactory().GetConnection();
                Conexao.Open();
                string sql = $"SELECT * FROM clients WHERE Name LIKE '%{SearchKey}%'";
                MySqlCommand execcmd = new MySqlCommand(sql, Conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(execcmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                dataGridView.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                throw; 
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        public static void RegisterClient(Cliente obj)
        {
            try
            {
                Conexao = new ConnectionFactory().GetConnection();
                string sql = @"Insert into clients(Name,Type,Email,PhoneNumber,Address,RegistrationDate,State,NIF) values (@nome_cliente,@type,@email,@telefone,@morada,@dataInicio,@estadoCli,@nif)";
                MySqlCommand execcmd = new MySqlCommand(sql, Conexao);
                execcmd.Parameters.AddWithValue("@estadoCli", obj.Estado);
                execcmd.Parameters.AddWithValue("@type", obj.Tipo);
                execcmd.Parameters.AddWithValue("@nome_cliente", obj.Nome);
                execcmd.Parameters.AddWithValue("@email", obj.Email);
                execcmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                execcmd.Parameters.AddWithValue("@morada", obj.Morada);
                execcmd.Parameters.AddWithValue("@dataInicio", obj.DataInicio);
                execcmd.Parameters.AddWithValue("@nif", obj.DataInicio);

                Conexao.Open();
                execcmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Registrado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro a registar o cliente" + e);
                throw;
            }
            finally
            {
                if (Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
    }
}