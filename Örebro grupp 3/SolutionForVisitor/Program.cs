using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elever = new List<Elev>
            {
                new Elev() { AmbitionsNivå = 20 },
                new Elev() {AmbitionsNivå = 10},
                new Elev() {AmbitionsNivå = 5}
            };
            
            

           foreach(var elev in elever)
            {
                elev.Plugga();
            }

       

           
            Console.WriteLine("Elev1 har nu uppnåt ambitionsnivån");

            Console.WriteLine("Läraren kollar om eleven kommer att klara tentan");

            foreach(var elev in elever)
            {
                Console.WriteLine(elev.klaratTentan());
            }
      
            Console.ReadKey();
        }
    }

    class Elev
    {
        public string Namn { get; set; }
        public int KunskapsNivå { get; set; }

        public int AmbitionsNivå { get; set; }

        public void Plugga()
        {
            KunskapsNivå += 10;
            Console.WriteLine("Eleven pluggar");
        }

        public void Spela()
        {
            KunskapsNivå--;
        }
        public bool klaratTentan()
        {
            if(KunskapsNivå > 30)
            {
                return true;
            } else
            {
               return false;
            }
        }

        public bool uppnåttAmbitionsNivå()
        {
            return KunskapsNivå >= AmbitionsNivå;
        }
       
    }

    
}
