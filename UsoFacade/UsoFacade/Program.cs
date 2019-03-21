using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFacade
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Name = "Jose";
            int cuenta = 325665;
            double Tot = 5000;
            string answer;
            Facade f = new Facade();
            Console.WriteLine("Menu de Operaciones \n" +
                "1. Depositar\n" +
                "2. Retirar");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Tecle la cantidad");
                double c = Convert.ToDouble(Console.ReadLine());
                f.operacion1(Name,cuenta,Tot,c);
            }
            else if (answer == "2")
            {
                Console.WriteLine("Tecle la cantidad");
                double c = Convert.ToDouble(Console.ReadLine());
                f.operacion1(Name, cuenta, Tot, c);
            }
            Console.ReadKey();
        }
    }
}
