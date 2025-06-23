

namespace Ucenje.E16Polimorfizam
{
    public class Ravnatelj : Osoba
    {
        private bool poruka;

        public override void Greska(string poruka)
        {
            
        }

        public override void Log(string porua)
        {
            Console.WriteLine(poruka);
        }

        public override string Pozdravi()
        {
            return "";
        }
    }
}
