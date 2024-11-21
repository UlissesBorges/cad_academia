using System.Windows.Forms;
using System;

namespace ProjetoDePratica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bCadastrarM = new System.Windows.Forms.Button();
            this.bExcluirM = new System.Windows.Forms.Button();
            this.bAlterarM = new System.Windows.Forms.Button();
            this.bConsultarM = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBloco = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCatraca = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bExcluirE = new System.Windows.Forms.Button();
            this.bAlterarE = new System.Windows.Forms.Button();
            this.bCadastrarE = new System.Windows.Forms.Button();
            this.bConsultarE = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbBlocoE = new System.Windows.Forms.TextBox();
            this.tbEnderecoE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bCarregarM = new System.Windows.Forms.Button();
            this.bCarregarE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAtivo = new System.Windows.Forms.TextBox();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 346);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bCadastrarM);
            this.tabPage1.Controls.Add(this.bExcluirM);
            this.tabPage1.Controls.Add(this.bAlterarM);
            this.tabPage1.Controls.Add(this.bConsultarM);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbTelefone);
            this.tabPage1.Controls.Add(this.tbEmail);
            this.tabPage1.Controls.Add(this.tbBloco);
            this.tabPage1.Controls.Add(this.tbEndereco);
            this.tabPage1.Controls.Add(this.tbCPF);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bCatraca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de usuário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bCadastrarM
            // 
            this.bCadastrarM.BackColor = System.Drawing.Color.PaleGreen;
            this.bCadastrarM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCadastrarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCadastrarM.Location = new System.Drawing.Point(409, 185);
            this.bCadastrarM.Margin = new System.Windows.Forms.Padding(2);
            this.bCadastrarM.Name = "bCadastrarM";
            this.bCadastrarM.Size = new System.Drawing.Size(96, 33);
            this.bCadastrarM.TabIndex = 16;
            this.bCadastrarM.Text = "CADASTRAR";
            this.bCadastrarM.UseVisualStyleBackColor = false;
            this.bCadastrarM.Click += new System.EventHandler(this.bCadastrarM_Click);
            // 
            // bExcluirM
            // 
            this.bExcluirM.BackColor = System.Drawing.Color.Red;
            this.bExcluirM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExcluirM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluirM.Location = new System.Drawing.Point(409, 138);
            this.bExcluirM.Margin = new System.Windows.Forms.Padding(2);
            this.bExcluirM.Name = "bExcluirM";
            this.bExcluirM.Size = new System.Drawing.Size(96, 33);
            this.bExcluirM.TabIndex = 15;
            this.bExcluirM.Text = "EXCLUIR";
            this.bExcluirM.UseVisualStyleBackColor = false;
            this.bExcluirM.Click += new System.EventHandler(this.bExcluirM_Click);
            // 
            // bAlterarM
            // 
            this.bAlterarM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAlterarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterarM.Location = new System.Drawing.Point(409, 90);
            this.bAlterarM.Margin = new System.Windows.Forms.Padding(2);
            this.bAlterarM.Name = "bAlterarM";
            this.bAlterarM.Size = new System.Drawing.Size(96, 33);
            this.bAlterarM.TabIndex = 14;
            this.bAlterarM.Text = "ALTERAR";
            this.bAlterarM.UseVisualStyleBackColor = true;
            this.bAlterarM.Click += new System.EventHandler(this.bAlterarM_Click);
            // 
            // bConsultarM
            // 
            this.bConsultarM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConsultarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultarM.Location = new System.Drawing.Point(409, 43);
            this.bConsultarM.Margin = new System.Windows.Forms.Padding(2);
            this.bConsultarM.Name = "bConsultarM";
            this.bConsultarM.Size = new System.Drawing.Size(96, 33);
            this.bConsultarM.TabIndex = 13;
            this.bConsultarM.Text = "CONSULTAR";
            this.bConsultarM.UseVisualStyleBackColor = true;
            this.bConsultarM.Click += new System.EventHandler(this.bConsultarM_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CADASTRO DE ALUNO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTelefone.Location = new System.Drawing.Point(84, 207);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(92, 20);
            this.tbTelefone.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Location = new System.Drawing.Point(84, 174);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(258, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // tbBloco
            // 
            this.tbBloco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBloco.Location = new System.Drawing.Point(84, 238);
            this.tbBloco.Margin = new System.Windows.Forms.Padding(2);
            this.tbBloco.Name = "tbBloco";
            this.tbBloco.Size = new System.Drawing.Size(92, 20);
            this.tbBloco.TabIndex = 9;
            // 
            // tbEndereco
            // 
            this.tbEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEndereco.Location = new System.Drawing.Point(84, 138);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(94, 20);
            this.tbEndereco.TabIndex = 8;
            // 
            // tbCPF
            // 
            this.tbCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCPF.Location = new System.Drawing.Point(84, 103);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(105, 20);
            this.tbCPF.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Location = new System.Drawing.Point(84, 70);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(258, 20);
            this.tbNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bloco";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // bCatraca
            // 
            this.bCatraca.BackColor = System.Drawing.Color.LightCoral;
            this.bCatraca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCatraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCatraca.Location = new System.Drawing.Point(409, 235);
            this.bCatraca.Margin = new System.Windows.Forms.Padding(2);
            this.bCatraca.Name = "bCatraca";
            this.bCatraca.Size = new System.Drawing.Size(96, 33);
            this.bCatraca.TabIndex = 17;
            this.bCatraca.Text = "LIBERAR CATRACA";
            this.bCatraca.UseVisualStyleBackColor = false;
            this.bCatraca.Click += new System.EventHandler(this.bCatraca_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bExcluirE);
            this.tabPage2.Controls.Add(this.bAlterarE);
            this.tabPage2.Controls.Add(this.bCadastrarE);
            this.tabPage2.Controls.Add(this.bConsultarE);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.tbBlocoE);
            this.tabPage2.Controls.Add(this.tbEnderecoE);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(574, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agenda da academia";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bExcluirE
            // 
            this.bExcluirE.BackColor = System.Drawing.Color.Red;
            this.bExcluirE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExcluirE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExcluirE.Location = new System.Drawing.Point(173, 204);
            this.bExcluirE.Margin = new System.Windows.Forms.Padding(2);
            this.bExcluirE.Name = "bExcluirE";
            this.bExcluirE.Size = new System.Drawing.Size(79, 32);
            this.bExcluirE.TabIndex = 15;
            this.bExcluirE.Text = "EXCLUIR";
            this.bExcluirE.UseVisualStyleBackColor = false;
            this.bExcluirE.Click += new System.EventHandler(this.bExcluirE_Click);
            // 
            // bAlterarE
            // 
            this.bAlterarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAlterarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterarE.Location = new System.Drawing.Point(173, 250);
            this.bAlterarE.Margin = new System.Windows.Forms.Padding(2);
            this.bAlterarE.Name = "bAlterarE";
            this.bAlterarE.Size = new System.Drawing.Size(79, 32);
            this.bAlterarE.TabIndex = 14;
            this.bAlterarE.Text = "ALTERAR";
            this.bAlterarE.UseVisualStyleBackColor = true;
            this.bAlterarE.Click += new System.EventHandler(this.bAlterarE_Click);
            // 
            // bCadastrarE
            // 
            this.bCadastrarE.BackColor = System.Drawing.Color.PaleGreen;
            this.bCadastrarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCadastrarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCadastrarE.Location = new System.Drawing.Point(35, 250);
            this.bCadastrarE.Margin = new System.Windows.Forms.Padding(2);
            this.bCadastrarE.Name = "bCadastrarE";
            this.bCadastrarE.Size = new System.Drawing.Size(90, 32);
            this.bCadastrarE.TabIndex = 13;
            this.bCadastrarE.Text = "CADASTRAR";
            this.bCadastrarE.UseVisualStyleBackColor = false;
            this.bCadastrarE.Click += new System.EventHandler(this.bCadastrarE_Click);
            // 
            // bConsultarE
            // 
            this.bConsultarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bConsultarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultarE.Location = new System.Drawing.Point(35, 204);
            this.bConsultarE.Margin = new System.Windows.Forms.Padding(2);
            this.bConsultarE.Name = "bConsultarE";
            this.bConsultarE.Size = new System.Drawing.Size(90, 32);
            this.bConsultarE.TabIndex = 12;
            this.bConsultarE.Text = "CONSULTAR";
            this.bConsultarE.UseVisualStyleBackColor = true;
            this.bConsultarE.Click += new System.EventHandler(this.bConsultarE_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(35, 164);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // tbBlocoE
            // 
            this.tbBlocoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBlocoE.Location = new System.Drawing.Point(97, 98);
            this.tbBlocoE.Margin = new System.Windows.Forms.Padding(2);
            this.tbBlocoE.Name = "tbBlocoE";
            this.tbBlocoE.Size = new System.Drawing.Size(216, 20);
            this.tbBlocoE.TabIndex = 10;
            this.tbBlocoE.TextChanged += new System.EventHandler(this.tbBlocoE_TextChanged);
            // 
            // tbEnderecoE
            // 
            this.tbEnderecoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEnderecoE.Location = new System.Drawing.Point(92, 66);
            this.tbEnderecoE.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnderecoE.Name = "tbEnderecoE";
            this.tbEnderecoE.Size = new System.Drawing.Size(126, 20);
            this.tbEnderecoE.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(209, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "RESERVA PARA EVENTOS";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(338, 140);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(275, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tipo de Evento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Endereço";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quantidade Pessoas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Aluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Luta",
            "Crossfit",
            "Musculação",
            "Pilates"});
            this.comboBox1.Location = new System.Drawing.Point(377, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bCarregarM);
            this.tabPage3.Controls.Add(this.bCarregarE);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(574, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calendário/Usuários";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bCarregarM
            // 
            this.bCarregarM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCarregarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCarregarM.Location = new System.Drawing.Point(118, 3);
            this.bCarregarM.Margin = new System.Windows.Forms.Padding(2);
            this.bCarregarM.Name = "bCarregarM";
            this.bCarregarM.Size = new System.Drawing.Size(110, 51);
            this.bCarregarM.TabIndex = 2;
            this.bCarregarM.Text = "CARREGAR TABELA DE USUÁRIOS";
            this.bCarregarM.UseVisualStyleBackColor = true;
            this.bCarregarM.Click += new System.EventHandler(this.bCarregarM_Click);
            // 
            // bCarregarE
            // 
            this.bCarregarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCarregarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCarregarE.Location = new System.Drawing.Point(3, 3);
            this.bCarregarE.Margin = new System.Windows.Forms.Padding(2);
            this.bCarregarE.Name = "bCarregarE";
            this.bCarregarE.Size = new System.Drawing.Size(110, 51);
            this.bCarregarE.TabIndex = 1;
            this.bCarregarE.Text = "CARREGAR TABELA DE EVENTOS";
            this.bCarregarE.UseVisualStyleBackColor = true;
            this.bCarregarE.Click += new System.EventHandler(this.bCarregarE_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbAtivo
            // 
            this.tbAtivo.Location = new System.Drawing.Point(0, 0);
            this.tbAtivo.Name = "tbAtivo";
            this.tbAtivo.Size = new System.Drawing.Size(100, 20);
            this.tbAtivo.TabIndex = 0;
            // 
            // tbPago
            // 
            this.tbPago.Location = new System.Drawing.Point(0, 0);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(100, 20);
            this.tbPago.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Academia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bCadastrarM;
        private System.Windows.Forms.Button bExcluirM;
        private System.Windows.Forms.Button bCatraca;
        private System.Windows.Forms.Button bAlterarM;
        private System.Windows.Forms.Button bConsultarM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBloco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbAtivo;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbBlocoE;
        private System.Windows.Forms.TextBox tbEnderecoE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bExcluirE;
        private System.Windows.Forms.Button bAlterarE;
        private System.Windows.Forms.Button bCadastrarE;
        private System.Windows.Forms.Button bConsultarE;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bCarregarE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCarregarM;
    }
}

