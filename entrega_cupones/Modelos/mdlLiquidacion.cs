using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Modelos
{
  class mdlLiquidacion
  {
    public int Id { get; set; }
    public DateTime FechaEmision { get; set; }
    public int AñoLiquidacion { get; set; }
    public string Descripcion { get; set; }
    public int MesImputacion { get; set; }
    public decimal Total { get; set; }
    public int Estado { get; set; }
    public string EstadoString { get; set; }

  }
}
