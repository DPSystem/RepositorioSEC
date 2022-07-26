using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_cupones.Modelos
{
  class MdlBseTxtFile
  {
    // propiedades de la clase 
    public int cabeza_codBanco { get; set; }
    public string cabeza_codEmpresa { get; set; }
    public string cabeza_f_acreditacion { get; set; }
    public string cabeza_nro_carga { get; set; }
    public int cabeza_tipo_reg { get; set; }
    public int cabeza_nro_aleatorio { get; set; }
    public string cabeza_ceros { get; set; }
    public string cabeza_espacios { get; set; }


    //variables para el cuerpo de del archivo (DATOS)
    public int datos_codBanco { get; set; }
    public string datos_codEmpresa { get; set; }
    public string datos_f_acreditacion { get; set; }
    public string datos_nro_carga { get; set; }
    public int datos_tipo_reg { get; set; }
    public string datos_sucursal { get; set; }
    public string datos_nro_cuenta { get; set; }
    public string datos_importe { get; set; }
    public string datos_codigo { get; set; }
    public string datos_nro_comprobante { get; set; }
    public string datos_nombre_benef { get; set; }
    public string datos_tipo_documento { get; set; }
    public string datos_nro_documento { get; set; }
    public string datos_prov_documento { get; set; }
    public int datos_codigo_retorno { get; set; }
    public string datos_cuenta_corriente { get; set; }
    public string datos_espacios { get; set; }
    public string datos_empresa_empleo { get; set; }

    // Variables para el (PIE) del Archivo
    public int pie_codBanco { get; set; }
    public string pie_codEmpresa { get; set; }
    public string pie_f_acreditacion { get; set; }
    public string pie_nro_carga { get; set; }
    public int pie_tipo_reg { get; set; }
    public string pie_total_mov { get; set; }
    public string pie_total_importe { get; set; }
    public string pie_espacios { get; set; }

  }
}
