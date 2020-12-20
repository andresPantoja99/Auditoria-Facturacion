using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sistema_de_facturacion.Ayuda
{
    public partial class ManualDeUsuario : Form
    {
        public Form inicial;
        public ManualDeUsuario(Form interfazInicial)
        {
            InitializeComponent();
            this.inicial = interfazInicial;
        }

        private void MinimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizarButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            inicial.Visible = true;
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
