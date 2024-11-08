using BE;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Task;
using System.Windows.Forms;

namespace ejemplo_1_7_mo
{
    public partial class Frm_ModificarProducto : Form
    {
        Producto p;
        public Frm_ModificarProducto(Producto SelectedProduct)
        {
            InitializeComponent();

            if (SelectedProduct == null)
            {
                MessageBox.Show("No se ha seleccionado ningun producto para editar.", "Error", MessageBox);
                this.Close();
                return;
            }
            p = selectedProduct;
            mostrarvalores();
        }
        public void mostrarvalores()
        {
            txtId.Text=p.Id.ToString();
            txtNombre.Text=p.Nombre;
            txtPrecio.Text=p.Precio.ToString("F2")
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            p.Nombre = txtNombre.Text;
            p.Precio = Decimal.Parse(txtPrecio.text);
            int a=RepositorioGlobal.repositorio.findIndex(p => p.Id == int.Parse(txtid.Text));
            RepositorioGlobal.repositorio[a]=p;
            MessageBox.Show(p.ToString());
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {
            p = SelectedProduct;
            mostrarvalores();
        }
    }
}