using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageAcademy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_loginName.Text=="admin" && txt_loginPass.Text=="123")
            {
                FormLanguageAcademy formLanguageAcademy = new FormLanguageAcademy();
                this.Hide();
                formLanguageAcademy.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen şifreyi Nil'e sorun:)","Information"
                    ,MessageBoxButtons.RetryCancel);
                txt_loginName.Text = "Please enter username.";
                txt_loginPass.Text = "Please enter password.";
            }
        }
    }
}
