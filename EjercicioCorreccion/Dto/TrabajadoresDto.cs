using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCorreccion.Dto
{
    internal class TrabajadoresDto
    {
        //Atributos
        long id;
        string name = "aaaaa";
        string lastname = "aaaaa";
        string nombreCompleto = "aaaaa";
        int AniosTrabajados = 0;

       //Getters y setters
        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; } 
        public int AniosTrabajados1 { get => AniosTrabajados; set => AniosTrabajados = value; }

        //Contructores
        public TrabajadoresDto(long id, string name, string lastname, string nombreCompleto, int aniosTrabajados)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.nombreCompleto = nombreCompleto;
            AniosTrabajados = aniosTrabajados;
        }
        public TrabajadoresDto()
        { 
        
        }

        //ToString
        override
            public string ToString()
        {
             nombreCompleto = name + " " + lastname;
             string trabajadorYAnios = nombreCompleto + " " + AniosTrabajados;
            return trabajadorYAnios;

        }
    }
}
