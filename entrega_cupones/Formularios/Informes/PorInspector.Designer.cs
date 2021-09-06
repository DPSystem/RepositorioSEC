
namespace entrega_cupones.Formularios.Informes
{
  partial class PorInspector
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
      this.dgv1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv1
      // 
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Location = new System.Drawing.Point(24, 53);
      this.dgv1.Name = "dgv1";
      this.dgv1.Size = new System.Drawing.Size(927, 370);
      this.dgv1.TabIndex = 0;
      // 
      // PorInspector
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(985, 496);
      this.Controls.Add(this.dgv1);
      this.Name = "PorInspector";
      this.Text = "PorInspector";
      this.Load += new System.EventHandler(this.PorInspector_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv1;
  }
}