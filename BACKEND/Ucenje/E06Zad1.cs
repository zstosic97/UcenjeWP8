﻿

namespace Ucenje
{
    internal class E06Zad1
    {

        public static void izvedi()
        {

            Console.WriteLine("E06Zad1");

            // program unosi ocjene u školi (niz 7) i ispisuje sve ocjene te prosjek ocjena

            int i = 0;

            int[] ocjene = new int[7];

            Console.Write("Upiši {0}. ocjenu: ", i+1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            Console.Write("Upiši {0}. ocjenu: ", i + 1);
            ocjene[i++] = int.Parse(Console.ReadLine());

            int suma = ocjene[0] + ocjene[1] + ocjene[2] + ocjene[3] + ocjene[4] + ocjene[5] + ocjene[6];

                Console.WriteLine(string.Join(", ", ocjene));
            Console.WriteLine("Prosjek je: {0}", (double)suma/7);
        


        }

    }
}
