using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Modelos
{
  class mdlLiquidacionDetalle
  {
    public int Id { get; set; }
    public DateTime FechaEmision { get; set; }
    public string Beneficiario { get; set; }
    public  string DNI { get; set; }
    public string CBU { get; set; }
    public string  Cuenta { get; set; }
    public decimal Importe { get; set; }

  }
}
