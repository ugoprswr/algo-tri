﻿namespace algo_tri
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
            this.lblCode = new System.Windows.Forms.Label();
            this.gbTriConfiguration = new System.Windows.Forms.GroupBox();
            this.btnTrierTriBulle = new MaterialSkin.Controls.MaterialButton();
            this.lsbCas = new System.Windows.Forms.ListBox();
            this.lsbVitesse = new System.Windows.Forms.ListBox();
            this.panelElements = new System.Windows.Forms.Panel();
            this.lblPseudoCode = new System.Windows.Forms.Label();
            this.txbPseudoCode = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblCodeEnCours = new System.Windows.Forms.Label();
            this.txbCodePas = new System.Windows.Forms.TextBox();
            this.txbCode = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.gbTriConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(40, 295);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(78, 20);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code C# : ";
            // 
            // gbTriConfiguration
            // 
            this.gbTriConfiguration.Controls.Add(this.btnTrierTriBulle);
            this.gbTriConfiguration.Controls.Add(this.lsbCas);
            this.gbTriConfiguration.Controls.Add(this.lsbVitesse);
            this.gbTriConfiguration.Location = new System.Drawing.Point(204, 437);
            this.gbTriConfiguration.Name = "gbTriConfiguration";
            this.gbTriConfiguration.Size = new System.Drawing.Size(800, 104);
            this.gbTriConfiguration.TabIndex = 4;
            this.gbTriConfiguration.TabStop = false;
            // 
            // btnTrierTriBulle
            // 
            this.btnTrierTriBulle.AutoSize = false;
            this.btnTrierTriBulle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrierTriBulle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTrierTriBulle.Depth = 0;
            this.btnTrierTriBulle.HighEmphasis = true;
            this.btnTrierTriBulle.Icon = null;
            this.btnTrierTriBulle.Location = new System.Drawing.Point(451, 33);
            this.btnTrierTriBulle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrierTriBulle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrierTriBulle.Name = "btnTrierTriBulle";
            this.btnTrierTriBulle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTrierTriBulle.Size = new System.Drawing.Size(110, 36);
            this.btnTrierTriBulle.TabIndex = 8;
            this.btnTrierTriBulle.Text = "Trier";
            this.btnTrierTriBulle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrierTriBulle.UseAccentColor = false;
            this.btnTrierTriBulle.UseVisualStyleBackColor = true;
            this.btnTrierTriBulle.Click += new System.EventHandler(this.btnTrierTriBulle_Click);
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
            this.lsbVitesse.SelectedIndexChanged += new System.EventHandler(this.lsbVitesse_SelectedIndexChanged);
            // 
            // panelElements
            // 
            this.panelElements.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelElements.Location = new System.Drawing.Point(204, 593);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(799, 178);
            this.panelElements.TabIndex = 5;
            // 
            // lblPseudoCode
            // 
            this.lblPseudoCode.AutoSize = true;
            this.lblPseudoCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudoCode.Location = new System.Drawing.Point(40, 101);
            this.lblPseudoCode.Name = "lblPseudoCode";
            this.lblPseudoCode.Size = new System.Drawing.Size(107, 20);
            this.lblPseudoCode.TabIndex = 6;
            this.lblPseudoCode.Text = "Pseudo-code :";
            // 
            // txbPseudoCode
            // 
            this.txbPseudoCode.AnimateReadOnly = false;
            this.txbPseudoCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbPseudoCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPseudoCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPseudoCode.Depth = 0;
            this.txbPseudoCode.HideSelection = true;
            this.txbPseudoCode.Location = new System.Drawing.Point(204, 12);
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
            this.txbPseudoCode.TabIndex = 8;
            this.txbPseudoCode.TabStop = false;
            this.txbPseudoCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPseudoCode.UseSystemPasswordChar = false;
            // 
            // lblCodeEnCours
            // 
            this.lblCodeEnCours.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodeEnCours.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeEnCours.Location = new System.Drawing.Point(201, 558);
            this.lblCodeEnCours.Name = "lblCodeEnCours";
            this.lblCodeEnCours.Size = new System.Drawing.Size(194, 22);
            this.lblCodeEnCours.TabIndex = 0;
            this.lblCodeEnCours.Text = "Ligne de code en cours :";
            // 
            // txbCodePas
            // 
            this.txbCodePas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txbCodePas.Location = new System.Drawing.Point(395, 557);
            this.txbCodePas.Multiline = true;
            this.txbCodePas.Name = "txbCodePas";
            this.txbCodePas.Size = new System.Drawing.Size(228, 23);
            this.txbCodePas.TabIndex = 9;
            // 
            // txbCode
            // 
            this.txbCode.AnimateReadOnly = false;
            this.txbCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCode.Depth = 0;
            this.txbCode.HideSelection = true;
            this.txbCode.Location = new System.Drawing.Point(203, 213);
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
            this.txbCode.TabIndex = 10;
            this.txbCode.TabStop = false;
            this.txbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCode.UseSystemPasswordChar = false;
            // 
            // FrmTriBulle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1184, 814);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.txbCodePas);
            this.Controls.Add(this.lblCodeEnCours);
            this.Controls.Add(this.txbPseudoCode);
            this.Controls.Add(this.lblPseudoCode);
            this.Controls.Add(this.panelElements);
            this.Controls.Add(this.gbTriConfiguration);
            this.Controls.Add(this.lblCode);
            this.Name = "FrmTriBulle";
            this.Text = "FrmTriBulle";
            this.Load += new System.EventHandler(this.FrmTriBulle_Load);
            this.gbTriConfiguration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox gbTriConfiguration;
        private System.Windows.Forms.ListBox lsbVitesse;
        private System.Windows.Forms.ListBox lsbCas;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.Label lblPseudoCode;
        private MaterialSkin.Controls.MaterialButton btnTrierTriBulle;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txbPseudoCode;
        private System.Windows.Forms.Label lblCodeEnCours;
        private System.Windows.Forms.TextBox txbCodePas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txbCode;
    }
}