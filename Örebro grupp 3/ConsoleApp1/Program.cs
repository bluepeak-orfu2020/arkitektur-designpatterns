using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        } 
    }

    class ConcreteGrade10 : ITeacher
    {
        public void setGrade(IStudent s)
        {
            s.SetBadGrade(this);
        }
    }

    class ConcreteGrade20 : ITeacher
    {
        public void setGrade(IStudent s)
        {
            s.SetGoodGrade(this);
        }
    }

    interface ITeacher
    {
        void setGrade(IStudent s);

        
    }

    interface IStudent
    {
        void SetBadGrade(ConcreteGrade10 c);

        void SetGoodGrade(ConcreteGrade20 c);
    }

   class Elev : IStudent
    {
        public int Poäng { get; set; }

        public void Plugga()
        {
            Poäng++;
        }

        public void SetBadGrade(ConcreteGrade10 c)
        {
            Poäng += 10;
        }

        public void SetGoodGrade(ConcreteGrade20 c)
        {
            Poäng += 20;
        }
    }

}
