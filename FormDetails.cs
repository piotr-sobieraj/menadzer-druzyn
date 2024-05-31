using System.Windows.Forms;

namespace Menadżer_Drużyn
{
    public partial class FormDetails : Form
    {
        public FormDetails(string name, Player p1, Player p2, Player p3, Player p4, Player p5)
        {
            InitializeComponent();

            this.Text = name;

            listBoxSummary.Items.Add(p1.ToString());
            listBoxSummary.Items.Add(p2.ToString());
            listBoxSummary.Items.Add(p3.ToString());
            listBoxSummary.Items.Add(p4.ToString());
            listBoxSummary.Items.Add(p5.ToString());
        }
    }
}
