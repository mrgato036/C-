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
    public partial class Frml_Principal : Form
    {
        Producto SelectedProduct;

        public Frml_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Frm_AgregarProducto frm = new Frm_AgregarProducto())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cargargrilla();
                    MessageBOx.Show("Producto agregado con exito.")
                }
            }
        }
        public void cargargrilla()
        {
            grilla.DataSource=null;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.allowUserToOrderColumns = false;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.DataSource=RepositorioGlobal.repositorio.ToList();
        }
        private void Frm_AgregarProducto_Load(object sender, EventArgs e)
        {
            cargargrilla();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (grilla.SelectedRows.Count > 0)
            {
            
                DataGridViewRow row = grilla.SelectedRows[0];

                Producto SelectedProduct = new Producto
            {
                Id=int.Parse(row.Cells["Id"].Value.ToString());
                Nombre=  row.Cells["Nombre"].Value.ToString();
                Precio=Decimal.Parse(row.Cells["Precio"].Value.ToString());
            };
        }    
            using(Frm_ModificarProducto frm = new Frm_ModificarProducto(SelectedProduct))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cargargrilla();
                    MessageBOx.Show("Producto modificado con exito.")
                }
            }
            }  
        }
        
    }
    private void button3_Click(objetc sender, EventArgs e)
    {
        if (grilla.SelectedRows.Count > 0)
        {
            DataGridViewRow row = grilla.selectedRows[0];

 
            int  id = int.Parse(row.Cells["Id"].Value.ToString()); 
            Producto p=RepositorioGlobal.repositorio.FirstOrDefault(pr => pr.Id ==id)
            RepositorioGlobal.repositorio.Remove(p);
            cargargrilla();
            MessageBox.Show("Producto modificado con exito. ")
        }                
}
    
    