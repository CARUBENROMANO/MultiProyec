﻿namespace CapaPresentacion
{
    partial class frmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label6 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            textfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            txtidproducto = new TextBox();
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precioProducto = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 0;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 9);
            label6.Name = "label6";
            label6.Size = new Size(1184, 674);
            label6.TabIndex = 15;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(82, 19);
            label9.Name = "label9";
            label9.Size = new Size(246, 35);
            label9.TabIndex = 32;
            label9.Text = "REGISTAR COMPRA";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(textfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(88, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 124);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra:";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.BackColor = Color.WhiteSmoke;
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(192, 57);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(216, 28);
            cbotipodocumento.TabIndex = 38;
            // 
            // textfecha
            // 
            textfecha.BackColor = Color.WhiteSmoke;
            textfecha.Location = new Point(13, 58);
            textfecha.Name = "textfecha";
            textfecha.Size = new Size(146, 27);
            textfecha.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 35;
            label3.Text = "Fecha : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(192, 23);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 36;
            label2.Text = "Tipo Documento : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(364, 23);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 36;
            label4.Text = "Razon Social : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnbuscar);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(553, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 124);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor:";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(582, 25);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(61, 27);
            txtidproveedor.TabIndex = 40;
            txtidproveedor.Visible = false;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.PowderBlue;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.White;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 25;
            btnbuscar.Location = new Point(256, 59);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(53, 26);
            btnbuscar.TabIndex = 40;
            btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.BackColor = Color.WhiteSmoke;
            txtnombreproveedor.Location = new Point(364, 58);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(279, 27);
            txtnombreproveedor.TabIndex = 38;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.BackColor = Color.WhiteSmoke;
            txtdocproveedor.Location = new Point(13, 58);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(225, 27);
            txtdocproveedor.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(182, 23);
            label5.TabIndex = 35;
            label5.Text = "Numero Documento : ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(88, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(987, 124);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion de Producto:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(837, 61);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(112, 27);
            numericUpDown1.TabIndex = 47;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(141, 23);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(53, 27);
            txtidproducto.TabIndex = 41;
            txtidproducto.Visible = false;
            // 
            // txtprecioventa
            // 
            txtprecioventa.BackColor = Color.WhiteSmoke;
            txtprecioventa.Location = new Point(670, 59);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(141, 27);
            txtprecioventa.TabIndex = 46;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.BackColor = Color.WhiteSmoke;
            txtpreciocompra.Location = new Point(516, 59);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(137, 27);
            txtpreciocompra.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(516, 23);
            label12.Name = "label12";
            label12.Size = new Size(137, 23);
            label12.TabIndex = 44;
            label12.Text = "Precio Compra : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(670, 23);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 43;
            label11.Text = "Precio Venta : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(833, 23);
            label10.Name = "label10";
            label10.Size = new Size(93, 23);
            label10.TabIndex = 42;
            label10.Text = "Cantidad : ";
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.BackColor = Color.PowderBlue;
            btnbuscarproducto.Cursor = Cursors.Hand;
            btnbuscarproducto.FlatAppearance.BorderColor = Color.Black;
            btnbuscarproducto.FlatStyle = FlatStyle.Flat;
            btnbuscarproducto.ForeColor = Color.White;
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 25;
            btnbuscarproducto.Location = new Point(212, 60);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(53, 26);
            btnbuscarproducto.TabIndex = 41;
            btnbuscarproducto.UseVisualStyleBackColor = false;
            // 
            // txtproducto
            // 
            txtproducto.BackColor = Color.WhiteSmoke;
            txtproducto.Location = new Point(271, 58);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(223, 27);
            txtproducto.TabIndex = 38;
            // 
            // txtcodproducto
            // 
            txtcodproducto.BackColor = Color.WhiteSmoke;
            txtcodproducto.Location = new Point(13, 58);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(181, 27);
            txtcodproducto.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 35;
            label7.Text = "Cod Producto : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(271, 23);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 36;
            label8.Text = "Producto : ";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, idProducto, producto, precioProducto, precioVenta, cantidad, subtotal });
            dgvdata.Location = new Point(88, 358);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvdata.RowTemplate.Height = 29;
            dgvdata.Size = new Size(987, 306);
            dgvdata.TabIndex = 40;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.Visible = false;
            idProducto.Width = 70;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 270;
            // 
            // precioProducto
            // 
            precioProducto.HeaderText = "Precio Producto";
            precioProducto.MinimumWidth = 6;
            precioProducto.Name = "precioProducto";
            precioProducto.ReadOnly = true;
            precioProducto.Width = 180;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio Venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.ReadOnly = true;
            precioVenta.Resizable = DataGridViewTriState.True;
            precioVenta.Visible = false;
            precioVenta.Width = 180;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 200;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Sub Total";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 150;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.PowderBlue;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1097, 223);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(117, 105);
            iconButton1.TabIndex = 41;
            iconButton1.Text = "AGREGAR";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 692);
            Controls.Add(iconButton1);
            Controls.Add(dgvdata);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "frmCompras";
            Text = "frmCompras";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label9;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private ComboBox cbotipodocumento;
        private TextBox textfecha;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtidproveedor;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox txtcodproducto;
        private Label label7;
        private Label label8;
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private TextBox txtidproducto;
        private NumericUpDown numericUpDown1;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioProducto;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subtotal;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}