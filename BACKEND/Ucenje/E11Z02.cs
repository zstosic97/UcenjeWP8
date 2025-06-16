

namespace Ucenje
{
    internal class E11Z02
    {

        public static void Izvedi()
        {
            Console.WriteLine("E11Z02");

            // Program unosi ime osobe i ispisuje uneseno ime 

            string ime = Pomocno.UcitajString("Unesi ime osobe");
            Console.WriteLine(ime);

            if (!Pomocno.isCijeliBroj(ime))

                {
                Console.WriteLine(ime);

            }


        }

    }
}
