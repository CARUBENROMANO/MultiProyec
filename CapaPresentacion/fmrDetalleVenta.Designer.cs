namespace CapaPresentacion
{
    partial class fmrDetalleVenta
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
            submenuregistrarcompra = new Label();
            SuspendLayout();
            // 
            // submenuregistrarcompra
            // 
            submenuregistrarcompra.AutoSize = true;
            submenuregistrarcompra.Location = new Point(344, 215);
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(118, 20);
            submenuregistrarcompra.TabIndex = 2;
            submenuregistrarcompra.Text = "Detalle de venta";
            // 
            // fmrDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submenuregistrarcompra);
            Name = "fmrDetalleVenta";
            Text = "fmrDetalleVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label submenuregistrarcompra;
    }
}