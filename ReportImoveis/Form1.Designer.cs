namespace ReportImoveis
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            ConteudoTxtBox = new TextBox();
            NomeArquivo = new TextBox();
            domainUpDown1 = new DomainUpDown();
            hScrollBar1 = new HScrollBar();
            menuStrip1 = new MenuStrip();
            pictureBoxTeste = new PictureBox();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeste).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 44);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 0;
            button1.Text = "Nova Apresentação";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnNew;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(53, 88);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Mudar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnMudar;
            // 
            // button3
            // 
            button3.Location = new Point(56, 145);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(393, 40);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Salvar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4SavarTest_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ConteudoTxtBox);
            panel1.Controls.Add(NomeArquivo);
            panel1.Location = new Point(393, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 5;
            // 
            // ConteudoTxtBox
            // 
            ConteudoTxtBox.Location = new Point(17, 69);
            ConteudoTxtBox.Name = "ConteudoTxtBox";
            ConteudoTxtBox.Size = new Size(125, 27);
            ConteudoTxtBox.TabIndex = 1;
            // 
            // NomeArquivo
            // 
            NomeArquivo.Location = new Point(17, 21);
            NomeArquivo.Name = "NomeArquivo";
            NomeArquivo.Size = new Size(125, 27);
            NomeArquivo.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(787, 145);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(150, 27);
            domainUpDown1.TabIndex = 6;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(691, 145);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(50, 226);
            hScrollBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // pictureBoxTeste
            // 
            pictureBoxTeste.BackColor = Color.Chartreuse;
            pictureBoxTeste.Location = new Point(693, 234);
            pictureBoxTeste.Name = "pictureBoxTeste";
            pictureBoxTeste.Size = new Size(125, 62);
            pictureBoxTeste.TabIndex = 9;
            pictureBoxTeste.TabStop = false;
            pictureBoxTeste.Click += PictureBox_Click;
            // 
            // button5
            // 
            button5.Location = new Point(514, 40);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "Carregar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 677);
            Controls.Add(button5);
            Controls.Add(pictureBoxTeste);
            Controls.Add(hScrollBar1);
            Controls.Add(domainUpDown1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ReviseImoveis";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private TextBox ConteudoTxtBox;
        private TextBox NomeArquivo;
        private DomainUpDown domainUpDown1;
        private HScrollBar hScrollBar1;
        private MenuStrip menuStrip1;
        private PictureBox pictureBoxTeste;
        private Button button5;
    }
}
