namespace CapaPresentacion
{
    partial class registrarCompra
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
            submenuregistrarcompra.Location = new Point(319, 227);
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(159, 20);
            submenuregistrarcompra.TabIndex = 0;
            submenuregistrarcompra.Text = "Formulario de Compra";
            // 
            // registrarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submenuregistrarcompra);
            Name = "registrarCompra";
            Text = "registrarCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label submenuregistrarcompra;
    }
}