using Datos.util;
using DATOS.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.DAOS
{
    public class UsuariosDAO
    {
        public void insert(usuarios u)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO usuarios (idUsuario,nombre,apellidos,institucion,correo,contrasenia,tipo)" +
                "VALUES (@idUsuario,@nombre,@apellidos,@institucion,@correo,@contrasenia,@tipo);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idUsuario", u.idUsuario);
            sqlCom.Parameters.AddWithValue("@nombre", u.nombre);
            sqlCom.Parameters.AddWithValue("@apellidos", u.apellidos);
            sqlCom.Parameters.AddWithValue("@institucion", u.institucion);
            sqlCom.Parameters.AddWithValue("@correo", u.correo);
            sqlCom.Parameters.AddWithValue("@contrasenia", u.contrasenia);
            sqlCom.Parameters.AddWithValue("@tipo", u.tipo);
            con.EjecutaSQLComando(sqlCom);
        }
    }
}
