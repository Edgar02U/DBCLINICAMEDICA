using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class ExamenDAL
    {
        public List<EXAMEN> ListExamen()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.EXAMEN.ToList();
            }
        }

        List<ModelExamen> Examen = new List<ModelExamen>();
        public List<ModelExamen> ListExamen_()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Examen = (from e in db.EXAMEN
                          select new ModelExamen
                          {
                              ID_EXAMEN = e.ID_EXAMEN,
                              NOMBRE_EXAMEN = e.NOMBRE_EXAMEN,
                              PRECIO = e.PRECIO,
                              RECOMENDACION = e.RECOMENDACION,
                              DESCRIPCION = e.DESCRIPCION,
                              TRATAMIENTO = e.TRATAMIENTO
                          }
                          ).ToList();
            }
            return Examen;
        }

        public void Agregar(EXAMEN examen)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.EXAMEN.Add(examen);
                db.SaveChanges();
            }
        }

        public EXAMEN getExamen(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.EXAMEN.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(EXAMEN examen)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var c = db.EXAMEN.Find(examen.ID_EXAMEN);


                c.NOMBRE_EXAMEN = examen.NOMBRE_EXAMEN;
                c.PRECIO = examen.PRECIO;
                c.RECOMENDACION = examen.RECOMENDACION;
                c.DESCRIPCION = examen.DESCRIPCION;
                c.TRATAMIENTO = examen.TRATAMIENTO;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var ex = db.EXAMEN.Find(id);
                db.EXAMEN.Remove(ex);
                db.SaveChanges();
            }
        }
    }
}
