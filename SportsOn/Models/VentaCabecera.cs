using System;
using System.Collections.Generic;

namespace SportsOn.Models;

public partial class VentaCabecera
{
    public int IdCabecera { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCliente { get; set; }

    public DateTime? FechaVenta { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
