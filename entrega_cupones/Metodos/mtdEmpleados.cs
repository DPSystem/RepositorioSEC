using AutoGestion;
using entrega_cupones.Modelos;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Metodos
{
  class mtdEmpleados
  {
    public static mdlEmpleados TodoLosEmpleados = new mdlEmpleados();

    public static List<mdlDDJJEmpleado> _ListadoAporteEmpleados = new List<mdlDDJJEmpleado>();
    public static List<mdlDDJJEmpleado> ListadoEmpleadoAporte(string cuit, DateTime periodo, int rectificacion)
    {
      _ListadoAporteEmpleados.Clear();
      using (var context = new lts_sindicatoDataContext())
      {
        var ListadoAportes = (from a in context.ddjj.Where(x => x.CUIT_STR == cuit && x.periodo == periodo && x.rect == rectificacion)
                              join b in context.maesoc on a.CUIL_STR equals b.MAESOC_CUIL_STR //.MAESOC_CUIL
                              //join c in context.EscalaSalarial on b.MAESOC_CODCAT equals c.CodCategoria
                              //join d in context.categorias_empleado on c.CodCategoria equals d.MAECAT_CODCAT
                              join d in context.categorias_empleado on b.MAESOC_CODCAT equals d.MAECAT_CODCAT
                              //where c.Periodo == a.periodo
                              join e in context.socemp on b.MAESOC_CUIL equals e.SOCEMP_CUIL
                              where e.SOCEMP_ULT_EMPRESA == 'S' && e.SOCEMP_CUITE_STR == a.CUIT_STR

                              select new mdlDDJJEmpleado
                              {
                                Periodo = Convert.ToDateTime(a.periodo),
                                Apellido = b.MAESOC_APELLIDO.Trim(),
                                Nombre = b.MAESOC_APELLIDO.Trim() + " " + b.MAESOC_NOMBRE.Trim(),
                                Dni = b.MAESOC_NRODOC.ToString(),
                                Sueldo = (decimal)(a.impo + a.impoaux),
                                AporteLey = (decimal)((a.impo + a.impoaux) * 0.02),
                                AporteSocio = (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0),
                                Jornada = a.jorp == true ? "Parcial" : "Completa",
                                //Escala = a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe,
                                //BasicoJubPres = mtdSueldos.GetBasicoJubPres(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, 0, 0), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)(a.impo + a.impoaux)),
                                Categoria = d.MAECAT_NOMCAT,
                                FechaIngreso = e.SOCEMP_FECHAING,
                                Antiguedad = DateTime.Now.Year - e.SOCEMP_FECHAING.Year,
                                Diferencia = 0,//CalcularDiferencia((decimal)(a.impo + a.impoaux), (decimal)c.Importe, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),

                                //Acuerdos

                                //AcuerdoNR1 = a.jorp == true ? (decimal)c.AcuerdoNR1 / 2 : (decimal)c.AcuerdoNR1,
                                //AcuerdoNR2 = a.jorp == true ? (decimal)c.AcuerdoNR2 / 2 : (decimal)c.AcuerdoNR2,

                                //Haberes
                                //AntiguedadImporte = a.jorp == true ? mtdSueldos.GetAntiguedad((decimal)c.Importe / 2, DateTime.Now.Year - e.SOCEMP_FECHAING.Year) : mtdSueldos.GetAntiguedad((decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year),
                                //Presentismo = a.jorp == true ? mtdSueldos.GetPresentismo((decimal)c.Importe / 2, DateTime.Now.Year - e.SOCEMP_FECHAING.Year) : mtdSueldos.GetPresentismo((decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year),

                                //TotalHaberes = mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, 0, 0),
                                //TotalHaberes2 = mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year) + (decimal) (c.AcuerdoNR1 + c.AcuerdoNR2),

                                //Descuentos
                                //Jubilacion = mtdSueldos.DescuentoJubilacion(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, 0, 0)),
                                //ObraSocial = mtdSueldos.DescuentoObraSocial(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
                                //Ley19302 = mtdSueldos.DescuentoLey19302(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, 0, 0)),
                                //AporteLeyDif = mtdSueldos.DescuentoAporteLey(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
                                //AporteSocioDif = mtdSueldos.DescuentoAporteSocio(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
                                //AporteSocioEscala = mtdSueldos.DescuentoAporteSocioEscala(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
                                //SueldoDif = mtdSueldos.GetSueldoDif(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)(a.impo + a.impoaux)),
                                //FAECys = mtdSueldos.DescuentoFAECyS(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
                                //OSECAC = mtdSueldos.DescuentoOSECAC(),

                                //TotalDescuentos = mtdSueldos.GetTotalDescuentos(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp)

                              }).OrderBy(x => x.Nombre);

        _ListadoAporteEmpleados.AddRange(ListadoAportes);


        // ****** esta comentado por los campos AR
        //foreach (var item in _ListadoAporteEmpleados)
        //{
        //  if (item.Periodo.Date == Convert.ToDateTime("01/04/2021"))
        //  {
        //    int s = 0;
        //  }
        //  decimal Basico = 0;
        //  int AntiguedadAños = DateTime.Now.Year - item.FechaIngreso.Year;

        //  //Basico = mtdSueldos.GetTotalHaberes(item.Jornada == "Parcial" ? (decimal)item.Escala / 2 : (decimal)item.Escala, item.Antiguedad, 0, 0);
        //  Basico = mtdSueldos.GetTotalHaberes(item.Escala, item.Antiguedad, 0, 0);
        //  item.Jubilacion = mtdSueldos.DescuentoJubilacion(Basico);
        //  item.Ley19302 = mtdSueldos.DescuentoLey19302(Basico);
        //  item.AntiguedadImporte = mtdSueldos.GetAntiguedad(item.Escala, AntiguedadAños);
        //  item.Presentismo = mtdSueldos.GetPresentismo(item.Escala, AntiguedadAños);
        //  item.ObraSocial = mtdSueldos.DescuentoObraSocial(Basico, item.AcuerdoNR1, item.AcuerdoNR2, item.Jornada == "Parcial");
        //  item.AporteLey = mtdSueldos.DescuentoAporteLey(Basico, item.AcuerdoNR1, item.AcuerdoNR2);
        //  item.AporteSocio = mtdSueldos.DescuentoAporteSocio(Basico, item.AporteSocio == 0 ? false : true, item.AporteSocio, item.Jornada == "S" ? true : false) ;
        //  item.FAECys = mtdSueldos.DescuentoFAECyS(Basico,item.AcuerdoNR1,item.AcuerdoNR2);
        //  item.OSECAC = mtdSueldos.DescuentoOSECAC();
        //  item.TotalHaberes = Basico +   item.AcuerdoNR1 + item.AcuerdoNR2;
        //  item.TotalDescuentos = item.Jubilacion + item.Ley19302 + item.ObraSocial + item.AporteLey + item.AporteSocio + item.FAECys + item.OSECAC;

        //  //item.ObraSocial = mtdSueldos.DescuentoObraSocial(TotalHaberes, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
        //  //                      Ley19302 = mtdSueldos.DescuentoLey19302(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, 0, 0)),
        //  //                      AporteLeyDif = mtdSueldos.DescuentoAporteLey(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
        //  //                      AporteSocioDif = mtdSueldos.DescuentoAporteSocio(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
        //  //                      AporteSocioEscala = mtdSueldos.DescuentoAporteSocioEscala(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
        //  //                      SueldoDif = mtdSueldos.GetSueldoDif(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)(a.impo + a.impoaux)),
        //  //                      FAECys = mtdSueldos.DescuentoFAECyS(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)c.AcuerdoNR1, (decimal)c.AcuerdoNR2)),
        //  //                      OSECAC = mtdSueldos.DescuentoOSECAC(),
        //}
        return _ListadoAporteEmpleados;
      }
    }

    public static decimal CalcularDiferencia(decimal Sueldo, decimal Escala, decimal AporteSocio, bool Jornada)
    {
      decimal Diferencia = 0;

      if (Jornada == true && AporteSocio > 0) // Parcial
      {
        Diferencia = Escala * (decimal)0.02;
        if (AporteSocio < Diferencia)
        {
          Diferencia -= AporteSocio;
        }
      }
      return Diferencia;
    }

    public static List<mdlEmpleados> GetTodosLosEmpleados()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var todos = (from a in context.empleados
                     select new mdlEmpleados  // where a.EMP_ESTADO == 1
                     {
                       Id = Convert.ToInt32(a.EMP_ID),
                       Legajo = Convert.ToInt32(a.EMP_LEGAJO),
                       ApeNom = a.EMP_APELLIDO.Trim() + " " + a.EMP_NOMBRE.Trim(),
                       Apellido = a.EMP_APELLIDO,
                       Nombre = a.EMP_NOMBRE,
                       DNI = a.EMP_DNI,
                       CUIT = a.EMP_CUIT,
                       Telefono = a.EMP_TEL,
                       Email = a.EMP_MAIL,
                       Domicilio = a.EMP_DIRECCION,
                       FechaNac = Convert.ToDateTime(a.EMP_FECHA_NACIMIENTO),
                       Margen = a.EMP_MARGEN == null ? 0 : Convert.ToDecimal(a.EMP_MARGEN),
                       MargenDisponible = Convert.ToDecimal(a.EMP_MARGEN_DISPONIBLE)
                     }).OrderBy(x => x.ApeNom);
        return todos.ToList();

      }
    }

    public static List<mdlEmpleados> GetEmpladosPorDNI(string DNI)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var PorDNI = (from a in context.empleados.Where(x => x.EMP_DNI.Contains(DNI))
                      select new mdlEmpleados
                      {
                        Id = Convert.ToInt32(a.EMP_ID),
                        Legajo = Convert.ToInt32(a.EMP_LEGAJO),
                        ApeNom = a.EMP_APELLIDO.Trim() + " " + a.EMP_NOMBRE.Trim(),
                        Apellido = a.EMP_APELLIDO,
                        Nombre = a.EMP_NOMBRE,
                        DNI = a.EMP_DNI,
                        CUIT = a.EMP_CUIT,
                        Telefono = a.EMP_TEL,
                        Email = a.EMP_MAIL,
                        Domicilio = a.EMP_DIRECCION,
                        FechaNac = Convert.ToDateTime(a.EMP_FECHA_NACIMIENTO),
                        Margen = a.EMP_MARGEN == null ? 0 : Convert.ToDecimal(a.EMP_MARGEN)

                      }).OrderBy(x => x.ApeNom);
        return PorDNI.ToList();
      }
    }

    public static List<mdlEmpleados> GetEmpladosPorApeNom(string ApeNom)
    {
      using (var context = new lts_autogestionDataContext())
      {

        var PorApeNom = (from a in context.empleados.Where(x => x.EMP_APENOM.Contains(ApeNom))
                           //join bancos in context.empleados_bancos.Where(x => x.EMPB_CUE_LIQ == 1) on a.EMP_ID equals bancos.EMPB_EMP_ID
                           //into eb
                           //from final in eb.DefaultIfEmpty()
                         select new mdlEmpleados
                         {
                           Id = Convert.ToInt32(a.EMP_ID),
                           Legajo = Convert.ToInt32(a.EMP_LEGAJO),
                           ApeNom = a.EMP_APELLIDO.Trim() + " " + a.EMP_NOMBRE.Trim(),
                           Apellido = a.EMP_APELLIDO,
                           Nombre = a.EMP_NOMBRE,
                           DNI = a.EMP_DNI,
                           CUIT = a.EMP_CUIT,
                           Telefono = a.EMP_TEL,
                           Email = a.EMP_MAIL,
                           Domicilio = a.EMP_DIRECCION,
                           FechaNac = Convert.ToDateTime(a.EMP_FECHA_NACIMIENTO),
                           Margen = a.EMP_MARGEN == null ? 0 : Convert.ToDecimal(a.EMP_MARGEN)
                           //CBU = final.EMPB_CBU,//GetCBU(Convert.ToInt32(a.EMP_ID)),
                           //Cuenta = final.EMPB_CUE_CODIGO,//GetNroCuenta(Convert.ToInt32(a.EMP_ID)),
                           //Condicion = "",
                         }).OrderBy(x => x.ApeNom);
        return PorApeNom.ToList();
      }
    }

    public static string GetCBU(int EmpleadoId)
    {
      using (var context = new lts_autogestionDataContext())
      {
        string CBU = "";
        var getCBU = from a in context.empleados_bancos
                     where Convert.ToInt32(a.EMPB_EMP_ID) == EmpleadoId && a.EMPB_CUE_LIQ == 1
                     select a;
        if (getCBU.Count() > 0)
        {
          CBU = getCBU.SingleOrDefault().EMPB_CBU;
        }
        return CBU;
      }
    }

    public static string GetNroCuenta(int EmpleadoId)
    {
      using (var context = new lts_autogestionDataContext())
      {
        string CBU = "";
        var getCBU = from a in context.empleados_bancos
                     where Convert.ToInt32(a.EMPB_EMP_ID) == EmpleadoId && a.EMPB_CUE_LIQ == 1
                     select a;
        if (getCBU.Count() > 0)
        {
          CBU = getCBU.SingleOrDefault().EMPB_CUE_CODIGO;
        }
        return CBU;
      }
    }

    public static string GetApeNom(int EmpleadoId)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var ApeNom = (from a in context.empleados
                      where a.EMP_ID == EmpleadoId
                      select new
                      {
                        Apenom = a.EMP_APELLIDO.Trim() + " " + a.EMP_NOMBRE.Trim()
                      }).FirstOrDefault().Apenom;
        return ApeNom;
      }
    }

    public static bool ControlarDNIRepetidoEnEmpleados(string DNI)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var DNIRepetido = from a in context.empleados
                          where a.EMP_DNI == DNI
                          select a;
        return DNIRepetido.Count() > 0;
      }
    }
    public static bool ControlarLegajoRepetidoEnEmpleados(string Legajo)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var DNIRepetido = from a in context.empleados
                          where a.EMP_DNI == Legajo
                          select a;
        return DNIRepetido.Count() > 0;
      }
    }
    public static bool ControlarCBURepetido(string CBU)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var CBURepetido = from a in context.empleados_bancos
                          where a.EMPB_CBU == CBU
                          select a;
        return CBURepetido.Count() > 0;
      }
    }
  }
}

