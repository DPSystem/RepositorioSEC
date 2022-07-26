using AutoGestion;
using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Metodos
{
  class mtdLiquidacion
  {
    public static List<mdlLiquidacionDetalle> _Liqd = new List<mdlLiquidacionDetalle>();
    
    public static List<mdlLiquidacion> GetLiquidaciones()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var Liquidaciones = from a in context.autogestion_liquidacion
                            select new mdlLiquidacion
                            {
                              Id = Convert.ToInt32(a.ALIQ_ID),
                              FechaEmision = Convert.ToDateTime(a.ALIQ_FECHA_EM),
                              AñoLiquidacion = Convert.ToInt32(a.ALIQ_MES_IMPUTACION),
                              Descripcion = a.ALIQ_DESCRIPCION,
                              MesImputacion = Convert.ToInt32(a.ALIQ_MES_IMPUTACION),
                              Total = Convert.ToDecimal(a.ALIQ_TOTAL),
                              Estado = Convert.ToInt32(a.ALIQ_ESTADO),
                              EstadoString = Convert.ToInt32(a.ALIQ_ESTADO) == 1 ? "Cerrado":"Pendiente"
                            };
        return Liquidaciones.ToList();
      }
    }
    
    public static List<mdlLiquidacionDetalle> GetLiquidacionDetalle(int LiquidacionId)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var Detalle = (from a in context.autogestion_liquidacion_detalle
                      where a.ALIQD_ALIQ_ID == LiquidacionId && a.ALIQD_ESTADO == 0
                      join  emp in context.empleados on a.ALIQD_EMP_ID equals emp.EMP_ID
                      join eb in context.empleados_bancos on emp.EMP_ID equals eb.EMPB_EMP_ID 
                      where eb.EMPB_CUE_LIQ == 1
                      //into CBUS from cb in CBUS.DefaultIfEmpty()
                      select new mdlLiquidacionDetalle
                      {
                        Id = Convert.ToInt32(a.ALIQD_ID),
                        FechaEmision = Convert.ToDateTime(a.ALIQD_FECHA_EM),
                        Beneficiario = emp.EMP_APELLIDO.Trim() + " " + emp.EMP_NOMBRE.Trim(), // mtdEmpleados.GetApeNom(Convert.ToInt32( a.ALIQD_EMP_ID)),
                        DNI = emp.EMP_DNI,
                        CBU = eb.EMPB_CBU,//mtdEmpleados.GetCBU(Convert.ToInt32(a.ALIQD_EMP_ID)),
                        Importe = Convert.ToDecimal(a.ALIQD_IMPORTE),
                        Cuenta = eb.EMPB_CUE_CODIGO
                        //

                      }).OrderBy(x=>x.Beneficiario);
        return Detalle.ToList();
      }
    }
    
    public static int  GetUltimoNroLiquidacion()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var NroLiquidacion = context.autogestion_liquidacion;
        if (NroLiquidacion.Count() == 0)
        {
          return 1;
        }
        else
        {
            return Convert.ToInt32(NroLiquidacion.Max(x => x.ALIQ_ID)) + 1;
        }
      }
    }

    public static bool ControlarDNIRepetidoEnLiqDetalle(int LiqId, int EmpId )
    {
      using (var context = new lts_autogestionDataContext())
      {
        var DNIRepetido = from a in context.autogestion_liquidacion_detalle
                          where a.ALIQD_ALIQ_ID ==LiqId && a.ALIQD_EMP_ID == EmpId
                          select a;
        return DNIRepetido.Count() > 0;
      }
    }
  }
}
