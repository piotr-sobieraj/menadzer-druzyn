namespace Menadżer_Drużyn
{
    public class Player
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public bool IsCaptain { get; set; }

        public Player(string name, string rank, bool isCaptain)
        {
            Name = name;
            Rank = rank;
            IsCaptain = isCaptain;
        }

        public override string ToString()
        {
            return IsCaptain ? $"* {Name}" : Name;
        }
    }
}
