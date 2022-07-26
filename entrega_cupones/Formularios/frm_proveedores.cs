using AutoGestion.Metodos;
using AutoGestion.Modelos;
using entrega_cupones.Formularios;
using entrega_cupones.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGestion.Formularios
{
  public partial class Frm_Proveedores : Form
  {

    List<MdlProveedores> _Proveedores = new List<MdlProveedores>();
    int _ABM = 0;

    public Frm_Proveedores()
    {
      InitializeComponent();
    }

    private void Frm_proveedores_Load(object sender, EventArgs e)
    {

      _Proveedores = MtdProveedores.GetAllProveedores();
      Dgv_Proveedores.AutoGenerateColumns = false;
      Dgv_Proveedores.DataSource = _Proveedores;

    }

    private void Btn_Salir_Click(object sender, EventArgs e)
    {
      frm_Principal2 padre = (frm_Principal2)this.MdiParent;
      padre.menuStrip1.Enabled = true;
      Close();
    }

    private void Txt_DatoABuscar_TextChanged(object sender, EventArgs e)
    {
      //_Proveedores.Clear();
      //_Proveedores = MtdProveedores.GetAllProveedores() ;
      Dgv_Proveedores.DataSource = _Proveedores.Where(x => x.NomRazSocCUIT.Contains(txt_DatoABuscar.Text)).ToList();
    }

    private void Btn_Nuevo_Click(object sender, EventArgs e)
    {
      _ABM = 1;
      LimpiarTextBox();
      ActivarTextBox();
      txt_DatoABuscar.Enabled = false;
      Btn_Nuevo.Enabled = false;
      Btn_Eliminar.Enabled = false;
      Btn_Modificar.Enabled = false;
      Dgv_Proveedores.Enabled = false;
    }


    private void LimpiarTextBox()
    {
      Txt_Nombre.Text = "";
      Txt_RazonSoc.Text = "";
      Txt_Telefono.Text = "";
      Txt_Celular.Text = "";
      Txt_Email.Text = "";
      Txt_Domicilio.Text = "";
      Txt_CUIT.Text = "";
      Txt_CuentaBanco.Text = "";
      Txt_CBU.Text = "";
    }

    private void ActivarTextBox()
    {
      Txt_Nombre.ReadOnly = false;
      Txt_RazonSoc.ReadOnly = false;
      Txt_Telefono.ReadOnly = false;
      Txt_Celular.ReadOnly = false;
      Txt_Email.ReadOnly = false;
      Txt_Domicilio.ReadOnly = false;
      Txt_CUIT.ReadOnly = false;
      Txt_CuentaBanco.ReadOnly = false;
      Txt_CBU.ReadOnly = false;
    }

    private void BloquearTextBox()
    {
      Txt_Nombre.ReadOnly = true;
      Txt_RazonSoc.ReadOnly = true;
      Txt_Telefono.ReadOnly = true;
      Txt_Celular.ReadOnly = true;
      Txt_Email.ReadOnly = true;
      Txt_Domicilio.ReadOnly = true;
      Txt_CUIT.ReadOnly = true;
      Txt_CuentaBanco.ReadOnly = true;
      Txt_CBU.ReadOnly = true;
    }

    private void Btn_Eliminar_Click(object sender, EventArgs e)
    {

    }

    private void Btn_Modificar_Click(object sender, EventArgs e)
    {
      _ABM = 3;
      ActivarTextBox();
      txt_DatoABuscar.Enabled = false;
      Btn_Nuevo.Enabled = false;
      Btn_Eliminar.Enabled = false;
      Btn_Modificar.Enabled = false;
      Dgv_Proveedores.Enabled = false;
    }

    private void Btn_Cancelar_Click(object sender, EventArgs e)
    {
      BloquearTextBox();
      _ABM = 0;

      Dgv_Proveedores.DataSource = _Proveedores = MtdProveedores.GetAllProveedores();
      Btn_Nuevo.Enabled = true;
      Btn_Eliminar.Enabled = true;
      Btn_Modificar.Enabled = true;
      Dgv_Proveedores.Enabled = true;
      txt_DatoABuscar.Enabled = true;
    }

    private void Btn_Confirmar_Click(object sender, EventArgs e)
    {
      ABM();
      txt_DatoABuscar.Enabled = true;
      Btn_Nuevo.Enabled = true;
      Btn_Eliminar.Enabled = true;
      Btn_Modificar.Enabled = true;
      Dgv_Proveedores.Enabled = true;
      BloquearTextBox();
    }

    private void ABM()
    {
      if (_ABM == 1)
      {
        using (var context = new lts_autogestionDataContext())
        {
          if (!MtdProveedores.Controlar_CUIT_Repetidos(Txt_CUIT.Text))
          {
            Proveedores prov = new Proveedores
            {
              Nombre = Txt_Nombre.Text,
              RazonSocial = Txt_RazonSoc.Text,
              TelefonoFijo = Txt_Telefono.Text,
              Celular = Txt_Celular.Text,
              Email = Txt_Email.Text,
              Domicilio = Txt_Domicilio.Text,
              //LocalidadId = 
              Fecha = DateTime.Now,
              Estado = 0,
              CUIT = Txt_CUIT.Text,
              Cuenta_Banco = Txt_CuentaBanco.Text,
              CBU = Txt_CBU.Text

            };

            context.Proveedores.InsertOnSubmit(prov);
            context.SubmitChanges();

            MessageBox.Show("El Proveedor fue Cargado con exito. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");

            _Proveedores = MtdProveedores.GetAllProveedores();
            Dgv_Proveedores.DataSource = _Proveedores;
          }
          else
          {
            MessageBox.Show("El CUIT ingresado ya existe. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");
            Txt_CUIT.Focus();
            return;
          }
        }
      }

      if (_ABM == 3)
      {
        using (var context = new lts_autogestionDataContext())
        {

          var prov = context.Proveedores.Where(x => x.Id == Convert.ToInt32(Dgv_Proveedores.CurrentRow.Cells["ProvId"].Value)).Single();

          prov.Nombre = Txt_Nombre.Text;
          prov.RazonSocial = Txt_RazonSoc.Text;
          prov.TelefonoFijo = Txt_Telefono.Text;
          prov.Celular = Txt_Celular.Text;
          prov.Email = Txt_Email.Text;
          prov.Domicilio = Txt_Domicilio.Text;
          //LocalidadId = 
          prov.Fecha = DateTime.Now;
          prov.Estado = 0;
          prov.CUIT = Txt_CUIT.Text;
          prov.Cuenta_Banco = Txt_CuentaBanco.Text;
          prov.CBU = Txt_CBU.Text;

          context.SubmitChanges();

          _Proveedores = MtdProveedores.GetAllProveedores();
          Dgv_Proveedores.DataSource = _Proveedores;

          MessageBox.Show("El Proveedor se Actualizo con exito. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");
        }
      }
      _ABM = 0;
    }

    private void Dgv_Proveedores_SelectionChanged(object sender, EventArgs e)
    {
      MostrarDatosEmpleado();
    }

    private void MostrarDatosEmpleado()
    {
      if (_Proveedores.Count() > 0)
      {
        int index = Dgv_Proveedores.CurrentRow.Index;
        //txt_apellido.Text = _Empleados[index].Apellido;
        Txt_Nombre.Text = _Proveedores[index].Nombre;
        Txt_RazonSoc.Text = _Proveedores[index].RazonSocial;
        Txt_Telefono.Text = _Proveedores[index].TelefonoFijo;
        Txt_Celular.Text = _Proveedores[index].Celular;
        Txt_Email.Text = _Proveedores[index].Email;
        Txt_Domicilio.Text = _Proveedores[index].Domicilio;
        Txt_CUIT.Text = _Proveedores[index].CUIT;
        Txt_CuentaBanco.Text = _Proveedores[index].Cuenta_Banco;
        Txt_CBU.Text = _Proveedores[index].CBU;
      }
      else
      {
        LimpiarTextBox();
      }
    }
  }
}
