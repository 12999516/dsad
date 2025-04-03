using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clibre biblo = new clibre("prova");
            biblo.lib.Add(new Clib("inferno", "dan", new DateTime(1554, 8, 7), 800));
            //biblo.addl("inferno", "dan", "brown", new DateTime(534, 6, 8), 800);
            WriteLine(clibre.tot());
        }
    }
}