using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownik
{
    class Pielegniarka : Pracownik
    {
        private int stazpracy;
        public int Stazpracy { get; set; }

        public Pielegniarka(string name, string surname, int mies) : base(name,surname)
        {
            this.Stazpracy = mies;
        }
        public override void Info()
        {
            Console.Write("Pielegniarka :");
            base.Info();
            Console.WriteLine("Staz pracy {0} miesiecy",this.Stazpracy);
        }
    }
}
