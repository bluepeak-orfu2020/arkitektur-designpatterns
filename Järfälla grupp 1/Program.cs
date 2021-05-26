using System;

namespace Bad_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa tre användare
            GoldMember kalle = new GoldMember("Kalle", "password", "kalle@kalle.se");

            PlatinumMember gustav = new PlatinumMember("Gustav", "gurraking", "Gurra@Gurra.se");

            VIPMember curt = new VIPMember("Curt", "Kurt", "Curt@kurt.se");



            // Skriver ut hur många videos kalle har tillgång till nu som GoldMember
            Console.WriteLine($"Kalle innan uppgradering {kalle.VideosAvailible()}");

            //Skapa en ny variant av kalle - "upgradedKalle" med hjälp av metoden upgradeUser där kalle är argumentet
            PlatinumMember upgradedKalle = upgradeUser(kalle);

            //Skiva ut hur många videos den nya upgradera versionen av Kalle har som platinumMember
            Console.WriteLine($"Kalle efter uppgradering {upgradedKalle.VideosAvailible()}");
        }


        // Overloaded methods av att uppgradera användare, finns ej att nergradera än...
        static PlatinumMember upgradeUser(GoldMember goldmember)
        {
            PlatinumMember newplat = new PlatinumMember(goldmember.UserName, goldmember.Password, goldmember.Email);
            return newplat;
        }

        static VIPMember upgradeUser(PlatinumMember platmember)
        {
            VIPMember newvip = new VIPMember(platmember.UserName, platmember.Password, platmember.Email);
            return newvip;
        }
    }
}
