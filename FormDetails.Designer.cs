namespace Menadżer_Drużyn
{
    partial class FormDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        public FormDetails(string param)
        {
            InitializeComponent();
        } 

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
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.ItemHeight = 33;
            this.listBoxSummary.Location = new System.Drawing.Point(0, 0);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(233, 241);
            this.listBoxSummary.TabIndex = 0;
            // 
            // FormDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(233, 241);
            this.Controls.Add(this.listBoxSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szczegóły";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSummary;
    }
}