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
    public class EquiposDAO
    {
        public List<equipos> getAll()
        {
            List<equipos> lista = new List<equipos>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM equipos;");
            DataTable dt = datos.Tables[0];
            equipos e;
            foreach (DataRow r in dt.Rows)
            {
                e = new equipos();
                e.idEquipo = (int)r.ItemArray[0];
                e.referencia = (string)r.ItemArray[1];
                e.institucion = (string)r.ItemArray[2];
                e.nivelEducativo = (string)r.ItemArray[3];
                e.nombreEquipo = (string)r.ItemArray[4];
                e.entrenadorEquipo = (string)r.ItemArray[5];
                e.correoEntrenador = (string)r.ItemArray[6];
                e.RFC = (string)r.ItemArray[7];
                e.Telefono = (string)r.ItemArray[8];
                lista.Add(e);
            }

            return lista;
        }

        public List<equipos> getAllByContacto()
        {
            List<equipos> lista = new List<equipos>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM equipos where Estado='S'");
            DataTable dt = datos.Tables[0];
            equipos e;
            foreach (DataRow r in dt.Rows)
            {
                e = new equipos();
                e.idEquipo = (int)r.ItemArray[0];
                e.referencia = (string)r.ItemArray[1];
                e.institucion = (string)r.ItemArray[2];
                e.nivelEducativo = (string)r.ItemArray[3];
                e.nombreEquipo = (string)r.ItemArray[4];
                e.entrenadorEquipo = (string)r.ItemArray[5];
                e.correoEntrenador = (string)r.ItemArray[6];
                e.RFC = (string)r.ItemArray[7];
                e.Telefono = (string)r.ItemArray[8];
                lista.Add(e);
            }

            return lista;
        }


        public List<equipos> getAllByInstitucion(string institucion)
        {
            List<equipos> lista = new List<equipos>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM equipos where institucion ='" + institucion + "';");
            DataTable dt = datos.Tables[0];
            equipos e;
            foreach (DataRow r in dt.Rows)
            {
                e = new equipos();
                e.idEquipo = (int)r.ItemArray[0];
                e.referencia = (string)r.ItemArray[1];
                e.institucion = (string)r.ItemArray[2];
                e.nivelEducativo = (string)r.ItemArray[3];
                e.nombreEquipo = (string)r.ItemArray[4];
                e.entrenadorEquipo = (string)r.ItemArray[5];
                e.correoEntrenador = (string)r.ItemArray[6];
                e.RFC = (string)r.ItemArray[7];
                e.Telefono = (string)r.ItemArray[8];
                lista.Add(e);
            }

            return lista;
        }

        public List<equipos> getAllByNivelEducativo(string nivelEducativo)
        {
            List<equipos> lista = new List<equipos>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM equipos where nivelEducativo ='" + nivelEducativo + "';");
            DataTable dt = datos.Tables[0];
            equipos e;
            foreach (DataRow r in dt.Rows)
            {
                e = new equipos();
                e.idEquipo = (int)r.ItemArray[0];
                e.referencia = (string)r.ItemArray[1];
                e.institucion = (string)r.ItemArray[2];
                e.nivelEducativo = (string)r.ItemArray[3];
                e.nombreEquipo = (string)r.ItemArray[4];
                e.entrenadorEquipo = (string)r.ItemArray[5];
                e.correoEntrenador = (string)r.ItemArray[6];
                e.RFC = (string)r.ItemArray[7];
                e.Telefono = (string)r.ItemArray[8];
                lista.Add(e);
            }

            return lista;
        }

        public void insert(equipos e)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO equipos (referencia,institucion,nivelEducativo,nombreEquipo,entrenadorEquipo,correoEntrenador,RFC,Telefono,Estado)" +
                "VALUES (@referencia,@institucion,@nivelEducativo,@nombreEquipo,@entrenadorEquipo,@correoEntrenador,@RFC,@Telefono,@Estado);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@referencia", e.referencia);
            sqlCom.Parameters.AddWithValue("@institucion", e.institucion);
            sqlCom.Parameters.AddWithValue("@nivelEducativo", e.nivelEducativo);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", e.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@entrenadorEquipo", e.entrenadorEquipo);
            sqlCom.Parameters.AddWithValue("@correoEntrenador", e.correoEntrenador);
            sqlCom.Parameters.AddWithValue("@RFC", e.RFC);
            sqlCom.Parameters.AddWithValue("@Telefono", e.Telefono);
            sqlCom.Parameters.AddWithValue("@Estado", e.Estado);
            con.EjecutaSQLComando(sqlCom);
        }

        public void update(equipos e)
        {
            Conexion con = new Conexion();
            String SQL = "UPDATE equipos" +
                "SET referencia = @referencia, institucion = @institucion, nivelEducativo = @nivelEducativo, nombreEquipo = @nombreEquipo, entrenadorEquipo = @entrenadorEquipo, correoEntrenador = @correoEntrenador, RFC = @RFC, Telefono = @Telefono, Estado = @Estado" +
                "WHERE idEquipo = @idEquipo limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idEquipo", e.idEquipo);
            sqlCom.Parameters.AddWithValue("@referencia", e.referencia);
            sqlCom.Parameters.AddWithValue("@institucion", e.institucion);
            sqlCom.Parameters.AddWithValue("@nivelEducativo", e.nivelEducativo);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", e.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@entrenadorEquipo", e.entrenadorEquipo);
            sqlCom.Parameters.AddWithValue("@correoEntrenador", e.correoEntrenador);
            sqlCom.Parameters.AddWithValue("@RFC", e.RFC);
            sqlCom.Parameters.AddWithValue("@Telefono", e.Telefono);
            sqlCom.Parameters.AddWithValue("@Estado", e.Estado);
            con.EjecutaSQLComando(sqlCom);
        }

        public void delete(equipos e)
        {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM equipos WHERE idEquipo=@idEquipo limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idEquipo", e.idEquipo);
            con.EjecutaSQLComando(sqlCom);
        }

    }

}
