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
    public class Negocio_aula
    {
        Datos_aulas objd = new Datos_aulas();

        public DataTable Mostrar_Aula()
        {
            return objd.Mostrar_Aula();
        }

        public DataTable Insertar_Aula(Entidad_aulas obj)
        {
            return objd.Insertar_Aula(obj);
        }

        public DataTable Actualizar_Aula(Entidad_aulas obj)
        {
            return objd.Actualizar_Aula(obj);
        }

        //public DataTable Eliminar_Aula(int id)
        //{
        //    return objd.Eliminar_Usuario(id);
        //}
    }
}
