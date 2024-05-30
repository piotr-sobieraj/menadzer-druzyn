namespace Menadżer_Drużyn
{
    partial class UserControl
    {
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxRola = new System.Windows.Forms.PictureBox();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.checkBoxCaptain = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(292, 31);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.WordWrap = false;
            // 
            // pictureBoxRola
            // 
            this.pictureBoxRola.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRola.Image")));
            this.pictureBoxRola.Location = new System.Drawing.Point(52, 35);
            this.pictureBoxRola.Name = "pictureBoxRola";
            this.pictureBoxRola.Size = new System.Drawing.Size(61, 61);
            this.pictureBoxRola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRola.TabIndex = 5;
            this.pictureBoxRola.TabStop = false;
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "unranked",
            "bronze",
            "silver",
            "gold"});
            this.comboBoxRank.Location = new System.Drawing.Point(500, 47);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(175, 33);
            this.comboBoxRank.TabIndex = 1;
            // 
            // checkBoxCaptain
            // 
            this.checkBoxCaptain.AutoSize = true;
            this.checkBoxCaptain.Location = new System.Drawing.Point(708, 51);
            this.checkBoxCaptain.Name = "checkBoxCaptain";
            this.checkBoxCaptain.Size = new System.Drawing.Size(129, 29);
            this.checkBoxCaptain.TabIndex = 2;
            this.checkBoxCaptain.Text = "Kapitan?";
            this.checkBoxCaptain.UseVisualStyleBackColor = true;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxCaptain);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxRola);
            this.Name = "UserControl";
            this.Size = new System.Drawing.Size(877, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxRola;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.CheckBox checkBoxCaptain;


        // Właściwość do uzyskania lub ustawienia tekstu w textBoxName
        public string PlayerName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        // Właściwość do uzyskania lub ustawienia wybranej wartości w comboBoxRank
        public string Rank
        {
            get { return comboBoxRank.SelectedItem?.ToString(); }
            set { comboBoxRank.SelectedItem = value; }
        }

        // Właściwość do uzyskania lub ustawienia stanu checkBoxCaptain
        public bool IsCaptain
        {
            get { return checkBoxCaptain.Checked; }
            set { checkBoxCaptain.Checked = value; }
        }

        public override string ToString()
        {
            return IsCaptain ? $"* {Name}" : Name;
        }

        //public Image RoleImage
        //{
        //    get { return pictureBoxRola.Image; }
        //    set { pictureBoxRola.Image = value; }
        //}
    }
}
