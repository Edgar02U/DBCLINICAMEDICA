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
    public class InventarioDAL
    {
        public List<INVENTARIO> ListInventario()
        {

            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.INVENTARIO.ToList();

            }
        }

        List<ModelInventario> Inventario = new List<ModelInventario>();

        public List<ModelInventario> ListInventarios()
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                Inventario = (from i in db.INVENTARIO
                                  join t in db.TIPO_INVENTARIO
                                  on i.ID_TIPO_INVENTARIO equals t.ID_TIPO_INVENTARIO
                                  join m in db.MEDICINA
                                  on i.ID_MEDICINA equals m.ID_MEDICINA
                                  join su in db.SUCURSAL
                                  on i.ID_SUCURSAL equals su.ID_SUCURSAL
                                  select new ModelInventario
                                  {
                                      ID_INVENTARIO = i.ID_INVENTARIO,
                                      TIPO_INVENTARIO = t.NOMBRE,
                                      MEDICINA = m.NOMBRE,
                                      CANTIDAD = i.CANTIDAD,
                                      SUCURSAL = su.NOMBRE
                                  }
                            ).ToList();
            }
            return Inventario;
        }

        public void Agregar(INVENTARIO inventario)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                    db.INVENTARIO.Add(inventario);
                    db.SaveChanges();
            }
        }

        public INVENTARIO getInventario(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.INVENTARIO.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }

        public void Editar(INVENTARIO inventario)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var p = db.INVENTARIO.Find(inventario.ID_INVENTARIO);


                p.ID_TIPO_INVENTARIO = inventario.ID_TIPO_INVENTARIO;
                p.ID_MEDICINA = inventario.ID_MEDICINA;
                p.CANTIDAD = inventario.CANTIDAD;
                p.ID_SUCURSAL = inventario.ID_SUCURSAL;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                var pac = db.INVENTARIO.Find(id);
                db.INVENTARIO.Remove(pac);
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

        public MEDICINA getMedicina(int id)
        {
            using (DBClinicaEntities db = new DBClinicaEntities())
            {
                return db.MEDICINA.Find(id);
                //return db.PACIENTE.Where(x => x.ID_PACIENTE ==id).FirstOrDefault();
            }
        }
    }
}
