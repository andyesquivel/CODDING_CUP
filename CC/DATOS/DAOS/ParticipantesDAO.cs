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
    public class ParticipantesDAO
    {
        public void insert(participantes p)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO participantes (nombre,apellidos,institucion,nivelEducativo,nombreEquipo,nombreEntrenador,playera)" +
                "VALUES (@nombre,@apellidos,@institucion,@nivelEducativo,@nombreEquipo,@nombreEntrenador,@playera);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", p.nombre);
            sqlCom.Parameters.AddWithValue("@apellidos", p.apellidos);
            sqlCom.Parameters.AddWithValue("@institucion", p.institucion);
            sqlCom.Parameters.AddWithValue("@nivelEducativo", p.nivelEducativo);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", p.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@nombreEntrenador", p.nombreEntrenador);
            sqlCom.Parameters.AddWithValue("@playera", p.playera);
            con.EjecutaSQLComando(sqlCom);
        }
    }
}
