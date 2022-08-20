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
    public class Negocio_usuario
    {
        Datos_usuario objd = new Datos_usuario();

        public DataTable Mostrar_Usuario()
        {
            return objd.Mostrar_Usuario();
        }

        public DataTable Insertar_Usuario(Entidad_usuario obj)
        {
            return objd.Insertar_Usuario(obj);
        }

        public DataTable Actualizar_Usuario(Entidad_usuario obj)
        {
            return objd.Actualizar_Usuario(obj);
        }

        public DataTable Eliminar_Usuario(int id)
        {
            return objd.Eliminar_Usuario(id);
        }
    }
}
