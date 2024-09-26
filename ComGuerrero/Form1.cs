using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Comercial_Guerrero
{
    public partial class Form1 : Form
    {
        private List<InventarioItem> inventarioItems = new List<InventarioItem>();
        private List<PagoItem> pagoItems = new List<PagoItem>();
        private List<ProveedorItem> proveedorItems = new List<ProveedorItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            var item = new InventarioItem
            {
                Producto = txtProducto.Text,
                Descripcion = txtDescripcion.Text,
                Categoria = txtCategoria.Text,
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text)
            };

            inventarioItems.Add(item);
            UpdateInventarioTable();
            ClearInventarioFields();
        }

        private void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            var item = new PagoItem
            {
                Id = int.Parse(txtIdPago.Text),
                Empresa = txtEmpresa.Text,
                Descripcion = txtDescripcionPago.Text,
                Cantidad = decimal.Parse(txtCantidad.Text),
                Pago = decimal.Parse(txtPago.Text)
            };

            pagoItems.Add(item);
            UpdatePagosTable();
            ClearPagoFields();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            var item = new ProveedorItem
            {
                Id = int.Parse(txtIdProveedor.Text),
                Nombre = txtNombreProveedor.Text,
                FechaEntrega = dtpFechaEntrega.Value,
                Productos = txtProductosProveedor.Text,
                Unidades = int.Parse(txtUnidadesProveedor.Text)
            };

            proveedorItems.Add(item);
            UpdateProveedoresTable();
            ClearProveedorFields();
        }

        private void UpdateInventarioTable()
        {
            dgvInventario.Rows.Clear();
            foreach (var item in inventarioItems)
            {
                dgvInventario.Rows.Add(item.Producto, item.Descripcion, item.Categoria, item.PrecioUnitario);
            }
        }

        private void UpdatePagosTable()
        {
            dgvPagos.Rows.Clear();
            foreach (var item in pagoItems)
            {
                dgvPagos.Rows.Add(item.Id, item.Empresa, item.Descripcion, item.Cantidad, item.Pago);
            }
        }

        private void UpdateProveedoresTable()
        {
            dgvProveedores.Rows.Clear();
            foreach (var item in proveedorItems)
            {
                dgvProveedores.Rows.Add(item.Id, item.Nombre, item.FechaEntrega.ToShortDateString(), item.Productos, item.Unidades);
            }
        }

        private void ClearInventarioFields()
        {
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtCategoria.Clear();
            txtPrecioUnitario.Clear();
        }

        private void ClearPagoFields()
        {
            txtIdPago.Clear();
            txtEmpresa.Clear();
            txtDescripcionPago.Clear();
            txtCantidad.Clear();
            txtPago.Clear();
        }

        private void ClearProveedorFields()
        {
            txtIdProveedor.Clear();
            txtNombreProveedor.Clear();
            dtpFechaEntrega.Value = DateTime.Now;
            txtProductosProveedor.Clear();
            txtUnidadesProveedor.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabReportesProveedores_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class InventarioItem
    {
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

    public class PagoItem
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Pago { get; set; }
    }

    public class ProveedorItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Productos { get; set; }
        public int Unidades { get; set; }
    }
}
