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
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NIF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ClientState = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 645);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DelBtn);
            this.tabPage1.Controls.Add(this.InsertBtn);
            this.tabPage1.Controls.Add(this.EditBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.tabPage1.Size = new System.Drawing.Size(1146, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ficha Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.label5);
            this.gb3.Controls.Add(this.label3);
            this.gb3.Controls.Add(this.Date);
            this.gb3.Controls.Add(this.ID);
            this.gb3.Location = new System.Drawing.Point(602, 24);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(521, 111);
            this.gb3.TabIndex = 23;
            this.gb3.TabStop = false;
            this.gb3.Text = "Informação avançada";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data de registo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(147, 58);
            this.Date.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(364, 22);
            this.Date.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(147, 24);
            this.ID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(364, 22);
            this.ID.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NIF);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Adress);
            this.groupBox2.Location = new System.Drawing.Point(602, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(521, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturação";
            // 
            // NIF
            // 
            this.NIF.Location = new System.Drawing.Point(166, 63);
            this.NIF.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.NIF.Mask = "000000000";
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(82, 22);
            this.NIF.TabIndex = 9;
            this.NIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Endereço";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(166, 29);
            this.Adress.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(345, 22);
            this.Adress.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ClientState);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(557, 234);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação do cliente";
            // 
            // ClientType
            // 
            this.ClientType.AllowDrop = true;
            this.ClientType.AutoCompleteCustomSource.AddRange(new string[] { "Privado", "Empresa" });
            this.ClientType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ClientType.Items.AddRange(new object[] { "Privado", "Empresa" });
            this.ClientType.Location = new System.Drawing.Point(164, 158);
            this.ClientType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientType.Name = "ClientType";
            this.ClientType.Size = new System.Drawing.Size(366, 24);
            this.ClientType.TabIndex = 17;
            this.ClientType.Text = "Privado";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telefone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(164, 88);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PhoneNumber.Mask = "000000000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(89, 22);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nome";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(164, 54);
            this.Email.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(366, 22);
            this.Email.TabIndex = 3;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(164, 20);
            this.ClientName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(366, 22);
            this.ClientName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 156);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tipo de cliente";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientState
            // 
            this.ClientState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientState.FormattingEnabled = true;
            this.ClientState.Location = new System.Drawing.Point(164, 122);
            this.ClientState.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ClientState.Name = "ClientState";
            this.ClientState.Size = new System.Drawing.Size(366, 24);
            this.ClientState.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "Estado do Cliente";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Red;
            this.DelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DelBtn.Location = new System.Drawing.Point(723, 282);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(196, 57);
            this.DelBtn.TabIndex = 20;
            this.DelBtn.Text = "Deletar";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.InsertBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertBtn.Location = new System.Drawing.Point(519, 282);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(196, 57);
            this.InsertBtn.TabIndex = 18;
            this.InsertBtn.Text = "Inserir";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditBtn.Location = new System.Drawing.Point(927, 282);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(196, 57);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.SearchBtn);
            this.tabPage2.Controls.Add(this.SearchBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(1146, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 493);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDualContentClick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(958, 27);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(151, 43);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Pesquisar";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox1
            // 
            this.SearchBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBox1.Location = new System.Drawing.Point(219, 37);
            this.SearchBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Size = new System.Drawing.Size(708, 22);
            this.SearchBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
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
            this.tabPage3.Size = new System.Drawing.Size(1146, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1146, 616);
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
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Date;

        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NIF;

        private System.Windows.Forms.ComboBox ClientType;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button DelBtn;

        private System.Windows.Forms.ComboBox ClientState;
        
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClientName;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.MaskedTextBox PhoneNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox SearchBox1;
        private System.Windows.Forms.Button SearchBtn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}