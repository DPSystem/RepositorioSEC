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

namespace entrega_cupones.Formularios.Informes
{
  public partial class PorInspector : Form
  {
    public PorInspector()
    {
      InitializeComponent();
    }

    private void PorInspector_Load(object sender, EventArgs e)
    {
      dgv1.DataSource = MtdInformes.EmpresasQueNoDeclaran(Convert.ToDateTime("01/01/2021"), Convert.ToDateTime("01/07/2021"));

    }
  }
}
