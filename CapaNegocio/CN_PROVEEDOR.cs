using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_PROVEEDOR
    {
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public string razon_social { get; set; }
        public int nro_telefono { get; set; }

        public void CN_Proveedor(string nombre, string apellido, string correo, int dni, string direccion, string razon_social, int nro_telefono)
        {
            this.nombre = nombre.ToString();
            this.apellido = apellido.ToString();
            this.correo = correo.ToString();
            this.dni = dni;
            this.direccion = direccion.ToString();
            this.razon_social = razon_social.ToString();
            this.nro_telefono = nro_telefono;

        }


        public int insertar_proveedor(string nombre, string apellido, string correo, int dni, string direccion, string razon_social, int nro_telefono)
        {
            CD_Proveedor proveedor = new CD_Proveedor();
            return proveedor.insertar_proveedor ( nombre,  apellido,  razon_social,  direccion,  correo,  nro_telefono,  dni);


        }

        public List<string> obtener_proveedores()
        {
            CD_Proveedor datos = new CD_Proveedor();
            return datos.obtener_proveedores();
        }

    }
}
