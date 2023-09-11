using System;
using System.Collections.Generic;

namespace TecniTienda.Models;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public int? IdCliente { get; set; }

    public int? TotalProducto { get; set; }

    public decimal? MontoTotal { get; set; }

    public string? Contacto { get; set; }

    public string? IdBarrio { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? IdTransaccion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
