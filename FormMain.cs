using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menadżer_Drużyn
{
    public partial class FormMain : Form
    {
        private Dictionary<string, double> rankValues = new Dictionary<string, double>
        {
            { "unranked", 0.0 },
            { "bronze", 0.20 },
            { "silver", 0.40 },
            { "gold", 0.60 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {

            string name1 = userControlPlayer1.PlayerName;
            string rank1 = userControlPlayer1.Rank;
            bool isCaptain1 = userControlPlayer1.IsCaptain;
            double rankValue1 = rankValues.ContainsKey(rank1) ? rankValues[rank1] : 0.0;
            Player p1 = new Player(name1, rank1, isCaptain1, rankValue1);

            string name2 = userControlPlayer2.PlayerName;
            string rank2 = userControlPlayer2.Rank;
            bool isCaptain2 = userControlPlayer2.IsCaptain;
            double rankValue2 = rankValues.ContainsKey(rank2) ? rankValues[rank2] : 0.0;
            Player p2 = new Player(name2, rank2, isCaptain2, rankValue2);

            // Uruchomienie formatki z listą
            FormDetails formDetails = new FormDetails(p1, p2);
            formDetails.ShowDialog();
        }
    }
}
