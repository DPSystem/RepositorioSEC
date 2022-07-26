using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoGestion.Formularios;
using entrega_cupones.Clases;
using entrega_cupones.Formularios.Informes;
using entrega_cupones.Metodos;
using entrega_cupones.Modelos;
using Microsoft.Reporting.WebForms;

namespace entrega_cupones.Formularios
{
  public partial class frm_Principal2 : Form
  {
    public int _UserId;
    public int _UserRol;
    public string _RolNombre;
    public string _UserDNI;
    public string _User_Cuil;
    public string _UserNombre;
    public bool _EsSocio;



    DateTime _FechaDeBaja = Convert.ToDateTime("01-01-1000");

    Func_Utiles fnc = new Func_Utiles();
    Buscadores buscar = new Buscadores();
    convertir_imagen cnvimg = new convertir_imagen();




    public frm_Principal2(int id, string Nombre, string dni, string rol_nombre, int rol_Id)
    {
      InitializeComponent();
      menuStrip1.Renderer = new MiRenderizador();

      _UserId = id;
      _UserNombre = Nombre;
      _UserDNI = dni;
      _RolNombre = rol_nombre;
      _UserRol = rol_Id;
    }

    private class MiRenderizador : ToolStripProfessionalRenderer
    {
      protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
      {
        if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
        else
        {
          Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
          e.Graphics.FillRectangle(Brushes.DarkGreen, rc); //Elige el color que desees Brushes.DarkOrange
          e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
        }
      }
    }

    private void frm_Principal2_Load(object sender, EventArgs e)
    {
      Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(52, 52, 52);
    }

    private void menuCupones_Click(object sender, EventArgs e)
    {

    }

    private void menuQuinchos_Click(object sender, EventArgs e)
    {
      frm_quinchos f_quinnchos = new frm_quinchos();
      f_quinnchos.ShowDialog();
    }

    private void menu_VerificarDeuda_Click(object sender, EventArgs e)
    {
      VerificarDeuda f_VerificarDeuda = new VerificarDeuda();
      f_VerificarDeuda._UserId = _UserId;
      f_VerificarDeuda.ShowDialog();
    }

    private void menuCobros_Click(object sender, EventArgs e)
    {
      frm_CobroDeActas frmCobroDeActa = new frm_CobroDeActas();
      frmCobroDeActa.Show();

    }

    private void menu_RendicionDeCobroDeActa_Click(object sender, EventArgs e)
    {
      frm_CobroDeActas frmCobroDeActa = new frm_CobroDeActas();
      frmCobroDeActa.Show();
    }

    private void menuMochilasEmitirCupon_Click(object sender, EventArgs e)
    {

    }

    private void MenuMochilasEntregar_Click(object sender, EventArgs e)
    {
      frm_EntregarMochila f_EntregaMochila = new frm_EntregarMochila();
      f_EntregaMochila.UsuarioId = _UserId;
      f_EntregaMochila.UsuarioNombre = _UserNombre;
      f_EntregaMochila.ShowDialog();
    }

    private void MenuMochilasEdades_Click(object sender, EventArgs e)
    {
      frm_edades f_edades = new frm_edades();
      f_edades.Show();
    }


    private void Menu_BuscarVerificacionDeuda_Click(object sender, EventArgs e)
    {
      frm_VDBuscar f_VDBuscar = new frm_VDBuscar();
      f_VDBuscar.ShowDialog();
    }


    private void menu_ListadoActas_Click(object sender, EventArgs e)
    {
      frm_ActaBuscar f_ActasBuscar = new frm_ActaBuscar();
      f_ActasBuscar.MdiParent = this;
      f_ActasBuscar.Show();
    }


    private void menuSorteoDEC_Click(object sender, EventArgs e)
    {
      //if (_EsSocio)
      //{
      //  if (MessageBox.Show("Esta Seguro de emitir el Cupon de Sorteo?", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
      //  {
      //    MtdSorteos.ControlPreImpresionCuponSorteo(_EsSocio, txt_CUIL.Text.Trim(), txt_DNI.Text, _UserId, txt_Nombre.Text, txt_RazonSocial.Text, txt_NroSocio.Text, mtdConvertirImagen.ImageToByteArray(picbox_socio.Image), "0", "rpt_CuponSorteoDDEDC");
      //  }
      //}
      //else
      //{
      //  MessageBox.Show("El empleado no es socio Activo por lo tanto no puede emitir Numero para el Sorteo .......");
      //}

    }



