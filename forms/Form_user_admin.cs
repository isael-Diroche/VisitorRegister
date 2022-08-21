using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad.Clases;
using Capa_Negocio.Clases;

namespace ITLA_Visitors.forms
{
    public partial class Form_user_admin : Form
    {
        private Negocio_visitas tblUsuario = new Negocio_visitas();
        private Negocio_edificio tblEdificio = new Negocio_edificio();
        private Negocio_aula tblAula = new Negocio_aula();

        public Form_user_admin()
        {
            InitializeComponent();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_user_admin_Load(object sender, EventArgs e)
        {
            //Saltamos al frente al panel principal
            this.panelSeleccion.BringToFront();

            //Llenar el ComboBox de las carreras
            DataTable tCarrera= tblUsuario.Mostrar_Carrera();
            cbxCarrera.DataSource = tCarrera;
            cbxCarrera.DisplayMember = "descripcion";
            cbxCarrera.ValueMember = "descripcion";

            //Llenar el ComboBox de las edificios
            DataTable tEdificio = tblUsuario.Mostrar_Edificio();
            cbxEdificio.DataSource = tEdificio;
            cbxEdificio.DisplayMember = "descripcion";
            cbxEdificio.ValueMember = "descripcion";

            cbxEdificioAula.DataSource = tEdificio;
            cbxEdificioAula.DisplayMember = "descripcion";
            cbxEdificioAula.ValueMember = "descripcion";


            this.FillGridView();
            

            if (Form_main.user_tipo_usuario == "admin")
            {
                //botones para hacer posible acceder con Enabled o no
                MessageBox.Show("Eres admin");
            }
            else if (Form_main.user_tipo_usuario == "general")
            {
                //botones para hacer posible acceder con Enabled o no
                this.btnEdificios.Visible = false;
                this.btnUsuarios.Visible = false;
                MessageBox.Show("Eres general");
            }

            //lblNombre.Text = Form_main.usuario_nombre;
            //timer1.Start();
        }

        private void FillGridView()
        {
            dgvVisitas.DataSource = tblUsuario.Mostrar_Visitas();
            dgvDatosEdificio.DataSource = tblEdificio.Mostrar_Edificio();
            dgvDatosAula.DataSource = tblAula.Mostrar_Aula();

            DataGridViewImageColumn colum = (DataGridViewImageColumn)dgvVisitas.Columns[9];
            colum.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVisitas.Columns[0].Visible = false;
            //dgvVisitas.Columns[6].Visible = false;
            //dgvVisitas.Columns[7].Visible = false;


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar el panel de gestion de visitas
            panelVisitas.BringToFront();
        }

        private void panelRegitroVisita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panelVisitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Negocio_visitas objnvisitas = new Negocio_visitas();
            Entidad_visitas objevisitas = new Entidad_visitas();

            DataTable Tabla = new DataTable();

            try
            {
                //Cargar los getters
                objevisitas.nombre = txtNombre.Text;
                objevisitas.apellido = txtApellido.Text;
                objevisitas.carrera = cbxCarrera.Text;
                objevisitas.correo = txtCorreo.Text;
                objevisitas.edificio = cbxEdificio.Text;
                objevisitas.hora_entrada = dtEntrada.Text;
                objevisitas.hora_salida = dtSalida.Text;
                objevisitas.motivo_visita = txtMotivo.Text;
                objevisitas.foto_visita = clsImagen.ImageToByte(pbFotoVisita.Image);
                objevisitas.se_dirige = cbxAula.Text;

                Tabla = objnvisitas.Insertar_Visitas(objevisitas);

                MessageBox.Show("Registros Agregados Correctamente!", "Todo Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al Insertar los Registros " + ex, "Error insertando registros");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void pbFotoVisita_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione una imagen";
            dialog.Filter = "*.png|*.png";
            dialog.InitialDirectory = "C:\\Users\\robin\\Desktop\\ITLA Visitors\\Resource\\Visitor Picture";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbFotoVisita.ImageLocation = dialog.FileName;
            }
        }

        private void cbxEdificio_SelectedValueChanged(object sender, EventArgs e)
        {
            Entidad_edificios objeuser = new Entidad_edificios();
            Negocio_visitas objnuser = new Negocio_visitas();

            //MessageBox.Show(cbxEdificio.Text, "Aqui estan los valores");
            try
            {
                DataTable tAula = new DataTable();
                objeuser.Id = 1;
                objeuser.descripcion = cbxEdificio.Text;

                tAula = objnuser.Mostrar_Aula_Edificio(objeuser);

                //Llenar el ComboBox de las Aulas
                //DataTable tAula= tblUsuario.Mostrar_Aula_Edificio(cbxEdificio.Text);
                cbxAula.DataSource = tAula;
                cbxAula.DisplayMember = "descripcion";
                cbxAula.ValueMember = "descripcion";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //.Show(ex.Message, "Ocurrio un error Cargando El Area o Salon");
                
            }

            //MessageBox.Show("Se cambio el valor seleccionado");
            //----------------------------------------------------------------------Cargar el ComboBox de Aulas
        }

        private void txtBuscarVisita_TextChanged(object sender, EventArgs e)
        {
            String Valor = txtBuscarVisita.Text;

            dgvVisitas.DataSource = tblUsuario.Buscar_visita(Valor);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.FillGridView();
        }

        private void btnEdificios_Click(object sender, EventArgs e)
        {
            this.panelEdificio.BringToFront();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.panelUsuario.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_edificios objeuser = new Entidad_edificios();
                Negocio_edificio objnuser = new Negocio_edificio();

                String texto = txtNuevoEdificio.Text;

                objeuser.descripcion = texto;

                objnuser.Insertar_Edificio(objeuser);

                MessageBox.Show("Se insertaron los registros del Edificio", "Se inserto Correctamente!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error insertando");
            }
        }

        private void btnAgregarAula_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_aulas objeuser = new Entidad_aulas();
                Negocio_aula objnuser = new Negocio_aula();              

                objeuser.descripcion = txtNuevaAula.Text;
                objeuser.edificio = cbxEdificioAula.Text;

                objnuser.Insertar_Aula(objeuser);

                MessageBox.Show("Se insertaron los registros de la Aula", "Se inserto Correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocurrio un error insertando");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panelSeleccion.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panelSeleccion.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.panelSeleccion.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_main login = new Form_main();
            this.Hide();

            //Application.Run(new Form_main());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Run(new Form_main());
        }

        //lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        //lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }
}
