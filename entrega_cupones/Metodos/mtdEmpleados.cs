﻿using entrega_cupones.Modelos;
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
    public static List<EmpleadoAportePorPeriodo> _ListadoAporteEmpleados = new List<EmpleadoAportePorPeriodo>();

    public static List<EmpleadoAportePorPeriodo> ListadoEmpleadoAporte(string cuit, DateTime periodo, int rectificacion)
    {
      _ListadoAporteEmpleados.Clear();
      using (var context = new lts_sindicatoDataContext())
      {
        var ddjj1 = context.ddjj.Where(x => x.CUIT_STR == cuit && x.periodo == periodo && x.rect == rectificacion);

        var ListadoAportes = (from a in context.ddjj.Where(x => x.CUIT_STR == cuit && x.periodo == periodo && x.rect == rectificacion)
                              join b in context.maesoc on a.CUIL_STR equals b.MAESOC_CUIL_STR //.MAESOC_CUIL
                              join c in context.EscalaSalarial on b.MAESOC_CODCAT equals c.CodCategoria
                              join d in context.categorias_empleado on c.CodCategoria equals d.MAECAT_CODCAT
                              where c.Periodo == a.periodo
                              join e in context.socemp on b.MAESOC_CUIL equals e.SOCEMP_CUIL
                              where e.SOCEMP_ULT_EMPRESA == 'S' && e.SOCEMP_CUITE_STR == a.CUIT_STR

                              select new EmpleadoAportePorPeriodo
                              {
                                Periodo = Convert.ToDateTime(a.periodo),
                                Apellido = b.MAESOC_APELLIDO.Trim(),
                                Nombre = b.MAESOC_APELLIDO.Trim() + " " + b.MAESOC_NOMBRE.Trim(),
                                Dni = b.MAESOC_NRODOC.ToString(),
                                Sueldo = (decimal)(a.impo + a.impoaux),
                                AporteLey = (decimal)((a.impo + a.impoaux) * 0.02),
                                AporteSocio = (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0),
                                Jornada = a.jorp == true ? "Parcial" : "Completa",
                                Escala = a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe,
                                BasicoJubPres = mtdSueldos.GetBasicoJubPres(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)(a.impo + a.impoaux)),
                                Categoria = d.MAECAT_NOMCAT,
                                FechaIngreso = e.SOCEMP_FECHAING,
                                Antiguedad = DateTime.Now.Year - e.SOCEMP_FECHAING.Year,
                                Diferencia = CalcularDiferencia((decimal)(a.impo + a.impoaux), (decimal)c.Importe, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
                                //Haberes
                                AntiguedadImporte = a.jorp == true ? mtdSueldos.GetAntiguedad((decimal)c.Importe / 2, DateTime.Now.Year - e.SOCEMP_FECHAING.Year) : mtdSueldos.GetAntiguedad((decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year),
                                Presentismo = a.jorp == true ? mtdSueldos.GetPresentismo((decimal)c.Importe / 2, DateTime.Now.Year - e.SOCEMP_FECHAING.Year) : mtdSueldos.GetPresentismo((decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year),

                                TotalHaberes = mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year),
                                //Descuentos
                                Jubilacion = mtdSueldos.DescuentoJubilacion(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year)),//(decimal)c.Importe / 2) : mtdSueldos.DescuentoJubilacion((decimal)c.Importe),
                                ObraSocial = mtdSueldos.DescuentoObraSocial(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year)),//(decimal)c.Importe / 2) : mtdSueldos.DescuentoObraSocial((decimal)c.Importe),
                                Ley19302 = mtdSueldos.DescuentoLey19302(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year)),//(decimal)c.Importe / 2) : mtdSueldos.DescuentoLey19302((decimal)c.Importe),
                                AporteLeyDif = mtdSueldos.DescuentoAporteLey(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year)),//(decimal)c.Importe / 2) : mtdSueldos.DescuentoAporteLey((decimal)c.Importe),
                                AporteSocioDif = mtdSueldos.DescuentoAporteSocio(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp), //CalcularDiferencia((decimal)(a.impo + a.impoaux), (decimal)c.Importe, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),// mtdSueldos.DescuentoAporteSocio((decimal)c.Importe, a.jorp),
                                AporteSocioEscala = mtdSueldos.DescuentoAporteSocioEscala(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp),
                                SueldoDif = mtdSueldos.GetSueldoDif(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp, DateTime.Now.Year - e.SOCEMP_FECHAING.Year, (decimal)(a.impo + a.impoaux)),
                                FAECys = mtdSueldos.DescuentoFAECyS(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year)),//(decimal)c.Importe / 2) : mtdSueldos.DescuentoFAECyS((decimal)c.Importe),
                                OSECAC = mtdSueldos.DescuentoOSECAC(),

                                TotalDescuentos = mtdSueldos.GetTotalDescuentos(mtdSueldos.GetTotalHaberes(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, DateTime.Now.Year - e.SOCEMP_FECHAING.Year), a.item2, (decimal)((a.item2 == true) ? (a.impo + a.impoaux) * 0.02 : 0), a.jorp) //(a.jorp == true ? (decimal)c.Importe / 2 : (decimal)c.Importe, a.item2),

                              }).OrderBy(x => x.Nombre);
        _ListadoAporteEmpleados.AddRange(ListadoAportes);
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
  }
}
