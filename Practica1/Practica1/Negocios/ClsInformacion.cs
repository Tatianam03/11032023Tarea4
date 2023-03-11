using Practica1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Negocios
{
    internal class ClsInformacion
    {
        public String Validar(Informacion informacion)
        {
            if (informacion.Numero1 > informacion.Numero2)
            {
                return "El numero " + informacion.Numero1 + " es mayor que el numero " + informacion.Numero2;
            }
            else if (informacion.Numero2 > informacion.Numero1)
            {
                return "El numero " + informacion.Numero2 + " es mayor que el numero " + informacion.Numero1;
            }
            else if (informacion.Numero1 == informacion.Numero2)
            {
                return "Los numeros son iguales";
            }
            else
            {
                return "¡Error!";
            }
        }
    }
}
