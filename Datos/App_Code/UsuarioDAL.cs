using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class UsuarioDAL
    {
        public List<USUARIO> ListUsuario()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.USUARIO.ToList();
            }
        }

        List<ModelUsuario> Usuario = new List<ModelUsuario>();

        public List<ModelUsuario> ListUsuarios()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Usuario = (from i in db.USUARIO
                           join su in db.SUCURSAL
                            on i.ID_SUCURSAL equals su.ID_SUCURSAL
                           select new ModelUsuario
                            {
                                ID_USUARIO = i.ID_USUARIO,
                                PRIMER_NOMBRE = i.PRIMER_NOMBRE,
                                SEGUNDO_NOMBRE = i.SEGUNDO_NOMBRE,
                                PRIMER_APELLIDO = i.PRIMER_APELLIDO,
                                SEGUNDO_APELLIDO = i.SEGUNDO_APELLIDO,
                                USERC = i.USERC,
                                PASSWORD = i.PASSWORD,
                                EDAD = i.EDAD,
                                FECHA_CREACION = i.FECHA_CREACION,
                                ESTADO = i.PUESTO,
                                GENERO = i.GENERO,
                                SUCURSAL = su.NOMBRE
                            }
                            ).ToList();
            }
            return Usuario;
        }
        public void Agregar(USUARIO usuario)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.USUARIO.Add(usuario);
                db.SaveChanges();
            }
        }

        public USUARIO getUsuario(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.USUARIO.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(USUARIO usuario)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.USUARIO.Find(usuario.ID_USUARIO);


                p.PRIMER_NOMBRE = usuario.PRIMER_NOMBRE;
                p.SEGUNDO_NOMBRE = usuario.SEGUNDO_NOMBRE;
                p.PRIMER_APELLIDO = usuario.PRIMER_APELLIDO;
                p.SEGUNDO_APELLIDO = usuario.SEGUNDO_APELLIDO;
                p.USERC = usuario.USERC;
                p.PASSWORD = usuario.PASSWORD;
                p.EDAD = usuario.EDAD;
                p.FECHA_CREACION = usuario.FECHA_CREACION;
                p.ESTADO = usuario.ESTADO;
                p.PUESTO = usuario.PUESTO;
                p.GENERO = usuario.GENERO;
                p.ID_SUCURSAL = usuario.ID_SUCURSAL;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.USUARIO.Find(id);
                db.USUARIO.Remove(pac);
                db.SaveChanges();
            }
        }
    }
}
