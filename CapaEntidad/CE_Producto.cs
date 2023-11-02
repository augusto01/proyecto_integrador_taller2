using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Producto
    {
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public float precio_unitario { get; set; }

        public int stock { get; set; }
        public DateTime fehca_alta { get; set; }

        public int id_categoria { get; set; }

        public int id_proveedor { get; set; }   



    }
}
