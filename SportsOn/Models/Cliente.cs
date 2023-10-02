using System;
using System.Collections.Generic;

namespace SportsOn.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string ApellidoCliente { get; set; } = null!;

    public string? CorreoCliente { get; set; }

    public bool? EstadoCliente { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<VentaCabecera> VentaCabeceras { get; set; } = new List<VentaCabecera>();
}
