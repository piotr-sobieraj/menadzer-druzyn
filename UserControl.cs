using System;

namespace Menadżer_Drużyn
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
            this.Load += UserControl_Load;
        }


        private void UserControl_Load(object sender, EventArgs e)
        {
            // Ustawienie domyślnej wartości dla ComboBox na pierwszy element
            if (comboBoxRank.Items.Count > 0)
            {
                comboBoxRank.SelectedIndex = 0;
            }
        }
    }
}
