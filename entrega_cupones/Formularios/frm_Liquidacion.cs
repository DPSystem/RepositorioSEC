using entrega_cupones.Metodos;
using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoGestion;

namespace entrega_cupones.Formularios
{
  public partial class frm_Liquidacion : Form
  {
    List<mdlLiquidacionDetalle> _LiquidacionDetalle = new List<mdlLiquidacionDetalle>();
    List<mdlEmpleados> _Empleados = new List<mdlEmpleados>();

    public frm_Liquidacion()
    {
      InitializeComponent();
    }

    private void frm_Liquidacion_Load(object sender, EventArgs e)
    {
      dgv_Liquidaciones.AutoGenerateColumns = false;

      dgv_Liquidaciones.DataSource = mtdLiquidacion.GetLiquidaciones();

      dgv_LiquidacionDetalle.AutoGenerateColumns = false;

      dgv_BuscarBenef.AutoGenerateColumns = false;

      _Empleados.AddRange(mtdEmpleados.GetTodosLosEmpleados());

      cbx_BuscarPor.SelectedIndex = 0;

      txt_TotalLiq.ReadOnly = true;

    }

    private void dgv_Liquidaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgv_Liquidaciones_SelectionChanged(object sender, EventArgs e)
    {
      cargar_dgv_LiquidacionDetalle();
      lbl_DetalleDeLiq.Text = "Detalle de Liquidacion N°:  " + dgv_Liquidaciones.CurrentRow.Cells["Id"].Value.ToString();
      pnl_AddBenefALiquidacion.Enabled = dgv_Liquidaciones.CurrentRow.Cells["EstadoString"].Value.ToString() == "Cerrado" ? false : true;
      pnl_ModificarEliminarDetalle.Enabled = dgv_Liquidaciones.CurrentRow.Cells["EstadoString"].Value.ToString() == "Cerrado" ? false : true;
    }

    private void cargar_dgv_LiquidacionDetalle()
    {
      dgv_LiquidacionDetalle.DataSource = mtdLiquidacion.GetLiquidacionDetalle(Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value));
      if (dgv_LiquidacionDetalle.Rows.Count > 0)
      {
        decimal total = dgv_LiquidacionDetalle.Rows.Cast<DataGridViewRow>()
                .Sum(x => (decimal?)x.Cells["Importe"].Value ?? 0);
        txt_TotalLiq.Text = total.ToString("N2");
      }
      else
      {
        txt_TotalLiq.Text = "0.00";
      }
    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {

    }

    private void btn_CrearLiquidacion_Click(object sender, EventArgs e)
    {
      using (var context = new lts_autogestionDataContext())
      {
        autogestion_liquidacion al = new autogestion_liquidacion();
        al.ALIQ_FECHA_EM = DateTime.Now;
        al.ALIQ_ANIO_IMPUTACION = DateTime.Now.Year;
        al.ALIQ_MES_IMPUTACION = Convert.ToByte(DateTime.Now.Month);
        al.ALIQ_TOTAL = 0;
        al.ALIQ_ESTADO = 0;
        al.ALIQ_USR_ID = 0;
        al.ALIQ_EMPR_ID = 1;
        al.ALIQ_DESCRIPCION = txt_ReseñaLiquidacion.Text;
        context.autogestion_liquidacion.InsertOnSubmit(al);
        context.SubmitChanges();
      }

      cargar_dgv_LiquidacionDetalle();

    }

    private void btn_Nuevo_Click(object sender, EventArgs e)
    {

      pnl_CrearLiquidacion.Enabled = true;

      txt_NroLiquidacion.Text = mtdLiquidacion.GetUltimoNroLiquidacion().ToString();
    }

    private void btn_Salir_Click(object sender, EventArgs e)
    {

      frm_Principal2 padre = (frm_Principal2)this.MdiParent;
      padre.menuStrip1.Enabled = true;
      Close();
    }

    private void txt_DatoABuscar_TextChanged(object sender, EventArgs e)
    {
      dgv_BuscarBenef.DataSource = cbx_BuscarPor.SelectedIndex == 0 ? mtdEmpleados.GetEmpladosPorDNI(txt_DatoABuscar.Text) : mtdEmpleados.GetEmpladosPorApeNom(txt_DatoABuscar.Text);

    }

    private void btn_Agregar_Click(object sender, EventArgs e)
    {
      if (dgv_BuscarBenef.CurrentRow.Cells["CBU"].Value != null)
      {
        if (txt_Importe.Text != "")
        {
          // Si repite DNI Informo sino Agrego a Liquidacion
          if (mtdLiquidacion.ControlarDNIRepetidoEnLiqDetalle(
            Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value),
            Convert.ToInt32(dgv_BuscarBenef.CurrentRow.Cells["IdBenef"].Value)))
          {
            //Pregunto si a pesar de que se repite desea liquidar igualmente
            if (MessageBox.Show("Esta Seguro de Liquidar a Pesar de que se repite el Beneficiario ? ", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              AgregarBenefALiquidacion();
            }
          }
          else
          {
            AgregarBenefALiquidacion();
          }
        }
        else
        {
          MessageBox.Show("Debe Ingresar un importe Valido.  Verifique !!! ", "¡¡¡ ATENCION !!!");
          txt_Importe.Focus();
        }
      }
      else
      {
        MessageBox.Show("El Empleado no tiene cargado un CBU  Verifique !!! ", "¡¡¡ ATENCION !!!");
      }
    }

