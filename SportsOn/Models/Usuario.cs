using System;
using System.Collections.Generic;

namespace SportsOn.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int? IdTipoUsuario { get; set; }

    public int? IdVenta { get; set; }

    public int? IdCompra { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? Dni { get; set; }

    public string? Username { get; set; }

    public virtual Compra? IdCompraNavigation { get; set; }

    public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }

    public virtual VentaDetalle? IdVentaNavigation { get; set; }

    public virtual ICollection<VentaCabecera> VentaCabeceras { get; set; } = new List<VentaCabecera>();
}
