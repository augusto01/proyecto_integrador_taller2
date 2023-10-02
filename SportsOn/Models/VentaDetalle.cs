using System;
using System.Collections.Generic;

namespace SportsOn.Models;

public partial class VentaDetalle
{
    public int IdVenta { get; set; }

    public int? IdProducto { get; set; }

    public string? Descripcion { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
