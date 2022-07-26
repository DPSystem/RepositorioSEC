
using System;
using System.Windows.Forms;

namespace entrega_cupones.Formularios
{
  partial class frm_Liquidacion
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label23 = new System.Windows.Forms.Label();
      this.pnl_LiquidacionesEmitidas = new System.Windows.Forms.Panel();
      this.btn_CerrarLiq = new System.Windows.Forms.Button();
      this.btn_GenerarTXT = new System.Windows.Forms.Button();
      this.dgv_Liquidaciones = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.EstadoString = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_Nuevo = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pnl_ModificarEliminarDetalle = new System.Windows.Forms.Panel();
      this.btn_EliminarDetalle = new System.Windows.Forms.Button();
      this.txt_ModificarImporteLiqDetalle = new System.Windows.Forms.TextBox();
      this.btn_AceptarModifImporteLiqDetalle = new System.Windows.Forms.Button();
      this.chk_ModifcarImporteLiqDetalle = new System.Windows.Forms.CheckBox();
      this.txt_TotalLiq = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.dgv_LiquidacionDetalle = new System.Windows.Forms.DataGridView();
      this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbl_DetalleDeLiq = new System.Windows.Forms.Label();
      this.txt_DatoABuscar = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.pnl_CrearLiquidacion = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.btn_CancelarLiq = new System.Windows.Forms.Button();
      this.btn_CrearLiquidacion = new System.Windows.Forms.Button();
      this.txt_ReseñaLiquidacion = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txt_NroLiquidacion = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.pnl_AddBenefALiquidacion = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.txt_Importe = new System.Windows.Forms.TextBox();
      this.dgv_BuscarBenef = new System.Windows.Forms.DataGridView();
      this.IdBenef = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbl_DatoABuscar = new System.Windows.Forms.Label();
      this.cbx_BuscarPor = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.btn_Agregar = new System.Windows.Forms.Button();
      this.btn_Salir = new System.Windows.Forms.Button();
      this.pnl_LiquidacionesEmitidas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Liquidaciones)).BeginInit();
      this.panel1.SuspendLayout();
      this.pnl_ModificarEliminarDetalle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_LiquidacionDetalle)).BeginInit();
      this.pnl_CrearLiquidacion.SuspendLayout();
      this.pnl_AddBenefALiquidacion.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarBenef)).BeginInit();
      this.SuspendLayout();
      // 
      // label23
      // 
      this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.label23.Dock = System.Windows.Forms.DockStyle.Top;
      this.label23.Font = new System.Drawing.Font("Century Gothic", 11F);
      this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.label23.Location = new System.Drawing.Point(0, 0);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(1207, 23);
      this.label23.TabIndex = 616;
      this.label23.Text = "Liquidaciones";
      this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnl_LiquidacionesEmitidas
      // 
      this.pnl_LiquidacionesEmitidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.pnl_LiquidacionesEmitidas.Controls.Add(this.btn_CerrarLiq);
      this.pnl_LiquidacionesEmitidas.Controls.Add(this.btn_GenerarTXT);
      this.pnl_LiquidacionesEmitidas.Controls.Add(this.dgv_Liquidaciones);
      this.pnl_LiquidacionesEmitidas.Controls.Add(this.label1);
      this.pnl_LiquidacionesEmitidas.Controls.Add(this.btn_Nuevo);
      this.pnl_LiquidacionesEmitidas.Location = new System.Drawing.Point(4, 48);
      this.pnl_LiquidacionesEmitidas.Name = "pnl_LiquidacionesEmitidas";
      this.pnl_LiquidacionesEmitidas.Size = new System.Drawing.Size(400, 284);
      this.pnl_LiquidacionesEmitidas.TabIndex = 617;
      // 
      // btn_CerrarLiq
      // 
      this.btn_CerrarLiq.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_CerrarLiq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CerrarLiq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_CerrarLiq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CerrarLiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_CerrarLiq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_CerrarLiq.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_CerrarLiq.Image = global::AutoGestion.Properties.Resources.verification_of_delivery_list_clipboard_symbol__1_;
      this.btn_CerrarLiq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_CerrarLiq.Location = new System.Drawing.Point(261, 234);
      this.btn_CerrarLiq.Name = "btn_CerrarLiq";
      this.btn_CerrarLiq.Size = new System.Drawing.Size(126, 40);
      this.btn_CerrarLiq.TabIndex = 645;
      this.btn_CerrarLiq.Text = "Cerrar Liq.    ";
      this.btn_CerrarLiq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_CerrarLiq.UseVisualStyleBackColor = true;
      this.btn_CerrarLiq.Click += new System.EventHandler(this.btn_CerrarLiq_Click);
      // 
      // btn_GenerarTXT
      // 
      this.btn_GenerarTXT.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_GenerarTXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_GenerarTXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_GenerarTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_GenerarTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_GenerarTXT.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_GenerarTXT.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_GenerarTXT.Image = global::AutoGestion.Properties.Resources.Modificar_24;
      this.btn_GenerarTXT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_GenerarTXT.Location = new System.Drawing.Point(129, 234);
      this.btn_GenerarTXT.Name = "btn_GenerarTXT";
      this.btn_GenerarTXT.Size = new System.Drawing.Size(126, 40);
      this.btn_GenerarTXT.TabIndex = 644;
      this.btn_GenerarTXT.Text = "Generar TXT  ";
      this.btn_GenerarTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_GenerarTXT.UseVisualStyleBackColor = true;
      this.btn_GenerarTXT.Click += new System.EventHandler(this.btn_GenerarTXT_Click);
      // 
      // dgv_Liquidaciones
      // 
      this.dgv_Liquidaciones.AllowUserToAddRows = false;
      this.dgv_Liquidaciones.AllowUserToDeleteRows = false;
      this.dgv_Liquidaciones.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dgv_Liquidaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv_Liquidaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Liquidaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgv_Liquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Liquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaEmision,
            this.Total,
            this.EstadoString});
      this.dgv_Liquidaciones.Location = new System.Drawing.Point(3, 26);
      this.dgv_Liquidaciones.Name = "dgv_Liquidaciones";
      this.dgv_Liquidaciones.RowHeadersVisible = false;
      this.dgv_Liquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Liquidaciones.Size = new System.Drawing.Size(391, 197);
      this.dgv_Liquidaciones.TabIndex = 642;
      this.dgv_Liquidaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Liquidaciones_CellContentClick);
      this.dgv_Liquidaciones.SelectionChanged += new System.EventHandler(this.dgv_Liquidaciones_SelectionChanged);
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.NullValue = null;
      this.Id.DefaultCellStyle = dataGridViewCellStyle3;
      this.Id.HeaderText = "ID";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 50;
      // 
      // FechaEmision
      // 
      this.FechaEmision.DataPropertyName = "FechaEmision";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.FechaEmision.DefaultCellStyle = dataGridViewCellStyle4;
      this.FechaEmision.HeaderText = "Emision";
      this.FechaEmision.Name = "FechaEmision";
      this.FechaEmision.ReadOnly = true;
      this.FechaEmision.Width = 120;
      // 
      // Total
      // 
      this.Total.DataPropertyName = "Total";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.Total.DefaultCellStyle = dataGridViewCellStyle5;
      this.Total.HeaderText = "Total";
      this.Total.Name = "Total";
      this.Total.ReadOnly = true;
      this.Total.Width = 120;
      // 
      // EstadoString
      // 
      this.EstadoString.DataPropertyName = "EstadoString";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle6.Format = "N2";
      dataGridViewCellStyle6.NullValue = null;
      this.EstadoString.DefaultCellStyle = dataGridViewCellStyle6;
      this.EstadoString.HeaderText = "Estado";
      this.EstadoString.Name = "EstadoString";
      this.EstadoString.ReadOnly = true;
      this.EstadoString.Width = 80;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(400, 23);
      this.label1.TabIndex = 617;
      this.label1.Text = " Emitidas";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_Nuevo
      // 
      this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Nuevo.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_Nuevo.Image = global::AutoGestion.Properties.Resources.portapapeles_24;
      this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_Nuevo.Location = new System.Drawing.Point(3, 234);
      this.btn_Nuevo.Name = "btn_Nuevo";
      this.btn_Nuevo.Size = new System.Drawing.Size(120, 40);
      this.btn_Nuevo.TabIndex = 636;
      this.btn_Nuevo.Text = "Nuevo        ";
      this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_Nuevo.UseVisualStyleBackColor = true;
      this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.panel1.Controls.Add(this.pnl_ModificarEliminarDetalle);
      this.panel1.Controls.Add(this.txt_TotalLiq);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.dgv_LiquidacionDetalle);
      this.panel1.Controls.Add(this.lbl_DetalleDeLiq);
      this.panel1.Location = new System.Drawing.Point(426, 48);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(774, 284);
      this.panel1.TabIndex = 618;
      // 
      // pnl_ModificarEliminarDetalle
      // 
      this.pnl_ModificarEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
      this.pnl_ModificarEliminarDetalle.Controls.Add(this.btn_EliminarDetalle);
      this.pnl_ModificarEliminarDetalle.Controls.Add(this.txt_ModificarImporteLiqDetalle);
      this.pnl_ModificarEliminarDetalle.Controls.Add(this.btn_AceptarModifImporteLiqDetalle);
      this.pnl_ModificarEliminarDetalle.Controls.Add(this.chk_ModifcarImporteLiqDetalle);
      this.pnl_ModificarEliminarDetalle.Location = new System.Drawing.Point(4, 229);
      this.pnl_ModificarEliminarDetalle.Name = "pnl_ModificarEliminarDetalle";
      this.pnl_ModificarEliminarDetalle.Size = new System.Drawing.Size(458, 48);
      this.pnl_ModificarEliminarDetalle.TabIndex = 646;
      // 
      // btn_EliminarDetalle
      // 
      this.btn_EliminarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_EliminarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_EliminarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_EliminarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_EliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_EliminarDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_EliminarDetalle.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_EliminarDetalle.Image = global::AutoGestion.Properties.Resources.delete_24;
      this.btn_EliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_EliminarDetalle.Location = new System.Drawing.Point(305, 5);
      this.btn_EliminarDetalle.Name = "btn_EliminarDetalle";
      this.btn_EliminarDetalle.Size = new System.Drawing.Size(142, 35);
      this.btn_EliminarDetalle.TabIndex = 647;
      this.btn_EliminarDetalle.Text = "Eliminar Detalle";
      this.btn_EliminarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_EliminarDetalle.UseVisualStyleBackColor = true;
      this.btn_EliminarDetalle.Click += new System.EventHandler(this.btn_EliminarDetalle_Click);
      // 
      // txt_ModificarImporteLiqDetalle
      // 
      this.txt_ModificarImporteLiqDetalle.Enabled = false;
      this.txt_ModificarImporteLiqDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_ModificarImporteLiqDetalle.Location = new System.Drawing.Point(136, 11);
      this.txt_ModificarImporteLiqDetalle.Name = "txt_ModificarImporteLiqDetalle";
      this.txt_ModificarImporteLiqDetalle.Size = new System.Drawing.Size(76, 23);
      this.txt_ModificarImporteLiqDetalle.TabIndex = 647;
      this.txt_ModificarImporteLiqDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btn_AceptarModifImporteLiqDetalle
      // 
      this.btn_AceptarModifImporteLiqDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_AceptarModifImporteLiqDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_AceptarModifImporteLiqDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_AceptarModifImporteLiqDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_AceptarModifImporteLiqDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_AceptarModifImporteLiqDetalle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_AceptarModifImporteLiqDetalle.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_AceptarModifImporteLiqDetalle.Image = global::AutoGestion.Properties.Resources.check_24_px;
      this.btn_AceptarModifImporteLiqDetalle.Location = new System.Drawing.Point(216, 10);
      this.btn_AceptarModifImporteLiqDetalle.Name = "btn_AceptarModifImporteLiqDetalle";
      this.btn_AceptarModifImporteLiqDetalle.Size = new System.Drawing.Size(32, 25);
      this.btn_AceptarModifImporteLiqDetalle.TabIndex = 648;
      this.btn_AceptarModifImporteLiqDetalle.UseVisualStyleBackColor = true;
      this.btn_AceptarModifImporteLiqDetalle.Click += new System.EventHandler(this.btn_AceptarModifImporteLiqDetalle_Click);
      // 
      // chk_ModifcarImporteLiqDetalle
      // 
      this.chk_ModifcarImporteLiqDetalle.AutoSize = true;
      this.chk_ModifcarImporteLiqDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chk_ModifcarImporteLiqDetalle.ForeColor = System.Drawing.Color.Gainsboro;
      this.chk_ModifcarImporteLiqDetalle.Location = new System.Drawing.Point(8, 13);
      this.chk_ModifcarImporteLiqDetalle.Name = "chk_ModifcarImporteLiqDetalle";
      this.chk_ModifcarImporteLiqDetalle.Size = new System.Drawing.Size(122, 19);
      this.chk_ModifcarImporteLiqDetalle.TabIndex = 646;
      this.chk_ModifcarImporteLiqDetalle.Text = "Modificar Importe";
      this.chk_ModifcarImporteLiqDetalle.UseVisualStyleBackColor = true;
      this.chk_ModifcarImporteLiqDetalle.CheckedChanged += new System.EventHandler(this.chk_ModifcarImporteLiqDetalle_CheckedChanged);
      // 
      // txt_TotalLiq
      // 
      this.txt_TotalLiq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_TotalLiq.Location = new System.Drawing.Point(639, 231);
      this.txt_TotalLiq.Name = "txt_TotalLiq";
      this.txt_TotalLiq.Size = new System.Drawing.Size(130, 23);
      this.txt_TotalLiq.TabIndex = 645;
      this.txt_TotalLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.Gainsboro;
      this.label7.Location = new System.Drawing.Point(579, 234);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 17);
      this.label7.TabIndex = 644;
      this.label7.Text = "Total: ";
      // 
      // dgv_LiquidacionDetalle
      // 
      this.dgv_LiquidacionDetalle.AllowUserToAddRows = false;
      this.dgv_LiquidacionDetalle.AllowUserToDeleteRows = false;
      this.dgv_LiquidacionDetalle.AllowUserToResizeRows = false;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
      this.dgv_LiquidacionDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
      this.dgv_LiquidacionDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_LiquidacionDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
      this.dgv_LiquidacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_LiquidacionDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id2,
            this.dataGridViewTextBoxColumn2,
            this.Beneficiario,
            this.DNI,
            this.NroCuenta,
            this.dataGridViewTextBoxColumn4,
            this.Importe});
      this.dgv_LiquidacionDetalle.Location = new System.Drawing.Point(4, 26);
      this.dgv_LiquidacionDetalle.Name = "dgv_LiquidacionDetalle";
      this.dgv_LiquidacionDetalle.RowHeadersVisible = false;
      this.dgv_LiquidacionDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_LiquidacionDetalle.Size = new System.Drawing.Size(766, 197);
      this.dgv_LiquidacionDetalle.TabIndex = 643;
      this.dgv_LiquidacionDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LiquidacionDetalle_CellContentClick);
      this.dgv_LiquidacionDetalle.SelectionChanged += new System.EventHandler(this.dgv_LiquidacionDetalle_SelectionChanged);
      // 
      // Id2
      // 
      this.Id2.DataPropertyName = "Id";
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle9.NullValue = null;
      this.Id2.DefaultCellStyle = dataGridViewCellStyle9;
      this.Id2.HeaderText = "ID";
      this.Id2.Name = "Id2";
      this.Id2.ReadOnly = true;
      this.Id2.Width = 40;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FechaEmision";
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
      this.dataGridViewTextBoxColumn2.HeaderText = "Emision";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 110;
      // 
      // Beneficiario
      // 
      this.Beneficiario.DataPropertyName = "Beneficiario";
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.Beneficiario.DefaultCellStyle = dataGridViewCellStyle11;
      this.Beneficiario.HeaderText = "Beneficiario";
      this.Beneficiario.Name = "Beneficiario";
      this.Beneficiario.ReadOnly = true;
      this.Beneficiario.Width = 200;
      // 
      // DNI
      // 
      this.DNI.DataPropertyName = "DNI";
      dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle12.Format = "N2";
      this.DNI.DefaultCellStyle = dataGridViewCellStyle12;
      this.DNI.HeaderText = "DNI";
      this.DNI.Name = "DNI";
      this.DNI.Width = 75;
      // 
      // NroCuenta
      // 
      this.NroCuenta.DataPropertyName = "Cuenta";
      this.NroCuenta.HeaderText = "N° Cuenta";
      this.NroCuenta.Name = "NroCuenta";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "CBU";
      dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle13.Format = "N2";
      dataGridViewCellStyle13.NullValue = null;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
      this.dataGridViewTextBoxColumn4.HeaderText = "CBU";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 140;
      // 
      // Importe
      // 
      this.Importe.DataPropertyName = "Importe";
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle14.Format = "N2";
      this.Importe.DefaultCellStyle = dataGridViewCellStyle14;
      this.Importe.HeaderText = "Importe";
      this.Importe.Name = "Importe";
      this.Importe.Width = 80;
      // 
      // lbl_DetalleDeLiq
      // 
      this.lbl_DetalleDeLiq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.lbl_DetalleDeLiq.Dock = System.Windows.Forms.DockStyle.Top;
      this.lbl_DetalleDeLiq.Font = new System.Drawing.Font("Century Gothic", 11F);
      this.lbl_DetalleDeLiq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.lbl_DetalleDeLiq.Location = new System.Drawing.Point(0, 0);
      this.lbl_DetalleDeLiq.Name = "lbl_DetalleDeLiq";
      this.lbl_DetalleDeLiq.Size = new System.Drawing.Size(774, 23);
      this.lbl_DetalleDeLiq.TabIndex = 617;
      this.lbl_DetalleDeLiq.Text = "Detalle de Liquidacion";
      this.lbl_DetalleDeLiq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txt_DatoABuscar
      // 
      this.txt_DatoABuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_DatoABuscar.Location = new System.Drawing.Point(87, 68);
      this.txt_DatoABuscar.Name = "txt_DatoABuscar";
      this.txt_DatoABuscar.Size = new System.Drawing.Size(213, 23);
      this.txt_DatoABuscar.TabIndex = 640;
      this.txt_DatoABuscar.TextChanged += new System.EventHandler(this.txt_DatoABuscar_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Gainsboro;
      this.label3.Location = new System.Drawing.Point(6, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 17);
      this.label3.TabIndex = 641;
      this.label3.Text = "Buscar por:";
      // 
      // pnl_CrearLiquidacion
      // 
      this.pnl_CrearLiquidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.pnl_CrearLiquidacion.Controls.Add(this.label2);
      this.pnl_CrearLiquidacion.Controls.Add(this.btn_CancelarLiq);
      this.pnl_CrearLiquidacion.Controls.Add(this.btn_CrearLiquidacion);
      this.pnl_CrearLiquidacion.Controls.Add(this.txt_ReseñaLiquidacion);
      this.pnl_CrearLiquidacion.Controls.Add(this.label4);
      this.pnl_CrearLiquidacion.Controls.Add(this.txt_NroLiquidacion);
      this.pnl_CrearLiquidacion.Controls.Add(this.label5);
      this.pnl_CrearLiquidacion.Enabled = false;
      this.pnl_CrearLiquidacion.Location = new System.Drawing.Point(4, 356);
      this.pnl_CrearLiquidacion.Name = "pnl_CrearLiquidacion";
      this.pnl_CrearLiquidacion.Size = new System.Drawing.Size(400, 242);
      this.pnl_CrearLiquidacion.TabIndex = 642;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(400, 23);
      this.label2.TabIndex = 643;
      this.label2.Text = "Crear";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_CancelarLiq
      // 
      this.btn_CancelarLiq.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_CancelarLiq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CancelarLiq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_CancelarLiq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CancelarLiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_CancelarLiq.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_CancelarLiq.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_CancelarLiq.Image = global::AutoGestion.Properties.Resources.delete_24;
      this.btn_CancelarLiq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_CancelarLiq.Location = new System.Drawing.Point(274, 201);
      this.btn_CancelarLiq.Name = "btn_CancelarLiq";
      this.btn_CancelarLiq.Size = new System.Drawing.Size(117, 35);
      this.btn_CancelarLiq.TabIndex = 638;
      this.btn_CancelarLiq.Text = "Cancelar    ";
      this.btn_CancelarLiq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_CancelarLiq.UseVisualStyleBackColor = true;
      this.btn_CancelarLiq.Click += new System.EventHandler(this.btn_CancelarLiq_Click);
      // 
      // btn_CrearLiquidacion
      // 
      this.btn_CrearLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_CrearLiquidacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CrearLiquidacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_CrearLiquidacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_CrearLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_CrearLiquidacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_CrearLiquidacion.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_CrearLiquidacion.Image = global::AutoGestion.Properties.Resources.plus__1_;
      this.btn_CrearLiquidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_CrearLiquidacion.Location = new System.Drawing.Point(148, 201);
      this.btn_CrearLiquidacion.Name = "btn_CrearLiquidacion";
      this.btn_CrearLiquidacion.Size = new System.Drawing.Size(120, 35);
      this.btn_CrearLiquidacion.TabIndex = 637;
      this.btn_CrearLiquidacion.Text = "Crear          ";
      this.btn_CrearLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_CrearLiquidacion.UseVisualStyleBackColor = true;
      this.btn_CrearLiquidacion.Click += new System.EventHandler(this.btn_CrearLiquidacion_Click);
      // 
      // txt_ReseñaLiquidacion
      // 
      this.txt_ReseñaLiquidacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_ReseñaLiquidacion.Location = new System.Drawing.Point(3, 79);
      this.txt_ReseñaLiquidacion.Multiline = true;
      this.txt_ReseñaLiquidacion.Name = "txt_ReseñaLiquidacion";
      this.txt_ReseñaLiquidacion.Size = new System.Drawing.Size(391, 118);
      this.txt_ReseñaLiquidacion.TabIndex = 578;
      this.txt_ReseñaLiquidacion.TextChanged += new System.EventHandler(this.txt_ReseñaLiquidacion_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.Gainsboro;
      this.label4.Location = new System.Drawing.Point(8, 59);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 17);
      this.label4.TabIndex = 579;
      this.label4.Text = "Reseña: ";
      // 
      // txt_NroLiquidacion
      // 
      this.txt_NroLiquidacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_NroLiquidacion.Location = new System.Drawing.Point(39, 31);
      this.txt_NroLiquidacion.Name = "txt_NroLiquidacion";
      this.txt_NroLiquidacion.Size = new System.Drawing.Size(97, 23);
      this.txt_NroLiquidacion.TabIndex = 576;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Gainsboro;
      this.label5.Location = new System.Drawing.Point(11, 34);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 17);
      this.label5.TabIndex = 577;
      this.label5.Text = "N°: ";
      // 
      // pnl_AddBenefALiquidacion
      // 
      this.pnl_AddBenefALiquidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.pnl_AddBenefALiquidacion.Controls.Add(this.label6);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.txt_Importe);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.dgv_BuscarBenef);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.lbl_DatoABuscar);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.cbx_BuscarPor);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.label8);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.txt_DatoABuscar);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.btn_Agregar);
      this.pnl_AddBenefALiquidacion.Controls.Add(this.label3);
      this.pnl_AddBenefALiquidacion.Enabled = false;
      this.pnl_AddBenefALiquidacion.Location = new System.Drawing.Point(426, 356);
      this.pnl_AddBenefALiquidacion.Name = "pnl_AddBenefALiquidacion";
      this.pnl_AddBenefALiquidacion.Size = new System.Drawing.Size(575, 242);
      this.pnl_AddBenefALiquidacion.TabIndex = 645;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.Gainsboro;
      this.label6.Location = new System.Drawing.Point(373, 71);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 17);
      this.label6.TabIndex = 647;
      this.label6.Text = "Importe:";
      // 
      // txt_Importe
      // 
      this.txt_Importe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_Importe.Location = new System.Drawing.Point(442, 68);
      this.txt_Importe.Name = "txt_Importe";
      this.txt_Importe.Size = new System.Drawing.Size(126, 23);
      this.txt_Importe.TabIndex = 646;
      // 
      // dgv_BuscarBenef
      // 
      this.dgv_BuscarBenef.AllowUserToAddRows = false;
      this.dgv_BuscarBenef.AllowUserToDeleteRows = false;
      this.dgv_BuscarBenef.AllowUserToResizeRows = false;
      dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
      this.dgv_BuscarBenef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
      this.dgv_BuscarBenef.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_BuscarBenef.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
      this.dgv_BuscarBenef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_BuscarBenef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBenef,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.CBU,
            this.dataGridViewTextBoxColumn8});
      this.dgv_BuscarBenef.Location = new System.Drawing.Point(4, 97);
      this.dgv_BuscarBenef.Name = "dgv_BuscarBenef";
      this.dgv_BuscarBenef.RowHeadersVisible = false;
      this.dgv_BuscarBenef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_BuscarBenef.Size = new System.Drawing.Size(564, 136);
      this.dgv_BuscarBenef.TabIndex = 645;
      // 
      // IdBenef
      // 
      this.IdBenef.DataPropertyName = "Id";
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle17.NullValue = null;
      this.IdBenef.DefaultCellStyle = dataGridViewCellStyle17;
      this.IdBenef.HeaderText = "ID";
      this.IdBenef.Name = "IdBenef";
      this.IdBenef.ReadOnly = true;
      this.IdBenef.Width = 40;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "DNI";
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle18.Format = "N2";
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle18;
      this.dataGridViewTextBoxColumn6.HeaderText = "DNI";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Width = 80;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "ApeNom";
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle19;
      this.dataGridViewTextBoxColumn5.HeaderText = "Apellido Y Nombre";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 270;
      // 
      // CBU
      // 
      this.CBU.DataPropertyName = "CBU";
      dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle20.Format = "N2";
      dataGridViewCellStyle20.NullValue = null;
      this.CBU.DefaultCellStyle = dataGridViewCellStyle20;
      this.CBU.HeaderText = "CBU";
      this.CBU.Name = "CBU";
      this.CBU.ReadOnly = true;
      this.CBU.Width = 150;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "Importe";
      dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle21.Format = "N2";
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle21;
      this.dataGridViewTextBoxColumn8.HeaderText = "Importe";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Visible = false;
      this.dataGridViewTextBoxColumn8.Width = 80;
      // 
      // lbl_DatoABuscar
      // 
      this.lbl_DatoABuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_DatoABuscar.ForeColor = System.Drawing.Color.Gainsboro;
      this.lbl_DatoABuscar.Location = new System.Drawing.Point(9, 71);
      this.lbl_DatoABuscar.Name = "lbl_DatoABuscar";
      this.lbl_DatoABuscar.Size = new System.Drawing.Size(72, 17);
      this.lbl_DatoABuscar.TabIndex = 644;
      this.lbl_DatoABuscar.Text = "D.N.I.:";
      this.lbl_DatoABuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
      this.lbl_DatoABuscar.Click += new System.EventHandler(this.lbl_DatoABuscar_Click);
      // 
      // cbx_BuscarPor
      // 
      this.cbx_BuscarPor.BackColor = System.Drawing.Color.White;
      this.cbx_BuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbx_BuscarPor.Font = new System.Drawing.Font("Century Gothic", 9.5F);
      this.cbx_BuscarPor.ForeColor = System.Drawing.Color.Black;
      this.cbx_BuscarPor.FormattingEnabled = true;
      this.cbx_BuscarPor.Items.AddRange(new object[] {
            "D.N.I.",
            "Apellido"});
      this.cbx_BuscarPor.Location = new System.Drawing.Point(87, 36);
      this.cbx_BuscarPor.Name = "cbx_BuscarPor";
      this.cbx_BuscarPor.Size = new System.Drawing.Size(213, 25);
      this.cbx_BuscarPor.TabIndex = 643;
      this.cbx_BuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbx_BuscarPor_SelectedIndexChanged);
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.label8.Dock = System.Windows.Forms.DockStyle.Top;
      this.label8.Font = new System.Drawing.Font("Century Gothic", 11F);
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.label8.Location = new System.Drawing.Point(0, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(575, 23);
      this.label8.TabIndex = 642;
      this.label8.Text = "Agregar Beneficiario a  Liquidacion ";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_Agregar
      // 
      this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Agregar.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_Agregar.Image = global::AutoGestion.Properties.Resources.plus__1_;
      this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_Agregar.Location = new System.Drawing.Point(442, 31);
      this.btn_Agregar.Name = "btn_Agregar";
      this.btn_Agregar.Size = new System.Drawing.Size(126, 33);
      this.btn_Agregar.TabIndex = 639;
      this.btn_Agregar.Text = "Agregar        ";
      this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_Agregar.UseVisualStyleBackColor = true;
      this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
      // 
      // btn_Salir
      // 
      this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
      this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Salir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Salir.ForeColor = System.Drawing.Color.Gainsboro;
      this.btn_Salir.Image = global::AutoGestion.Properties.Resources.exit_door_PNG_24;
      this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_Salir.Location = new System.Drawing.Point(1075, 645);
      this.btn_Salir.Name = "btn_Salir";
      this.btn_Salir.Size = new System.Drawing.Size(120, 40);
      this.btn_Salir.TabIndex = 644;
      this.btn_Salir.Text = "Salir            ";
      this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_Salir.UseVisualStyleBackColor = true;
      this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
      // 
      // frm_Liquidacion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
      this.ClientSize = new System.Drawing.Size(1207, 697);
      this.Controls.Add(this.pnl_AddBenefALiquidacion);
      this.Controls.Add(this.btn_Salir);
      this.Controls.Add(this.pnl_CrearLiquidacion);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.pnl_LiquidacionesEmitidas);
      this.Controls.Add(this.label23);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frm_Liquidacion";
      this.Text = "frm_Liquidacion";
      this.Load += new System.EventHandler(this.frm_Liquidacion_Load);
      this.pnl_LiquidacionesEmitidas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Liquidaciones)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.pnl_ModificarEliminarDetalle.ResumeLayout(false);
      this.pnl_ModificarEliminarDetalle.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_LiquidacionDetalle)).EndInit();
      this.pnl_CrearLiquidacion.ResumeLayout(false);
      this.pnl_CrearLiquidacion.PerformLayout();
      this.pnl_AddBenefALiquidacion.ResumeLayout(false);
      this.pnl_AddBenefALiquidacion.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_BuscarBenef)).EndInit();
      this.ResumeLayout(false);

    }

   

    #endregion

    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Panel pnl_LiquidacionesEmitidas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lbl_DetalleDeLiq;
    private System.Windows.Forms.Button btn_Nuevo;
    private System.Windows.Forms.Button btn_Agregar;
    public System.Windows.Forms.TextBox txt_DatoABuscar;
    private System.Windows.Forms.Label label3;
    public System.Windows.Forms.DataGridView dgv_Liquidaciones;
    public DataGridView dgv_LiquidacionDetalle;
    private Panel pnl_CrearLiquidacion;
    private Button btn_CrearLiquidacion;
    public TextBox txt_ReseñaLiquidacion;
    private Label label4;
    public TextBox txt_NroLiquidacion;
    private Label label5;
    private Button btn_Salir;
    private Panel pnl_AddBenefALiquidacion;
    private Label label8;
    private Label lbl_DatoABuscar;
    private ComboBox cbx_BuscarPor;
    public DataGridView dgv_BuscarBenef;
    private Label label6;
    public TextBox txt_Importe;
    public TextBox txt_TotalLiq;
    private Label label7;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn FechaEmision;
    private DataGridViewTextBoxColumn Total;
    private DataGridViewTextBoxColumn EstadoString;
    private Button btn_CancelarLiq;
    private CheckBox chk_ModifcarImporteLiqDetalle;
    private Button btn_AceptarModifImporteLiqDetalle;
    public TextBox txt_ModificarImporteLiqDetalle;
    private Panel pnl_ModificarEliminarDetalle;
    private Button btn_EliminarDetalle;
    private Label label2;
    private DataGridViewTextBoxColumn IdBenef;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn CBU;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private Button btn_GenerarTXT;
    private Button btn_CerrarLiq;
    private DataGridViewTextBoxColumn Id2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn Beneficiario;
    private DataGridViewTextBoxColumn DNI;
    private DataGridViewTextBoxColumn NroCuenta;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn Importe;
  }
}