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

            userControlPlayer1.SetRoleImageFromResources("Top");
            userControlPlayer2.SetRoleImageFromResources("Jungle");
            userControlPlayer3.SetRoleImageFromResources("Middle");
            userControlPlayer4.SetRoleImageFromResources("Bottom");
            userControlPlayer5.SetRoleImageFromResources("Support");
        }    

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //Player 1
            string name1 = userControlPlayer1.PlayerName;
            string rank1 = userControlPlayer1.Rank;
            bool isCaptain1 = userControlPlayer1.IsCaptain;
            double rankValue1 = rankValues.ContainsKey(rank1) ? rankValues[rank1] : 0.0;
            Player p1 = new Player(name1, rank1, isCaptain1, rankValue1);

            //Player 2
            string name2 = userControlPlayer2.PlayerName;
            string rank2 = userControlPlayer2.Rank;
            bool isCaptain2 = userControlPlayer2.IsCaptain;
            double rankValue2 = rankValues.ContainsKey(rank2) ? rankValues[rank2] : 0.0;
            Player p2 = new Player(name2, rank2, isCaptain2, rankValue2);

            //Player 3
            string name3 = userControlPlayer3.PlayerName;
            string rank3 = userControlPlayer3.Rank;
            bool isCaptain3 = userControlPlayer3.IsCaptain;
            double rankValue3 = rankValues.ContainsKey(rank3) ? rankValues[rank3] : 0.0;
            Player p3 = new Player(name3, rank3, isCaptain3, rankValue3);

            //Player 4
            string name4 = userControlPlayer4.PlayerName;
            string rank4 = userControlPlayer4.Rank;
            bool isCaptain4 = userControlPlayer4.IsCaptain;
            double rankValue4 = rankValues.ContainsKey(rank4) ? rankValues[rank4] : 0.0;
            Player p4 = new Player(name4, rank4, isCaptain4, rankValue4);

            //Player 5
            string name5 = userControlPlayer5.PlayerName;
            string rank5 = userControlPlayer5.Rank;
            bool isCaptain5 = userControlPlayer5.IsCaptain;
            double rankValue5 = rankValues.ContainsKey(rank5) ? rankValues[rank5] : 0.0;
            Player p5 = new Player(name5, rank5, isCaptain5, rankValue5);


            // Uruchomienie formatki z listą
            FormDetails formDetails = new FormDetails(p1, p2, p3, p4, p5);
            formDetails.ShowDialog();
        }
    }
}
