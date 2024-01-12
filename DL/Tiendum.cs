using System;
using System.Collections.Generic;

namespace DL;

public partial class Tiendum
{
    public int IdTienda { get; set; }

    public string Nombre { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Regional { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
