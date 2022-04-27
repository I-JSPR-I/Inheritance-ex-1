using System;

namespace Inheritance_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AangetekendeBrief[] brieflijst;
            AangetekendeBrief brief = new AangetekendeBrief();

            Console.WriteLine("Hello World!");

        }

        public void DemonstreerBrieven( )
        {
            Console.WriteLine("Welke soort brief is het?");
            Console.WriteLine("(1) Een GEWONE aangetekende brief");
            Console.WriteLine("(2) Een INTERNATIONALE aangetekende brief");
            Console.WriteLine("(3) Een HOGE PRIORITEIT aangetekende brief");
            int IntAntwoord = Convert.ToInt32(Console.ReadLine());
            if (IntAntwoord == 1)
            {
                AangetekendeBrief brief = new AangetekendeBrief();
                Console.WriteLine("Wat is de reisafstand");
                brief.Reisafstand = Convert.ToDouble( Console.ReadLine());
            }
            if (IntAntwoord == 2)
            {
                AangetekendeBrief brief = new InternationaleAangetekendeBrief();
                Console.WriteLine("Wat is de reisafstand");
                brief.Reisafstand = Convert.ToDouble(Console.ReadLine());
            }
            if (IntAntwoord == 3)
            {
                AangetekendeBrief brief = new HogePrioriteitsAangetekendeBrief();
                Console.WriteLine("Wat is de reisafstand");
                brief.Reisafstand = Convert.ToDouble(Console.ReadLine());
            }

        }
    }
}
