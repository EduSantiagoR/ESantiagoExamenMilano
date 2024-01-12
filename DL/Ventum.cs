using System;
using System.Collections.Generic;

namespace DL;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public int IdProductoVendido { get; set; }

    public int Cantidad { get; set; }

    public double Total { get; set; }

    public virtual Producto IdProductoVendidoNavigation { get; set; } = null!;
}
