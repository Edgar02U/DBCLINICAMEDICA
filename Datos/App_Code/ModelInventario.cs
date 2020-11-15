using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
   public class ModelInventario
    {
        public int ID_INVENTARIO { get; set; }
        public string TIPO_INVENTARIO { get; set; }
        public string MEDICINA { get; set; }
        public int CANTIDAD { get; set; }
        public string SUCURSAL { get; set; }

        
    }
}
