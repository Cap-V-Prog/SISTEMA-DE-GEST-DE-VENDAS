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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateBtn_click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

            ClientManager.Cliente obj = new ClientManager.Cliente(
                0,
                ClientName.Text,
                ClientType.Text,
                Email.Text,
                int.Parse(PhoneNumber.Text),
                EnterpriseAdress.Text,
                DateTime.Now,
                ClientState.Text);
            ClientManager.RegisterClient(obj);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ClientManager.Search(SearchBox1.Text,2,dataGridView1);
            //ClientManager.Cliente obj = new ClientManager.Cliente()
        }
    }
}