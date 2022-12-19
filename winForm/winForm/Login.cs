using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace winForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
            errorProvider1.SetError(txtPassword, "");
            if (txtUsername.Text.ToString().Trim() != "" && txtPassword.Text.ToString().Trim() != "")
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:34814/");
                    LoginClass lgn = new LoginClass { LoginName = txtUsername.Text.ToString(), PasswordHash = txtPassword.Text.ToString(), EmpType = "Employee" };
                    var response = client.PostAsJsonAsync("api/Users/Login", lgn).Result;
                    var a = response.Content.ReadAsStringAsync();
                    if (a.Result.ToString().Trim() == "\"User successfully logged in\"")
                    {
                        Welcome welcome = new Welcome();
                        welcome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password");
                    }
                }
            }
            else if (txtUsername.Text.ToString().Trim() == "" && txtPassword.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter the email");
                errorProvider1.SetError(txtPassword, "Please enter the password");
            }
            else if (txtUsername.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter the email");
            }
            else if (txtPassword.Text.ToString().Trim() == "")
            {
                errorProvider1.SetError(txtPassword, "Please enter the password");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