    private void AgregarBenefALiquidacion()
    {
      using (var context = new lts_autogestionDataContext())
      {
        autogestion_liquidacion_detalle ALD = new autogestion_liquidacion_detalle();

        ALD.ALIQD_ALIQ_ID = Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value);
        ALD.ALIQD_EMP_ID = Convert.ToInt32(dgv_BuscarBenef.CurrentRow.Cells["IdBenef"].Value);
        ALD.ALIQD_FECHA_EM = DateTime.Now;
        ALD.ALIQD_MES_IMPUTACION = Convert.ToByte(DateTime.Now.Date.Month);
        ALD.ALIQD_IMPORTE = Convert.ToDecimal(txt_Importe.Text);
        ALD.ALIQD_ESTADO = 0;
        context.autogestion_liquidacion_detalle.InsertOnSubmit(ALD);
        context.SubmitChanges();
        cargar_dgv_LiquidacionDetalle();
      }
    }

    private void cbx_BuscarPor_SelectedIndexChanged(object sender, EventArgs e)
    {
      lbl_DatoABuscar.Text = cbx_BuscarPor.SelectedIndex == 0 ? "D.N.I.:" : "Apellido:";
    }

    private void chk_ModifcarImporteLiqDetalle_CheckedChanged(object sender, EventArgs e)
    {
      if (chk_ModifcarImporteLiqDetalle.Checked)
      {
        txt_ModificarImporteLiqDetalle.Enabled = true;
        btn_AceptarModifImporteLiqDetalle.Enabled = true;
      }
      else
      {
        txt_ModificarImporteLiqDetalle.Enabled = false;
        btn_AceptarModifImporteLiqDetalle.Enabled = false;
      }
    }

    private void dgv_LiquidacionDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgv_LiquidacionDetalle_SelectionChanged(object sender, EventArgs e)
    {
      decimal importe = Convert.ToDecimal(dgv_LiquidacionDetalle.CurrentRow.Cells["Importe"].Value);
      txt_ModificarImporteLiqDetalle.Text = importe.ToString("N2");
    }

    private void btn_AceptarModifImporteLiqDetalle_Click(object sender, EventArgs e)
    {
      using (var context = new lts_autogestionDataContext())
      {
        var c = from a in context.autogestion_liquidacion_detalle where a.ALIQD_ID == Convert.ToInt32(dgv_LiquidacionDetalle.CurrentRow.Cells["Id2"].Value) select a;
        decimal t = Convert.ToDecimal(txt_ModificarImporteLiqDetalle.Text);
        c.Single().ALIQD_IMPORTE = t;
        context.SubmitChanges();

        cargar_dgv_LiquidacionDetalle();
        chk_ModifcarImporteLiqDetalle.Checked = false;
        txt_ModificarImporteLiqDetalle.Enabled = false;
        btn_AceptarModifImporteLiqDetalle.Enabled = false;
      }
    }

    private void btn_EliminarDetalle_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta Seguro de Eliminar el Detalle de la liquidacion ? ", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        using (var context = new lts_autogestionDataContext())
        {
          var Eliminar = from a in context.autogestion_liquidacion_detalle where a.ALIQD_ID == Convert.ToInt32(dgv_LiquidacionDetalle.CurrentRow.Cells["Id2"].Value) select a;
          Eliminar.Single().ALIQD_ESTADO = 1;
          context.SubmitChanges();
          cargar_dgv_LiquidacionDetalle();
        }
      }

    }

    private void btn_CancelarLiq_Click(object sender, EventArgs e)
    {
      txt_ReseñaLiquidacion.Text = "";
      pnl_CrearLiquidacion.Enabled = false;
    }

    private void lbl_DatoABuscar_Click(object sender, EventArgs e)
    {

    }

    private void btn_GenerarTXT_Click(object sender, EventArgs e)
    {
      if (dgv_Liquidaciones.CurrentRow.Cells["EstadoString"].Value.ToString() == "Cerrado")
      {
        if (MessageBox.Show("La liquidacion esta cerrada. Esta Seguro de Generar el Archivo  ? ", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          MtdGenerarTXTBSE.crear_txt(Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value.ToString()));
          MessageBox.Show("Archivo TXT Generado Correctamente ? ", "¡¡¡ ATENCION !!!");
        }
      }
      else
      {
        MtdGenerarTXTBSE.crear_txt(Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value.ToString()));
        MessageBox.Show("Archivo TXT Generado Correctamente ? ", "¡¡¡ ATENCION !!!");
      }

    }

    private void txt_ReseñaLiquidacion_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_CerrarLiq_Click(object sender, EventArgs e)
    {
      using (var context = new lts_autogestionDataContext())
      {
        if (MessageBox.Show("Es seguro de cerrar la liquidacion. Por favor Verifique? ", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          var liq = from a in context.autogestion_liquidacion where a.ALIQ_ID == Convert.ToInt32(dgv_Liquidaciones.CurrentRow.Cells["Id"].Value.ToString()) select a;
          liq.Single().ALIQ_ESTADO = 1;
          liq.Single().ALIQ_TOTAL = Convert.ToDecimal(txt_TotalLiq.Text);
          context.SubmitChanges();
          
          MessageBox.Show("Liquidacion cerrada con exito. Por favor Verifique? ", "¡¡¡ ATENCION !!!");
          dgv_Liquidaciones.DataSource = mtdLiquidacion.GetLiquidaciones();
        }
      }
    }
  }
}
