using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Modelos
{
  class mdlEmpleados
  {
    public int Id { get; set; }
    public int?  Legajo { get; set; }
    public string  ApeNom { get; set; }
    public string Apellido { get; set; }
    public string  Nombre { get; set; }
    public string DNI { get; set; }
    public string CUIT { get; set; }
    public string Telefono { get; set; }
    public string Domicilio { get; set; }
    public DateTime? FechaNac { get; set; }
    public string Email { get; set; }
    public  string Contrato { get; set; }
    public string CBU { get; set; }
    public string Cuenta { get; set; }
    public bool AfectadoAlCovid { get; set; }
    public string  Condicion { get; set; }
    public decimal Margen { get; set; }
    public decimal MargenDisponible { get; set; }

  }
}
