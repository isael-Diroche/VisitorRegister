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
            if (Form_main.area == "A0001")
            {
                //botones para hacer posible acceder con Enabled o no
            }
            else if (Form_main.area == "B0002")
            {
                //botones para hacer posible acceder con Enabled o no
            }
            else if (Form_main.area == "C0003")
            {
                //botones para hacer posible acceder con Enabled o no
            }

            //lblNombre.Text = Form_main.usuario_nombre;
            //timer1.Start();
        }

        //lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        //lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }
}
