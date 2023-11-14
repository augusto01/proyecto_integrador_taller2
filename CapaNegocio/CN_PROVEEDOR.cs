using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        public string razonsocial { get; set; }
 
        public string direccion { get; set; }

        public string correo { get; set; }
        public int nro_telefono { get; set; }
        public int dni { get; set; }


        public void CN_Proveedor(string nombre, string apellido, string correo, int dni, string direccion, string razon_social, int nro_telefono)
        {
            this.nombre = nombre.ToString();
            this.apellido = apellido.ToString();
            this.razonsocial = razon_social.ToString();
            this.correo = correo.ToString();
            this.dni = dni;
            this.direccion = direccion.ToString();
            this.nro_telefono = nro_telefono;
      

        }

        CD_Proveedor proveedor = new CD_Proveedor();

        public void registrar_proveedor(string nombre, string apellido, int dni, string email, string domicilio, string razonsocial, int celular)
        {
            
            proveedor.insertar_proveedor(nombre, apellido, razonsocial, domicilio, email, celular, dni);
        }

        public DataTable ConsultaDT()
        {
         
            return proveedor.ConsultarProveedoresDG();
        }


        public int modificar_proveedor(string nombre, string apellido, int dni, string email, string domicilio, string razonsocial, int celular)
        {
            CD_Proveedor proveedor = new CD_Proveedor();
            return proveedor.modificar_proveedor(nombre, apellido, dni, email, domicilio, razonsocial,celular);
        }

        public int eliminar_proveedor(int dni)
        {
            CD_Proveedor proveedor = new CD_Proveedor();
            return proveedor.eliminar_proveedor(dni);


        }



        public List<string> obtener_proveedores()
        {
            CD_Proveedor datos = new CD_Proveedor();
            return datos.obtener_proveedores();
        }

    }
}
