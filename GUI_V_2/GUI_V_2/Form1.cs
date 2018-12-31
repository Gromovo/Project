using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_V_2.Core.View
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        public static service fs;
        [STAThread]
      

    

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ProductView());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new InicioResumen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null,e);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }    

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new brends());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f2 = new service();
            f2.Show();
        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
           
            MenuVertical.BackColor = Color.FromArgb(128, 64, 64);           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuVertical.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Purch());
        }

        private void Settings_pctr_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.Show();
        }


    }
}
