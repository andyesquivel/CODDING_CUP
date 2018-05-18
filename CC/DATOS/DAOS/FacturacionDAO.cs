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
    public class FacturacionDAO
    {
        public List<facturacion> getAll()
        {
            List<facturacion> lista = new List<facturacion>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM facturacion;");
            DataTable dt = datos.Tables[0];
            facturacion f;
            foreach (DataRow r in dt.Rows)
            {
                f = new facturacion();
                f.idFacturacion = (int)r.ItemArray[0];
                f.nombreEquipo = (string)r.ItemArray[1];
                f.RFC = (string)r.ItemArray[2];
                f.calle = (string)r.ItemArray[3];
                f.numero = (string)r.ItemArray[4];
                f.colonia = (string)r.ItemArray[5];
                f.ciudad = (string)r.ItemArray[6];
                f.codigoPostal = (string)r.ItemArray[7];
                lista.Add(f);
            }

            return lista;
        }

        public void insert(facturacion f)
        {
            Conexion con = new Conexion();
            String SQL = "INSERT INTO facturacion (nombreEquipo,RFC,calle,numero,colonia,ciudad,codigoPostal)" +
                "VALUES (@nombreEquipo,@RFC,@calle,@numero,@colonia,@ciudad,@codigoPostal);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombreEquipo", f.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@RFC", f.RFC);
            sqlCom.Parameters.AddWithValue("@calle", f.calle);
            sqlCom.Parameters.AddWithValue("@numero", f.numero);
            sqlCom.Parameters.AddWithValue("@colonia", f.colonia);
            sqlCom.Parameters.AddWithValue("@ciudad", f.ciudad);
            sqlCom.Parameters.AddWithValue("@codigoPostal", f.codigoPostal);
            con.EjecutaSQLComando(sqlCom);
        }

        public void update(facturacion f)
        {
            Conexion con = new Conexion();
            String SQL = "UPDATE facturacion" +
                "SET nombreEquipo = @nombreEquipo, RFC = @RFC, calle = @calle, numero = @numero, colonia = @colonia, ciudad = @ciudad, codigoPostal = @codigoPostal" +
                "WHERE idFacturacion = @idFacturacion limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idFacturacion", f.idFacturacion);
            sqlCom.Parameters.AddWithValue("@nombreEquipo", f.nombreEquipo);
            sqlCom.Parameters.AddWithValue("@RFC", f.RFC);
            sqlCom.Parameters.AddWithValue("@calle", f.calle);
            sqlCom.Parameters.AddWithValue("@numero", f.numero);
            sqlCom.Parameters.AddWithValue("@colonia", f.colonia);
            sqlCom.Parameters.AddWithValue("@ciudad", f.ciudad);
            sqlCom.Parameters.AddWithValue("@codigoPostal", f.codigoPostal);
            con.EjecutaSQLComando(sqlCom);
        }

        public void delete(facturacion f)
        {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM facturacion WHERE idFacturacion=@idFacturacion limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idFacturacion", f.idFacturacion);
            con.EjecutaSQLComando(sqlCom);
        }
    }
}
