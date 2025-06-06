

namespace Ucenje
{
    internal class E05UvjetnoGrananjeSwitch 
    {
        public static void Izvedi()
        {
            Console.WriteLine("E05UvjetnoGrananjeSwitch");

            //switch radi s tipovima podattaka: int, string, char i 

            Console.WriteLine("Unesi ocjenu brojem: ");

            int broj = int.Parse(Console.ReadLine());

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Pa i to bi mogle biti ocjene ali nisu");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;





            }

        }

    }
}
