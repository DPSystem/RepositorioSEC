
namespace entrega_cupones.Formularios
{
  partial class frm_ActaBuscar
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
      this.btn_VerVD = new System.Windows.Forms.Button();
      this.dgv_Actas = new System.Windows.Forms.DataGridView();
      this.label23 = new System.Windows.Forms.Label();
      this.NroActa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.VD_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Actas)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_VerVD
      // 
      this.btn_VerVD.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_VerVD.Location = new System.Drawing.Point(716, 277);
      this.btn_VerVD.Name = "btn_VerVD";
      this.btn_VerVD.Size = new System.Drawing.Size(82, 38);
      this.btn_VerVD.TabIndex = 609;
      this.btn_VerVD.Text = "Ver Acta";
      this.btn_VerVD.UseVisualStyleBackColor = true;
      this.btn_VerVD.Click += new System.EventHandler(this.btn_VerVD_Click);
      // 
      // dgv_Actas
      // 
      this.dgv_Actas.AllowUserToAddRows = false;
      this.dgv_Actas.AllowUserToDeleteRows = false;
      this.dgv_Actas.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      this.dgv_Actas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv_Actas.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Actas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgv_Actas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Actas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroActa,
            this.Fecha,
            this.Cuit,
            this.RazonSocial,
            this.Desde,
            this.Hasta,
            this.Importe,
            this.VD_Estado});
      this.dgv_Actas.Location = new System.Drawing.Point(4, 30);
      this.dgv_Actas.Name = "dgv_Actas";
      this.dgv_Actas.RowHeadersVisible = false;
      this.dgv_Actas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Actas.Size = new System.Drawing.Size(794, 241);
      this.dgv_Actas.TabIndex = 608;
      // 
      // label23
      // 
      this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(151)))), ((int)(((byte)(119)))));
      this.label23.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
      this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.label23.Location = new System.Drawing.Point(4, 3);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(794, 23);
      this.label23.TabIndex = 610;
      this.label23.Text = "Listado de Actas Emitidas ";
      this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // NroActa
      // 
      this.NroActa.DataPropertyName = "NroActa";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.NullValue = null;
      this.NroActa.DefaultCellStyle = dataGridViewCellStyle3;
      this.NroActa.HeaderText = "Numero";
      this.NroActa.Name = "NroActa";
      this.NroActa.ReadOnly = true;
      this.NroActa.Width = 70;
      // 
      // Fecha
      // 
      this.Fecha.DataPropertyName = "Fecha";
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
      this.Fecha.HeaderText = "Fecha";
      this.Fecha.Name = "Fecha";
      this.Fecha.ReadOnly = true;
      this.Fecha.Width = 80;
      // 
      // Cuit
      // 
      this.Cuit.DataPropertyName = "Cuit";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle5.Format = "N2";
      dataGridViewCellStyle5.NullValue = null;
      this.Cuit.DefaultCellStyle = dataGridViewCellStyle5;
      this.Cuit.HeaderText = "CUIT";
      this.Cuit.Name = "Cuit";
      this.Cuit.ReadOnly = true;
      // 
      // RazonSocial
      // 
      this.RazonSocial.DataPropertyName = "RazonSocial";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle6;
      this.RazonSocial.HeaderText = "Empresa";
      this.RazonSocial.Name = "RazonSocial";
      this.RazonSocial.ReadOnly = true;
      this.RazonSocial.Width = 300;
      // 
      // Desde
      // 
      this.Desde.DataPropertyName = "Desde";
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Desde.DefaultCellStyle = dataGridViewCellStyle7;
      this.Desde.HeaderText = "Desde";
      this.Desde.Name = "Desde";
      this.Desde.ReadOnly = true;
      this.Desde.Width = 70;
      // 
      // Hasta
      // 
      this.Hasta.DataPropertyName = "Hasta";
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Hasta.DefaultCellStyle = dataGridViewCellStyle8;
      this.Hasta.HeaderText = "Hasta";
      this.Hasta.Name = "Hasta";
      this.Hasta.ReadOnly = true;
      this.Hasta.Width = 70;
      // 
      // Importe
      // 
      this.Importe.DataPropertyName = "Importe";
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle9.Format = "N2";
      dataGridViewCellStyle9.NullValue = null;
      this.Importe.DefaultCellStyle = dataGridViewCellStyle9;
      this.Importe.HeaderText = "Importe";
      this.Importe.Name = "Importe";
      this.Importe.ReadOnly = true;
      this.Importe.Width = 80;
      // 
      // VD_Estado
      // 
      this.VD_Estado.DataPropertyName = "Estado";
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle10.Format = "N2";
      dataGridViewCellStyle10.NullValue = null;
      this.VD_Estado.DefaultCellStyle = dataGridViewCellStyle10;
      this.VD_Estado.HeaderText = "Estado";
      this.VD_Estado.Name = "VD_Estado";
      this.VD_Estado.ReadOnly = true;
      this.VD_Estado.Visible = false;
      // 
      // frm_ActaBuscar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.ClientSize = new System.Drawing.Size(802, 319);
      this.Controls.Add(this.label23);
      this.Controls.Add(this.btn_VerVD);
      this.Controls.Add(this.dgv_Actas);
      this.Name = "frm_ActaBuscar";
      this.Text = "frm_ActaBuscar";
      this.Load += new System.EventHandler(this.frm_ActaBuscar_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Actas)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_VerVD;
    public System.Windows.Forms.DataGridView dgv_Actas;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.DataGridViewTextBoxColumn NroActa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
    private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
    private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
    private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
    private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    private System.Windows.Forms.DataGridViewTextBoxColumn VD_Estado;
  }
}