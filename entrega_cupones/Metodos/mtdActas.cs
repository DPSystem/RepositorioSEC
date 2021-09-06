using entrega_cupones.Formularios;
using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrega_cupones.Metodos
{
  class mtdActas
  {
    public static mdlActa ActaReturn = new mdlActa();

    public static int ObtenerNroDeActa()
    {
      using (var context = new lts_sindicatoDataContext())
      {
        return context.Acta.Count() > 0 ? context.Acta.Max(x => x.Numero) + 1 : 1;
      }
    }

    public static void GuardarActaCabecera(List<EstadoDDJJ> ddjjt, DateTime FechaDeConfeccion, DateTime desde, DateTime hasta, DateTime vencimiento, int empresaId, string cuit, int cantidadEmpleados, decimal InteresMensual, decimal InteresDiario, List<mdlCuadroAmortizacion> _PlanDePago)
    {
      using (var context = new lts_sindicatoDataContext())
      {
        int NroDeActa = ObtenerNroDeActa();

        int NroDePlan = mtdCobranzas.AsentarPlan(cuit, NroDeActa, _PlanDePago);

        MessageBox.Show("Se grabo el Plan de Pago con exito");

        Acta acta = new Acta();
        acta.Fecha = FechaDeConfeccion;
        acta.Numero = NroDeActa;
        acta.EmpresaCuit = cuit;
        acta.Desde = desde;
        acta.Hasta = hasta;
        acta.Vencimiento = vencimiento;
        acta.EmpresaId = empresaId;
        acta.Capital = Math.Round(ddjjt.Sum(x => x.Capital), 2);
        acta.EmpresaCuit = cuit;
        acta.Interes = Math.Round(ddjjt.Sum(x => x.Interes), 2);
        acta.Total = Math.Round(ddjjt.Sum(x => x.Total), 2);
        acta.PlanDePago = NroDePlan;
        acta.InspectorId = 0;
        acta.EmpleadosCantidad = cantidadEmpleados;
        acta.InteresMensualAplicado = InteresMensual;
        acta.InteresDiarioAplicado = InteresDiario;

        context.Acta.InsertOnSubmit(acta);
        context.SubmitChanges();

        MessageBox.Show("Se grabo el Acta con exito");
        int actaId = context.Acta.Where(x => x.EmpresaCuit == acta.EmpresaCuit && x.Numero == acta.Numero).SingleOrDefault().Id;

        GuardarActaDetalle(ddjjt, acta.Numero, acta.EmpresaCuit, actaId);
        MessageBox.Show("Se grabo el detalle del Acta con exito");
      }
    }

    public static void GuardarActaDetalle(List<EstadoDDJJ> ddjjt, int actaNumero, string actaCuit, int actaId)
    {
      using (var context = new lts_sindicatoDataContext())
      {
        foreach (var periodo in ddjjt)
        {
          ActasDetalle actadet = new ActasDetalle
          {
            NumeroDeActa = actaNumero,
            ActaId = actaId,
            Periodo = periodo.Periodo,
            CantidadEmpleados = periodo.Empleados,
            CantidadSocios = periodo.Socios,
            TotalSueldoEmpleados = periodo.TotalSueldoEmpleados,
            TotalSueldoSocios = periodo.TotalSueldoSocios,
            TotalAporteEmpleados = periodo.AporteLey,
            TotalAporteSocios = periodo.AporteSocio,
            FechaDePago = Convert.ToDateTime(periodo.FechaDePago),
            ImporteDepositado = periodo.ImporteDepositado,
            DiasDeMora = periodo.DiasDeMora,
            DeudaGenerada = periodo.Capital,
            InteresGenerado = periodo.Interes,
            Total = periodo.Total,
            PerNoDec = periodo.PerNoDec

          };
          context.ActasDetalle.InsertOnSubmit(actadet);
          context.SubmitChanges();
        }
      }
    }

    public static mdlActa GetActa(int NroDeActa)
    {
      using (var context = new lts_sindicatoDataContext())
      {
        var acta = from a in context.Acta.Where(x => x.Numero == NroDeActa)
                   join b in context.maeemp on a.EmpresaCuit equals b.MEEMP_CUIT_STR
                   select new mdlActa
                   {
                     NroActa = a.Numero,
                     Fecha = a.Fecha,
                     Cuit = a.EmpresaCuit,
                     Domicilio = b.MAEEMP_CALLE.Trim() + " " + b.MAEEMP_NRO,
                     Localidad = mtdFuncUtiles.GetLocalidad(Convert.ToInt32(b.MAEEMP_CODLOC)),
                     CodigoPostal = b.MAEEMP_CODPOS,
                     RazonSocial = b.MAEEMP_RAZSOC,
                     Desde = (DateTime)a.Desde,
                     Hasta = (DateTime)a.Hasta,
                     FechaVenc = a.Vencimiento,
                     Importe = a.Total,
                     NroDePlan = a.PlanDePago,
                     CantidadEmpleados = a.EmpleadosCantidad,
                     TelefonoEmpresa = b.MAEEMP_TEL,
                     InteresMensual = a.InteresMensualAplicado,
                     InteresDiario = a.InteresDiarioAplicado,
                     Capital = a.Capital,
                     Interes = a.Interes,
                     Total = a.Total

                   };
        ActaReturn = acta.FirstOrDefault();
        return ActaReturn;
      }
    }

    public static List<mdlDeudaParaRanking> DeudaParaRanking()
    {
      DateTime FechaVacia = Convert.ToDateTime("01/01/0001");
      List<mdlDeudaParaRanking> deudaParaRanking = new List<mdlDeudaParaRanking>();

      using (var context = new lts_sindicatoDataContext())
      {
        foreach (var empresa in context.maeemp)
        {
          mdlDeudaParaRanking dpr = new mdlDeudaParaRanking();
          dpr.Cuit = empresa.MEEMP_CUIT_STR;
          dpr.Empresa = empresa.MAEEMP_RAZSOC.Trim();
          dpr.Deuda = CalcularDeudaRanking(empresa.MEEMP_CUIT_STR);
          if (dpr.Deuda > 0)
          {
            deudaParaRanking.Add(dpr);
          }
        }
      }

      return deudaParaRanking.OrderByDescending(x => x.Deuda).ToList();

    }

    public static decimal CalcularDeudaRanking(string cuit)
    {
      //List<mdlDeudaParaRanking> deudaParaRanking = new List<mdlDeudaParaRanking>();
      using (var context = new lts_sindicatoDataContext())
      {
        var deuda = context.ddjjt.Where(x => x.CUIT_STR == cuit && x.fpago == null).Sum(x => x.titem1 + x.titem2);



        //var ddjj = context.ddjjt.Where(x => x.CUIT_STR == cuit && x.fpago == null).Sum(x=>x.titem1 + x.titem2);


        return Convert.ToDecimal(deuda);
      }
    }

    public static List<mdlActa> Get_ListadoDeActas()
    {
      using (var datacontext = new lts_sindicatoDataContext())
      {
        var actas = (from a in datacontext.Acta
                     where a.Estado == 0 || a.Estado == 2
                     select new mdlActa
                     {
                       NroActa = a.Numero,
                       Fecha = Convert.ToDateTime(a.Fecha),
                       Cuit = a.EmpresaCuit,
                       RazonSocial = mtdEmpresas.GetEmpresaNombre(a.EmpresaCuit),
                       Desde = Convert.ToDateTime(a.Desde),
                       Hasta = Convert.ToDateTime(a.Hasta),
                       Importe = a.Total,
                       NroDePlan = a.PlanDePago

                     }).OrderByDescending(x => x.NroActa);
        if (actas.Count() > 0)
        {
          return actas.ToList();
        }
        else
        {
          return null;
        }
      }
    }

    public static void ReimprimirActa(int NumeroActa)
    {
      mdlActa Acta = GetActa(NumeroActa);

      frm_GenerarActa formActasGenerar = new frm_GenerarActa();

      formActasGenerar.msk_FechaConfeccion.Text = Convert.ToDateTime(Acta.Fecha).ToString("dd/MM/yyyy");
      formActasGenerar.txt_NumeroDeActa.Text = Acta.NroActa.ToString();
      formActasGenerar.txt_CantidadEmpleado.Text = Acta.CantidadEmpleados.ToString();
      formActasGenerar.txt_CodigoPostal.Text = Acta.CodigoPostal;
      formActasGenerar.EsReimpresion = true;
      formActasGenerar.txt_CUIT.Text = Acta.Cuit; //txt_CUIT.Text;
      formActasGenerar.txt_RazonSocial.Text = Acta.RazonSocial;// txt_BuscarEmpesa.Text;
      formActasGenerar.txt_Domicilio.Text = Acta.Domicilio;
      formActasGenerar.txt_Localidad.Text = Acta.Localidad;
      formActasGenerar.msk_Desde.Text = Convert.ToDateTime(Acta.Desde).ToString("MM/yyyy"); //msk_Desde.Text;
      formActasGenerar.msk_Hasta.Text = Convert.ToDateTime(Acta.Hasta).ToString("MM/yyyy");// msk_Hasta.Text;
      formActasGenerar.msk_Vencimiento.Text = Convert.ToDateTime(Acta.FechaVenc).ToString("dd/MM/yyyy");//msk_Vencimiento.Text;
      formActasGenerar.msk_LibroSueldoDesde.Text = Convert.ToDateTime(Acta.Desde).ToString("MM/yyyy");//msk_Desde.Text;
      formActasGenerar.msk_LibroSueldoHasta.Text = Convert.ToDateTime(Acta.Hasta).ToString("MM/yyyy");//msk_Hasta.Text;
      formActasGenerar.msk_ReciboSueldoDesde.Text = Convert.ToDateTime(Acta.Desde).ToString("dd/MM/yyyy"); //msk_Desde.Text;
      formActasGenerar.msk_ReciboSueldoHasta.Text = Convert.ToDateTime(Acta.Hasta).ToString("MM/yyyy"); //msk_Hasta.Text;
      formActasGenerar.msk_BoletaDepositoDesde.Text = Convert.ToDateTime(Acta.Desde).ToString("MM/yyyy"); //msk_Desde.Text;
      formActasGenerar.msk_BoletaDepositoHasta.Text = Convert.ToDateTime(Acta.Hasta).ToString("MM/yyyy");// msk_Hasta.Text;
      formActasGenerar.txt_Total.Text = Acta.Importe.ToString("N2"); //txt_Total.Text;
      formActasGenerar.txt_Interes.Text = Acta.InteresMensual.ToString(); //txt_Interes.Text;
      formActasGenerar.txt_InteresDiario.Text = Acta.InteresDiario.ToString();//txt_InteresDiario.Text;
      formActasGenerar.txt_Cuotas.Text = "";//txt_CantidadDeCuotas.Text;
      formActasGenerar.txt_ImporteDeCuota.Text = "";// txt_ImporteDeCuota.Text;
      formActasGenerar.txt_Telefono.Text = Acta.TelefonoEmpresa;
      formActasGenerar.Show();


      //reportes formReporte = new reportes();

      //formReporte.Parametro1 = Acta.NroActa.ToString();// NumeroDeActa.ToString();
      //formReporte.Parametro2 = Acta.RazonSocial;//.Text.Trim();
      //formReporte.Parametro3 = Acta.Domicilio.ToString();
      //formReporte.Parametro4 = Convert.ToDateTime(Acta.Desde).ToString("MM/yyyy");//desde.ToString("MM/yyyy");
      //formReporte.Parametro5 = Convert.ToDateTime(Acta.Hasta).ToString("MM/yyyy");//hasta.ToString("MM/yyyy");
      //formReporte.Parametro6 = Convert.ToDateTime(Acta.FechaVenc).ToString("dd/MM/yyyy");//Vencimiento.ToString("dd/MM/yyyy");
      //formReporte.Parametro7 = Acta.Cuit; //txt_CUIT.Text;
      //formReporte.Parametro8 = Acta.Importe.ToString("N2");//_PreActa.Sum(x => x.Total).ToString("N2");
      //formReporte.Parametro9 = "";// txt_ActasAnteriores.Text;
      //formReporte.Parametro10 = "";// msk_InicioDeActividad.Text;
      //formReporte.Parametro11 = Acta.CantidadEmpleados.ToString();//txt_CantidadEmpleado.Text;
      //formReporte.Parametro12 = Acta.TelefonoEmpresa;//txt_Telefono.Text;
      //formReporte.Parametro13 = Convert.ToDateTime(Acta.Fecha).ToString("dd/MM/yyyy"); //msk_FechaConfeccion.Text;
      //formReporte.Parametro14 = "Santiago del Estero";//txt_Lugar.Text;
      //formReporte.Parametro15 = Convert.ToDateTime(Acta.Fecha).Day.ToString();// FechaDeConfeccion.Day.ToString();
      //formReporte.Parametro16 = mtdFechas.NombreDelMes(Convert.ToDateTime(Acta.Fecha).Month);//mtdFechas.NombreDelMes(FechaDeConfeccion.Month); //FechaDeConfeccion.Month.ToString("mm");
      //formReporte.Parametro17 = Convert.ToDateTime(Acta.Fecha).Year.ToString();  //FechaDeConfeccion.Year.ToString();
      //formReporte.Parametro18 = ""; //txt_persona.Text;
      //formReporte.Parametro19 = "";// txt_Relacion.Text;
      //formReporte.Parametro20 = mtdNum2words.enletras(Acta.Importe.ToString());
      //formReporte.Parametro21 = "";// txt_Observaciones.Text;

      //formReporte.dt = mtdFilial.Get_DatosFilial();
      //formReporte.NombreDelReporte = "entrega_cupones.Reportes.rpt_ActaCabecera.rdlc";
      //formReporte.Show();

      //ImprimirActaDetalle();
    }

    public static void GetDDJJPorNumeroActa(int NumeroActa)
    {
      using (var context = new lts_sindicatoDataContext())
      {
        List<EstadoDDJJ> estadoDDJJs = new List<EstadoDDJJ>();
        var _ddjj = from a in context.ActasDetalle
                    where a.NumeroDeActa == NumeroActa
                    select new EstadoDDJJ
                    {
                      Periodo = Convert.ToDateTime(a.Periodo),

                      AporteLey = (decimal)a.TotalAporteEmpleados,
                      AporteSocio = (decimal)a.TotalAporteSocios,
                      TotalSueldoEmpleados = (decimal)a.TotalSueldoEmpleados / Convert.ToDecimal(0.02),
                      TotalSueldoSocios = (decimal)a.TotalSueldoSocios / Convert.ToDecimal(0.02),
                      FechaDePago = a.FechaDePago, //  a.FechaDePago == null ? null : Convert.ToDateTime(a.FechaDePago),// a.FechaDePago == null ? null : a.FechaDePago,
                      ImporteDepositado = (decimal)a.ImporteDepositado,
                      Empleados = a.CantidadEmpleados,
                      Socios = a.CantidadSocios,
                      Capital = a.DeudaGenerada,
                      Interes = a.InteresGenerado,
                      DiasDeMora = a.DiasDeMora,
                      Total = a.Total
                    };
        estadoDDJJs.AddRange(_ddjj);
        mdlActa Acta = GetActa(NumeroActa);
        ReimprimirDDJJ(estadoDDJJs, Acta);
      }
    }

    public static void ReimprimirDDJJ(List<EstadoDDJJ> ddjj, mdlActa acta)
    {
      DS_cupones ds = new DS_cupones();
      DataTable dt_ActasDetalle = ds.ActasDetalle;
      dt_ActasDetalle.Clear();

      int color = 0;
      string fecha2 = "";
      foreach (var periodo in ddjj)
      {
        DataRow row = dt_ActasDetalle.NewRow();
        row["NumeroDeActa"] = acta.NroActa;
        row["Periodo"] = periodo.Periodo;
        row["CantidadDeEmpleados"] = periodo.Empleados;
        row["CantidadSocios"] = periodo.Socios;
        row["TotalSueldoEmpleados"] = periodo.TotalSueldoEmpleados;
        row["TotalSueldoSocios"] = periodo.TotalSueldoSocios;
        row["TotalAporteEmpleados"] = periodo.AporteLey;
        row["TotalAporteSocios"] = periodo.AporteSocio;
        fecha2 = periodo.FechaDePago.ToString();
        if (fecha2 != "")
        {
          fecha2 = Convert.ToDateTime(periodo.FechaDePago).Date.ToString("dd/MM/yyyy");
        }
        row["FechaDePago"] = fecha2;//periodo.FechaDePago.ToString();//== null ? "01/01/0001" : periodo.FechaDePago.Value.Date.ToString();
        row["ImporteDepositado"] = periodo.ImporteDepositado;
        row["DiasDeMora"] = periodo.DiasDeMora;
        row["DeudaGenerada"] = periodo.Capital;
        row["InteresGenerado"] = periodo.Interes;
        row["Total"] = periodo.Total;
        row["Color"] = color;
        color = color == 1 ? 0 : 1;
        dt_ActasDetalle.Rows.Add(row);
      }

      Empresa empresa = mtdEmpresas.GetEmpresa(acta.Cuit);

      reportes formReporte = new reportes();
      formReporte.dt = dt_ActasDetalle;
      formReporte.dt2 = mtdFilial.Get_DatosFilial();

      formReporte.Parametro1 = empresa.MAEEMP_RAZSOC.Trim();
      formReporte.Parametro2 = empresa.MEEMP_CUIT_STR;
      formReporte.Parametro3 = mtdFuncUtiles.generar_ceros(acta.NroActa.ToString(), 6);
      formReporte.Parametro4 = acta.Capital.ToString("N2"); // _PreActa.Sum(x => x.Capital).ToString("N2");
      formReporte.Parametro5 = acta.Interes.ToString(); // _PreActa.Sum(x => x.Interes).ToString("N2");
      formReporte.Parametro6 = acta.Total.ToString();// _PreActa.Sum(x => x.Total).ToString("N2");
      formReporte.Parametro7 = "Original";
      formReporte.Parametro8 = " ";
      formReporte.Parametro9 = Convert.ToDateTime(acta.FechaVenc).ToString("dd/MM/yyyy");//msk_Vencimiento.Text;
      formReporte.Parametro10 = acta.Domicilio;// txt_Domicilio.Text + " " + txt_Localidad.Text;
      formReporte.NombreDelReporte = "entrega_cupones.Reportes.rpt_ActaDetalle.rdlc";
      formReporte.Show();
    }

  }
}
