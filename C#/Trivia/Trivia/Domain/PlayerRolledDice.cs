namespace Trivia
{
    public class PlayerRolledDice
    {
        public string Name { get; private set; }
        public int Roll { get; private set; }

        public PlayerRolledDice(string name, int roll)
        {
            Name = name;
            Roll = roll;
        }
    }
}