    private void menuDDLM_Click(object sender, EventArgs e) // Dia de la Madre
    {
      //if (_EsSocio)
      //{
      //  if (MessageBox.Show("Esta Seguro de emitir el Cupon de Sorteo?", "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
      //  {
      //    MtdSorteos.ControlPreImpresionCuponSorteo(_EsSocio, txt_CUIL.Text.Trim(), txt_DNI.Text, _UserId, txt_Nombre.Text, txt_RazonSocial.Text, txt_NroSocio.Text, mtdConvertirImagen.ImageToByteArray(picbox_socio.Image), "0", "rpt_CuponSorteoDDLM");
      //  }
      //}
      //else
      //{
      //  MessageBox.Show("El empleado no es socio Activo por lo tanto no puede emitir Numero para el Sorteo .......");
      //}
      ////if (_EsSocio)
      ////{
      ////  if (!MtdSorteos.CuponYaEmitido(txt_CUIL.Text.Trim()))
      ////  {

      ////    double Dni = Convert.ToDouble(txt_DNI.Text);

      ////    int NroSorteo = MtdDEC.GetNroSorteo(2, txt_CUIL.Text, _UserId);

      ////    MtdSorteos.ImprimirCuponSorteo(NroSorteo, txt_CUIL.Text, txt_Nombre.Text, Dni.ToString("N0"), txt_RazonSocial.Text, txt_NroSocio.Text, mtdConvertirImagen.ImageToByteArray(picbox_socio.Image), "0", "rpt_CuponSorteoDDLM");

      ////  }

      ////  else
      ////  {
      ////    if (MessageBox.Show(MtdDEC.CuponEmitidoLeyenda(txt_CUIL.Text.Trim()), "¡¡¡ ATENCION !!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
      ////    {

      ////      double Dni_ = Convert.ToDouble(txt_DNI.Text);

      ////      int NroSorteo_ = MtdDEC.GetNroCuponYaEmitido(txt_CUIL.Text);

      ////      MtdSorteos.ImprimirCuponSorteo(NroSorteo_, txt_CUIL.Text, txt_Nombre.Text, Dni_.ToString("N0"), txt_RazonSocial.Text, txt_NroSocio.Text, mtdConvertirImagen.ImageToByteArray(picbox_socio.Image), "1", "rpt_CuponSorteoDDLM");
      ////    }
      ////  }
      ////}
      ////else
      ////{
      ////  MessageBox.Show("La empleada no es socio Activo por lo tanto no puede emitir Numero para el Sorteo .......");
      ////}
    }


    private void MenuEmpleadosABM_Click(object sender, EventArgs e)
    {
      menuStrip1.Enabled = false;

      frm_EmpleadosABM f_empleadosABM = new frm_EmpleadosABM(_UserId);
      f_empleadosABM._UserId = _UserId;
      f_empleadosABM.MdiParent = this;
      f_empleadosABM.StartPosition = FormStartPosition.Manual;

      f_empleadosABM.Show();
    }

    private void MenuLiquidaciones_Click(object sender, EventArgs e)
    {
      menuStrip1.Enabled = false;
      frm_Liquidacion f_liquidacion = new frm_Liquidacion();
      f_liquidacion.MdiParent = this;
      f_liquidacion.StartPosition = FormStartPosition.Manual;
      f_liquidacion.Show();

    }

    private void menuProveedores_Click_1(object sender, EventArgs e)
    {
      menuStrip1.Enabled = false;
      Frm_Proveedores f_liquidacion = new Frm_Proveedores();
      f_liquidacion.MdiParent = this;
      f_liquidacion.StartPosition = FormStartPosition.Manual;
      f_liquidacion.Show();
    }

    private void MenuCreditos_Click(object sender, EventArgs e)
    {
      menuStrip1.Enabled = false;
      Frm_Creditos f_Creditos = new Frm_Creditos();
      f_Creditos.MdiParent = this;
      f_Creditos.StartPosition = FormStartPosition.Manual;
      f_Creditos.Show();
    }
  }
}
