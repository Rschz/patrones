 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.DTO
{
    class EmpresasDto
    {
        //Atributos
        int _empresaID;
        string _nombre;
        string _correo;
        string _direccion;
        string _postal;

        //Propiedades Getters and Setters
        public int EmpresaID { get => _empresaID; set => _empresaID = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Postal { get => _postal; set => _postal = value; }

    }
}
