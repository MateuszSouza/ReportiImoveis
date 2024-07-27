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
            LoacalIm1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PrecoIm1 = new TextBox();
            TextBoxNome1 = new TextBox();
            SuspendLayout();
            // 
            // SalvarDados
            // 
            SalvarDados.Location = new Point(660, 642);
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
            AddImovel.Location = new Point(760, 642);
            AddImovel.Name = "AddImovel";
            AddImovel.Size = new Size(94, 29);
            AddImovel.TabIndex = 2;
            AddImovel.Text = "Adicionar imovel";
            AddImovel.UseVisualStyleBackColor = true;
            AddImovel.Click += AddImovel_Click;
            // 
            // LoacalIm1
            // 
            LoacalIm1.Location = new Point(588, 162);
            LoacalIm1.Name = "LoacalIm1";
            LoacalIm1.Size = new Size(179, 27);
            LoacalIm1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 128);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "Tipo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 128);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 128);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Local";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 169);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 14;
            label4.Text = "Imóvel 1";
            label4.Click += label4_Click;
            // 
            // PrecoIm1
            // 
            PrecoIm1.Location = new Point(385, 162);
            PrecoIm1.Name = "PrecoIm1";
            PrecoIm1.Size = new Size(179, 27);
            PrecoIm1.TabIndex = 17;
            PrecoIm1.TextChanged += PrecoUm_TextChanged;
            // 
            // TextBoxNome1
            // 
            TextBoxNome1.Location = new Point(180, 162);
            TextBoxNome1.Name = "TextBoxNome1";
            TextBoxNome1.Size = new Size(179, 27);
            TextBoxNome1.TabIndex = 20;
            TextBoxNome1.TextChanged += textBox9_TextChanged;
            // 
            // Criacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 712);
            Controls.Add(TextBoxNome1);
            Controls.Add(PrecoIm1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoacalIm1);
            Controls.Add(AddImovel);
            Controls.Add(SalvarDados);
            Name = "Criacao";
            Text = "Criacao";
            Load += Criacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SalvarDados;
        private Button AddImovel;
        private TextBox LoacalIm1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PrecoIm1;
        private TextBox TextBoxNome1;
    }
}