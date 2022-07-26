using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Metodos
{
  public class MtdCreditos
  {
    public static int GetUltimoCredito()
    {
      using (var context = new lts_autogestionDataContext())
      {
        return context.Creditos.Count() == 0 ? 1 : context.Creditos.Max(x=>x.Id) + 1;  
      }
    }

    public static int GetUltimoCreditoId()
    {
      using (var context = new lts_autogestionDataContext())
      {
        return  context.Creditos.Max(x => x.Id) ;
      }
    }

    public static void DescontarMargen(int NroLegajo, decimal Importe)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var margen = (from a in context.empleados where a.EMP_LEGAJO == NroLegajo select a).Single();
        margen.EMP_MARGEN_DISPONIBLE -= Importe;
        context.SubmitChanges();
      }
    }

    public static void AgregarMargen(int NroLegajo, decimal Importe)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var margen = (from a in context.empleados where a.EMP_LEGAJO == NroLegajo select a).Single();
        margen.EMP_MARGEN_DISPONIBLE += Importe;
        context.SubmitChanges();
      }
    }
  }
}
