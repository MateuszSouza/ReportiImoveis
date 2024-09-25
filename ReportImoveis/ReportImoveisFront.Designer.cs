namespace ReportImoveis
{
    partial class ReportImoveisFront
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
            Criar = new Button();
            ApresentarBtn = new Button();
            menuStrip1 = new MenuStrip();
            SuspendLayout();
            // 
            // Criar
            // 
            Criar.Location = new Point(56, 44);
            Criar.Name = "Criar";
            Criar.Size = new Size(173, 29);
            Criar.TabIndex = 0;
            Criar.Text = "Criar/editar";
            Criar.UseVisualStyleBackColor = true;
            Criar.Click += BtnNew;
            // 
            // ApresentarBtn
            // 
            ApresentarBtn.Location = new Point(56, 90);
            ApresentarBtn.Name = "ApresentarBtn";
            ApresentarBtn.Size = new Size(173, 29);
            ApresentarBtn.TabIndex = 2;
            ApresentarBtn.Text = "Apresentar";
            ApresentarBtn.UseVisualStyleBackColor = true;
            ApresentarBtn.Click += Apresentar_OnClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(299, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // ReportImoveisFront
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 178);
            Controls.Add(ApresentarBtn);
            Controls.Add(Criar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReportImoveisFront";
            Text = "ReviseImoveis";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Criar;
        private Button ApresentarBtn;
        private MenuStrip menuStrip1;
    }
}
