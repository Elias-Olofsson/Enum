using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Det här programmet skriver namnet på siffran.");
            Console.WriteLine("Skriv en siffra i tal form.");
            int consolePunktReadLine = int.Parse(Console.ReadLine());
            Siffror siffror = (Siffror)consolePunktReadLine;
            Console.WriteLine(siffror);
            return;
            if (consolePunktReadLine == (int)Siffror.noll)
            {
                Console.WriteLine(Siffror.noll);
            }
            else if (consolePunktReadLine == (int)Siffror.ett)
            {
                Console.WriteLine(Siffror.ett);
            }
            else if (consolePunktReadLine == (int)Siffror.två)
            {
                Console.WriteLine(Siffror.två);
            }
            else if (consolePunktReadLine == (int)Siffror.tre)
            {
                Console.WriteLine(Siffror.tre);
            }
            else if (consolePunktReadLine == (int)Siffror.fyra)
            {
                Console.WriteLine(Siffror.fyra);
            }
            else if (consolePunktReadLine == (int)Siffror.fem)
            {
                Console.WriteLine(Siffror.fem);
            }
            else if (consolePunktReadLine == (int)Siffror.sex)
            {
                Console.WriteLine(Siffror.sex);
            }
            else if (consolePunktReadLine == (int)Siffror.sju)
            {
                Console.WriteLine(Siffror.sju);
            }
            else if (consolePunktReadLine == (int)Siffror.åtta)
            {
                Console.WriteLine(Siffror.åtta);
            }
            else if (consolePunktReadLine == (int)Siffror.nio)
            {
                Console.WriteLine(Siffror.nio);
            }
            Console.ReadLine();
        }
    }
}
