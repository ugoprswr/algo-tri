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
            this.txbCodePas = new System.Windows.Forms.TextBox();
            this.lblCodeEnCours = new System.Windows.Forms.Label();
            this.txbPseudoCode = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblPseudoCode = new System.Windows.Forms.Label();
            this.panelElements = new System.Windows.Forms.Panel();
            this.gbTriConfiguration = new System.Windows.Forms.GroupBox();
            this.btnTrierTriShell = new MaterialSkin.Controls.MaterialButton();
            this.lsbCas = new System.Windows.Forms.ListBox();
            this.lsbVitesse = new System.Windows.Forms.ListBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.gbTriConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCodePas
            // 
            this.txbCodePas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbCodePas.Location = new System.Drawing.Point(399, 573);
            this.txbCodePas.Multiline = true;
            this.txbCodePas.Name = "txbCodePas";
            this.txbCodePas.Size = new System.Drawing.Size(228, 23);
            this.txbCodePas.TabIndex = 17;
            // 
            // lblCodeEnCours
            // 
            this.lblCodeEnCours.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodeEnCours.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEnCours.Location = new System.Drawing.Point(205, 574);
            this.lblCodeEnCours.Name = "lblCodeEnCours";
            this.lblCodeEnCours.Size = new System.Drawing.Size(194, 22);
            this.lblCodeEnCours.TabIndex = 10;
            this.lblCodeEnCours.Text = "Ligne de code en cours :";
            // 
            // txbPseudoCode
            // 
            this.txbPseudoCode.AnimateReadOnly = false;
            this.txbPseudoCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbPseudoCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPseudoCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPseudoCode.Depth = 0;
            this.txbPseudoCode.HideSelection = true;
            this.txbPseudoCode.Location = new System.Drawing.Point(208, 28);
            this.txbPseudoCode.MaxLength = 32767;
            this.txbPseudoCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txbPseudoCode.Name = "txbPseudoCode";
            this.txbPseudoCode.PasswordChar = '\0';
            this.txbPseudoCode.ReadOnly = true;
            this.txbPseudoCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPseudoCode.SelectedText = "";
            this.txbPseudoCode.SelectionLength = 0;
            this.txbPseudoCode.SelectionStart = 0;
            this.txbPseudoCode.ShortcutsEnabled = true;
            this.txbPseudoCode.Size = new System.Drawing.Size(800, 172);
            this.txbPseudoCode.TabIndex = 16;
            this.txbPseudoCode.TabStop = false;
            this.txbPseudoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPseudoCode.UseSystemPasswordChar = false;
            // 
            // lblPseudoCode
            // 
            this.lblPseudoCode.AutoSize = true;
            this.lblPseudoCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudoCode.Location = new System.Drawing.Point(44, 117);
            this.lblPseudoCode.Name = "lblPseudoCode";
            this.lblPseudoCode.Size = new System.Drawing.Size(107, 20);
            this.lblPseudoCode.TabIndex = 15;
            this.lblPseudoCode.Text = "Pseudo-code :";
            // 
            // panelElements
            // 
            this.panelElements.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelElements.Location = new System.Drawing.Point(208, 609);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(799, 178);
            this.panelElements.TabIndex = 14;
            // 
            // gbTriConfiguration
            // 
            this.gbTriConfiguration.Controls.Add(this.btnTrierTriShell);
            this.gbTriConfiguration.Controls.Add(this.lsbCas);
            this.gbTriConfiguration.Controls.Add(this.lsbVitesse);
            this.gbTriConfiguration.Location = new System.Drawing.Point(208, 453);
            this.gbTriConfiguration.Name = "gbTriConfiguration";
            this.gbTriConfiguration.Size = new System.Drawing.Size(800, 104);
            this.gbTriConfiguration.TabIndex = 13;
            this.gbTriConfiguration.TabStop = false;
            // 
            // btnTrierTriShell
            // 
            this.btnTrierTriShell.AutoSize = false;
            this.btnTrierTriShell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrierTriShell.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrierTriShell.Depth = 0;
            this.btnTrierTriShell.HighEmphasis = true;
            this.btnTrierTriShell.Icon = null;
            this.btnTrierTriShell.Location = new System.Drawing.Point(451, 33);
            this.btnTrierTriShell.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrierTriShell.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrierTriShell.Name = "btnTrierTriShell";
            this.btnTrierTriShell.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrierTriShell.Size = new System.Drawing.Size(110, 36);
            this.btnTrierTriShell.TabIndex = 8;
            this.btnTrierTriShell.Text = "Trier";
            this.btnTrierTriShell.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrierTriShell.UseAccentColor = false;
            this.btnTrierTriShell.UseVisualStyleBackColor = true;
            this.btnTrierTriShell.Click += new System.EventHandler(this.btnTrierTriShell_Click);
            // 
            // lsbCas
            // 
            this.lsbCas.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCas.FormattingEnabled = true;
            this.lsbCas.ItemHeight = 16;
            this.lsbCas.Items.AddRange(new object[] {
            "Le pire des cas",
            "Aléatoire"});
            this.lsbCas.Location = new System.Drawing.Point(263, 33);
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
            this.lsbVitesse.Location = new System.Drawing.Point(100, 33);
            this.lsbVitesse.Name = "lsbVitesse";
            this.lsbVitesse.Size = new System.Drawing.Size(120, 36);
            this.lsbVitesse.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(44, 311);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(78, 20);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Code C# : ";
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.SystemColors.Menu;
            this.txbCode.Enabled = false;
            this.txbCode.Location = new System.Drawing.Point(208, 221);
            this.txbCode.Multiline = true;
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCode.Size = new System.Drawing.Size(799, 200);
            this.txbCode.TabIndex = 11;
            // 
            // FrmTriShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 814);
            this.Controls.Add(this.txbCodePas);
            this.Controls.Add(this.lblCodeEnCours);
            this.Controls.Add(this.txbPseudoCode);
            this.Controls.Add(this.lblPseudoCode);
            this.Controls.Add(this.panelElements);
            this.Controls.Add(this.gbTriConfiguration);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txbCode);
            this.Name = "FrmTriShell";
            this.Text = "FrmTriShell";
            this.Load += new System.EventHandler(this.FrmTriShell_Load);
            this.gbTriConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodePas;
        private System.Windows.Forms.Label lblCodeEnCours;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txbPseudoCode;
        private System.Windows.Forms.Label lblPseudoCode;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.GroupBox gbTriConfiguration;
        private MaterialSkin.Controls.MaterialButton btnTrierTriShell;
        private System.Windows.Forms.ListBox lsbCas;
        private System.Windows.Forms.ListBox lsbVitesse;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbCode;
    }
}