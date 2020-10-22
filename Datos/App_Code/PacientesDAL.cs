using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class PacientesDAL
    {
        //List<ModelPaciente> DatosPaciente = new List<ModelPaciente>();

        //public List<ModelPaciente> Pacientes()
        //{
        //    using (DBClinicaEntities db = new DBClinicaEntities())
        //    {
        //        DatosPaciente = (from q in db.PACIENTE
        //                         select new ModelPaciente
        //                         {
        //                             ID_PACIENTE = q.ID_PACIENTE,
        //                             PRIMER_NOMBRE = q.PRIMER_NOMBRE,
        //                             SEGUNDO_NOMBRE = q.SEGUNDO_NOMBRE,
        //                             PRIMER_APELLIDO = q.PRIMER_APELLIDO,
        //                             SEGUNDO_APELLIDO = q.SEGUNDO_APELLIDO,
        //                             EDAD = q.EDAD,
        //                             DIRECCION = q.DIRECCION
        //                         }
        //                    ).ToList();
        //    }
        //    return DatosPaciente;
        //}

        public List<PACIENTE> ListPacientes()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE.ToList();
            }
        }
    }
}
