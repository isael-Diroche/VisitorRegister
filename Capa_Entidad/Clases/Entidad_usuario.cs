using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad.Clases
{
    public class Entidad_usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha_nacimiento { get; set; }
        public string tipo_usuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
    }
}
