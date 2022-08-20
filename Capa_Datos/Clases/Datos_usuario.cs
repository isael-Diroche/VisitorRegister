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
    public class Datos_usuario
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);
        
        public DataTable Mostrar_Usuario()
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_mostrar_usuario", conexion);

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

        public DataTable Insertar_Usuario(Entidad_usuario obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_insertar_usuario", conexion);
            
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("D_nombre", obj.nombre);
                cmd.Parameters.AddWithValue("D_apellido", obj.apellido);
                cmd.Parameters.AddWithValue("D_fecha_nacimiento", obj.fecha_nacimiento);
                cmd.Parameters.AddWithValue("D_tipo_usuario", obj.tipo_usuario);
                cmd.Parameters.AddWithValue("D_usuario", obj.usuario);
                cmd.Parameters.AddWithValue("D_contrasena", obj.contrasena);
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

        public DataTable Actualizar_Usuario(Entidad_usuario obj)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_actualizar_usuario", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //PARAMETERS
                cmd.Parameters.AddWithValue("idItem", obj.Id);
                cmd.Parameters.AddWithValue("D_nombre", obj.nombre);
                cmd.Parameters.AddWithValue("D_apellido", obj.apellido);
                cmd.Parameters.AddWithValue("D_fecha_nacimiento", obj.fecha_nacimiento);
                cmd.Parameters.AddWithValue("D_tipo_usuario", obj.tipo_usuario);
                cmd.Parameters.AddWithValue("D_usuario", obj.usuario);
                cmd.Parameters.AddWithValue("D_contrasena", obj.contrasena);
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

        public DataTable Eliminar_Usuario(int id)
        {
            DataTable Tabla = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SP_eliminar_usuario", conexion);

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
