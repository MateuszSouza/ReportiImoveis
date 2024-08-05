namespace ReportImoveis
{
    partial class Criacao
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
            SalvarDados = new Button();
            AddImovel = new Button();
            BanheirosTxtBox = new TextBox();
            metragemLabel = new Label();
            labelValor = new Label();
            BanheirosLabel = new Label();
            ImovelLabel = new Label();
            ValorTxtBox1 = new TextBox();
            MetragemTxtBox1 = new TextBox();
            label5 = new Label();
            NomeEstudo = new TextBox();
            NomeCliente = new Label();
            NomeClienteTextBox = new TextBox();
            CorretorLabel = new Label();
            CorretorTextBox = new TextBox();
            GaragemLabel = new Label();
            GaragemTxtBox = new TextBox();
            DormLabel = new Label();
            DormTxtBox = new TextBox();
            CasaPictureBox = new PictureBox();
            LinkImovelTxtBox = new TextBox();
            Linklbl = new Label();
            ((System.ComponentModel.ISupportInitialize)CasaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SalvarDados
            // 
            SalvarDados.Location = new Point(1308, 671);
            SalvarDados.Name = "SalvarDados";
            SalvarDados.Size = new Size(94, 29);
            SalvarDados.TabIndex = 1;
            SalvarDados.Text = "Salvar";
            SalvarDados.UseMnemonic = false;
            SalvarDados.UseVisualStyleBackColor = true;
            SalvarDados.Click += SalvarDados_Click;
            // 
            // AddImovel
            // 
            AddImovel.Location = new Point(1408, 671);
            AddImovel.Name = "AddImovel";
            AddImovel.Size = new Size(94, 29);
            AddImovel.TabIndex = 2;
            AddImovel.Text = "Adicionar imovel";
            AddImovel.UseVisualStyleBackColor = true;
            AddImovel.Click += AddImovel_Click;
            // 
            // BanheirosTxtBox
            // 
            BanheirosTxtBox.Location = new Point(534, 162);
            BanheirosTxtBox.Name = "BanheirosTxtBox";
            BanheirosTxtBox.Size = new Size(170, 27);
            BanheirosTxtBox.TabIndex = 4;
            // 
            // metragemLabel
            // 
            metragemLabel.AutoSize = true;
            metragemLabel.Location = new Point(126, 128);
            metragemLabel.Name = "metragemLabel";
            metragemLabel.Size = new Size(78, 20);
            metragemLabel.TabIndex = 5;
            metragemLabel.Text = "Metragem";
            metragemLabel.Click += label1_Click;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(331, 128);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(74, 20);
            labelValor.TabIndex = 6;
            labelValor.Text = "Valor (R$)";
            // 
            // BanheirosLabel
            // 
            BanheirosLabel.AutoSize = true;
            BanheirosLabel.Location = new Point(534, 128);
            BanheirosLabel.Name = "BanheirosLabel";
            BanheirosLabel.Size = new Size(74, 20);
            BanheirosLabel.TabIndex = 7;
            BanheirosLabel.Text = "Banheiros";
            // 
            // ImovelLabel
            // 
            ImovelLabel.AutoSize = true;
            ImovelLabel.Location = new Point(45, 169);
            ImovelLabel.Name = "ImovelLabel";
            ImovelLabel.Size = new Size(66, 20);
            ImovelLabel.TabIndex = 14;
            ImovelLabel.Text = "Imóvel 1";
            ImovelLabel.Click += label4_Click;
            // 
            // ValorTxtBox1
            // 
            ValorTxtBox1.Location = new Point(331, 162);
            ValorTxtBox1.Name = "ValorTxtBox1";
            ValorTxtBox1.Size = new Size(170, 27);
            ValorTxtBox1.TabIndex = 17;
            ValorTxtBox1.TextChanged += PrecoUm_TextChanged;
            // 
            // MetragemTxtBox1
            // 
            MetragemTxtBox1.Location = new Point(126, 162);
            MetragemTxtBox1.Name = "MetragemTxtBox1";
            MetragemTxtBox1.Size = new Size(170, 27);
            MetragemTxtBox1.TabIndex = 20;
            MetragemTxtBox1.TextChanged += textBox9_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 68);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 21;
            label5.Text = "Título Apresentação:";
            // 
            // NomeEstudo
            // 
            NomeEstudo.Location = new Point(296, 65);
            NomeEstudo.Name = "NomeEstudo";
            NomeEstudo.Size = new Size(203, 27);
            NomeEstudo.TabIndex = 22;
            // 
            // NomeCliente
            // 
            NomeCliente.AutoSize = true;
            NomeCliente.Location = new Point(519, 70);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(58, 20);
            NomeCliente.TabIndex = 23;
            NomeCliente.Text = "Cliente:";
            // 
            // NomeClienteTextBox
            // 
            NomeClienteTextBox.Location = new Point(588, 63);
            NomeClienteTextBox.Name = "NomeClienteTextBox";
            NomeClienteTextBox.Size = new Size(259, 27);
            NomeClienteTextBox.TabIndex = 24;
            // 
            // CorretorLabel
            // 
            CorretorLabel.AutoSize = true;
            CorretorLabel.Location = new Point(875, 68);
            CorretorLabel.Name = "CorretorLabel";
            CorretorLabel.Size = new Size(67, 20);
            CorretorLabel.TabIndex = 25;
            CorretorLabel.Text = "Corretor:";
            // 
            // CorretorTextBox
            // 
            CorretorTextBox.Location = new Point(948, 65);
            CorretorTextBox.Name = "CorretorTextBox";
            CorretorTextBox.Size = new Size(232, 27);
            CorretorTextBox.TabIndex = 26;
            CorretorTextBox.Text = "Alexandre";
            // 
            // GaragemLabel
            // 
            GaragemLabel.AutoSize = true;
            GaragemLabel.Location = new Point(736, 128);
            GaragemLabel.Name = "GaragemLabel";
            GaragemLabel.Size = new Size(70, 20);
            GaragemLabel.TabIndex = 28;
            GaragemLabel.Text = "Garagem";
            // 
            // GaragemTxtBox
            // 
            GaragemTxtBox.Location = new Point(736, 162);
            GaragemTxtBox.Name = "GaragemTxtBox";
            GaragemTxtBox.Size = new Size(170, 27);
            GaragemTxtBox.TabIndex = 27;
            // 
            // DormLabel
            // 
            DormLabel.AutoSize = true;
            DormLabel.Location = new Point(928, 128);
            DormLabel.Name = "DormLabel";
            DormLabel.Size = new Size(89, 20);
            DormLabel.TabIndex = 30;
            DormLabel.Text = "Dormitórios";
            // 
            // DormTxtBox
            // 
            DormTxtBox.Location = new Point(928, 162);
            DormTxtBox.Name = "DormTxtBox";
            DormTxtBox.Size = new Size(170, 27);
            DormTxtBox.TabIndex = 29;
            // 
            // CasaPictureBox
            // 
            CasaPictureBox.Location = new Point(1203, 30);
            CasaPictureBox.Name = "CasaPictureBox";
            CasaPictureBox.Size = new Size(125, 62);
            CasaPictureBox.TabIndex = 31;
            CasaPictureBox.TabStop = false;
            // 
            // LinkImovelTxtBox
            // 
            LinkImovelTxtBox.Location = new Point(1115, 162);
            LinkImovelTxtBox.Name = "LinkImovelTxtBox";
            LinkImovelTxtBox.Size = new Size(170, 27);
            LinkImovelTxtBox.TabIndex = 32;
            // 
            // Linklbl
            // 
            Linklbl.AutoSize = true;
            Linklbl.Location = new Point(1115, 128);
            Linklbl.Name = "Linklbl";
            Linklbl.Size = new Size(35, 20);
            Linklbl.TabIndex = 33;
            Linklbl.Text = "Link";
            // 
            // Criacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 712);
            Controls.Add(Linklbl);
            Controls.Add(LinkImovelTxtBox);
            Controls.Add(CasaPictureBox);
            Controls.Add(DormLabel);
            Controls.Add(DormTxtBox);
            Controls.Add(GaragemLabel);
            Controls.Add(GaragemTxtBox);
            Controls.Add(CorretorTextBox);
            Controls.Add(CorretorLabel);
            Controls.Add(NomeClienteTextBox);
            Controls.Add(NomeCliente);
            Controls.Add(NomeEstudo);
            Controls.Add(label5);
            Controls.Add(MetragemTxtBox1);
            Controls.Add(ValorTxtBox1);
            Controls.Add(ImovelLabel);
            Controls.Add(BanheirosLabel);
            Controls.Add(labelValor);
            Controls.Add(metragemLabel);
            Controls.Add(BanheirosTxtBox);
            Controls.Add(AddImovel);
            Controls.Add(SalvarDados);
            Name = "Criacao";
            Text = "Criacao";
            Load += Criacao_Load;
            ((System.ComponentModel.ISupportInitialize)CasaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SalvarDados;
        private Button AddImovel;
        private TextBox BanheirosTxtBox;
        private Label metragemLabel;
        private Label labelValor;
        private Label BanheirosLabel;
        private Label ImovelLabel;
        private TextBox ValorTxtBox1;
        private TextBox MetragemTxtBox1;
        private Label label5;
        private TextBox NomeEstudo;
        private Label NomeCliente;
        private TextBox NomeClienteTextBox;
        private Label CorretorLabel;
        private TextBox CorretorTextBox;
        private Label GaragemLabel;
        private TextBox GaragemTxtBox;
        private Label DormLabel;
        private TextBox DormTxtBox;
        private PictureBox CasaPictureBox;
        private TextBox LinkImovelTxtBox;
        private Label Linklbl;
    }
}