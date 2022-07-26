using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Modelos
{
  public class MdlProveedores
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string RazonSocial { get; set; }
    public string TelefonoFijo { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    public string Domicilio { get; set; }
    public string Localidad { get; set; }
    public DateTime Fecha { get; set; }
    public int Estado { get; set; }
    public string CUIT { get; set; }
    public string Cuenta_Banco { get; set; }
    public string CBU { get; set; }
    public string NomRazSocCUIT { get; set; }
  }
}
