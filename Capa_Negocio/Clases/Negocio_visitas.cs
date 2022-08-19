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
    public class Negocio_visitas
    {
        Datos_visitas objd = new Datos_visitas();

        public DataTable Insertar_Visitas(Entidad_visitas obj)
        {
            return objd.Insertar_Datos_Visita(obj);
        }

        public DataTable Mostrar_Visitas()
        {
            return objd.Mostrar_Datos_Visita();
        }
    }
}
