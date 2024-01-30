using EjercicioCorreccion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorreccion.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de funcionalidad
    /// 300124 dom
    /// </summary>
    internal class FuncionalidadImplementacion : FuncionalidadInterfaz
    {
        public void darAltaTrabajador(List<TrabajadoresDto> listaTrabajadoresAntigua)
        {
            TrabajadoresDto nuevoTrabajador = crearTrabajador();
            listaTrabajadoresAntigua.Add(nuevoTrabajador);
        }

        /// <summary>
        /// Método que pide al usuario la informacion necesaria para crear un nuevo cliente
        /// 300124 dom
        /// </summary>
        /// <returns></returns>
        private TrabajadoresDto crearTrabajador()
        {
            TrabajadoresDto trabajador = new TrabajadoresDto();
            Console.WriteLine("Introduce el id del trabajador: ");
            trabajador.Id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del trabajador: ");
            trabajador.Name = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del trabajador: ");
            trabajador.Lastname = Console.ReadLine();
            Console.WriteLine("Introduzca los años de experencia del trabajador: ");
            trabajador.AniosTrabajados1 = Convert.ToInt32(Console.ReadLine());
            return trabajador;
        }
        //Algoritmo de ordenación burbuja
        public void ordenarTrabajador(List<TrabajadoresDto> listaTrabajadoresAntigua)
        {
            int t = listaTrabajadoresAntigua.Count;
            if (t >= 2)
            {
                for (int i = 0; i < listaTrabajadoresAntigua.Count; i++)
                {
                    for (int j = 0; j < listaTrabajadoresAntigua.Count - 1 - i; j++)
                    {
                        if (listaTrabajadoresAntigua[j + 1].AniosTrabajados1 > listaTrabajadoresAntigua[j].AniosTrabajados1)
                        {
                            TrabajadoresDto aux = listaTrabajadoresAntigua[j];
                            listaTrabajadoresAntigua[j] = listaTrabajadoresAntigua[j + 1];
                            listaTrabajadoresAntigua[j + 1] = aux;
                        }
                    }
                }
                  
                foreach (TrabajadoresDto trabajador in listaTrabajadoresAntigua)
                {
                    Console.WriteLine(trabajador.ToString());
                }
            }
            else
            {
                Console.WriteLine("[INFO] - No hay suficientes trabajadores para ordenar");
            }
        }
    }
}
