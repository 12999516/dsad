using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class Clib
    {
        private string tit;
        private string aut;
        private DateTime ann;
        private int pag;

        public Clib() 
        {
            tit = "trm";
            aut = "dsa";
            ann = DateTime.Now;
            pag = 0;
        }

        public Clib (string t, string aut, DateTime d, int p)
        {
            tit = t;
            this.aut = aut;
            ann = d;
            pag = p;
        }

        public string info()
        {
            return $"il libro {tit} è stato scritto da {aut} nel {ann} e ha un totale di {pag} pagine";
        }
    }
}
