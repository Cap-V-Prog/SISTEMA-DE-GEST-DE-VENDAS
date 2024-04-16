namespace Ficha001
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ClientState = new System.Windows.Forms.ComboBox();
            this.NIF = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ClientType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CAE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PostalCode = new System.Windows.Forms.MaskedTextBox();
            this.EnterpriseAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnterpriseEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Enterprise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DelBtn);
            this.tabPage1.Controls.Add(this.UpdateBtn);
            this.tabPage1.Controls.Add(this.InsertBtn);
            this.tabPage1.Controls.Add(this.EditBtn);
            this.tabPage1.Controls.Add(this.ClientState);
            this.tabPage1.Controls.Add(this.NIF);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.ClientType);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.ClientName);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ficha Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(811, 298);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(196, 57);
            this.DelBtn.TabIndex = 20;
            this.DelBtn.Text = "Deletar";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(607, 362);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(196, 57);
            this.UpdateBtn.TabIndex = 19;
            this.UpdateBtn.Text = "Atualizar";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(811, 362);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(196, 57);
            this.InsertBtn.TabIndex = 18;
            this.InsertBtn.Text = "Inserir";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(607, 298);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(196, 57);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ClientState
            // 
            this.ClientState.FormattingEnabled = true;
            this.ClientState.Location = new System.Drawing.Point(789, 57);
            this.ClientState.Margin = new System.Windows.Forms.Padding(4);
            this.ClientState.Name = "ClientState";
            this.ClientState.Size = new System.Drawing.Size(216, 24);
            this.ClientState.TabIndex = 16;
            // 
            // NIF
            // 
            this.NIF.Location = new System.Drawing.Point(541, 57);
            this.NIF.Margin = new System.Windows.Forms.Padding(4);
            this.NIF.Mask = "000000000";
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(216, 22);
            this.NIF.TabIndex = 9;
            this.NIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(789, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Estado Cliente";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "NIF";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientType
            // 
            this.ClientType.Location = new System.Drawing.Point(284, 57);
            this.ClientType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientType.Name = "ClientType";
            this.ClientType.Size = new System.Drawing.Size(216, 22);
            this.ClientType.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(284, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tipo de cliente";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(31, 55);
            this.ClientName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(216, 22);
            this.ClientName.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PhoneNumber);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Country);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.City);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.CAE);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(608, 110);
            this.panel3.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel3.Size = new System.Drawing.Size(399, 175);
            this.panel3.TabIndex = 8;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(148, 57);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumber.Mask = "000000000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(216, 22);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "País";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(148, 130);
            this.Country.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(216, 22);
            this.Country.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(148, 91);
            this.City.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(216, 22);
            this.City.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telefone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CAE
            // 
            this.CAE.Location = new System.Drawing.Point(148, 17);
            this.CAE.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CAE.Name = "CAE";
            this.CAE.Size = new System.Drawing.Size(216, 22);
            this.CAE.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "CAE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nome";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Contact);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(31, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel2.Size = new System.Drawing.Size(563, 123);
            this.panel2.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(148, 68);
            this.Email.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(380, 22);
            this.Email.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(148, 31);
            this.Contact.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(380, 22);
            this.Contact.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contacto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PostalCode);
            this.panel1.Controls.Add(this.EnterpriseAdress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnterpriseEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Enterprise);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(563, 175);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo postal";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCode
            // 
            this.PostalCode.Location = new System.Drawing.Point(148, 130);
            this.PostalCode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PostalCode.Mask = "0000-999";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(97, 22);
            this.PostalCode.TabIndex = 6;
            this.PostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterpriseAdress
            // 
            this.EnterpriseAdress.Location = new System.Drawing.Point(148, 91);
            this.EnterpriseAdress.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EnterpriseAdress.Name = "EnterpriseAdress";
            this.EnterpriseAdress.Size = new System.Drawing.Size(380, 22);
            this.EnterpriseAdress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereço";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnterpriseEmail
            // 
            this.EnterpriseEmail.Location = new System.Drawing.Point(148, 54);
            this.EnterpriseEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EnterpriseEmail.Name = "EnterpriseEmail";
            this.EnterpriseEmail.Size = new System.Drawing.Size(380, 22);
            this.EnterpriseEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Enterprise
            // 
            this.Enterprise.Location = new System.Drawing.Point(148, 17);
            this.Enterprise.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Enterprise.Name = "Enterprise";
            this.Enterprise.Size = new System.Drawing.Size(380, 22);
            this.Enterprise.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empresa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.SearchBtn);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(847, 39);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(151, 43);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Pesquisar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(212, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1027, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1027, 445);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1068, 510);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;

        private System.Windows.Forms.ComboBox ClientState;

        private System.Windows.Forms.TextBox ClientType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox NIF;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClientName;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CAE;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.MaskedTextBox PostalCode;

        private System.Windows.Forms.TextBox EnterpriseEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnterpriseAdress;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox Enterprise;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBtn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}