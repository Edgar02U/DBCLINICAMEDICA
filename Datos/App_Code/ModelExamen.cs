using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ModelExamen
    {
        public int ID_EXAMEN { get; set; }
        public string NOMBRE_EXAMEN { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public string RECOMENDACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string TRATAMIENTO { get; set; }
    }
}
