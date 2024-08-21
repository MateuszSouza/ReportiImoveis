namespace ReportImoveis
{
    partial class AprensetacaoForm
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
            vScrollBar1 = new VScrollBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(vScrollBar1);
            panel1.Location = new Point(41, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 488);
            panel1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(908, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 488);
            vScrollBar1.TabIndex = 0;
            // 
            // AprensetacaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 650);
            Controls.Add(panel1);
            Name = "AprensetacaoForm";
            Text = "AprensetacaoForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private VScrollBar vScrollBar1;
    }
}