using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Metodos
{
  class MtdGenerarTXTBSE
  {

    public static void crear_txt(int NroLiquidacion)
    {
      // DataTable dt = new DataTable("empleados"); // Obtnener los registros para liquidar, traer por nro_liquidacion

      using (StreamWriter archivoTXT = new StreamWriter("C:\\Autogestion\\LIQUIDACION-BSE\\SUEL1640.txt", false, Encoding.Default))
      { // guardamos el archivo con nro de liquidacion y fecha codificado en ANSI

        //  *** Escribimos la cabeza del Archivo TXT

        archivoTXT.WriteLine(
          cabeza("1640", DateTime.Today.Date, NroLiquidacion.ToString()));

        List<mdlLiquidacionDetalle> Cuerpo = new List<mdlLiquidacionDetalle>();

        Cuerpo.AddRange(mtdLiquidacion.GetLiquidacionDetalle(NroLiquidacion));

        decimal TotalLiquidacion = Math.Round(Cuerpo.Sum(x => x.Importe), 2);

        //  *** Escribimos el cuerpo del Archivo TXT

        foreach (var linea in Cuerpo)
        {
          archivoTXT.WriteLine(
                                datos(
                                      "1640",
                                      DateTime.Today.Date,
                                      linea.Cuenta, //          item["EMPB_CUE_CODIGO"].ToString(),
                                      Math.Round(linea.Importe, 2).ToString(),  //importe.ToString(),
                                      linea.Id.ToString(), //Convert.ToInt32(item["ALIQD_ID"]),
                                      linea.Beneficiario, //(item["emp_apellido"].ToString().Trim() + " " + item["emp_nombre"].ToString().Trim()),
                                      linea.DNI
                               ));// item["EMP_DNI"].ToString()));
        }

        //  *** Escribimos el Pie del Archivo TXT
        archivoTXT.WriteLine(Pie("1640", DateTime.Today.Date, Cuerpo.Count().ToString(), TotalLiquidacion.ToString()));

      };
    }

    public static string cabeza(string cod_empresa, DateTime fecha_acred, string nro_carga)
    {
      string cabeza_codBanco = "321";                                              // 1- valor fijo 321 (Long x 3)
      string cabeza_codEmpresa = generar_ceros(cod_empresa, 3);                    // 2- valor asignado por el banco (Long x 3)
      string cabeza_f_acreditacion = generar_fecha(fecha_acred);                   // 3- Fecha formato AAAAMMDD (Long x 8)
      string cabeza_nro_carga = generar_ceros(nro_carga, 2);            // 4- valor correlativo (Long x 2)
      string cabeza_tipo_reg = "0";                                                  // 5- Valor Fijo 0 cero  (Long x 1)
      string cabeza_nro_aleatorio = "12345678";                                      // 6- Valor Fijo 12345678 (Long x 8)
      string cabeza_ceros = generar_ceros(string.Empty, 15);                       // 7- Valor Fijo 15 ceros (Long x 15)
      string cabeza_espacios = generar_blancos(string.Empty, 80);                  // 8- Valor Fijo 80 espacios en blanco (Long x 80)

      string cabe = cabeza_codBanco.ToString() +
              cabeza_codEmpresa +
              cabeza_f_acreditacion +
              cabeza_nro_carga +
              cabeza_tipo_reg.ToString() +
              cabeza_nro_aleatorio.ToString() +
              cabeza_ceros +
              cabeza_espacios
      ;
      return cabe;
    }

    public static string datos(string cod_empresa, DateTime fecha_acred, string nro_cuenta, string importe, string nro_comprobante, string apenom, string nro_dni)
    {
      

      string cuerpo_codBanco = "321";                                               // 1- valor fijo 321 (Long x 3)
      string cuerpo_codEmpresa = generar_ceros(cod_empresa, 3);                     // 2- valor asignado por el banco (Long x 3)
      string cuerpo_f_acreditacion = generar_fecha(fecha_acred);                    // 3 -Fecha formato AAAAMMDD (Long x 8)
      string cuerpo_nro_carga = generar_ceros("1", 2);                              // 4- valor fijo 01 (Long x 2)
      string cuerpo_tipo_reg = "2";                                                 // 5- valor fijo 1 (Long x 1)
      string cuerpo_sucursal = "00001";                                             // 6- Valor fijo 00001 (Long x 5)
      string cuerpo_nro_cuenta = generar_ceros(nro_cuenta, 10);                     // 7- valor Nro Asignado por el Banco
      string cuerpo_importe = generar_ceros(importe.Remove(importe.LastIndexOf('.'), 1), 11); // 8- valor Nro Asignado por el Banco
      string cuerpo_codigo = "C";                                                   // 9- valor (C) Crédito - (D) Debito   (Long x 1)
      string cuerpo_nro_comprobante = generar_ceros(nro_comprobante.ToString(), 7); // 10- valor Nro de control interno
      string cuerpo_nombre_benef = apenom.Length > 20 ? apenom.Substring(0, 20) : generar_blancos(apenom, 20); // 11- valor Nombre del empleado (Long x 20) // Recorto si el nombre tiene mas de 20 carcateres //Completo con blancos si el nombre tiene menos de 20 carcateres
      string cuerpo_tipo_documento = generar_ceros("1", 3);                         // 12- valor  [005 = CUIT] [008 = CUIL] [009 = CDI] tipo de documento (Long x 3) 
      string cuerpo_nro_documento = generar_ceros(nro_dni, 17);                     // 13- Valor Nro de Documento (Long x 17)
      string cuerpo_prov_documento = "22";                                          // 14- Valor Provincia Documento (Long X 2)
      string cuerpo_codigo_retorno = "99";                                          // 15- Valor fijo 99 (Long X 2)
      string cuerpo_cuenta_corriente = generar_blancos("", 2);                      // 16- valor  en blanco x 2 
      string cuerpo_espacios = generar_ceros("", 23);                               // 17- valor CBU (Long x 22)
      string cuerpo_empresa_empleo = generar_blancos("", 3);                        // 18- valor espacio en blanco

      string linea = cuerpo_codBanco.ToString() +
                  cuerpo_codEmpresa +
                  cuerpo_f_acreditacion +
                  cuerpo_nro_carga +
                  cuerpo_tipo_reg.ToString() +
                  cuerpo_sucursal +
                  cuerpo_nro_cuenta +
                  cuerpo_importe +
                  cuerpo_codigo +
                  cuerpo_nro_comprobante +
                  cuerpo_nombre_benef +
                  cuerpo_tipo_documento +
                  cuerpo_nro_documento +
                  cuerpo_prov_documento +
                  cuerpo_codigo_retorno.ToString() +
                  cuerpo_cuenta_corriente +
                  cuerpo_espacios +
                  cuerpo_empresa_empleo;
      return linea;
    }

    public static string Pie(string cod_empresa, DateTime fecha_acred, string cantidad_registros, string total_importes)
    {
      string pie_codBanco = "321";                                                 // 1- valor fijo 321 (Long x 3)
      string pie_codEmpresa = generar_ceros(cod_empresa, 3);                       // 2- valor asignado por el banco (Long x 3)
      string pie_f_acreditacion = generar_fecha(fecha_acred);                      // 3- Fecha formato AAAAMMDD (Long x 8)
      string pie_nro_carga = generar_ceros("1", 2);                                // 4- valor fijo 01 (Long x 2)
      string pie_tipo_reg = "8";                                                   // 5- valor fijo 8 (Long x 1)
      string pie_total_mov = generar_ceros(cantidad_registros, 8);                 // 6- valor Cantidad de registros de datos (Long x 8)
      string pie_total_importe = generar_ceros(total_importes.Remove(total_importes.LastIndexOf('.'), 1), 15); // 7- Valor Sumatoria de importe de Datos (Long x 8)
      string pie_espacios = generar_blancos("", 80);  
      // 8- Valor Fijo 80 espacios en blanco (Long x 80)
      string pie_ =
          pie_codBanco.ToString() +
          pie_codEmpresa +
          pie_f_acreditacion +
          pie_nro_carga +
          pie_tipo_reg +
          pie_total_mov +
          pie_total_importe +
          pie_espacios;
      return pie_;
    }

    public static string generar_ceros(string valor, int tamaño)
    {
      string ceros = null;
      for (int i = 0; i < tamaño - valor.Length; i++)
      {
        ceros += "0";
      }
      valor = ceros + valor;
      return valor;
    }

    public static string generar_blancos(string valor, int tamaño)
    {
      string blancos = null;
      for (int i = 0; i < tamaño - valor.Length; i++)
      {
        blancos += " ";
      }
      valor = valor + blancos;
      return valor;
    }

    public static string generar_fecha(DateTime fecha_acreditacion)
    {
      string fechaAc = string.Empty;
      fechaAc = fecha_acreditacion.Year.ToString() + generar_ceros(fecha_acreditacion.Month.ToString(), 2) + generar_ceros(fecha_acreditacion.Day.ToString(), 2);
      return fechaAc;
    }
  }
}
