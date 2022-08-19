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

namespace ITLA_Visitors
{
    public partial class Form_main : Form
    {
        Entidad_login objeuser = new Entidad_login();
        Negocio_Login objnuser = new Negocio_Login();

        forms.Form_user_admin frm = new forms.Form_user_admin();

        public static string user_nombre;
        public static string user_apellido;
        public static string user_tipo_usuario;

        public void p_logeo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txtUsuario.Text;
            objeuser.contrasena = txtContrasena.Text;

            dt = objnuser.N_login(objeuser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user_nombre = dt.Rows[0][1].ToString();
                user_apellido = dt.Rows[0][2].ToString();
                user_tipo_usuario = dt.Rows[0][3].ToString();

                frm.Show();
                this.Hide();

                Form_main login = new Form_main();
                //login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new forms.Form_user_admin());
                }

                txtUsuario.Clear();
                txtContrasena.Clear();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public Form_main()
        {
            InitializeComponent();
            panelMain.BringToFront();
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.SendToBack();
            panelMain.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelLogin.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelLogin.Visible = false;
            
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            if (panelLogin.Visible)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
        }

        private void btnEmpezar_Click_1(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelMain.SendToBack();

            panelLogin.Visible = true;
            panelLogin.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            p_logeo();
        }
    }
}
