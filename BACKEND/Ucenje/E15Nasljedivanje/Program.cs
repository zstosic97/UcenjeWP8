
using System.Text;

namespace Ucenje.E15Nasljedivanje
{
    public class Program
    {

        public Program() 
        {
            Console.WriteLine("Nasljeđivanje");

            var oso = new PotencijalniPolaznik() { Ime = "Marija", Prezime = "Kaz" };

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR534325324523" };

            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };

           Polaznik pol1 = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };

            // što će se ispisati ? metode Equals, GetHashCode i ToString se izvode u 1. prolazu iz klase Object i u navodnicima su navedene vrijednosti koje se dobiju
            Console.WriteLine(pol.Equals(pol1)); // False

            Console.WriteLine(pol.GetHashCode()); // 43942917
            Console.WriteLine(pol1.GetHashCode()); //59941933
            Console.WriteLine(pol.ToString()); //Ucenje.E15Nasljedivanje.Polaznik


            // 2. prolaz, nakon pisanja prepisanih petoda

            Console.WriteLine(pol); // ovo je jednako kao da sam pozvao pol.ToString Karla Sep 099 / 325-636
            Console.WriteLine(pre);

            string grad = "Osijek";

            Console.WriteLine(grad.GetHashCode()); //-428829813

            grad += " je najbolji";

            Console.WriteLine(grad.GetHashCode()); //1149823153
            // ista varijabla nakon proimjene nema isti hashcode - immutable
            //string je immutable klasa (ne može se mjenjati) 
            // svaka promjena string varijable radi novu instancu string klase - ŠTO NIKAKO NIJE DOBRO

            // rješenje: koristiti StringBuilder klasu

            var sb = new StringBuilder();

            sb.Append("Osijek");
            Console.WriteLine(sb.GetHashCode());

            sb.Append(" je najbolji");

            Console.WriteLine(sb.GetHashCode());



        }

    }
}
