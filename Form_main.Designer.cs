
namespace ITLA_Visitors
{
    partial class Form_main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.LOGIN = new System.Windows.Forms.Panel();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.LOGIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCloseTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ITLA_Visitors.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(4, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = global::ITLA_Visitors.Properties.Resources.Settings;
            this.btnSetting.Location = new System.Drawing.Point(1112, 3);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(45, 45);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::ITLA_Visitors.Properties.Resources.Subtract;
            this.btnMaximizar.Location = new System.Drawing.Point(1159, 3);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(45, 45);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::ITLA_Visitors.Properties.Resources.Frame_1730;
            this.btnMinimizar.Location = new System.Drawing.Point(1206, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseTab.FlatAppearance.BorderSize = 0;
            this.btnCloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTab.Image = global::ITLA_Visitors.Properties.Resources.x;
            this.btnCloseTab.Location = new System.Drawing.Point(1253, 3);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(1);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Padding = new System.Windows.Forms.Padding(10);
            this.btnCloseTab.Size = new System.Drawing.Size(45, 45);
            this.btnCloseTab.TabIndex = 0;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1300, 600);
            this.panelMain.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.panel2.BackgroundImage = global::ITLA_Visitors.Properties.Resources.REC_1;
            this.panel2.Controls.Add(this.lblSubtitle);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnEmpezar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(80, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 290);
            this.panel2.TabIndex = 5;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.lblSubtitle.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(150)))), ((int)(((byte)(171)))));
            this.lblSubtitle.Location = new System.Drawing.Point(59, 141);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(480, 69);
            this.lblSubtitle.TabIndex = 19;
            this.lblSubtitle.Text = "Una flexible y segura forma de gestionar las visitas a los edificios";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.lblTitle.Font = new System.Drawing.Font("Poppins", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(607, 154);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "ITLA Visitors";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpezar.FlatAppearance.BorderSize = 0;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.ForeColor = System.Drawing.Color.White;
            this.btnEmpezar.Image = global::ITLA_Visitors.Properties.Resources.Button_1_large;
            this.btnEmpezar.Location = new System.Drawing.Point(874, 110);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(232, 73);
            this.btnEmpezar.TabIndex = 17;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label3.Image = global::ITLA_Visitors.Properties.Resources.Component_41;
            this.label3.Location = new System.Drawing.Point(648, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 278);
            this.label3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Image = global::ITLA_Visitors.Properties.Resources.Component_21;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 541);
            this.label1.TabIndex = 4;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BackgroundImage = global::ITLA_Visitors.Properties.Resources.Component_3;
            this.panelLogin.Controls.Add(this.LOGIN);
            this.panelLogin.Location = new System.Drawing.Point(0, 50);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1300, 600);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.VisibleChanged += new System.EventHandler(this.panel3_VisibleChanged);
            // 
            // LOGIN
            // 
            this.LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.LOGIN.BackgroundImage = global::ITLA_Visitors.Properties.Resources.REC_2;
            this.LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LOGIN.Controls.Add(this.cbShow);
            this.LOGIN.Controls.Add(this.txtContrasena);
            this.LOGIN.Controls.Add(this.txtUsuario);
            this.LOGIN.Controls.Add(this.label4);
            this.LOGIN.Controls.Add(this.label2);
            this.LOGIN.Controls.Add(this.label7);
            this.LOGIN.Controls.Add(this.label8);
            this.LOGIN.Controls.Add(this.label9);
            this.LOGIN.Controls.Add(this.label10);
            this.LOGIN.Controls.Add(this.btnRegistrar);
            this.LOGIN.Controls.Add(this.btnLogin);
            this.LOGIN.Location = new System.Drawing.Point(451, 47);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(0);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(425, 539);
            this.LOGIN.TabIndex = 15;
            // 
            // cbShow
            // 
            this.cbShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.cbShow.BackgroundImage = global::ITLA_Visitors.Properties.Resources.eye;
            this.cbShow.FlatAppearance.BorderSize = 0;
            this.cbShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShow.Location = new System.Drawing.Point(349, 370);
            this.cbShow.Margin = new System.Windows.Forms.Padding(0);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(29, 30);
            this.cbShow.TabIndex = 12;
            this.cbShow.UseVisualStyleBackColor = false;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("DM Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(64, 377);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(270, 17);
            this.txtContrasena.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("DM Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(64, 280);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 17);
            this.txtUsuario.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Image = global::ITLA_Visitors.Properties.Resources.Input;
            this.label4.Location = new System.Drawing.Point(44, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 44);
            this.label4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Image = global::ITLA_Visitors.Properties.Resources.Input;
            this.label2.Location = new System.Drawing.Point(43, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 44);
            this.label2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(43, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label9.Image = global::ITLA_Visitors.Properties.Resources.Login_Logo;
            this.label9.Location = new System.Drawing.Point(144, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 150);
            this.label9.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label10.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(119, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 72);
            this.label10.TabIndex = 4;
            this.label10.Text = "Login";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnRegistrar.Image = global::ITLA_Visitors.Properties.Resources.lblRegistrar;
            this.btnRegistrar.Location = new System.Drawing.Point(43, 453);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 48);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::ITLA_Visitors.Properties.Resources.lblLogin;
            this.btnLogin.Location = new System.Drawing.Point(229, 453);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 48);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.LOGIN.ResumeLayout(false);
            this.LOGIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LOGIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox cbShow;
    }
}

