using Practica1.Entidades;
using Practica1.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Informacion info = new Informacion();
            ClsInformacion clsInfo = new ClsInformacion();

            Console.WriteLine("Igresa el primer numero");
            info.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            info.Numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(clsInfo.Validar(info));

            Console.ReadKey();         
        }
    }
}
