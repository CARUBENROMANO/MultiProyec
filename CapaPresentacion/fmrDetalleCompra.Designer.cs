namespace CapaPresentacion
{
    partial class fmrDetalleCompra
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
            submenuregistrarcompra.Location = new Point(321, 215);
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(190, 20);
            submenuregistrarcompra.TabIndex = 1;
            submenuregistrarcompra.Text = "Formulario Detalle Compra";
            // 
            // fmrDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submenuregistrarcompra);
            Name = "fmrDetalleCompra";
            Text = "fmrDetalleCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label submenuregistrarcompra;
    }
}