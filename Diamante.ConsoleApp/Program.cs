using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamante diamante = new Diamante();
            diamante.GeraDiamante('Z');
            Console.ReadLine();
        }
    }
}
