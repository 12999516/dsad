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
        private caut aut;
        private DateTime ann;
        private int pag;

        public Clib()
        {
            tit = "xxx";
            aut = new caut();
            ann = DateTime.Now;
            pag = 0;
        }

        public Clib(string t, string aut, DateTime d, int p)
        {
            tit = t;
            this.aut = new caut(aut, "", DateTime.Now);
            ann = d;
            pag = p;
        }

        public string info()
        {
            return $"il libro {tit} è stato scritto da {aut.smp()} nel {ann} e ha un totale di {pag} pagine, alcune info sull'autore sono: {aut.stmp()}";
        }
    }
}

