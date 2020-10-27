using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class CitasDAL
    {
        public List<CITAS> ListCita()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.CITAS.ToList(); 
            }
        }

        List<ModelCitas> Citas = new List<ModelCitas>();

        public List<ModelCitas> ListCitas()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Citas = (from c in db.CITAS
                         join pa in db.PACIENTE
                         on c.ID_PACIENTE equals pa.ID_PACIENTE
                         select new ModelCitas
                         {
                             ID_CITA = c.ID_CITA,
                             FECHA = c.FECHA,
                             OBOSERVACIONES = c.OBOSERVACIONES,
                             PACIENTE = pa.PRIMER_NOMBRE + " " + pa.PRIMER_APELLIDO
                         }
                      ).ToList();
            }
            return Citas;
        }
    }
}
