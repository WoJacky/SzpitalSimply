using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");

            Lekarz stefan = new Lekarz("Wojciech", "Jackowiak", "wszytsko i nic");
            Lekarz lekarz2 = new Lekarz("Wojwoj", "jack jack", "informatyka");
            Pielegniarka barbara = new Pielegniarka("LiczeNa", "Max", 5);
            Pielegniarka kasia = new Pielegniarka("Kasia", "Pani", 23);

            Szpital szpitalos = new Szpital("Nowy");
            szpitalos.DodajPracownikaLekarz(stefan);
            szpitalos.DodajPracownikaLekarz(lekarz2);
            //------------------------------
            szpitalos.DodajPracownikaPielegniarka(barbara);
            szpitalos.DodajPracownikaPielegniarka(kasia);
            // ----------------------------------------------
            szpitalos.Info();
            
        }
    }
}
