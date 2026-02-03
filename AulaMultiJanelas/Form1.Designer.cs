using System.Runtime.CompilerServices;

namespace AulaMultiJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novaJanelaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            txtModalidade = new TextBox();
            txtNumeroInscricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtClube = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaJanelaToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem, toolStripMenuItem3 });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(66, 20);
            arquivoToolStripMenuItem.Text = "&Cadastro";
            // 
            // novaJanelaToolStripMenuItem
            // 
            novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            novaJanelaToolStripMenuItem.Size = new Size(122, 22);
            novaJanelaToolStripMenuItem.Text = "&Listagem";
            novaJanelaToolStripMenuItem.Click += novaJanelaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(119, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(122, 22);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(122, 22);
            toolStripMenuItem3.Text = " ";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(180, 143);
            txtIdade.Margin = new Padding(3, 2, 3, 2);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(206, 23);
            txtIdade.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(180, 106);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(206, 23);
            txtNome.TabIndex = 4;
            // 
            // txtModalidade
            // 
            txtModalidade.Location = new Point(180, 177);
            txtModalidade.Margin = new Padding(3, 2, 3, 2);
            txtModalidade.Name = "txtModalidade";
            txtModalidade.Size = new Size(206, 23);
            txtModalidade.TabIndex = 6;
            // 
            // txtNumeroInscricao
            // 
            txtNumeroInscricao.Location = new Point(180, 214);
            txtNumeroInscricao.Margin = new Padding(3, 2, 3, 2);
            txtNumeroInscricao.Name = "txtNumeroInscricao";
            txtNumeroInscricao.Size = new Size(206, 23);
            txtNumeroInscricao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 109);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 146);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Idade:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 217);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 10;
            label3.Text = "Numero de Inscricao:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 180);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 9;
            label4.Text = "Modalidade:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 251);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Clube:";
            // 
            // txtClube
            // 
            txtClube.Location = new Point(180, 248);
            txtClube.Margin = new Padding(3, 2, 3, 2);
            txtClube.Name = "txtClube";
            txtClube.Size = new Size(206, 23);
            txtClube.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(180, 284);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(304, 284);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(txtClube);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtModalidade);
            Controls.Add(txtNumeroInscricao);
            Controls.Add(txtNome);
            Controls.Add(txtIdade);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cadastro de Jogadores";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novaJanelaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private TextBox txtIdade;
        private TextBox txtNome;
        private TextBox txtModalidade;
        private TextBox txtNumeroInscricao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtClube;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
    }
}
