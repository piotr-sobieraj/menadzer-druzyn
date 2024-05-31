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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.userControlPlayer1 = new Menadżer_Drużyn.UserControl();
            this.userControlPlayer2 = new Menadżer_Drużyn.UserControl();
            this.userControlPlayer3 = new Menadżer_Drużyn.UserControl();
            this.userControlPlayer4 = new Menadżer_Drużyn.UserControl();
            this.userControlPlayer5 = new Menadżer_Drużyn.UserControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Location = new System.Drawing.Point(12, 723);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(753, 46);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(178, 62);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // userControlPlayer1
            // 
            this.userControlPlayer1.IsCaptain = false;
            this.userControlPlayer1.Location = new System.Drawing.Point(12, 12);
            this.userControlPlayer1.Name = "userControlPlayer1";
            this.userControlPlayer1.PlayerName = "";
            this.userControlPlayer1.Rank = "unranked";
            this.userControlPlayer1.RoleImage = null;
            this.userControlPlayer1.Size = new System.Drawing.Size(972, 130);
            this.userControlPlayer1.TabIndex = 2;
            // 
            // userControlPlayer2
            // 
            this.userControlPlayer2.IsCaptain = false;
            this.userControlPlayer2.Location = new System.Drawing.Point(12, 138);
            this.userControlPlayer2.Name = "userControlPlayer2";
            this.userControlPlayer2.PlayerName = "";
            this.userControlPlayer2.Rank = "unranked";
            this.userControlPlayer2.RoleImage = null;
            this.userControlPlayer2.Size = new System.Drawing.Size(972, 130);
            this.userControlPlayer2.TabIndex = 3;
            // 
            // userControlPlayer3
            // 
            this.userControlPlayer3.IsCaptain = false;
            this.userControlPlayer3.Location = new System.Drawing.Point(12, 274);
            this.userControlPlayer3.Name = "userControlPlayer3";
            this.userControlPlayer3.PlayerName = "";
            this.userControlPlayer3.Rank = "unranked";
            this.userControlPlayer3.RoleImage = null;
            this.userControlPlayer3.Size = new System.Drawing.Size(972, 130);
            this.userControlPlayer3.TabIndex = 4;
            // 
            // userControlPlayer4
            // 
            this.userControlPlayer4.IsCaptain = false;
            this.userControlPlayer4.Location = new System.Drawing.Point(12, 410);
            this.userControlPlayer4.Name = "userControlPlayer4";
            this.userControlPlayer4.PlayerName = "";
            this.userControlPlayer4.Rank = "unranked";
            this.userControlPlayer4.RoleImage = null;
            this.userControlPlayer4.Size = new System.Drawing.Size(972, 130);
            this.userControlPlayer4.TabIndex = 5;
            // 
            // userControlPlayer5
            // 
            this.userControlPlayer5.IsCaptain = false;
            this.userControlPlayer5.Location = new System.Drawing.Point(12, 546);
            this.userControlPlayer5.Name = "userControlPlayer5";
            this.userControlPlayer5.PlayerName = "";
            this.userControlPlayer5.Rank = "unranked";
            this.userControlPlayer5.RoleImage = null;
            this.userControlPlayer5.Size = new System.Drawing.Size(972, 130);
            this.userControlPlayer5.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 869);
            this.Controls.Add(this.userControlPlayer5);
            this.Controls.Add(this.userControlPlayer4);
            this.Controls.Add(this.userControlPlayer3);
            this.Controls.Add(this.userControlPlayer2);
            this.Controls.Add(this.userControlPlayer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menadżer Drużyn";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAccept;
        private UserControl userControlPlayer1;
        private UserControl userControlPlayer2;
        private UserControl userControlPlayer3;
        private UserControl userControlPlayer4;
        private UserControl userControlPlayer5;
    }
}

