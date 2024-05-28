namespace Menadżer_Drużyn
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxKapitan1 = new System.Windows.Forms.CheckBox();
            this.comboBoxRank1 = new System.Windows.Forms.ComboBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.pictureBoxRola1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxKapitan1);
            this.panel1.Controls.Add(this.comboBoxRank1);
            this.panel1.Controls.Add(this.textBoxName1);
            this.panel1.Controls.Add(this.pictureBoxRola1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 86);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxKapitan1
            // 
            this.checkBoxKapitan1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKapitan1.AutoSize = true;
            this.checkBoxKapitan1.Location = new System.Drawing.Point(1076, 32);
            this.checkBoxKapitan1.Name = "checkBoxKapitan1";
            this.checkBoxKapitan1.Size = new System.Drawing.Size(126, 29);
            this.checkBoxKapitan1.TabIndex = 3;
            this.checkBoxKapitan1.Text = "kapitan?";
            this.checkBoxKapitan1.UseVisualStyleBackColor = true;
            // 
            // comboBoxRank1
            // 
            this.comboBoxRank1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRank1.FormattingEnabled = true;
            this.comboBoxRank1.Items.AddRange(new object[] {
            "unranked",
            "bronze",
            "silver",
            "gold"});
            this.comboBoxRank1.Location = new System.Drawing.Point(861, 27);
            this.comboBoxRank1.Name = "comboBoxRank1";
            this.comboBoxRank1.Size = new System.Drawing.Size(176, 33);
            this.comboBoxRank1.TabIndex = 2;
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName1.Location = new System.Drawing.Point(113, 30);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(709, 31);
            this.textBoxName1.TabIndex = 1;
            this.textBoxName1.WordWrap = false;
            // 
            // pictureBoxRola1
            // 
            this.pictureBoxRola1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRola1.Image")));
            this.pictureBoxRola1.Location = new System.Drawing.Point(13, 16);
            this.pictureBoxRola1.Name = "pictureBoxRola1";
            this.pictureBoxRola1.Size = new System.Drawing.Size(61, 61);
            this.pictureBoxRola1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRola1.TabIndex = 0;
            this.pictureBoxRola1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Location = new System.Drawing.Point(12, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(1032, 46);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(178, 62);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menadżer Drużyn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxRola1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.CheckBox checkBoxKapitan1;
        private System.Windows.Forms.ComboBox comboBoxRank1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAccept;
    }
}

