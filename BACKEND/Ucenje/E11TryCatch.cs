
namespace Ucenje
{
    internal class E11TryCatch
    {

        public static void Izvedi()
        {
            Console.WriteLine("Try Catch");

            Console.Write("Unesi broj: ");
            
                        int b=0;


                        /*
                        try
                        {
                             b = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Niste unijeli broj: ");
                        }


                        Console.WriteLine(b+1);
            */


            while (true)
            {
                
                try
                {
                    Console.Write("Niste unijeli broj: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj: ");

                }

            }
            Console.WriteLine(b+1);



            // napisati program koji za dva unesena cijela broja ispisuje njihov zbroj

            int pb, db; 

            while (true)
            {
                Console.Write("Unesi prvi broj: ");
                try
                {
                    pb = int.Parse(Console.ReadLine());
                    break; 
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli prvi broj");
                }
            }

            while (true)
            {
                Console.Write("Unesi drugi broj: ");
                try
                {

                    db= int.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli broj!");
                    
                }
            }

            Console.WriteLine("Rezultat {0} + {1} = {2} ", pb, db, pb+db);

            // dobro osiguranje unosa broja 

            string unosniNizZnakova;
            while (true)
            {
                Console.Write("Unesi Broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                if(unosniNizZnakova. Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugačak niz znakova");
                    continue; 
                }
                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if(b> 10000)
                    {
                        Console.WriteLine("Uneseni broj je preveliki, unesite manji broj");
                        continue;
                    }
                    break;
                }
                catch 
                {
                    Console.WriteLine("Niste unijeli broj!");
                   
                }

            }

            Console.WriteLine("Unesen je broj {0}", b);

        }




    }
}
