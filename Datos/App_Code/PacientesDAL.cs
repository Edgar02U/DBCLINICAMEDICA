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

        public void Agregar(PACIENTE paciente)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.PACIENTE.Add(paciente);
                db.SaveChanges();
            }
        }

        public PACIENTE getPaciente(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(PACIENTE paciente)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.PACIENTE.Find(paciente.ID_PACIENTE);


                p.PRIMER_NOMBRE = paciente.PRIMER_NOMBRE;
                p.SEGUNDO_NOMBRE = paciente.SEGUNDO_NOMBRE;
                p.PRIMER_APELLIDO = paciente.PRIMER_APELLIDO;
                p.SEGUNDO_APELLIDO = paciente.SEGUNDO_APELLIDO;
                p.EDAD = paciente.EDAD;
                p.DIRECCION = paciente.DIRECCION;
                p.FECHA_NACIMIENTO = paciente.FECHA_NACIMIENTO;
                p.TELEFONO = paciente.TELEFONO;
                p.CORREO_ELECTRONICO = paciente.CORREO_ELECTRONICO;
                p.ID_SUCURSAL = paciente.ID_SUCURSAL;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.PACIENTE.Find(id);
                db.PACIENTE.Remove(pac);
                db.SaveChanges();
            }
        }

        public List<PACIENTE> ListPaciente()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.PACIENTE.ToList();
            }
        }

        List<ModelPaciente> Paciente = new List<ModelPaciente>();

        public List<ModelPaciente> ListPacientes()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Paciente = (from i in db.PACIENTE
                            join su in db.SUCURSAL
                            on i.ID_SUCURSAL equals su.ID_SUCURSAL
                            select new ModelPaciente
                            {
                                ID_PACIENTE = i.ID_PACIENTE,
                                PRIMER_NOMBRE = i.PRIMER_NOMBRE,
                                SEGUNDO_NOMBRE = i.SEGUNDO_NOMBRE,
                                PRIMER_APELLIDO = i.PRIMER_APELLIDO,
                                SEGUNDO_APELLIDO = i.SEGUNDO_APELLIDO,
                                EDAD = i.EDAD,
                                DIRECCION = i.DIRECCION,
                                FECHA_NACIMIENTO = i.FECHA_NACIMIENTO,
                                TELEFONO = i.TELEFONO,
                                CORREO_ELECTRONICO = i.CORREO_ELECTRONICO,
                                SUCURSAL = su.NOMBRE
                            }
                            ).ToList();
            }
            return Paciente;
        }

        public SUCURSAL getSucursal(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.SUCURSAL.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }
    }
}
