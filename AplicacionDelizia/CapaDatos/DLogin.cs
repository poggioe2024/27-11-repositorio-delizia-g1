using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DLogin
    {
        public List<String> get_funcionario(string cedula_ingresada) {
            // generamos la consulta
            string consulta = "SELECT funcionarios.Cedula, funcionarios.Nombre, funcionarios.Apellido, funcionariostelefonos.Telefono, funcionarios.Correo, funcionarios.Contrasena, funcionarios.Direccion, funcionarios.Activo, funcionarios.Rol FROM funcionarios INNER JOIN funcionariostelefonos ON funcionarios.Cedula = funcionariostelefonos.Funcionario WHERE funcionarios.Cedula = " + cedula_ingresada;
            Conexion conexion = new Conexion();
            List<List<String>> resultado = conexion.consultar(consulta);
            List<string> salida = resultado[0];
            return salida;
        }
        public void nuevo_log(string fecha, string hora, string funcionario, string equipo) {
            // Tipo de log 1 = IN, 0 = OUT
            string consulta = "INSERT INTO logs (Fecha, Hora, Funcionario, Equipo, Tipo) VALUES ('" + fecha + "', '" + hora + "', '" + funcionario + "', '"+ equipo + "', 1)";
            Conexion conexion = new Conexion();
            conexion.modificar(consulta);
        }
    }
}
