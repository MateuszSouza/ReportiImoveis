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
            button2 = new Button();
            LoacalIm1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            PrecoIm1 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            LabelNome1 = new TextBox();
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
            // button2
            // 
            button2.Location = new Point(760, 642);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LoacalIm1
            // 
            LoacalIm1.Location = new Point(669, 182);
            LoacalIm1.Name = "LoacalIm1";
            LoacalIm1.Size = new Size(179, 27);
            LoacalIm1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 130);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(700, 129);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Local";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(669, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(669, 313);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 27);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 191);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 14;
            label4.Text = "Imóvel 1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 252);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 15;
            label5.Text = "Imóvel 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 322);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 16;
            label6.Text = "Imóvel 3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(403, 313);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(403, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(179, 27);
            textBox5.TabIndex = 18;
            // 
            // PrecoIm1
            // 
            PrecoIm1.Location = new Point(403, 182);
            PrecoIm1.Name = "PrecoIm1";
            PrecoIm1.Size = new Size(179, 27);
            PrecoIm1.TabIndex = 17;
            PrecoIm1.TextChanged += PrecoUm_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(173, 313);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(179, 27);
            textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(173, 243);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(179, 27);
            textBox8.TabIndex = 21;
            // 
            // LabelNome1
            // 
            LabelNome1.Location = new Point(173, 182);
            LabelNome1.Name = "LabelNome1";
            LabelNome1.Size = new Size(179, 27);
            LabelNome1.TabIndex = 20;
            LabelNome1.TextChanged += textBox9_TextChanged;
            // 
            // Criacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 712);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(LabelNome1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(PrecoIm1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoacalIm1);
            Controls.Add(button2);
            Controls.Add(SalvarDados);
            Name = "Criacao";
            Text = "Criacao";
            Load += Criacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SalvarDados;
        private Button button2;
        private TextBox LoacalIm1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox PrecoIm1;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox LabelNome1;
    }
}