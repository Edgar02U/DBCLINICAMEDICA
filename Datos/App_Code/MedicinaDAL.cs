using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class MedicinaDAL
    {
        public List<MEDICINA> ListMedicina()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.MEDICINA.ToList();
            }
        }

        public void Agregar(MEDICINA medicina)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.MEDICINA.Add(medicina);
                db.SaveChanges();
            }
        }

        public MEDICINA getMedicina(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.MEDICINA.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(MEDICINA medicina)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var m = db.MEDICINA.Find(medicina.ID_MEDICINA);


                m.NOMBRE = medicina.NOMBRE;
                m.DESCRIPCION = medicina.DESCRIPCION;

                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.MEDICINA.Find(id);
                db.MEDICINA.Remove(pac);
                db.SaveChanges();
            }
        }
    }
}
