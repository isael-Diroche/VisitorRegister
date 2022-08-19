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
    public class Datos_login
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString);
        
        public DataTable Datos_Login(Entidad_login obj)
        {
            MySqlCommand cmd = new MySqlCommand("SP_logueo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("dt_USUARIO", obj.usuario);
            cmd.Parameters.AddWithValue("dt_CONTRASENA", obj.contrasena);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
