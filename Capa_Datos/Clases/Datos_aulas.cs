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

        //public DataTable Insertar_Aula() { }

        //public DataTable Actualizar_Aula() { }

        //public DataTable Eliminar_Aula() { }
    }
}
