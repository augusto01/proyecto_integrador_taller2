﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_VENTA
    {

        public int id_venta { get; set; }

        public int id_cabecera { get; set; }

        public int id_cantidad_prodycto { get; set; }

        public string nombre_producto { get; set; }

        public int id_producto { get; set; }

    }
}
