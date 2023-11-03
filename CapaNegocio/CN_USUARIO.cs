using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_USUARIO
    {
        public int id_usuario { get; set; }
        public int id_tipo_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public int estado { get; set; }
        public DateTime fecha_creacion { get; set; }
        public int dni { get; set; }
        public string username { get; set; }
        public string pass { get; set; }

        public string domicilio { get; set; }

        public int cel { get; set; }


        public void CN_Usuario(int id_tipo_usuario, string nombre, string apellido, string correo, int estado, DateTime fecha_creacion, int dni, string username, string pass, int cel, string domicilio)
        {
            this.id_tipo_usuario = id_tipo_usuario;
            this.nombre = nombre.Trim();
            this.apellido = apellido.Trim();
            this.correo = correo.Trim();
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.dni = dni;
            this.username = username;
            this.pass = pass.Trim();
            this.cel = cel;
            this.domicilio = domicilio;
        }

        public void registrar_usuario(CE_Usuario usuarioInput)
        {
            CD_Usuario usuario = new CD_Usuario();
            usuario.registrar_usuario(usuarioInput);
        }

        public DataTable ConsultaDT()
        { 
            CD_Usuario usuarios = new CD_Usuario();
            return usuarios.ConsultaUsuariosDG();
        }


        public int modificar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            CD_Usuario usuario = new CD_Usuario();
            return usuario.modificar_usuario(nombre_usuario, apellido_usuario, username, dni_usuario, email_usuario, domicilio_usuario, celular, pass, id_tipousuario);    
        }

        public int insertar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            CD_Usuario usuario = new CD_Usuario();
            return usuario.insertar_usuario(nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular,pass,id_tipousuario);


        }

        public int eliminar_usuario(string dni)
        {
            CD_Usuario usuario = new CD_Usuario();
            return usuario.eliminar_usuario(dni);


        }
    }
}
