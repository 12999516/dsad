using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace es
{
    internal class caut
    {
        private string nome;
        private string cognome;
        private DateTime dat;
        private List<Clib> lb;

        public caut()
        {
            nome = "";
            cognome = "";
            dat = DateTime.Now;
            lb = new List<Clib>();
        }

        public caut(string n, string c, DateTime d)
        {
            nome = n;
            cognome = c;
            dat = d;
            lb = new List<Clib>();
        }

        public void trm(string t, string a, DateTime d, int p)
        {
            lb.Add(new Clib(t, a, d, p));
        }

        public string stmp()
        {
            string st = $"autore: {nome} {cognome} nato il {dat} libri pubblicati: \n\r";
            for (int i = 0; i < lb.Count; i++)
            {
                st += lb[i].ToString();
            }

            return st;
        }

        public string smp() 
        { 
            string st = $"{nome}";
            return st;
        }
    }
}
