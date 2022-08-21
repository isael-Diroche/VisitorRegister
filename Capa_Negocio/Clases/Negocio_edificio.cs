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
    public class Negocio_edificio
    {
        Datos_edificios objd = new Datos_edificios();

        public DataTable Mostrar_Edificio()
        {
            return objd.Mostrar_Edificio();
        }

        public DataTable Insertar_Edificio(Entidad_edificios obj)
        {
            return objd.Insertar_Edificio(obj);
        }

        public DataTable Actualizar_Edificio(Entidad_edificios obj)
        {
            return objd.Actualizar_Edificio(obj);
        }

        public DataTable Eliminar_Edificio(int id)
        {
            return objd.Eliminar_Edificio(id);
        }
    }
}
