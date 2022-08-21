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
    public class Datos_aulas
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);

        public DataTable Mostrar_Aula()
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_mostrar_aula", conexion);

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

        public DataTable Insertar_Aula(Entidad_aulas obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_insertar_aula", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("D_descripcion", obj.descripcion);
                cmd.Parameters.AddWithValue("D_edificio", obj.edificio);
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

        public DataTable Actualizar_Aula(Entidad_aulas obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_actualizar_aula", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("IdItem", obj.Id);
                cmd.Parameters.AddWithValue("D_descripcion", obj.descripcion);
                cmd.Parameters.AddWithValue("D_edificio", obj.edificio);
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

        public DataTable Eliminar_Aula(int id)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_eliminar_aula", conexion);

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
