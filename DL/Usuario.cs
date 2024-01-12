using System;
using System.Collections.Generic;

namespace DL;

public partial class Usuario
{
    public string NumeroEmpleado { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int IdTiendaAsignada { get; set; }

    public virtual Tiendum IdTiendaAsignadaNavigation { get; set; } = null!;
}
