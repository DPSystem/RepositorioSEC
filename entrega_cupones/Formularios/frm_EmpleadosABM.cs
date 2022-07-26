using AutoGestion;
using AutoGestion.Metodos;
using AutoGestion.Modelos;
using entrega_cupones.Metodos;
using entrega_cupones.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrega_cupones.Formularios
{
  public partial class frm_EmpleadosABM : Form
  {
    public int _UserId = 0;
    List<mdlEmpleados> _Empleados = new List<mdlEmpleados>();
    int _ABM = 0;
    DateTime _FechaCredito;

    public frm_EmpleadosABM(int UserId)
    {
      _UserId = UserId;

      InitializeComponent();
      //GestionarPermisos();
    }

    private void btn_Salir_Click(object sender, EventArgs e)
    {
      Close();
      frm_Principal2 f = new frm_Principal2(0, "", "", "", 0);
      f.menuStrip1.Enabled = true;
    }

    private void frm_EmpleadosABM_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void GestionarPermisos()
    {
      var ControlsButon = Controls.OfType<Button>().ToList();

      var ControlsText = this.Pnl_TxtBox.Controls.OfType<TextBox>().ToList();

      foreach (var objeto in MtdPermisos.GetPermisosDeUsuario(_UserId))
      {
        foreach (var cntrl in ControlsButon)
        {
          if (objeto.ObjetoNombre == cntrl.Name)
          {
            cntrl.Enabled = objeto.ObjetoEstado == 1;
          }
        }

        foreach (var cntrl in ControlsText)
        {

          if (objeto.ObjetoNombre == cntrl.Name)
          {
            cntrl.ReadOnly = objeto.ObjetoEstado == 1;
          }
        }
      }
    }

    private void frm_EmpleadosABM_Load(object sender, EventArgs e)
    {

      GetEmpleados();
      cbx_BuscarPor.SelectedIndex = 0;
      Cargar_Cbx_Proveedores();

    }
    private void GetEmpleados()
    {
      _Empleados = mtdEmpleados.GetTodosLosEmpleados();
      dgv_EmpleadosCargados.AutoGenerateColumns = false;
      dgv_EmpleadosCargados.DataSource = _Empleados;
    }


    private void Cargar_Cbx_Proveedores()
    {
      Cbx_Comercio.DisplayMember = "Nombre";
      Cbx_Comercio.ValueMember = "Id";
      Cbx_Comercio.DataSource = MtdProveedores.GetProveedoresCBX();
    }

    private void dgv_EmpleadosCargados_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dgv_EmpleadosCargados_SelectionChanged(object sender, EventArgs e)
    {
      MostrarDatosEmpleado();

      if (Convert.ToDecimal(Txt_Margen_Disponible.Text) > 0)
      {
        Btn_Credito.Enabled = true;
      }
      else
      {
        Btn_Credito.Enabled = false;
      }
    }

    private void MostrarDatosEmpleado() // Mostrar Socio
    {
      if (_Empleados.Count() > 0)
      {
        int index = dgv_EmpleadosCargados.CurrentRow.Index;
        Txt_Legajo.Text = _Empleados[index].Legajo.ToString();
        txt_apellido.Text = _Empleados[index].Apellido;
        txt_nombre.Text = _Empleados[index].Nombre;
        txt_dni.Text = _Empleados[index].DNI;
        txt_CUIT.Text = _Empleados[index].CUIT;
        txt_telefono.Text = _Empleados[index].Telefono;
        Txt_Domicilio.Text = _Empleados[index].Domicilio;
        Txt_Margen.Text = _Empleados[index].Margen.ToString("N2");
        Txt_Margen_Disponible.Text = _Empleados[index].MargenDisponible.ToString("N2");

        if (_Empleados[index].FechaNac != null)
        {
          DateTime fecha = Convert.ToDateTime(_Empleados[index].FechaNac);
          Cbx_Dia.Text = fecha.Day.ToString();
          Cbx_Mes.Text = fecha.Month.ToString();
          Cbx_Año.Text = fecha.Year.ToString();
        }
        else
        {
          Cbx_Dia.Text = "";
          Cbx_Mes.Text = "";
          Cbx_Año.Text = "";
        }

        txt_email.Text = _Empleados[index].Email;

      }
      else
      {
        LimpiarTextBox();
      }
    }

    private void LimpiarTextBox()
    {
      Txt_Legajo.Text = "";
      txt_apellido.Text = "";
      txt_nombre.Text = "";
      txt_dni.Text = "";
      txt_CUIT.Text = "";
      txt_telefono.Text = "";
      Txt_Domicilio.Text = "";
      txt_email.Text = "";
      Txt_Margen.Text = "";
    }

    private void ActivarTextBox()
    {
      Txt_Legajo.ReadOnly = false;
      txt_apellido.ReadOnly = false;
      txt_nombre.ReadOnly = false;
      txt_dni.ReadOnly = false;
      txt_CUIT.ReadOnly = false;
      txt_telefono.ReadOnly = false;
      Txt_Domicilio.ReadOnly = false;
      txt_email.ReadOnly = false;
      Txt_Margen.ReadOnly = false;
    }

    private void BloquearTextBox()
    {
      Txt_Legajo.ReadOnly = true;
      txt_apellido.ReadOnly = true;
      txt_nombre.ReadOnly = true;
      txt_dni.ReadOnly = true;
      txt_CUIT.ReadOnly = true;
      txt_telefono.ReadOnly = true;
      Txt_Domicilio.ReadOnly = true;
      txt_email.ReadOnly = true;
      Txt_Margen.ReadOnly = true;
    }

    private void btn_salir_Click_1(object sender, EventArgs e)
    {

      frm_Principal2 padre = (frm_Principal2)this.MdiParent;
      padre.menuStrip1.Enabled = true;

      Close();
    }

    private void cbx_BuscarPor_SelectedIndexChanged(object sender, EventArgs e)
    {
      lbl_DatoABuscar.Text = cbx_BuscarPor.SelectedIndex == 0 ? "D.N.I.:" : "Apellido:";
    }

    private void txt_DatoABuscar_TextChanged(object sender, EventArgs e)
    {
      _Empleados.Clear();
      _Empleados = cbx_BuscarPor.SelectedIndex == 0 ? mtdEmpleados.GetEmpladosPorDNI(txt_DatoABuscar.Text) : mtdEmpleados.GetEmpladosPorApeNom(txt_DatoABuscar.Text);
      dgv_EmpleadosCargados.DataSource = _Empleados;
    }

    private void btn_eliminar_Click(object sender, EventArgs e)
    {

    }

    private void btn_nuevo_Click(object sender, EventArgs e)
    {
      _ABM = 1;
      LimpiarTextBox();
      ActivarTextBox();
      cbx_BuscarPor.Enabled = false;
      txt_DatoABuscar.Enabled = false;
      btn_nuevo.Enabled = false;
      btn_eliminar.Enabled = false;
      btn_modificar.Enabled = false;
      dgv_EmpleadosCargados.Enabled = false;

    }

    private void btn_modificar_Click(object sender, EventArgs e)
    {
      _ABM = 3;
      ActivarTextBox();
      cbx_BuscarPor.Enabled = false;
      txt_DatoABuscar.Enabled = false;
      btn_nuevo.Enabled = false;
      btn_eliminar.Enabled = false;
      btn_modificar.Enabled = false;
      dgv_EmpleadosCargados.Enabled = false;
      GestionarPermisos();
    }

    private void ABM()
    {
      if (_ABM == 1) // Alta de Socio
      {
        using (var context = new lts_autogestionDataContext())
        {
          if (!mtdEmpleados.ControlarDNIRepetidoEnEmpleados(txt_dni.Text))
          {
            if (!mtdEmpleados.ControlarLegajoRepetidoEnEmpleados(Txt_Legajo.Text))
            {

              empleados emp = new empleados();
              empleados_bancos empban = new empleados_bancos();
              emp.EMP_LEGAJO = Convert.ToInt32(Txt_Legajo.Text);
              emp.EMP_APELLIDO = txt_apellido.Text;
              emp.EMP_NOMBRE = txt_nombre.Text;
              emp.EMP_APENOM = txt_apellido.Text + " " + txt_nombre.Text;
              emp.EMP_DNI = txt_dni.Text;
              emp.EMP_CUIT = txt_CUIT.Text;
              emp.EMP_TEL = txt_telefono.Text;
              emp.EMP_DIRECCION = Txt_Domicilio.Text;
              emp.EMP_MAIL = txt_email.Text;
              string fecha = mtdFuncUtiles.generar_ceros(Cbx_Dia.Text, 2) + "/" + mtdFuncUtiles.generar_ceros(Cbx_Mes.Text, 2) + "/" + Cbx_Año.Text;

              if (mtdFuncUtiles.ValidarFecha(fecha))
              {
                emp.EMP_FECHA_NACIMIENTO = Convert.ToDateTime(fecha);
              }
              else
              {
                MessageBox.Show("La fecha de nacimiento no es Valida, no se guardaron los cambios de la fecha.  ");
              }

              emp.EMP_ESTADO_CREDITO = 0;
              emp.EMP_MARGEN = Convert.ToDecimal(Txt_Margen.Text);

              context.empleados.InsertOnSubmit(emp);
              context.SubmitChanges();

              MessageBox.Show("El Socio fue Cargado con exito. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");
              _Empleados = mtdEmpleados.GetTodosLosEmpleados();
              dgv_EmpleadosCargados.DataSource = _Empleados;
            }
            else
            {
              MessageBox.Show("El Numero de Legajo ingresado ya existe. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");
            }
          }
          else
          {
            MessageBox.Show("El DNI ingresado ya existe. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");
            txt_dni.Focus();
          }
        }
      }

      if (_ABM == 3) //Modificacion de Socio
      {
        using (var context = new lts_autogestionDataContext())
        {

          var emp = context.empleados.Where(x => x.EMP_ID == Convert.ToInt32(dgv_EmpleadosCargados.CurrentRow.Cells["EmpleadoId"].Value)).Single();

          emp.EMP_LEGAJO = Convert.ToInt32(Txt_Legajo.Text);
          emp.EMP_APELLIDO = txt_apellido.Text;
          emp.EMP_NOMBRE = txt_nombre.Text;
          emp.EMP_APENOM = txt_apellido.Text + " " + txt_nombre.Text;
          emp.EMP_DNI = txt_dni.Text;
          emp.EMP_CUIT = txt_CUIT.Text;
          emp.EMP_TEL = txt_telefono.Text;
          emp.EMP_DIRECCION = Txt_Domicilio.Text;
          emp.EMP_MAIL = txt_email.Text;

          string fecha = mtdFuncUtiles.generar_ceros(Cbx_Dia.Text, 2) + "/" + mtdFuncUtiles.generar_ceros(Cbx_Mes.Text, 2) + "/" + Cbx_Año.Text;

          if (mtdFuncUtiles.ValidarFecha(fecha))
          {
            emp.EMP_FECHA_NACIMIENTO = Convert.ToDateTime(fecha);
          }
          else
          {
            MessageBox.Show("La fecha de nacimiento no es Valida, no se guardaron los cambios de la fecha.  ");
          }

          emp.EMP_ESTADO_CREDITO = 0;
          emp.EMP_MARGEN = Convert.ToDecimal(Txt_Margen.Text);

          context.SubmitChanges();

          MessageBox.Show("El Socio se Actualizo con exito. Por Favor  Verifique !!! ", "¡¡¡ ATENCION !!!");

          _Empleados = mtdEmpleados.GetTodosLosEmpleados();
          dgv_EmpleadosCargados.DataSource = _Empleados;

        }

      }
      _ABM = 0;
    }

    private void btn_confirmar_Click(object sender, EventArgs e)
    {
      ABM();
      cbx_BuscarPor.Enabled = true;
      txt_DatoABuscar.Enabled = true;
      btn_nuevo.Enabled = true;
      btn_eliminar.Enabled = true;
      btn_modificar.Enabled = true;
      dgv_EmpleadosCargados.Enabled = true;
      BloquearTextBox();

    }

    private void btn_cancelar_Click(object sender, EventArgs e)
    {
      Mtd_BtnCancelar();

    }
    private void Mtd_BtnCancelar()
    {
      BloquearTextBox();

      LimpiarCreditosObjects();

      _ABM = 0;
      dgv_EmpleadosCargados.DataSource = _Empleados = mtdEmpleados.GetTodosLosEmpleados();
      btn_nuevo.Enabled = true;
      btn_eliminar.Enabled = true;
      btn_modificar.Enabled = true;
      dgv_EmpleadosCargados.Enabled = true;
      cbx_BuscarPor.Enabled = true;
      txt_DatoABuscar.Enabled = true;
      Pnl_Creditos.Enabled = false;
    }

    private void txt_dni_TextChanged(object sender, EventArgs e)
    {

    }

    private void Btn_Credito_Click(object sender, EventArgs e)
    {
      Pnl_Creditos.Enabled = true;
      Txt_Importe.Enabled = true;
      Cbx_CantidadCuotas.Enabled = true;
      Cbx_Comercio.Enabled = true;
      Txt_Margen2.Text = Txt_Margen_Disponible.Text;
      dgv_EmpleadosCargados.Enabled = false;

    }

    private void Btn_SimularCredito_Click(object sender, EventArgs e)
    {
      SimularCredito();
    }

    private void SimularCredito()
    {
      string FechaCredito = mtdFuncUtiles.generar_ceros(Cbx_Dia_Credito.Text, 2) + "/" + mtdFuncUtiles.generar_ceros(Cbx_Mes_Credito.Text, 2) + "/" + Cbx_Año_Credito.Text;
      decimal MargenDisponible = Convert.ToDecimal(Txt_Margen2.Text);
      decimal ImporteCredito = Convert.ToDecimal(Txt_Importe.Text);

      if (mtdFuncUtiles.ValidarFecha(FechaCredito)) // si la fecha del cerdito es valida
      {
        if (!mtdFuncUtiles.ValidarFechaMayorQue(FechaCredito)) // si la fecha del credito es menor que la fecha actual
        {
          if (MargenDisponible >= ImporteCredito)
          {
            _FechaCredito = Convert.ToDateTime(FechaCredito);
            int cuotas = Convert.ToInt16(Cbx_CantidadCuotas.Text);

            Txt_ImporteCuota.Text = Math.Round((Convert.ToDecimal(Txt_Importe.Text) / cuotas), 2).ToString("N2");
            Dgv_Cuotas.Rows.Clear();

            for (int i = 1; i <= cuotas; i++)
            {
              Dgv_Cuotas.Rows.Insert(i - 1, i, Convert.ToDateTime(FechaCredito).AddMonths(i), Txt_ImporteCuota.Text);
            }
            Btn_Aprobar.Enabled = true;
          }
          else
          {
            MessageBox.Show("El Monto del  Credito , Debe ser Manor o Igual que el Margen Disponible, por Favor Ingresar un Monto Valido");
            Txt_Importe.Focus();
          }
        }
        else
        {
          MessageBox.Show("La fecha del credito no es valida, debe ser manor o igual que la fecha actual, por favor ingresar una valida");
          Cbx_Dia_Credito.Focus();
        }
      }
      else
      {
        MessageBox.Show("La fecha del credito no es valida, por favor ingresar una valida");
        Cbx_Dia_Credito.Focus();
      }
    }


    private void Cbx_CantidadCuotas_SelectedValueChanged(object sender, EventArgs e)
    {
      //CalcularImporteCuota();
    }

    private void Btn_Aprobar_Click(object sender, EventArgs e)
    {
      AprobarCredito();
    }
    private void AprobarCredito()
    {
      using (var context = new lts_autogestionDataContext())
      {
        int EmpleadoId = Convert.ToInt32(dgv_EmpleadosCargados.CurrentRow.Cells["EmpleadoId"].Value);
        int NumeroCredito = MtdCreditos.GetUltimoCredito();

        Creditos credito = new Creditos();


        credito.Fecha = _FechaCredito;
        credito.Numero = NumeroCredito;
        credito.EmpleadoId = EmpleadoId;
        credito.Legajo = Convert.ToInt32(Txt_Legajo.Text);
        credito.UsuarioId = _UserId;
        credito.ProveedorId = (int)Cbx_Comercio.SelectedValue;
        credito.Importe = Convert.ToDecimal(Txt_Importe.Text);
        credito.Cuotas = Convert.ToInt16(Cbx_CantidadCuotas.Text);
        credito.SinCargo = Chk_SinCargo.Checked ? 1 : 0;
        context.Creditos.InsertOnSubmit(credito);
        context.SubmitChanges();

        if (!Chk_SinCargo.Checked) // Sin Cargo  
        {
          foreach (DataGridViewRow fila in Dgv_Cuotas.Rows)
          {
            Creditos_Detalles CD = new Creditos_Detalles();
            CD.CreditoId = MtdCreditos.GetUltimoCreditoId();
            CD.Numero = NumeroCredito;
            CD.NroCuota = (int)fila.Cells["Cuota"].Value;
            CD.FechaDeVenc = (DateTime)fila.Cells["PeriodoDescuento"].Value;
            CD.Importe = Convert.ToDecimal(fila.Cells["ImporteCuota"].Value);
            CD.Saldo = Convert.ToDecimal(fila.Cells["ImporteCuota"].Value); ;
            context.Creditos_Detalles.InsertOnSubmit(CD);
            context.SubmitChanges();
          }
          MtdCreditos.DescontarMargen(Convert.ToInt32(Txt_Legajo.Text), Convert.ToDecimal(Txt_Importe.Text));
        }
        MessageBox.Show("El Credito fue Creado Exitosamente. !!!!", "ATENCION");
        LimpiarCreditosObjects();
      }
    }

    private void LimpiarCreditosObjects()
    {
      Cbx_Dia_Credito.Text = "Dia";
      Cbx_Mes_Credito.Text = "Mes";
      Cbx_Año_Credito.Text = "Año";
      Txt_Margen2.Text = "0.00";
      Txt_Importe.Text = "0.00";
      Cbx_CantidadCuotas.SelectedIndex = 0;
      Txt_ImporteCuota.Text = "0.00";
      Cbx_Comercio.SelectedIndex = 0;
      Chk_SinCargo.Checked = false;
      mtdFuncUtiles.limpiar_dgv(Dgv_Cuotas);
      dgv_EmpleadosCargados.Enabled = true;
      dgv_EmpleadosCargados.Focus();
      GetEmpleados();
    }

    private void Btn_ModificarMargen_Click(object sender, EventArgs e)
    {

    }

    private void Btn_VerCreditos_Click(object sender, EventArgs e)
    {
      dgv_EmpleadosCargados.Enabled = false;
      Btn_VerCreditos.Enabled = false;
      Pnl_CreditosEfectuados.Visible = true;
      Dgv_CreditosEfectuados.AutoGenerateColumns = false;
      MostrarCreditosEfectuados();
    }

    private void Btn_SalirCreditosEfectuados_Click(object sender, EventArgs e)
    {
      dgv_EmpleadosCargados.Enabled = true;
      Btn_VerCreditos.Enabled = true;
      Pnl_CreditosEfectuados.Visible = false;
    }

    private void MostrarCreditosEfectuados()
    {
      using (var context = new lts_autogestionDataContext())
      {
        var CreditosEfect = from a in context.Creditos
                            where a.Legajo == Convert.ToInt32(Txt_Legajo.Text)
                            join cd in context.Creditos_Detalles on a.Numero equals cd.Numero
                            join com in context.Proveedores on a.ProveedorId equals com.Id
                            select new MdlCreditosEfectuados
                            {
                              Comercio = com.Nombre,
                              Credito = (int)a.Numero,
                              NroCuota = (int)cd.NroCuota,
                              Periodo = Convert.ToDateTime(cd.FechaDeVenc),
                              Importe = (decimal)cd.Importe,
                              PagoParcial = (bool)cd.PagoParcial,
                              //PagoParcialString = (bool)cd.PagoParcial ? "Parcial" : "Completo",
                              Saldo = (decimal)cd.Saldo
                            };
        Dgv_CreditosEfectuados.DataSource = CreditosEfect.Count() > 0 ? CreditosEfect.ToList() : null;

        Txt_SaldoAPagar.Text = CreditosEfect.Count() > 0 ? CreditosEfect.Sum(x => x.Saldo).ToString() : "0";
      }
    }

    private void Btn_CobroMasivo_Click(object sender, EventArgs e)
    {
      using (var Context = new lts_autogestionDataContext())
      {

      }
    }
  }
}

