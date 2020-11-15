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
    public class Paciente_HabitacionDAL
    {
        public List<PACIENTE_HABITACION> ListPaciHabi()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE_HABITACION.ToList();
            }
        }

        List<ModelPaciente_Habitacion> PacienteHabitacion = new List<ModelPaciente_Habitacion>();

        public List<ModelPaciente_Habitacion> ListPaciHabis()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                PacienteHabitacion = (from ph in db.PACIENTE_HABITACION
                                      join pa in db.PACIENTE
                                      on ph.ID_PACIENTE equals pa.ID_PACIENTE
                                      join h in db.HABITACION
                                      on ph.ID_HABITACION equals h.ID_HABITACION
                                      select new ModelPaciente_Habitacion
                                      {
                                          ID_PACIENTE_HABITACION = ph.ID_PACIENTE_HABITACION,
                                          PACIENTE = pa.PRIMER_NOMBRE + " " + pa.PRIMER_APELLIDO,
                                          HABITACION = h.NOMBRE_HABITACION,
                                          Fecha_Estancia = ph.Fecha_Estancia
                                      }
                                ).ToList();
            }
            return PacienteHabitacion;
        }

        public void Agregar(PACIENTE_HABITACION pacienteHabitacion)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.PACIENTE_HABITACION.Add(pacienteHabitacion);
                db.SaveChanges();
            }
        }

        public PACIENTE_HABITACION getPacienteHabitacion(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE_HABITACION.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(PACIENTE_HABITACION pacienteHabitacion)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.PACIENTE_HABITACION.Find(pacienteHabitacion.ID_PACIENTE_HABITACION);


                p.ID_PACIENTE = pacienteHabitacion.ID_PACIENTE;
                p.ID_HABITACION = pacienteHabitacion.ID_HABITACION;
                p.Fecha_Estancia = pacienteHabitacion.Fecha_Estancia;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.PACIENTE_HABITACION.Find(id);
                db.PACIENTE_HABITACION.Remove(pac);
                db.SaveChanges();
            }
        }
    }
}
