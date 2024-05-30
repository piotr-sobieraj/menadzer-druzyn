using System;
using System.Drawing;

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

        // Metoda do ustawiania obrazu z zasobów
        public void SetRoleImageFromResources(string resourceName)
        {
            pictureBoxRola.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
        }

    }
}
