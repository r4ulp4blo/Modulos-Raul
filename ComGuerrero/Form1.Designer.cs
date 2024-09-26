namespace Comercial_Guerrero
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.TabPage tabReportesPagos;
        private System.Windows.Forms.TabPage tabReportesProveedores;

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Button btnAgregarInventario;
        private System.Windows.Forms.DataGridView dgvInventario;

        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtDescripcionPago;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.DataGridView dgvPagos;

        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtProductosProveedor;
        private System.Windows.Forms.TextBox txtUnidadesProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabInventario = new TabPage();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtProducto = new TextBox();
            txtDescripcion = new TextBox();
            txtCategoria = new TextBox();
            txtPrecioUnitario = new TextBox();
            btnAgregarInventario = new Button();
            dgvInventario = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabReportesPagos = new TabPage();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtIdPago = new TextBox();
            txtEmpresa = new TextBox();
            txtDescripcionPago = new TextBox();
            txtCantidad = new TextBox();
            txtPago = new TextBox();
            btnAgregarPago = new Button();
            dgvPagos = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            tabReportesProveedores = new TabPage();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txtIdProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            dtpFechaEntrega = new DateTimePicker();
            txtProductosProveedor = new TextBox();
            txtUnidadesProveedor = new TextBox();
            btnAgregarProveedor = new Button();
            dgvProveedores = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel6 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            tabControl.SuspendLayout();
            tabInventario.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            tabReportesPagos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            tabReportesProveedores.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabInventario);
            tabControl.Controls.Add(tabReportesPagos);
            tabControl.Controls.Add(tabReportesProveedores);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1037, 695);
            tabControl.TabIndex = 0;
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(panel4);
            tabInventario.Controls.Add(label1);
            tabInventario.Controls.Add(panel1);
            tabInventario.Controls.Add(txtProducto);
            tabInventario.Controls.Add(txtDescripcion);
            tabInventario.Controls.Add(txtCategoria);
            tabInventario.Controls.Add(txtPrecioUnitario);
            tabInventario.Controls.Add(btnAgregarInventario);
            tabInventario.Controls.Add(dgvInventario);
            tabInventario.Location = new Point(4, 29);
            tabInventario.Name = "tabInventario";
            tabInventario.Size = new Size(1029, 662);
            tabInventario.TabIndex = 0;
            tabInventario.Text = "Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 120);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 11;
            label1.Text = "Inventario";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 79, 59);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 662);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(314, 190);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(200, 27);
            txtProducto.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(314, 230);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(314, 270);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(200, 27);
            txtCategoria.TabIndex = 5;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(314, 310);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(200, 27);
            txtPrecioUnitario.TabIndex = 7;
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Location = new Point(314, 350);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(75, 30);
            btnAgregarInventario.TabIndex = 8;
            btnAgregarInventario.Text = "Agregar";
            btnAgregarInventario.Click += BtnAgregarInventario_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeight = 29;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvInventario.Location = new Point(296, 423);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(600, 200);
            dgvInventario.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // tabReportesPagos
            // 
            tabReportesPagos.Controls.Add(panel5);
            tabReportesPagos.Controls.Add(label2);
            tabReportesPagos.Controls.Add(panel2);
            tabReportesPagos.Controls.Add(txtIdPago);
            tabReportesPagos.Controls.Add(txtEmpresa);
            tabReportesPagos.Controls.Add(txtDescripcionPago);
            tabReportesPagos.Controls.Add(txtCantidad);
            tabReportesPagos.Controls.Add(txtPago);
            tabReportesPagos.Controls.Add(btnAgregarPago);
            tabReportesPagos.Controls.Add(dgvPagos);
            tabReportesPagos.Location = new Point(4, 29);
            tabReportesPagos.Name = "tabReportesPagos";
            tabReportesPagos.Size = new Size(1029, 662);
            tabReportesPagos.TabIndex = 1;
            tabReportesPagos.Text = "Reporte de Pagos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(315, 102);
            label2.Name = "label2";
            label2.Size = new Size(246, 38);
            label2.TabIndex = 13;
            label2.Text = "Reporte de Pagos";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 79, 59);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 662);
            panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(315, 181);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(200, 27);
            txtIdPago.TabIndex = 1;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(315, 221);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(200, 27);
            txtEmpresa.TabIndex = 3;
            // 
            // txtDescripcionPago
            // 
            txtDescripcionPago.Location = new Point(315, 261);
            txtDescripcionPago.Name = "txtDescripcionPago";
            txtDescripcionPago.Size = new Size(200, 27);
            txtDescripcionPago.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(315, 301);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 27);
            txtCantidad.TabIndex = 7;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(315, 341);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(200, 27);
            txtPago.TabIndex = 9;
            // 
            // btnAgregarPago
            // 
            btnAgregarPago.Location = new Point(315, 381);
            btnAgregarPago.Name = "btnAgregarPago";
            btnAgregarPago.Size = new Size(75, 31);
            btnAgregarPago.TabIndex = 10;
            btnAgregarPago.Text = "Agregar";
            btnAgregarPago.Click += BtnAgregarPago_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeight = 29;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dgvPagos.Location = new Point(315, 440);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 51;
            dgvPagos.Size = new Size(600, 200);
            dgvPagos.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Empresa";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Descripción";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Pago";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // tabReportesProveedores
            // 
            tabReportesProveedores.Controls.Add(panel6);
            tabReportesProveedores.Controls.Add(label3);
            tabReportesProveedores.Controls.Add(panel3);
            tabReportesProveedores.Controls.Add(txtIdProveedor);
            tabReportesProveedores.Controls.Add(txtNombreProveedor);
            tabReportesProveedores.Controls.Add(dtpFechaEntrega);
            tabReportesProveedores.Controls.Add(txtProductosProveedor);
            tabReportesProveedores.Controls.Add(txtUnidadesProveedor);
            tabReportesProveedores.Controls.Add(btnAgregarProveedor);
            tabReportesProveedores.Controls.Add(dgvProveedores);
            tabReportesProveedores.Location = new Point(4, 29);
            tabReportesProveedores.Name = "tabReportesProveedores";
            tabReportesProveedores.Size = new Size(1029, 662);
            tabReportesProveedores.TabIndex = 2;
            tabReportesProveedores.Text = "Reporte de Proveedores";
            tabReportesProveedores.Click += tabReportesProveedores_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 93);
            label3.Name = "label3";
            label3.Size = new Size(331, 38);
            label3.TabIndex = 14;
            label3.Text = "Reporte de Proveedores";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 79, 59);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 662);
            panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(316, 173);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(200, 27);
            txtIdProveedor.TabIndex = 1;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(316, 213);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(200, 27);
            txtNombreProveedor.TabIndex = 3;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(316, 253);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 27);
            dtpFechaEntrega.TabIndex = 5;
            // 
            // txtProductosProveedor
            // 
            txtProductosProveedor.Location = new Point(316, 293);
            txtProductosProveedor.Name = "txtProductosProveedor";
            txtProductosProveedor.Size = new Size(200, 27);
            txtProductosProveedor.TabIndex = 7;
            // 
            // txtUnidadesProveedor
            // 
            txtUnidadesProveedor.Location = new Point(316, 333);
            txtUnidadesProveedor.Name = "txtUnidadesProveedor";
            txtUnidadesProveedor.Size = new Size(200, 27);
            txtUnidadesProveedor.TabIndex = 9;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(316, 373);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(75, 33);
            btnAgregarProveedor.TabIndex = 10;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeight = 29;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            dgvProveedores.Location = new Point(316, 439);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(600, 200);
            dgvProveedores.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "ID";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Nombre";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Fecha Entrega";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Productos";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Unidades";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 125;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(247, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(782, 57);
            panel4.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Location = new Point(1174, 5);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Location = new Point(1234, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Location = new Point(1282, 4);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(pictureBox8);
            panel5.Controls.Add(pictureBox9);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(247, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(782, 57);
            panel5.TabIndex = 14;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.Location = new Point(1174, 5);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 41);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox8.Location = new Point(1234, 4);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox9.Location = new Point(1282, 4);
            pictureBox9.Margin = new Padding(0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 43);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(pictureBox10);
            panel6.Controls.Add(pictureBox11);
            panel6.Controls.Add(pictureBox12);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(247, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(782, 57);
            panel6.TabIndex = 15;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox10.Location = new Point(1174, 5);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(53, 41);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 2;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox11.Location = new Point(1234, 4);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(45, 43);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox12.Location = new Point(1282, 4);
            pictureBox12.Margin = new Padding(0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(38, 43);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(1037, 695);
            Controls.Add(tabControl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comercial Guerrero";
            tabControl.ResumeLayout(false);
            tabInventario.ResumeLayout(false);
            tabInventario.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            tabReportesPagos.ResumeLayout(false);
            tabReportesPagos.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            tabReportesProveedores.ResumeLayout(false);
            tabReportesProveedores.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Panel panel6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
    }
}
