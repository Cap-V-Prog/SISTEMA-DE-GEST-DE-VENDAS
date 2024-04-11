using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha001
{
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateBtn_click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente(int.Parse(ClientCod.Text),
                Contact.Text,
                ClientType.Text,
                Email.Text,
                int.Parse(PhoneNumber.Text),
                EnterpriseAdress.Text,
                DateTime.Now,
                ClientState.Text );
        }
    }
}