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
    public partial class Frm_AgregarProducto : Form
    {
        public Frm_AgregarProducto()
        {
            InitializeComponent();
        }
        private void Frm_AgregarProducto_Load(objetc sender, EventArgs e)
        {

        }
        private void button1_click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Id = int.parse(txtid.Text);
            p.Precio = decimal.Parse(textBox3.Text.ToString("F2"));
            p.Nombre = txtNombre.Text;
            RepositorioGlobal.repositorio.Add(p);
            MessageBOx.Show(p.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
