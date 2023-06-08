namespace algo_tri
{
    partial class FrmAide
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
            this.lblAide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAide
            // 
            this.lblAide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAide.Location = new System.Drawing.Point(12, 9);
            this.lblAide.Name = "lblAide";
            this.lblAide.Size = new System.Drawing.Size(776, 432);
            this.lblAide.TabIndex = 0;
            // 
            // FrmAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAide);
            this.Name = "FrmAide";
            this.Text = "FrmAide";
            this.Load += new System.EventHandler(this.FrmAide_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAide;
    }
}