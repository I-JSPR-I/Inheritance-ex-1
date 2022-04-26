using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_ex_1
{
    class InternationaleAangetekendeBrief:AangetekendeBrief
    {
        public void reistijd()
        {
            Console.WriteLine($"De reistijd is {Math.Round(Reisafstand / 50)} dagen");
        }
        public void kostprijs()
        {
            int i = -1;
            do
            {
                Reisafstand = Reisafstand - 100;
                i++;
            } while (Reisafstand > 0);
            Kostprijs = 20 + (20 * i);

        }
    }
}
