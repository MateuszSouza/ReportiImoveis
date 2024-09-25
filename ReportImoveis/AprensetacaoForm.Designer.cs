namespace ReportImoveis
{
    public partial class ApresentacaoForm
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
            panel1 = new Panel();
            CorretorPiture = new PictureBox();
            NomeCorretor = new Label();
            Linklbl = new Label();
            metragemLabel = new Label();
            labelValor = new Label();
            BanheirosLabel = new Label();
            GaragemLabel = new Label();
            DormLabel = new Label();
            ImovelPicBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CorretorPiture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImovelPicBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(ImovelPicBox);
            panel1.Controls.Add(Linklbl);
            panel1.Controls.Add(metragemLabel);
            panel1.Controls.Add(labelValor);
            panel1.Controls.Add(BanheirosLabel);
            panel1.Controls.Add(GaragemLabel);
            panel1.Controls.Add(DormLabel);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 806);
            panel1.TabIndex = 0;
            // 
            // CorretorPiture
            // 
            CorretorPiture.Location = new Point(1415, 12);
            CorretorPiture.Name = "CorretorPiture";
            CorretorPiture.Size = new Size(222, 195);
            CorretorPiture.TabIndex = 1;
            CorretorPiture.TabStop = false;
            // 
            // NomeCorretor
            // 
            NomeCorretor.AutoSize = true;
            NomeCorretor.Location = new Point(1415, 219);
            NomeCorretor.Name = "NomeCorretor";
            NomeCorretor.Size = new Size(105, 20);
            NomeCorretor.TabIndex = 2;
            NomeCorretor.Text = "NomeCorretor";
            // 
            // Linklbl
            // 
            Linklbl.AutoSize = true;
            Linklbl.Location = new Point(619, 602);
            Linklbl.Name = "Linklbl";
            Linklbl.Size = new Size(35, 20);
            Linklbl.TabIndex = 39;
            Linklbl.Text = "Link";
            // 
            // metragemLabel
            // 
            metragemLabel.AutoSize = true;
            metragemLabel.Location = new Point(81, 602);
            metragemLabel.Name = "metragemLabel";
            metragemLabel.Size = new Size(78, 20);
            metragemLabel.TabIndex = 34;
            metragemLabel.Text = "Metragem";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(188, 602);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(74, 20);
            labelValor.TabIndex = 35;
            labelValor.Text = "Valor (R$)";
            // 
            // BanheirosLabel
            // 
            BanheirosLabel.AutoSize = true;
            BanheirosLabel.Location = new Point(296, 602);
            BanheirosLabel.Name = "BanheirosLabel";
            BanheirosLabel.Size = new Size(74, 20);
            BanheirosLabel.TabIndex = 36;
            BanheirosLabel.Text = "Banheiros";
            // 
            // GaragemLabel
            // 
            GaragemLabel.AutoSize = true;
            GaragemLabel.Location = new Point(405, 602);
            GaragemLabel.Name = "GaragemLabel";
            GaragemLabel.Size = new Size(70, 20);
            GaragemLabel.TabIndex = 37;
            GaragemLabel.Text = "Garagem";
            // 
            // DormLabel
            // 
            DormLabel.AutoSize = true;
            DormLabel.Location = new Point(511, 602);
            DormLabel.Name = "DormLabel";
            DormLabel.Size = new Size(89, 20);
            DormLabel.TabIndex = 38;
            DormLabel.Text = "Dormitórios";
            // 
            // ImovelPicBox
            // 
            ImovelPicBox.BackColor = SystemColors.ControlLightLight;
            ImovelPicBox.Location = new Point(687, 602);
            ImovelPicBox.Name = "ImovelPicBox";
            ImovelPicBox.Size = new Size(75, 75);
            ImovelPicBox.TabIndex = 40;
            ImovelPicBox.TabStop = false;
            // 
            // ApresentacaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 809);
            Controls.Add(NomeCorretor);
            Controls.Add(CorretorPiture);
            Controls.Add(panel1);
            Name = "ApresentacaoForm";
            Text = "AprensetacaoForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CorretorPiture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImovelPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox CorretorPiture;
        private Label NomeCorretor;
        private Label Linklbl;
        private Label metragemLabel;
        private Label labelValor;
        private Label BanheirosLabel;
        private Label GaragemLabel;
        private Label DormLabel;
        private PictureBox ImovelPicBox;
    }
}