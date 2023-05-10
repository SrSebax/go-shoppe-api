﻿using System;
using System.Collections.Generic;

namespace SistemaVentas.Model;

public partial class Venta
{
    public int IdVenta { get; set; }

    // Buenas

    public string? NumeroDocumento { get; set; }

    public string? TipoPago { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();
}
