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
    }
}
