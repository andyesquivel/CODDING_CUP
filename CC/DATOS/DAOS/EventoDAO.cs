using Datos.util;
using DATOS.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.DAOS
{
    public class EventoDAO
    {
        public List<evento> getAll()
        {
            List<evento> lista = new List<evento>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM evento;");
            DataTable dt = datos.Tables[0];
            evento e;
            foreach (DataRow r in dt.Rows)
            {
                e = new evento();
                e.idRegistroEvento = (int)r.ItemArray[0];
                e.nombreEvento = (string)r.ItemArray[1];
                e.horaInicio = (string)r.ItemArray[2];
                e.horaFin = (string)r.ItemArray[3];
                e.nombreEquipo = (string)r.ItemArray[4];
                e.fecha = (string)r.ItemArray[5];
                e.asistencia = (char)r.ItemArray[6];
                e.lugaresDisponibles = (int)r.ItemArray[7];
                lista.Add(e);
            }

            return lista;
        }

        public void insert(evento e)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO evento (nombreEvento,horaInicio,horaFin,nombreEquipo,fecha,asistencia,lugaresDisponibles)" +
                "VALUES (@nombreEvento,@horaInicio,@horaFin,@nombreEquipo,@fecha,@asistencia,@lugaresDisponibles);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombreEvento", e.nombreEvento);
            sqlCom.Parameters.AddWithValue("@horaInicio", e.horaInicio);
            sqlCom.Parameters.AddWithValue("@horaFin", e.horaFin);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", e.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@fecha", e.fecha);
            sqlCom.Parameters.AddWithValue("@asistencia", e.asistencia);
            sqlCom.Parameters.AddWithValue("@lugaresDisponibles", e.lugaresDisponibles);
            con.EjecutaSQLComando(sqlCom);
        }

        public void update(evento e)
        {
            Conexion con = new Conexion();
            String SQL = "UPDATE evento" +
                "SET nombreEvento = @nombreEvento, horaInicio = @horaInicio, horaFin = @horaFin, nombreEquipo = @nombreEquipo, fecha = @fecha, asistencia = @asistencia, lugaresDisponibles = @lugaresDisponibles" +
                "WHERE idRegistroEvento = @idRegistroEvento limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idRegistroEvento", e.idRegistroEvento);
            sqlCom.Parameters.AddWithValue("@nombreEvento", e.nombreEvento);
            sqlCom.Parameters.AddWithValue("@horaInicio", e.horaInicio);
            sqlCom.Parameters.AddWithValue("@horaFin", e.horaFin);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", e.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@fecha", e.fecha);
            sqlCom.Parameters.AddWithValue("@asistencia", e.asistencia);
            sqlCom.Parameters.AddWithValue("@lugaresDisponibles", e.lugaresDisponibles);
            con.EjecutaSQLComando(sqlCom);
        }

        public void delete(evento e)
        {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM evento WHERE idRegistroEvento=@idRegistroEvento limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idRegistroEvento", e.idRegistroEvento);
            con.EjecutaSQLComando(sqlCom);
        }

    }
}
