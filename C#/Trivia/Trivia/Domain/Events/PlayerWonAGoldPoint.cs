namespace Trivia
{
    public class PlayerWonAGoldPoint
    {
        public string Name { get; private set; }
        public int GoldCoins { get; private set; }

        public PlayerWonAGoldPoint(string name, int goldCoins)
        {
            Name = name;
            GoldCoins = goldCoins;
        }
    }
}