using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorreccion.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menu
    /// 300124 dom
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("0. Se cierra la aplicación");
            Console.WriteLine("1. Dar alta trabajador");
            Console.WriteLine("2. Ordenar por años de experiencia");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
