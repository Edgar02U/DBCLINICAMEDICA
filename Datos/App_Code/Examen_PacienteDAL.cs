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
    public class Examen_PacienteDAL
    {
        public List<EXAMEN_PACIENTE> ListExamePaciente()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.EXAMEN_PACIENTE.ToList();
            }
        }

        List<ModelExamen_Paciente> ExamenPaciente = new List<ModelExamen_Paciente>();

        public List<ModelExamen_Paciente> ListExamenesPacientes()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                ExamenPaciente = (from p in db.EXAMEN_PACIENTE
                                  join e in db.EXAMEN
                                  on p.ID_EXAMEN equals e.ID_EXAMEN
                                  join pa in db.PACIENTE
                                  on p.ID_PACIENTE equals pa.ID_PACIENTE
                                  select new ModelExamen_Paciente
                                  {
                                      ID_EXAMEN_PACIENTE = p.ID_EXAMEN_PACIENTE,
                                      NOMBRE_EXAMEN = e.NOMBRE_EXAMEN,
                                      PACIENTE = pa.PRIMER_NOMBRE+" "+pa.PRIMER_APELLIDO,
                                      FECHA_REALIZO = p.FECHA_REALIZO,
                                      ENCARGADO = p.ENCARGADO
                                  }
                            ).ToList();
            }
            return ExamenPaciente;
        }


       
    }
}
