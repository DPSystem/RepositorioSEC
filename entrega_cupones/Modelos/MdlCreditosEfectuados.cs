using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Modelos
{
  class MdlCreditosEfectuados
  {

    public int Id { get; set; }
    public string Comercio { get; set; }
    public int Credito { get; set; }
    public int NroCuota { get; set; }
    public DateTime Periodo { get; set; }
    public decimal Importe { get; set; }
    public bool? PagoParcial { get; set; }
    public decimal Pago { get; set; }
    public string  PagoParcialString { get; set; }
    public decimal Saldo { get; set; }

  }
}
