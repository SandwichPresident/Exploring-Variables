namespace ExploringVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Johnathan";
            string heroLastName = "Gargantuan";
            string heroFullName;
            string villianName = "Megatronous";
            string minion1Name = "Anthony";
            string minion2Name = "Buford";
            string villianTitle = "The Tombstone";
            string minionTitle = "Hunk";


            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 15;

            heroFullName = heroFirstName + " " + heroLastName;

            Console.WriteLine("Behold, the legendary hero, " + heroFullName);
            Console.WriteLine("With a health of " + heroHealth + " and a strength of " + heroStrength);
            Console.WriteLine(villianName + " " + villianTitle + " is helped out by " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);
            Console.WriteLine(villianTitle + " has a health of " + bossHealth + " and a strength of " + bossStrength);
            Console.WriteLine(minionTitle + " " + minion1Name + " has a health of " + minion1Health + " and a strength of " + minionStrength);
            Console.WriteLine(minionTitle + " " + minion2Name + " has a health of " + minion2Health + " and a strength of " + minionStrength);

            //fight sequence
            Console.WriteLine(villianName + " " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " " + villianTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine("The evil minions attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;
            Console.WriteLine(villianName + " " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats a double glazzed apple fritter to restore health!");
            heroHealth+= 20;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine(villianName + " " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " " + villianTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " attacks " + villianName + " " + villianTitle + " for " + heroStrength + " damage!");
            bossHealth = bossHealth - heroStrength;
            Console.WriteLine(villianName + " " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and all the baddies to the winner!");
        }
    }
}


