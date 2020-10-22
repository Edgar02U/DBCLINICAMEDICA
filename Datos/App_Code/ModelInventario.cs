using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
   public class ModelInventario
    {
        public int ID_TIPO_INVENTARIO { get; set; }
        public int ID_MEDICINA { get; set; }
        public int CANTIDAD { get; set; }
        public int ID_SUCURSAL { get; set; }

        //public virtual MEDICINA MEDICINA { get; set; }
        //public virtual SUCURSAL SUCURSAL { get; set; }
        //public virtual TIPO_INVENTARIO TIPO_INVENTARIO { get; set; }
    }
}
