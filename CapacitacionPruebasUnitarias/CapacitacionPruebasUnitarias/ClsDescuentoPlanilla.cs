using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionPruebasUnitarias
{
    public class ClsDescuentoPlanilla
    {
        public decimal CalcularDescuento(decimal Salario, decimal Porcentaje)
        {
            return Salario * Porcentaje / 100m;
        }

        public decimal CalcularSalarioNeto(decimal Salario, decimal Porcentaje)
        {
            return Salario - CalcularDescuento(Salario, Porcentaje);
        }
    }
}
