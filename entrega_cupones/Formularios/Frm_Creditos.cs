using entrega_cupones.Formularios;
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

namespace AutoGestion.Formularios
{
  public partial class Frm_Creditos : Form
  {
    List<mdlEmpleados> _Empleados = new List<mdlEmpleados>();

    public Frm_Creditos()
    {
      InitializeComponent();
    }

    private void BtnSsalir_Click(object sender, EventArgs e)
    {
      frm_Principal2 padre = (frm_Principal2)this.MdiParent;
      padre.menuStrip1.Enabled = true;


      Close();
    }

    private void Frm_Creditos_Load(object sender, EventArgs e)
    {
      _Empleados = mtdEmpleados.GetTodosLosEmpleados();
      dgv_EmpleadosCargados.AutoGenerateColumns = false;
      dgv_EmpleadosCargados.DataSource = _Empleados;
      Cbx_CantidadCuotas.SelectedIndex = 0;
      Cbx_Porcentaje.SelectedIndex = 0;

    }

    private void txt_DatoABuscar_TextChanged(object sender, EventArgs e)
    {
      _Empleados.Clear();
      _Empleados = mtdEmpleados.GetEmpladosPorApeNom(txt_DatoABuscar.Text);
      dgv_EmpleadosCargados.DataSource = _Empleados;// _Empleados.Where(x => x.ApeNom.Contains(txt_DatoABuscar.Text)).ToList();
    }

    private void btn_eliminar_Click(object sender, EventArgs e)
    {

    }

    private void Txt_Sueldo_TextChanged(object sender, EventArgs e)
    {
      //Txt_Disponible.Text = Convert.ToDecimal( Txt_Sueldo.Text ) 
    }

    private void Txt_SimularCredito_Click(object sender, EventArgs e)
    {
      decimal Sueldo = Convert.ToDecimal(Txt_Sueldo.Text);
      int Porcentaje = Convert.ToInt32(Cbx_Porcentaje.SelectedItem);
      decimal Disponible = (Sueldo * Porcentaje) / 100;
      Txt_Disponible.Text = Disponible.ToString();

      Llenar_DGVC_Cuotas();
    }

    private void Llenar_DGVC_Cuotas()
    { 

    }
  }
}
