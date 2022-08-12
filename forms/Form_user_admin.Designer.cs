
namespace ITLA_Visitors.forms
{
    partial class Form_user_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::ITLA_Visitors.Properties.Resources.Frame_1728;
            this.btnBack.Location = new System.Drawing.Point(4, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 600);
            this.panel2.TabIndex = 3;
            // 
            // Form_user_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_user_admin";
            this.Text = "Form_user_admin";
            this.Load += new System.EventHandler(this.Form_user_admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Panel panel2;
    }
}