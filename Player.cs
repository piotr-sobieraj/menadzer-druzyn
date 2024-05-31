namespace Menadżer_Drużyn
{
    public class Player
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public bool IsCaptain { get; set; }
        public double RankValue { get; set; }

        public Player(string name, string rank, bool isCaptain, double rankValue)
        {
            Name = name;
            Rank = rank;
            IsCaptain = isCaptain;
            RankValue = rankValue;
        }

        public override string ToString()
        {
            string captainIndicator = IsCaptain ? "*" : "";
            return $"{captainIndicator} {Name} ({Rank})";
        }
    }
}
