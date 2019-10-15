using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownik
{
   public class Pracownik
    {
        private string imie;
        private string nazwisko;

        public string Imie { get; set; }
        public string  Nazwisko { get; set; }

        public Pracownik(string name, string surname   )
        {
            this.Imie = name;
            this.Nazwisko = surname;
        }

        public virtual void Info()
        {
            Console.WriteLine("Imie : {0} \nNazwisko {1}",this.Imie,this.Nazwisko);
            
        }
    }
}
