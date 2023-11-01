using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
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
        public int cel { get; set; }


        /*public CN_Usuario(int id_tipo_usuario, string nombre, string apellido, string correo, int estado, DateTime fecha_creacion,int dni, string username, string pass, int cel)
        {
            id_tipo_usuario = id_tipo_usuario;
            nombre = nombre.Trim();
            apellido = apellido.Trim();
            correo = correo.Trim();
            estado = estado;
            fecha_creacion = fecha_creacion;
            dni = dni;
            username = username;
            pass = pass.Trim();
            cel = cel;
        }*/

        public void registrar_usuario(CE_Usuario usuarioInput)
        {
            CD_Usuario usuario = new CD_Usuario();
            usuario.registrar_usuario(usuarioInput);
        }
    }

    
}
