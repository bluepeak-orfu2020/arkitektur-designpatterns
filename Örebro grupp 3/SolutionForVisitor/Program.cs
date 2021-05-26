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
            List<IElev> elever = new List<IElev>
            {
                new Elev() { AmbitionsNivå = 20 },
                new Elev() {AmbitionsNivå = 10},
                new Elev() {AmbitionsNivå = 5},
                new SmartElev() {AmbitionsNivå = 5}
            };

           foreach(var elev in elever)
            {
                elev.Plugga();
            }

            Console.WriteLine("Elev1 har nu uppnåt ambitionsnivån");

            Console.WriteLine("Läraren kollar om eleven kommer att klara tentan");

            foreach(var elev in elever)
            {
                elev.Accept(new KlarForTentaVisitor());
            }
      
            Console.ReadKey();
        }
    }

    interface IElev
    {
        string Namn { get; set; }
        int KunskapsNivå { get; set; }
        int AmbitionsNivå { get; set; }

        void Accept(IElevVisitor visitor);
        void Plugga();
    }

    class Elev : IElev
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

        public void Accept(IElevVisitor visitor)
        {
            visitor.Visit(this);
        }

        public bool uppnåttAmbitionsNivå()
        {
            return KunskapsNivå >= AmbitionsNivå;
        }
    }

    class SmartElev : IElev
    {
        public string Namn { get; set; }
        public int KunskapsNivå { get; set; }
        public int AmbitionsNivå { get; set; }
        public SmartElev()
        {
            KunskapsNivå = 1000;
        }

        public void Plugga()
        {
            KunskapsNivå += 1000;
        }

        public void Accept(IElevVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    interface IElevVisitor
    {
        void Visit(IElev elev);
    }

    class KlarForTentaVisitor : IElevVisitor
    {
        public void Visit(IElev elev)
        {
            if (elev.KunskapsNivå > 30)
            {
                Console.WriteLine($"Elev {elev.Namn} klarar tentan");
            }
            else
            {
                Console.WriteLine($"Elev {elev.Namn} klarar inte tentan");
            }
        }
    }
}
