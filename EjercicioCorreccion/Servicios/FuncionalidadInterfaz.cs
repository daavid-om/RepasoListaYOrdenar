using EjercicioCorreccion.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorreccion.Servicios
{
    /// <summary>
    /// Interfaz que realiza las funcionalidades de la aplicación
    /// 300124 dom
    /// </summary>
    internal interface FuncionalidadInterfaz
    {
        /// <summary>
        /// Método que da alta a los trabajadores
        /// 300124 dom
        /// </summary>
        /// <param name="listaTrabajadoresAntigua"></param>
        public void darAltaTrabajador(List<TrabajadoresDto> listaTrabajadoresAntigua);

        /// <summary>
        /// Método que ordena por el campo AnyosTrabajados
        /// 300124 dom
        /// </summary>
        /// <param name="listaTrabajadoresAntigua"></param>
        public void ordenarTrabajador(List<TrabajadoresDto> listaTrabajadoresAntigua);
    }
}
