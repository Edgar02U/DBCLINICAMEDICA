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
       
        public void Agregar(CITAS cita)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.CITAS.Add(cita);
                db.SaveChanges();
            }
        }

        public CITAS getCita(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.CITAS.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(CITAS cita)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var c = db.CITAS.Find(cita.ID_CITA);


                c.FECHA = cita.FECHA;
                c.OBOSERVACIONES = cita.OBOSERVACIONES;
                c.ID_PACIENTE = cita.ID_PACIENTE;
                
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var cit = db.CITAS.Find(id);
                db.CITAS.Remove(cit);
                db.SaveChanges();
            }
        }

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
