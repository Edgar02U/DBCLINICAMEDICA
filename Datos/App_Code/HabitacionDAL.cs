using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class HabitacionDAL
    {
        public List<HABITACION> ListHabitacion()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.HABITACION.ToList();
            }
        }

        public void Agregar(HABITACION habitacion)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.HABITACION.Add(habitacion);
                db.SaveChanges();
            }
        }

        public HABITACION getHabitacion(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.HABITACION.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(HABITACION habitacion)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.HABITACION.Find(habitacion.ID_HABITACION);


                p.NOMBRE_HABITACION = habitacion.NOMBRE_HABITACION;
                p.DESCRIPCION = habitacion.DESCRIPCION;
                p.CAPACIDAD = habitacion.CAPACIDAD;
                p.ESTADO = habitacion.ESTADO;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.HABITACION.Find(id);
                db.HABITACION.Remove(pac);
                db.SaveChanges();
            }
        }

        List<ModelHabitacion> Habitacion = new List<ModelHabitacion>();

        public List<ModelHabitacion> ListHabitaciones()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Habitacion = (from i in db.HABITACION
                              select new ModelHabitacion
                              {
                                  ID_HABITACION = i.ID_HABITACION,
                                  NOMBRE_HABITACION = i.NOMBRE_HABITACION,
                                  DESCRIPCION = i.DESCRIPCION,
                                  CAPACIDAD = i.CAPACIDAD,
                                  ESTADO = i.ESTADO
                              }
                            ).ToList();
            }
            return Habitacion;

        }
    }
 }
