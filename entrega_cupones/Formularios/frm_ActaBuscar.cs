using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entrega_cupones.Metodos;
using entrega_cupones.Modelos;

namespace entrega_cupones.Formularios
{
  public partial class frm_ActaBuscar : Form
  {
    public frm_ActaBuscar()
    {
      InitializeComponent();
    }

    private void frm_ActaBuscar_Load(object sender, EventArgs e)
    {
      //mtdActas.Get_ListadoDeActas();
      dgv_Actas.AutoGenerateColumns = false;
      dgv_Actas.DataSource = mtdActas.Get_ListadoDeActas();
    }
  }
}
