using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.App_Code
{
    public class SucursalDAL
    {
        public List<SUCURSAL> ListSucursal()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.SUCURSAL.ToList();
            }
        }
        List<ModelSucursal> Sucursal = new List<ModelSucursal>();
        public List<ModelSucursal> ListSucursales()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Sucursal = (from i in db.SUCURSAL
                            select new ModelSucursal
                            {
                                ID_SUCURSAL = i.ID_SUCURSAL,
                                NOMBRE = i.NOMBRE,
                                DIRECCION = i.DIRECCION,
                                TELEFONO = i.TELEFONO,
                            }
                            ).ToList();
            }
            return Sucursal;
        }

        public void Agregar(SUCURSAL sucursal)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                db.SUCURSAL.Add(sucursal);
                db.SaveChanges();
            }
        }

        public SUCURSAL getSucursal(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.SUCURSAL.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(SUCURSAL sucursal)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.SUCURSAL.Find(sucursal.ID_SUCURSAL);


                p.NOMBRE = sucursal.NOMBRE;
                p.DIRECCION = sucursal.DIRECCION;
                p.TELEFONO = sucursal.TELEFONO;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.SUCURSAL.Find(id);
                db.SUCURSAL.Remove(pac);
                db.SaveChanges();
            }
        }
    }
}
