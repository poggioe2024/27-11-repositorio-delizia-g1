using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAdministracion
    {

        public void crear_usuario(string consulta) {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }
        public void crear_telefono(string consulta)
        {
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }

    }
}
