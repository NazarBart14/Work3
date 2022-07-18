using System;
using System.Text;
using static System.Console;

namespace Homework_2
{
    internal class Program
    {

        static void Main()
        {
            OutputEncoding = Encoding.Unicode;
            Write("Write nomber 1 - ");
            int odun = Convert.ToInt32(ReadLine());
            Write("Write nomber 2 - "); ;
            int dwa = Convert.ToInt32(ReadLine());
            Write("Write nomber 3 - ");
            int tru = Convert.ToInt32(ReadLine());
            Write("Write nomber 4 - ");
            int chot = Convert.ToInt32(ReadLine());

            Console.WriteLine( odun + "" +  dwa + "" +   tru + "" +  chot + "");
        }
    }
}
