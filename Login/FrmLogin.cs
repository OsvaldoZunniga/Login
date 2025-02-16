using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        //Uso de API de Windows para mover la ventana
            // Constantes de mensajes de Windows
            private const int WM_NCLBUTTONDOWN = 0xA1;
            private const int HT_CAPTION = 0x2;

            // Importar funciones de la API de Windows
            [DllImport("user32.dll")]
            private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
            [DllImport("user32.dll")]
            private static extern bool ReleaseCapture();
        //Fin de uso de API de Windows para mover la ventana

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Manejo de booleanos

            //NegocioUsuarios negocioUsuarios = new NegocioUsuarios();
            //if (negocioUsuarios.Login(txt_user.Text, txt_password.Text))
            //{
            //    MessageBox.Show("Login correcto");
            //}
            //else
            //{
            //    MessageBox.Show("Login incorrecto");
            //}
        }

        bool isPasswordVisible = false;
        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {

            if (isPasswordVisible)
            {
                
                txt_password.UseSystemPasswordChar = true;
                isPasswordVisible = false;
                
            }
            else
            {
                
                txt_password.UseSystemPasswordChar = false;
                isPasswordVisible = true;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
