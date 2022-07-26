using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Modelos
{
  internal class MdlCuotasCredito
  {

    public int Id { get; set; }
    public int NroCuota { get; set; }
    public decimal Importe { get; set; }
    public string Preriodo { get; set; }
    public decimal Saldo { get; set; }
  }
}
