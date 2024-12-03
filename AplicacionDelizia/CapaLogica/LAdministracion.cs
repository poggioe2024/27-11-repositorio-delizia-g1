using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class LAdministracion
    {

        public void agregar_productos(string consulta)
        {
            Conexion c = new Conexion();
            c.abrir_conexion();
            c.modificar(consulta);
        }

        public Funcionario modificacion_obtener_funcionario(string cedula)
        {
            string consulta = "SELECT `Cedula`, `Rol`, `Nombre`, `Apellido`, `Correo`, `Contrasena`, `Direccion`, `Activo` FROM `funcionarios` WHERE Cedula='" + cedula + "'";
            List<List<string>> resultados = new Conexion().consultar(consulta);

            List<Funcionario> funcionarios = new List<Funcionario>();
            foreach (List<string> r in resultados)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.cedula = r[0];
                funcionario.rol = int.Parse(r[1]);
                funcionario.nombre = r[2];
                funcionario.apellido = r[3];
                funcionario.correo = r[4];
                funcionario.contrasena = r[5];
                funcionario.direccion = r[6];
                funcionario.activo = r[7];

                funcionarios.Add(funcionario);
            }


            return funcionarios[0];
        }

        public List<Funcionario> obtener_funcionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            string consulta = "SELECT Cedula, Nombre, Apellido, Activo FROM funcionarios WHERE Activo='Si'";
            List<List<String>> resultados = new Conexion().consultar(consulta);

            foreach (List<String> r in resultados)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.cedula = r[0];
                funcionario.nombre = r[1];
                funcionario.apellido = r[2];
                funcionario.activo = r[3];
                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public void insertar_usuario(Funcionario nuevo_usuario)
        {
            string consulta = generar_consulta_usuario(nuevo_usuario);

            DAdministracion dAdministracion = new DAdministracion();
            dAdministracion.crear_usuario(consulta);

            consulta = generar_consulta_telefono(nuevo_usuario);
            dAdministracion.crear_telefono(consulta);
        }

        public string generar_consulta_telefono(Funcionario nuevo_usuario) {
            string consulta = "INSERT INTO funcionariostelefonos(Funcionario, Telefono) VALUES (";
            consulta += "'" + nuevo_usuario.cedula + "', '";
            consulta += nuevo_usuario.telefono + "')";

            return consulta;
        }

        public string generar_consulta_usuario(Funcionario nuevo_usuario) {
            // genera la consulta con sus datos correctos
            string consulta = "INSERT INTO `funcionarios`(`Cedula`, `Rol`, `Nombre`, `Apellido`, `Correo`, `Contrasena`, `Direccion`, `Activo`) VALUES (";
            consulta += "'" + nuevo_usuario.cedula +"', ";
            consulta += "'" + nuevo_usuario.rol + "', ";
            consulta += "'" + nuevo_usuario.nombre + "', ";
            consulta += "'" + nuevo_usuario.apellido + "', ";
            consulta += "'" + nuevo_usuario.correo + "', ";
            consulta += "'" + nuevo_usuario.contrasena + "', ";
            consulta += "'" + nuevo_usuario.direccion + "', ";
            consulta += "'" + nuevo_usuario.activo + "')";

            return consulta;
        }

        public void GenerarConsultaActualizar(Funcionario funcionario)
        {
            string consulta = "UPDATE `funcionarios` SET " +
                              "`Cedula` = '" + funcionario.cedula + "', " +
                              "`Rol` = " + funcionario.rol + ", " +
                              "`Nombre` = '" + funcionario.nombre + "', " +
                              "`Apellido` = '" + funcionario.apellido + "', " +
                              "`Correo` = '" + funcionario.correo + "', " +
                              "`Contrasena` = '" + funcionario.contrasena + "', " +
                              "`Direccion` = '" + funcionario.direccion + "', " +
                              "`Activo` = '" + funcionario.activo + "' " +
                              "WHERE `Cedula` = '" + funcionario.cedula + "';";
            Conexion c = new Conexion();
            c.abrir_conexion();
            c.modificar(consulta);
        }

    }
}
