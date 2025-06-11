
namespace Ucenje
{
    internal class E08WhilePetlja
    {

        public static void Izvedi()
        {
            Console.WriteLine("E08WhilePetlja");

            //While radi s bool tipom podatka

            // beskonačna petlja


            while (true)
            {
                Console.WriteLine("Ispis iz beskonačne petlje nakon čega je break");
                break;

            }
            Console.WriteLine("************");

            // u while se ne mora ući 

            int i = 10;

            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("************");

            i = 0; // resertiram jedno te istu varijablu
            while (i < 10)
            {
                Console.WriteLine(i++);
            }
            
            Console.WriteLine("************");

            i = 0;
            int j = 1;
            while (i<10 && j == 1) // može ići  i || te ! 

            {
                Console.WriteLine(i);
            }


        // continue i break rade isto kao  i u for
        // gnježđenje je isto kao u for, može se kombiniraiti for i while


        
            while (i > 10)
            {
                while (j == 1)
                {

                    // kako prekinuti petlju while (i > 10)?
                    goto labela;
                }
            }

        labela:
            Console.WriteLine("Gotov");

        }


    }



}           




    

