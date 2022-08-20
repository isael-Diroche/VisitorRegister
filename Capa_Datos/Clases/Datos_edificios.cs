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
            MySqlCommand cmd = new MySqlCommand("SP_mostrar_edificio", conexion);

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

        //public DataTable Insertar_Edificio() { }

        //public DataTable Actualizar_Edificio() { }

        //public DataTable Eliminar_Edificio() { }
    }
}
