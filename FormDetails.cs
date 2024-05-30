using System.Windows.Forms;

namespace Menadżer_Drużyn
{
    public partial class FormDetails : Form
    {
        public FormDetails(Player p1, Player p2)
        {
            InitializeComponent();

            listBoxSummary.Items.Add(p1.ToString());
            listBoxSummary.Items.Add(p2.ToString());
        }
     }
}
