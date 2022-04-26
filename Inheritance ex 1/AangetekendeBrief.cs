using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_ex_1
{
    class AangetekendeBrief
    {
        public double Reisafstand;
        public byte Reistijd;
        public double Kostprijs;

        public void reistijd()
        {
            Console.WriteLine($"De reistijd is {Math.Round(Reisafstand / 100)} dagen");
        }
        public void kostprijs()
        {
                int i = -1;
                do
                {
                    Reisafstand = Reisafstand - 100;
                    i++;
                } while (Reisafstand > 0);
                Kostprijs = 15 + (10 * i);
            
        }
    }
}
