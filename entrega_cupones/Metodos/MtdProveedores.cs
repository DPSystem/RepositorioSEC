using AutoGestion.Modelos;
using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Metodos
{
  public class MtdProveedores
  {
    public static List<MdlProveedores> TodoLosEmpleados = new List<MdlProveedores>();
    public static List<MdlProveedores> GetAllProveedores()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var todos = (from a in context.Proveedores
                     select new MdlProveedores  // where a.EMP_ESTADO == 1
                     {
                       Id = Convert.ToInt32(a.Id),
                       Nombre = a.Nombre,
                       RazonSocial = a.RazonSocial,
                       TelefonoFijo = a.TelefonoFijo,
                       Celular = a.Celular,
                       Email = a.Email,
                       Domicilio = a.Domicilio,
                       CUIT = a.CUIT,
                       CBU = a.CBU, 
                       Cuenta_Banco = a.Cuenta_Banco,
                       //Localidad =
                       Fecha = Convert.ToDateTime(a.Fecha),
                       Estado = Convert.ToInt32(a.Estado),
                       NomRazSocCUIT = a.Nombre + " " + a.RazonSocial + " " + a.CUIT
                     }).OrderBy(x => x.Nombre);
        return todos.ToList();
      }
    }

    public static bool Controlar_CUIT_Repetidos(string CUIT)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var CUITRepetido = from a in context.Proveedores
                          where a.CUIT == CUIT
                          select a;
        return CUITRepetido.Count() > 0;
      }
    }

    public static List<MdlProveedores> GetProveedoresCBX()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var listproveedores = (from a in context.Proveedores
                              select new MdlProveedores
                              {
                                Id = a.Id,
                                Nombre = a.Nombre
                              }).OrderBy(x=>x.Nombre);
        return listproveedores.ToList();
      }
    }
  }
}
