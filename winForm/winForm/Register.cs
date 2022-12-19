using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnUsrBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnUsrSubmit_Click(object sender, EventArgs e)
        {
            if(txtUsrPswd.Text.ToString() == txtUsrCPswd.Text.ToString())
            {
                if (txtUsrfn.Text.ToString().Trim() != "" && txtUsrln.Text.ToString().Trim() != "" && txtUsrLoginName.Text.ToString().Trim() != "" && txtUsrCPswd.Text.ToString().Trim() != "" && txtUsrCPswd.Text.ToString().Trim() != "")
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:34814/");
                        RegisterClass buy = new RegisterClass { FirstName = txtUsrfn.Text.ToString(), LastName = txtUsrln.Text.ToString(), EmpType = "Employee", PasswordHash = txtUsrPswd.Text.ToString(), LoginName = txtUsrLoginName.Text.ToString() };
                        var response = client.PostAsJsonAsync("api/users", buy).Result;
                        var a = response.Content.ReadAsStringAsync();
                        if (a.Result.ToString().Trim() == "\"User was added successfully\"")
                        {
                            MessageBox.Show("User Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add new User.");
                        }
                    }
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!!");
            }
        }

        private void btnUsrClear_Click(object sender, EventArgs e)
        {
            txtUsrfn.Text = txtUsrln.Text = txtUsrPswd.Text = txtUsrLoginName.Text = "";
        }
    }
}
