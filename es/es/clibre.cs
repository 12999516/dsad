using System;
using System.Collections.Generic;

namespace es
{
    internal class clibre
    {
        private string nome;
        public List<Clib> lib;
        public List<caut> at;

        public clibre()
        {
            nome = "";
            lib = new List<Clib>();
            at = new List<caut>();
        }

        public clibre(string n)
        {
            nome = n;
            lib = new List<Clib>();
            at = new List<caut>();
        }

        public void addl(string t, string a, string c, DateTime an, int p)
        {
            caut author = new caut(a, c, DateTime.Now);
            lib.Add(new Clib(t, author.ToString(), an, p));
        }


        public string tot()
        {
            string st = $"libri:\n\r";
            for (int i = 0; i < lib.Count; i++)
            {
                st += $"{lib[i].info()} \n\r";
            }

            for (int i = 0; i < at.Count; i++)
            {
                st += $"{at[i].stmp()} \n\r";
            }
            return st;
        }
    }
}

