using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data.SqlClient;
using System.Configuration;
using Entidad;
using Entidad2;
using Entidad3;
using Entidad4;
using Negocio;
using System.IO;
using System.Drawing.Imaging;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        C_Entidad objEntidad = new C_Entidad();
        C_Entidad2 objEntidad2 = new C_Entidad2();
        C_Entidad3 objEntidad3 = new C_Entidad3();
        C_Entidad4 objEntidad4 = new C_Entidad4();
        C_Negocio objNegocio = new C_Negocio();
        C_Datos objDato = new C_Datos();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            PBEncabezado.Image = Image.FromFile(@"C:\Users\MASan\source\repos\Pets\Presentacion\Resources\huellas-de-garras (3).png");
            PBEncabezado.SizeMode = PictureBoxSizeMode.Zoom;
            txtEncabezado.Text = "Animales";

            TablaEquipamiento.SelectTab(tabPage: tabPage);


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            PBEncabezado.Image = Image.FromFile(@"C:\Users\MASan\source\repos\Pets\Presentacion\Resources\usuario.png");
            PBEncabezado.SizeMode = PictureBoxSizeMode.Zoom;
            txtEncabezado.Text = "Clientes";
            TablaEquipamiento.SelectTab(tabPage: tabPage2);


        }

        private void btnComidas_Click(object sender, EventArgs e)
        {
            PBEncabezado.Image = Image.FromFile(@"C:\Users\MASan\source\repos\Pets\Presentacion\Resources\comida-de-perro.png");
            PBEncabezado.SizeMode = PictureBoxSizeMode.Zoom;
            txtEncabezado.Text = "Comidas de Animales";
            TablaEquipamiento.SelectTab(tabPage: tabPage3);

        }

        private void btnEquipamiento_Click(object sender, EventArgs e)
        {
            PBEncabezado.Image = Image.FromFile(@"C:\Users\MASan\source\repos\Pets\Presentacion\Resources\collar-de-perro.png");
            PBEncabezado.SizeMode = PictureBoxSizeMode.Zoom;
            txtEncabezado.Text = "Equipamientos para Animales";
            TablaEquipamiento.SelectTab(tabPage: tabPage4);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void mostrarBuscarTabla(string buscar)
        {

            TablaAnimales.DataSource = objNegocio.ListandoAnimales(buscar);
            TablaClientes.DataSource = objNegocio.ListandoClientes(buscar);
            TablaComidas.DataSource = objNegocio.ListandoComidas(buscar);
            TablaEquip.DataSource = objNegocio.ListandoEquipamiento(buscar);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TablaEquipamiento.SelectedTab == tabPage)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage5);

            }
            if (TablaEquipamiento.SelectedTab == tabPage2)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage6);
            }
            if (TablaEquipamiento.SelectedTab == tabPage3)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage7);
            }
            if (TablaEquipamiento.SelectedTab == tabPage4)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage8);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objEntidad.Nombre = txtNombreAnimales.Text;
            objEntidad.TIPO = CBTipoAnimales.Text;
            objEntidad.RAZA = txtRazaAnimales.Text;
            objEntidad.DUEÑO = txtDuenoAnimales.Text;
            objEntidad.PROBLEMA = txtProblemaAnimales.Text;

            objNegocio.InsertandoAnimales(objEntidad);
            MessageBox.Show("Mascota agregada correctamente.");
            mostrarBuscarTabla("");

        }
        public void limpiarAnimales()
        {
            txtNombreAnimales.Text = "";
            txtRazaAnimales.Text = "";
            txtProblemaAnimales.Text = "";
            txtDuenoAnimales.Text = "";
            CBTipoAnimales.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarAnimales();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            objEntidad2.NOMBRE = txtNombreClientes.Text;
            objEntidad2.APELLIDO = txtApellidoClientes.Text;
            objEntidad2.CEDULA = txtCedulaClientes.Text;
            objEntidad2.MASCOTA = txtMascotaClientes.Text;
            objEntidad2.FECHAREGISTRO = txtFechaRegistroCliente.Text;
            objEntidad2.CORREO = txtCorreoCliente.Text;
            objEntidad2.TELEFONO = txtTelefonoCliente.Text;


            objNegocio.InsertandoClientes(objEntidad2);
            MessageBox.Show("Cliente agregado correctamente.");
            mostrarBuscarTabla("");
        }
        public void limpiarcliente()
        {
            txtNombreClientes.Text = "";
            txtApellidoClientes.Text = "";
            txtCedulaClientes.Text = "";
            txtCorreoCliente.Text = "";
            txtFechaRegistroCliente.Text = "";
            txtMascotaClientes.Text = "";
            txtTelefonoCliente.Text = "";
        }

        private void btnLimpiarClinete_Click(object sender, EventArgs e)
        {
            limpiarcliente();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objEntidad3.NOMBRE = txtNombreComidas.Text;
            objEntidad3.MARCA = txtMarcaComidas.Text;
            objEntidad3.PRECIO = Convert.ToInt32(txtPrecioComidas.Text);
            objEntidad3.CANTIDAD = txtCantidadComidas.Text;
            objNegocio.InsertandoComidas(objEntidad3);
            MessageBox.Show("Comida agregada correctamente");
            mostrarBuscarTabla("");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            objEntidad4.NOMBRE = txtNombreEquipamiento.Text;
            objEntidad4.MARCA = txtMarcaEquipamiento.Text;
            objEntidad4.COLOR = txtColorEquipamiento.Text;
            objEntidad4.PRECIO = Convert.ToInt32(txtPrecioEquipamiento.Text);
            objNegocio.InsertandoEquipaminetos(objEntidad4);
            MessageBox.Show("Datos agregados correctamente");
            mostrarBuscarTabla("");
        }
        public void limpiarComidas()
        {
            txtNombreComidas.Text = "";
            txtMarcaComidas.Text = "";
            txtCantidadComidas.Text = "";
            txtPrecioComidas.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiarComidas();
        }

        public void limpiarEquipamiento()
        {
            txtNombreEquipamiento.Text = "";
            txtMarcaEquipamiento.Text = "";
            txtPrecioEquipamiento.Text = "";
            txtColorEquipamiento.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            limpiarEquipamiento();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desa Editar esta mascota?", "Advertencia", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                objEntidad.IDANIMALES = Convert.ToInt32(txtIDanimales.Text);
                objEntidad.Nombre = txtEditarANombre.Text;
                objEntidad.TIPO = txtEditarATipo.Text;
                objEntidad.RAZA = txtEditarARaza.Text;
                objEntidad.DUEÑO = txtEditarADueno.Text;
                objEntidad.PROBLEMA = txtEditarAProblema.Text;
                objNegocio.EditandoAnimales(objEntidad);
                MessageBox.Show("Cambios guardados correctamente");
                mostrarBuscarTabla("");
                limpiarAnimales();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaEquipamiento.SelectedTab == tabPage)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage9);
                if (TablaAnimales.SelectedRows.Count > 0)
                {
                    txtIDanimales.Text = TablaAnimales.CurrentRow.Cells[0].Value.ToString();
                    txtEditarANombre.Text = TablaAnimales.CurrentRow.Cells[1].Value.ToString();
                    txtEditarATipo.Text = TablaAnimales.CurrentRow.Cells[2].Value.ToString();
                    txtEditarARaza.Text = TablaAnimales.CurrentRow.Cells[3].Value.ToString();
                    txtEditarADueno.Text = TablaAnimales.CurrentRow.Cells[4].Value.ToString();
                    txtEditarAProblema.Text = TablaAnimales.CurrentRow.Cells[5].Value.ToString();

                }
            }

            if (TablaEquipamiento.SelectedTab == tabPage2)
            {
                if (TablaClientes.SelectedRows.Count > 0)
                {
                    objEntidad2.IDCLIENTE = Convert.ToInt32(TablaClientes.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminandoClientes(objEntidad2);
                    MessageBox.Show("Registro Eliminado Correctamente");
                    mostrarBuscarTabla("");
                }
            }


            if (TablaEquipamiento.SelectedTab == tabPage2)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage10);
                if (TablaClientes.SelectedRows.Count > 0)
                {
                    txtIDClientes.Text = TablaClientes.CurrentRow.Cells[0].Value.ToString();
                    txtEditarCNombre.Text = TablaClientes.CurrentRow.Cells[1].Value.ToString();
                    txtEditarCApellido.Text = TablaClientes.CurrentRow.Cells[2].Value.ToString();
                    txtEditarCCedula.Text = TablaClientes.CurrentRow.Cells[3].Value.ToString();
                    txtEditarCMascota.Text = TablaClientes.CurrentRow.Cells[4].Value.ToString();
                    txtEditarCFechaRegistro.Text = TablaClientes.CurrentRow.Cells[5].Value.ToString();
                    txtEditarCCorreo.Text = TablaClientes.CurrentRow.Cells[6].Value.ToString();
                    txtEditarCTelefono.Text = TablaClientes.CurrentRow.Cells[7].Value.ToString();
                }
            }
            if (TablaEquipamiento.SelectedTab == tabPage3)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage11);
                if (TablaComidas.SelectedRows.Count > 0)
                {
                    txtIDComidas.Text = TablaComidas.CurrentRow.Cells[0].Value.ToString();
                    txtEditarCoNombre.Text = TablaComidas.CurrentRow.Cells[1].Value.ToString();
                    txtEditarCoMarca.Text = TablaComidas.CurrentRow.Cells[2].Value.ToString();
                    txtEditarCoPrecio.Text = TablaComidas.CurrentRow.Cells[3].Value.ToString();
                    txtEditarCoCantidad.Text = TablaComidas.CurrentRow.Cells[4].Value.ToString();
                }
            }
            if (TablaEquipamiento.SelectedTab == tabPage4)
            {
                TablaEquipamiento.SelectTab(tabPage: tabPage12);
                if (TablaEquip.SelectedRows.Count > 0)
                {
                    txtIDEquipamiento.Text = TablaEquip.CurrentRow.Cells[0].Value.ToString();
                    txtEditarENombre.Text = TablaEquip.CurrentRow.Cells[1].Value.ToString();
                    txtEditarEMarca.Text = TablaEquip.CurrentRow.Cells[2].Value.ToString();
                    txtEditarEColor.Text = TablaEquip.CurrentRow.Cells[3].Value.ToString();
                    txtEditarEPrecio.Text = TablaEquip.CurrentRow.Cells[4].Value.ToString();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desa Editar este cliente?", "Advertencia", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                objEntidad2.IDCLIENTE = Convert.ToInt32(txtIDClientes.Text);
                objEntidad2.NOMBRE = txtEditarCNombre.Text;
                objEntidad2.APELLIDO = txtEditarCApellido.Text;
                objEntidad2.CEDULA = txtEditarCCedula.Text;
                objEntidad2.MASCOTA = txtEditarCMascota.Text;
                objEntidad2.FECHAREGISTRO = txtEditarCFechaRegistro.Text;
                objEntidad2.CORREO = txtEditarCCorreo.Text;
                objEntidad2.TELEFONO = txtEditarCTelefono.Text;

                objNegocio.EditandoClientes(objEntidad2);
                MessageBox.Show("Cambios guardados correctamente");
                mostrarBuscarTabla("");
                limpiarcliente();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desa Editar esta comida?", "Advertencia", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                objEntidad3.IDCOMIDA = Convert.ToInt32(txtIDComidas.Text);
                objEntidad3.NOMBRE = txtEditarCoNombre.Text;
                objEntidad3.MARCA = txtEditarCoMarca.Text;
                objEntidad3.PRECIO = Convert.ToInt32(txtEditarCoPrecio.Text);
                objEntidad3.CANTIDAD = txtEditarCoCantidad.Text;
                objNegocio.EditandoComidas(objEntidad3);
                MessageBox.Show("Cambios guardados correctamente");
                mostrarBuscarTabla("");
                limpiarComidas();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desa Editar este Equipamiento?", "Advertencia", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                objEntidad4.IDEQUIPAMIENTO = Convert.ToInt32(txtIDEquipamiento.Text);
                objEntidad4.NOMBRE = txtEditarENombre.Text;
                objEntidad4.MARCA = txtEditarEMarca.Text;
                objEntidad4.COLOR = txtEditarEColor.Text;
                objEntidad4.PRECIO = Convert.ToInt32(txtEditarEPrecio.Text);
                objNegocio.EditandoEquipamiento(objEntidad4);
                MessageBox.Show("Cambios guardados correctamente");
                mostrarBuscarTabla("");
                limpiarEquipamiento();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpiarAnimales();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            limpiarcliente();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            limpiarComidas();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            limpiarEquipamiento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (TablaEquipamiento.SelectedTab == tabPage)
                {
                    if (TablaAnimales.SelectedRows.Count > 0)
                    {

                        objEntidad.IDANIMALES = Convert.ToInt32(TablaAnimales.CurrentRow.Cells[0].Value.ToString());
                        objNegocio.EliminandoAnimales(objEntidad);
                        MessageBox.Show("Mascota Eliminada Correctamente");
                        mostrarBuscarTabla("");

                    }
                }

                if (TablaEquipamiento.SelectedTab == tabPage2)
                {
                    if (TablaClientes.SelectedRows.Count > 0)
                    {
                            objEntidad2.IDCLIENTE = Convert.ToInt32(TablaClientes.CurrentRow.Cells[0].Value.ToString());
                            objNegocio.EliminandoClientes(objEntidad2);
                            MessageBox.Show("Cliente Eliminado Correctamente");
                            mostrarBuscarTabla("");
                    }
                }

                if (TablaEquipamiento.SelectedTab == tabPage3)
                {
                        if (TablaComidas.SelectedRows.Count > 0)
                        {
                            objEntidad3.IDCOMIDA = Convert.ToInt32(TablaComidas.CurrentRow.Cells[0].Value.ToString());
                            objNegocio.EliminandoComidas(objEntidad3);
                            MessageBox.Show("Comida Eliminada Correctamente");
                            mostrarBuscarTabla("");
                        }
                }

                if (TablaEquipamiento.SelectedTab == tabPage4)
                {
                        if (TablaEquip.SelectedRows.Count > 0)
                        {
                            objEntidad4.IDEQUIPAMIENTO = Convert.ToInt32(TablaEquip.CurrentRow.Cells[0].Value.ToString());
                            objNegocio.EliminandoEquipamiento(objEntidad4);
                            MessageBox.Show("Equipamiento Eliminado Correctamente");
                            mostrarBuscarTabla("");
                        }
                }
                



            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PBFoto.ImageLocation = abrirImagen.FileName;
                PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
