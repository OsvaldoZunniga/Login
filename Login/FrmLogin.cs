using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
