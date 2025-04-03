using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clib lib = new Clib();
            Clib lib2 = new Clib("trmasdoasmd", "sdaokd", new DateTime(215, 8, 3), 840);
            caut lv = new caut();
            caut lv2 = new caut("dan", "brown", new DateTime(1988, 5, 15));
            WriteLine(lv.stmp());
            WriteLine(lib2.info());
        }
    }
}