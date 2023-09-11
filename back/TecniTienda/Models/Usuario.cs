using System;
using System.Collections.Generic;

namespace TecniTienda.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
