using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    internal class caut
    {
        private string nome;
        private string cognome;
        private DateTime dat;
        private List <Clib> lb;

        public caut()
        {
            nome = "";
            cognome = "";
            dat = DateTime.Now;
            lb = new();
        }

        public caut(string n, string c, DateTime d)
        {
            nome = n;
            cognome = c;
            dat = d;
        }

        public void trm(string t, string a, DateTime d, int p) 
        {
            lb.Add(new Clib(t, a, d, p));
        }

        public string stmp() 
        {
            string st = $"autore: {nome} {cognome} nato il {dat} libti pubblicati: \n\r";
            for (int i = 0; i < lb.Count; i++)
            {
                st += lb[i].ToString();
            }

            return st ;
        }


    }
}
