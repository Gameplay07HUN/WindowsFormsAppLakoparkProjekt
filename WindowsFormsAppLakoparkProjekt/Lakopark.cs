using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLakoparkProjekt
{
    internal class Lakopark
    {
        private string nev;
        private int utcakSzama;
        private int maxHazSzam;
        private int[,] hazak;

        public string Nev => nev;
        public int UtcakSzama => utcakSzama;
        public int MaxHazSzam => maxHazSzam;
        public int[,] Hazak => hazak;

        public Lakopark(string nev, int utcakSzama, int maxHazSzam, int[,] hazak)
        {
            this.nev = nev;
            this.utcakSzama = utcakSzama;
            this.maxHazSzam = maxHazSzam;
            this.hazak = hazak;
        }
    }
}
