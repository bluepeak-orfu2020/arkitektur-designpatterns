using System;

namespace Bad_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa tre användare
            Member kalle = new Member("Kalle", "password", "kalle@kalle.se");

            // Skriver ut hur många videos kalle har tillgång till nu som GoldMember
            Console.WriteLine($"Kalle innan uppgradering {kalle.VideosAvailible()}");

            kalle.UpgradeMembership(); // Upgrade from gold to platinum
            //kalle.UpgradeMembership(); // Upgrade from platunim to VIP
            //kalle.UpgradeMembership(); // No more upgrades available

            //Skiva ut hur många videos den nya upgradera versionen av Kalle har som platinumMember
            Console.WriteLine($"Kalle efter uppgradering {kalle.VideosAvailible()}");
        }
    }
}
