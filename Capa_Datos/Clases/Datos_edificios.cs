using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using Capa_Entidad.Clases;

namespace Capa_Datos.Clases
{
    public class Datos_edificios
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);

        public DataTable Mostrar_Edificio()
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_mostrar_edificios", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Close(); }
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(Tabla);
            return Tabla;
        }

        public DataTable Insertar_Edificio(Entidad_edificios obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_insertar_edificio", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("Valor", obj.descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Close(); }
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(Tabla);
            return Tabla;
        }

        public DataTable Actualizar_Edificio(Entidad_edificios obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_actualizar_edificio", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("IdItem", obj.Id);
                cmd.Parameters.AddWithValue("D_descripcion", obj.descripcion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Close(); }
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(Tabla);
            return Tabla;
        }

        public DataTable Eliminar_Edificio(int id)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_eliminar_edificio", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("IdItem", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Close(); }
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(Tabla);
            return Tabla;
        }
    }
}
