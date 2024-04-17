using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Notice;

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
                Adress.Text,
                DateTime.Now,
                ClientState.Text);
            ClientManager.RegisterClient(obj);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text))
            {
                MessageBox.Show("É necessario selecionar o cliente primeiro");
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem a certeza que quer remover o registo?","Atenção",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClientManager.DelClient(int.Parse(ID.Text));
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox1.Text))
            {
                DialogResult result = MessageBox.Show("Tem a certeza que quer listar todos os registos?","Atenção",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClientManager.Search("", 1, dataGridView1);
                }
            }
            else
            {
                ClientManager.Search(SearchBox1.Text, 0, dataGridView1);
            }
            
        }

        private void dataGridView1_CellDualContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                ID.Text = selectedRow.Cells["Id"].Value.ToString();
                ClientName.Text = selectedRow.Cells["Name"].Value.ToString();
                ClientType.Text = selectedRow.Cells["Type"].Value.ToString();
                Email.Text = selectedRow.Cells["Email"].Value.ToString();
                PhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                Adress.Text = selectedRow.Cells["Address"].Value.ToString();
                Date.Text = selectedRow.Cells["RegistrationDate"].Value.ToString();
                ClientState.Text = selectedRow.Cells["State"].Value.ToString();
            }

            tabControl1.SelectedIndex = 0;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}