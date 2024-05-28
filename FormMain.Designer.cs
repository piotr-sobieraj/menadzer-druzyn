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
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.pictureBoxRola1 = new System.Windows.Forms.PictureBox();
            this.comboBoxRank1 = new System.Windows.Forms.ComboBox();
            this.checkBoxKapitan1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxKapitan1);
            this.panel1.Controls.Add(this.comboBoxRank1);
            this.panel1.Controls.Add(this.textBoxName1);
            this.panel1.Controls.Add(this.pictureBoxRola1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 86);
            this.panel1.TabIndex = 0;
            // 
            // textBoxName1
            // 
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
            // comboBoxRank1
            // 
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
            // checkBoxKapitan1
            // 
            this.checkBoxKapitan1.AutoSize = true;
            this.checkBoxKapitan1.Location = new System.Drawing.Point(1076, 32);
            this.checkBoxKapitan1.Name = "checkBoxKapitan1";
            this.checkBoxKapitan1.Size = new System.Drawing.Size(126, 29);
            this.checkBoxKapitan1.TabIndex = 3;
            this.checkBoxKapitan1.Text = "kapitan?";
            this.checkBoxKapitan1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 601);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Menadżer Drużyn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRola1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxRola1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.CheckBox checkBoxKapitan1;
        private System.Windows.Forms.ComboBox comboBoxRank1;
    }
}

