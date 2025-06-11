
namespace Ucenje
{
    internal class E10ForEach
    {

        public static void Izvedi()
        {
            Console.WriteLine("E10ForEach");


            Console.Write("Unesi ime grada: ");

            string grad = Console.ReadLine();


            //ispiši svako slovo grada jedno ispod drugog

            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("************");

            //u slučajevima kada idemo od početka do kraja (većina puta)
            foreach(char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("************");


            int[] brojevi = { 1, 23, 4, 2, 5, 6, 7, 8, 9, 45, 34, 234, 12, 3432, 4, 5465, 67 };

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

        }


    }
}
