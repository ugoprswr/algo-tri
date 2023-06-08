namespace algo_tri
{
    partial class FrmTriPeigne
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
            this.txbCode = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txbCodePas = new System.Windows.Forms.TextBox();
            this.lblCodeEnCours = new System.Windows.Forms.Label();
            this.txbPseudoCode = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblPseudoCode = new System.Windows.Forms.Label();
            this.panelElements = new System.Windows.Forms.Panel();
            this.gbTriConfiguration = new System.Windows.Forms.GroupBox();
            this.btnTrierTriPeigne = new MaterialSkin.Controls.MaterialButton();
            this.lsbCas = new System.Windows.Forms.ListBox();
            this.lsbVitesse = new System.Windows.Forms.ListBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.gbTriConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbCode
            // 
            this.txbCode.AnimateReadOnly = false;
            this.txbCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCode.Depth = 0;
            this.txbCode.HideSelection = true;
            this.txbCode.Location = new System.Drawing.Point(203, 229);
            this.txbCode.MaxLength = 32767;
            this.txbCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txbCode.Name = "txbCode";
            this.txbCode.PasswordChar = '\0';
            this.txbCode.ReadOnly = true;
            this.txbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCode.SelectedText = "";
            this.txbCode.SelectionLength = 0;
            this.txbCode.SelectionStart = 0;
            this.txbCode.ShortcutsEnabled = true;
            this.txbCode.Size = new System.Drawing.Size(800, 172);
            this.txbCode.TabIndex = 18;
            this.txbCode.TabStop = false;
            this.txbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCode.UseSystemPasswordChar = false;
            // 
            // txbCodePas
            // 
            this.txbCodePas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbCodePas.Location = new System.Drawing.Point(395, 573);
            this.txbCodePas.Multiline = true;
            this.txbCodePas.Name = "txbCodePas";
            this.txbCodePas.Size = new System.Drawing.Size(228, 23);
            this.txbCodePas.TabIndex = 17;
            // 
            // lblCodeEnCours
            // 
            this.lblCodeEnCours.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodeEnCours.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEnCours.Location = new System.Drawing.Point(201, 574);
            this.lblCodeEnCours.Name = "lblCodeEnCours";
            this.lblCodeEnCours.Size = new System.Drawing.Size(194, 22);
            this.lblCodeEnCours.TabIndex = 11;
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
            this.txbPseudoCode.Location = new System.Drawing.Point(204, 28);
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
            this.lblPseudoCode.Location = new System.Drawing.Point(40, 117);
            this.lblPseudoCode.Name = "lblPseudoCode";
            this.lblPseudoCode.Size = new System.Drawing.Size(107, 20);
            this.lblPseudoCode.TabIndex = 15;
            this.lblPseudoCode.Text = "Pseudo-code :";
            // 
            // panelElements
            // 
            this.panelElements.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelElements.Location = new System.Drawing.Point(204, 609);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(799, 178);
            this.panelElements.TabIndex = 14;
            // 
            // gbTriConfiguration
            // 
            this.gbTriConfiguration.Controls.Add(this.btnTrierTriPeigne);
            this.gbTriConfiguration.Controls.Add(this.lsbCas);
            this.gbTriConfiguration.Controls.Add(this.lsbVitesse);
            this.gbTriConfiguration.Location = new System.Drawing.Point(204, 453);
            this.gbTriConfiguration.Name = "gbTriConfiguration";
            this.gbTriConfiguration.Size = new System.Drawing.Size(800, 104);
            this.gbTriConfiguration.TabIndex = 13;
            this.gbTriConfiguration.TabStop = false;
            // 
            // btnTrierTriPeigne
            // 
            this.btnTrierTriPeigne.AutoSize = false;
            this.btnTrierTriPeigne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrierTriPeigne.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrierTriPeigne.Depth = 0;
            this.btnTrierTriPeigne.HighEmphasis = true;
            this.btnTrierTriPeigne.Icon = null;
            this.btnTrierTriPeigne.Location = new System.Drawing.Point(451, 33);
            this.btnTrierTriPeigne.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrierTriPeigne.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrierTriPeigne.Name = "btnTrierTriPeigne";
            this.btnTrierTriPeigne.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrierTriPeigne.Size = new System.Drawing.Size(110, 36);
            this.btnTrierTriPeigne.TabIndex = 8;
            this.btnTrierTriPeigne.Text = "Trier";
            this.btnTrierTriPeigne.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrierTriPeigne.UseAccentColor = false;
            this.btnTrierTriPeigne.UseVisualStyleBackColor = true;
            this.btnTrierTriPeigne.Click += new System.EventHandler(this.btnTrierTriPeigne_Click);
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
            this.lblCode.Location = new System.Drawing.Point(40, 311);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(78, 20);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Code C# : ";
            // 
            // FrmTriPeigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 814);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.txbCodePas);
            this.Controls.Add(this.lblCodeEnCours);
            this.Controls.Add(this.txbPseudoCode);
            this.Controls.Add(this.lblPseudoCode);
            this.Controls.Add(this.panelElements);
            this.Controls.Add(this.gbTriConfiguration);
            this.Controls.Add(this.lblCode);
            this.Name = "FrmTriPeigne";
            this.Text = "FrmTriPeigne";
            this.gbTriConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txbCode;
        private System.Windows.Forms.TextBox txbCodePas;
        private System.Windows.Forms.Label lblCodeEnCours;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txbPseudoCode;
        private System.Windows.Forms.Label lblPseudoCode;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.GroupBox gbTriConfiguration;
        private MaterialSkin.Controls.MaterialButton btnTrierTriPeigne;
        private System.Windows.Forms.ListBox lsbCas;
        private System.Windows.Forms.ListBox lsbVitesse;
        private System.Windows.Forms.Label lblCode;
    }
}