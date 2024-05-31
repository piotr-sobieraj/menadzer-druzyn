using System.Windows.Forms;

namespace Menadżer_Drużyn
{
    public partial class FormDetails : Form
    {
        public FormDetails(Player p1, Player p2, Player p3, Player p4, Player p5)
        {
            InitializeComponent();

            listBoxSummary.Items.Add(p1.ToString());
            listBoxSummary.Items.Add(p2.ToString());
            listBoxSummary.Items.Add(p3.ToString());
            listBoxSummary.Items.Add(p4.ToString());
            listBoxSummary.Items.Add(p5.ToString());
        }
    }
}
