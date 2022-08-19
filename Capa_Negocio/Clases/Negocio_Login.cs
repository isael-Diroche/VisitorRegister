using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Clases;
using Capa_Entidad.Clases;
using System.Data;

namespace Capa_Negocio.Clases
{
    public class Negocio_Login
    {
        Datos_login objd = new Datos_login();

        public DataTable N_login(Entidad_login obj)
        {
            return objd.Datos_Login(obj);
        }
    }
}
