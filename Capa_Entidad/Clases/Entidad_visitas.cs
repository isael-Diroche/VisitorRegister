using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad.Clases;

namespace Capa_Entidad.Clases
{
    public class Entidad_visitas
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string carrera { get; set; }
        public string correo { get; set; }
        public string edificio { get; set; }
        public string hora_entrada { get; set; }
        public string hora_salida { get; set; }
        public string motivo_visita { get; set; }
        public byte[] foto_visita { get; set; }
        public string se_dirige { get; set; }

    }
}
