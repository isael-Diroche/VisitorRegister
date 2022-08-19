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
    public class Datos_visitas
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);

        public DataTable Insertar_Datos_Visita(Entidad_visitas obj)
        {
            MySqlDataReader resultado;
            DataTable Tabla = new DataTable();
            /******** CONECION ********/
            MySqlCommand cmd = new MySqlCommand("SP_registrar_visita", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            byte[] mifoto = obj.foto_visita;
            //PARAMETERS
            cmd.Parameters.AddWithValue("D_nombre", obj.nombre);
            cmd.Parameters.AddWithValue("D_apellido", obj.apellido);
            cmd.Parameters.AddWithValue("D_carrera", obj.carrera);
            cmd.Parameters.AddWithValue("D_correo", obj.correo);
            cmd.Parameters.AddWithValue("D_edificio", obj.edificio);
            cmd.Parameters.AddWithValue("D_hora_entrada", obj.hora_entrada);
            cmd.Parameters.AddWithValue("D_hora_salida", obj.hora_salida);
            cmd.Parameters.AddWithValue("D_motivo_visita", obj.motivo_visita);
            cmd.Parameters.AddWithValue("D_foto_visita", mifoto);
            cmd.Parameters.AddWithValue("D_se_dirige", obj.se_dirige);

            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                resultado = cmd.ExecuteReader();
                Tabla.Load(resultado);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open) { conexion.Close(); }
            }

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(Tabla);
            return Tabla;
        }

        public DataTable Mostrar_Datos_Visita()
        {
            MySqlDataReader resultado;
            DataTable Tabla = new DataTable();
            /******** CONECION ********/
            MySqlCommand cmd = new MySqlCommand("SP_mostrar_visitas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                resultado = cmd.ExecuteReader();
                Tabla.Load(resultado);
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
