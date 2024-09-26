using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public  class Cl_tbl_producto
    {
        private static DataClasses1DataContext dc= new DataClasses1DataContext();

        public static void guardar(tbl_producto producto)
        {
            try
            {
                producto.pro_estado = 'A';
                dc.tbl_producto.InsertOnSubmit(producto);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados!</br>" + ex.Message);
            }
        }

        public static void modificar(tbl_producto producto)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados!</br>" + ex.Message);
            }
        }

        public static List<tbl_producto> listar()
        {
            var lista = dc.tbl_producto.Where(x => x.pro_estado == 'A').ToList();
            return lista;
        }

        public static List<tbl_producto> listarN(string nombre)
        {
            var lista = dc.tbl_producto.Where(x => x.pro_estado == 'A' && x.pro_nombre.Contains(nombre)).ToList();
            return lista;
        }

        public static List<tbl_producto> listarC(int cantidad)
        {
            var lista = dc.tbl_producto.Where(x => x.pro_estado == 'A' && x.pro_cantidad == cantidad).ToList();
            return lista;
        }

        public static List<tbl_producto> listarPro(int proveedorId)
        {
            var lista = dc.tbl_producto.Where(x => x.pro_estado == 'A' && x.prov_id == proveedorId).ToList();
            return lista;
        }

        public static tbl_producto GetById(int id)
        {
            return dc.tbl_producto.FirstOrDefault(x => x.pro_id == id);
        }

        public static void Delete(int id)
        {
            var producto = GetById(id);

            if (producto == null) return;
            producto.pro_estado = 'D';
            modificar(producto);
        }


    }
}
