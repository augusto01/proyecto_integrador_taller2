using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CLIENTE
    {

        public int id_cliente { get; set; }
        public int id_tipo_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }
      
        public int dni { get; set; }
    

        public string domicilio { get; set; }

        public int cel { get; set; }


        public void CN_Usuario( string nombre, string apellido, string correo, int estado, int dni,  int cel, string domicilio)
        {
            this.id_tipo_usuario = id_tipo_usuario;
            this.nombre = nombre.Trim();
            this.apellido = apellido.Trim();
            this.correo = correo.Trim();
            this.estado = estado; 
            this.dni = dni;        
            this.cel = cel;
            this.domicilio = domicilio;
        }

        public void registrar_cliente(string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domicilio_cliente, int celular_cliente )
        {
            CD_Cliente cliente = new CD_Cliente();
            cliente.insertar_cliente(nombre_cliente, apellido_cliente, dni_cliente, email_cliente, domicilio_cliente, celular_cliente);
        }
        
        public DataTable ConsultaDT()
        {
            CD_Cliente cliente = new CD_Cliente();
            return cliente.ConsultaClientesDg();
        }
        /*

        public int modificar_cliente(string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domicilio_cliente, int celular_cliente)
        {
            CD_Usuario cliente = new CD_Usuario();
            return cliente.modificar_cliente(nombre_cliente, apellido_cliente, dni_cliente, email_cliente, domicilio_cliente, celular_cliente);
        }

        public int insertar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            CD_Usuario cliente = new CD_Usuario();
            return cliente.registrar_cliente(nombre_usuario, apellido_usuario, username, dni_usuario, email_usuario, domicilio_usuario, celular, pass, id_tipousuario);


        }

        public int eliminar_cliente(int dni)
        {
            CD_Usuario cliente = new CD_Usuario();
            return cliente.eliminar_cliente(dni);


        }*/
    }
}

