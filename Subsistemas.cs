using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*------------------------------------Jorge Carrazco---------------------------------
 * ----------------------------------Uso de los Desig Patterns-----------------------
 * -----------------------------Facade Pattern---------------------------------------
 * 
 */
namespace UsoFacade
{
    class CuentaBancaria
    {

        public double RestaCuenta(double a, double b )
        {
            Console.WriteLine("El total nuevo es: " + Convert.ToString(a - b));
            return a - b;  
        }

        public double SumaCuenta(double a, double b)
        {
            Console.WriteLine("El total nuevo es: " + Convert.ToString(a + b));
            return a + b;
        }
    }

    class Usuario
    {
        
        public void Quien(string Nombre, int Ncuenta)
        {
            Console.WriteLine("El usuario: "+ Nombre+ " Ah realizado una transaccion " +
                " de la cuenta "+Ncuenta);
        }
    }    
}
