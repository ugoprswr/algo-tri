namespace algo_tri
{
    partial class FrmTriShell
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelElements = new System.Windows.Forms.Panel();
            this.gbTriConfiguration = new System.Windows.Forms.GroupBox();
            this.lsbCas = new System.Windows.Forms.ListBox();
            this.lsbVitesse = new System.Windows.Forms.ListBox();
            this.btnTrierTriShell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbPseudoCode = new System.Windows.Forms.TextBox();
            this.gbTriConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pseudo-code :";
            // 
            // panelElements
            // 
            this.panelElements.Location = new System.Drawing.Point(290, 609);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(799, 178);
            this.panelElements.TabIndex = 17;
            // 
            // gbTriConfiguration
            // 
            this.gbTriConfiguration.Controls.Add(this.lsbCas);
            this.gbTriConfiguration.Controls.Add(this.lsbVitesse);
            this.gbTriConfiguration.Controls.Add(this.btnTrierTriShell);
            this.gbTriConfiguration.Location = new System.Drawing.Point(290, 453);
            this.gbTriConfiguration.Name = "gbTriConfiguration";
            this.gbTriConfiguration.Size = new System.Drawing.Size(800, 69);
            this.gbTriConfiguration.TabIndex = 16;
            this.gbTriConfiguration.TabStop = false;
            // 
            // lsbCas
            // 
            this.lsbCas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCas.FormattingEnabled = true;
            this.lsbCas.ItemHeight = 16;
            this.lsbCas.Items.AddRange(new object[] {
            "Le pire des cas",
            "Aléatoire"});
            this.lsbCas.Location = new System.Drawing.Point(229, 19);
            this.lsbCas.Name = "lsbCas";
            this.lsbCas.Size = new System.Drawing.Size(120, 36);
            this.lsbCas.TabIndex = 2;
            // 
            // lsbVitesse
            // 
            this.lsbVitesse.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbVitesse.FormattingEnabled = true;
            this.lsbVitesse.ItemHeight = 16;
            this.lsbVitesse.Items.AddRange(new object[] {
            "Lent",
            "Normal"});
            this.lsbVitesse.Location = new System.Drawing.Point(88, 20);
            this.lsbVitesse.Name = "lsbVitesse";
            this.lsbVitesse.Size = new System.Drawing.Size(120, 36);
            this.lsbVitesse.TabIndex = 1;
            // 
            // btnTrierTriShell
            // 
            this.btnTrierTriShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrierTriShell.Location = new System.Drawing.Point(389, 27);
            this.btnTrierTriShell.Name = "btnTrierTriShell";
            this.btnTrierTriShell.Size = new System.Drawing.Size(85, 23);
            this.btnTrierTriShell.TabIndex = 0;
            this.btnTrierTriShell.Text = "Trier";
            this.btnTrierTriShell.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Code C# : ";
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.SystemColors.Menu;
            this.txbCode.Enabled = false;
            this.txbCode.Location = new System.Drawing.Point(290, 221);
            this.txbCode.Multiline = true;
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCode.Size = new System.Drawing.Size(799, 200);
            this.txbCode.TabIndex = 14;
            // 
            // txbPseudoCode
            // 
            this.txbPseudoCode.Enabled = false;
            this.txbPseudoCode.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPseudoCode.Location = new System.Drawing.Point(290, 28);
            this.txbPseudoCode.Multiline = true;
            this.txbPseudoCode.Name = "txbPseudoCode";
            this.txbPseudoCode.ReadOnly = true;
            this.txbPseudoCode.Size = new System.Drawing.Size(800, 187);
            this.txbPseudoCode.TabIndex = 13;
            this.txbPseudoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmTriShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 814);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelElements);
            this.Controls.Add(this.gbTriConfiguration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.txbPseudoCode);
            this.Name = "FrmTriShell";
            this.Text = "FrmTriShell";
            this.Load += new System.EventHandler(this.FrmTriShell_Load);
            this.gbTriConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.GroupBox gbTriConfiguration;
        private System.Windows.Forms.ListBox lsbCas;
        private System.Windows.Forms.ListBox lsbVitesse;
        private System.Windows.Forms.Button btnTrierTriShell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbPseudoCode;
    }
}