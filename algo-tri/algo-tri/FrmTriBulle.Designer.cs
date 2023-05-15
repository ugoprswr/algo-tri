namespace algo_tri
{
    partial class FrmTriBulle
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
            this.txbPseudoCode = new System.Windows.Forms.TextBox();
            this.txbCodeTriBulle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTriConfiguration = new System.Windows.Forms.GroupBox();
            this.lsbCas = new System.Windows.Forms.ListBox();
            this.lsbVitesse = new System.Windows.Forms.ListBox();
            this.btnTrierTriBulle = new System.Windows.Forms.Button();
            this.gbTriConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPseudoCode
            // 
            this.txbPseudoCode.Enabled = false;
            this.txbPseudoCode.Location = new System.Drawing.Point(204, 12);
            this.txbPseudoCode.Multiline = true;
            this.txbPseudoCode.Name = "txbPseudoCode";
            this.txbPseudoCode.ReadOnly = true;
            this.txbPseudoCode.Size = new System.Drawing.Size(800, 132);
            this.txbPseudoCode.TabIndex = 0;
            this.txbPseudoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCodeTriBulle
            // 
            this.txbCodeTriBulle.Location = new System.Drawing.Point(204, 167);
            this.txbCodeTriBulle.Multiline = true;
            this.txbCodeTriBulle.Name = "txbCodeTriBulle";
            this.txbCodeTriBulle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCodeTriBulle.Size = new System.Drawing.Size(799, 144);
            this.txbCodeTriBulle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pseudo code : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code C# : ";
            // 
            // gbTriConfiguration
            // 
            this.gbTriConfiguration.Controls.Add(this.lsbCas);
            this.gbTriConfiguration.Controls.Add(this.lsbVitesse);
            this.gbTriConfiguration.Controls.Add(this.btnTrierTriBulle);
            this.gbTriConfiguration.Location = new System.Drawing.Point(204, 346);
            this.gbTriConfiguration.Name = "gbTriConfiguration";
            this.gbTriConfiguration.Size = new System.Drawing.Size(800, 70);
            this.gbTriConfiguration.TabIndex = 4;
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
            // btnTrierTriBulle
            // 
            this.btnTrierTriBulle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrierTriBulle.Location = new System.Drawing.Point(389, 27);
            this.btnTrierTriBulle.Name = "btnTrierTriBulle";
            this.btnTrierTriBulle.Size = new System.Drawing.Size(85, 23);
            this.btnTrierTriBulle.TabIndex = 0;
            this.btnTrierTriBulle.Text = "Trier";
            this.btnTrierTriBulle.UseVisualStyleBackColor = true;
            this.btnTrierTriBulle.Click += new System.EventHandler(this.btnTrierTriBulle_Click);
            // 
            // FrmTriBulle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 814);
            this.Controls.Add(this.gbTriConfiguration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodeTriBulle);
            this.Controls.Add(this.txbPseudoCode);
            this.Name = "FrmTriBulle";
            this.Text = "FrmTriBulle";
            this.Load += new System.EventHandler(this.FrmTriBulle_Load);
            this.gbTriConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPseudoCode;
        private System.Windows.Forms.TextBox txbCodeTriBulle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTriConfiguration;
        private System.Windows.Forms.ListBox lsbVitesse;
        private System.Windows.Forms.Button btnTrierTriBulle;
        private System.Windows.Forms.ListBox lsbCas;
    }
}