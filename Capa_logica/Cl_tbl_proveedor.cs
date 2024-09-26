using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_logica
{
    public class Cl_tbl_proveedor
    {
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static List<tbl_proveedor> listar()
        {
            var lista = dc.tbl_proveedor.Where(prov => prov.prov_estado == 'A').ToList();
            return lista;
        }
    }
}
