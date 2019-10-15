using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownik
{
    class Szpital
    {
        private string nazwa;
        public string Nazwa { get; set; }
       
        
        
        
        List<Lekarz> lekarze = new List<Lekarz>();
        List<Pielegniarka> pielegniarki = new List<Pielegniarka>();
        
        public Szpital(string name)
        {
            this.Nazwa = name;
        }

        public void DodajPracownikaLekarz(Lekarz lekarz)
        {
            lekarze.Add(lekarz);
            
        }
        public void DodajPracownikaPielegniarka(Pielegniarka piel)
        {
            pielegniarki.Add(piel);
        }
        
        public void Info()
        {
            Console.WriteLine("Witaj w szpitalu {0}", this.Nazwa);
            Console.WriteLine("Pracuja tutaj : ");
            
            foreach (Lekarz x in lekarze)
            {
                x.Info();
                Console.WriteLine( "-----------");
                
                
            }
            foreach (Pielegniarka y in pielegniarki)
            {
                Console.WriteLine("----------------");
                y.Info();
               
                            }
        }

    }
}
