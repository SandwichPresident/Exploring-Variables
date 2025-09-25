namespace ExploringVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Johnathan";
            string heroLastName = "Gargantuan";
            string heroFullName;
            string villainName = "Megatronous";
            string minion1Name = "Anthony";
            string minion2Name = "Buford";
            string villainTitle = "The Tombstone";
            string minionTitle = "Hunk";

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold, the legendary hero, " + heroFullName);
            Console.WriteLine(villainName + " " + villainTitle + " is helped out by " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
        }
    }
}


