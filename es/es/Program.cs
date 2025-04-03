using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            clibre biblo = new clibre();
            biblo.addl("inferno", "dan", "brown", new DateTime(534, 6, 8), 800);
            WriteLine(new clibre());
        }
    }
}