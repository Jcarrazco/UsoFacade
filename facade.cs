using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFacade
{
    public class Facade
    {
        CuentaBancaria _cuenta = new CuentaBancaria();
        Usuario _usuario = new Usuario();
        

        public void operacion1(string Name, int cuenta, double total, double v1)
        {
            _cuenta.SumaCuenta(total,v1);
            _usuario.Quien(Name, cuenta);
        }

        public void operacion2(string Name, int cuenta, double total, double v1)
        {
            _cuenta.RestaCuenta(total, v1);
            _usuario.Quien(Name, cuenta);
        }
    }

}
