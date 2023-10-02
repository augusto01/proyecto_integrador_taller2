using System;
using System.Collections.Generic;

namespace SportsOn.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int IdProveedor { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaAltaCompra { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
