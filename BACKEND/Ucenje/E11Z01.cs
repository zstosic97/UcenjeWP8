

using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Ucenje
{
    internal class E11Z01
    {

        //Za učitani cijeli broj, program ispisujee da li je paran ili ne 

        public static void Izvedi()
        {
            Console.WriteLine("E11Z01");

            int b;
            for (; ; )
            {
                Console.WriteLine("Unesi cijeli broj: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.WriteLine("Pokušajte ponovno.");

                }
            }
            if (b % 2 == 0)
            {
            Console.WriteLine("Uneseni broj {0} je paran",b);
            }
            else
{
    Console.WriteLine("Uneseni broj {0} je neparan", b); ;
}
      


        }
        


    }
}
