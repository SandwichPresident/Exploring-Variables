namespace ExploringVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Johnathan";
            string heroLastName = "Gargantuan";
            string heroFullName;

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold, the legendary hero, " + heroFullName);
        }
    }
}


