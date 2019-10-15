using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownik
{
    class Lekarz:Pracownik
    {
        private string specjalizacja;

        public string Specjalizacja { get; set; }

        public Lekarz(string imie, string nazwisko, string spec):base(imie,nazwisko)
        {
            this.Specjalizacja = spec;
        }

        public override void Info()
        {
            Console.Write("Lekarz :");
            base.Info();
            Console.WriteLine("specjalizacja {0}",this.Specjalizacja);
        }
    }
}
