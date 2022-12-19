using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections;

namespace winForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnNewBuyer_Click(object sender, EventArgs e)
        {
            Buyers buyers = new Buyers();
            buyers.Show();
            this.Hide();
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
