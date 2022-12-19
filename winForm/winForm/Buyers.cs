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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace winForm
{
    public partial class Buyers : Form
    {
        int buyerid;
        public Buyers()
        {
            InitializeComponent();
            displayData();
        }

        private void txtBuyerAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBuyerSubmit_Click(object sender, EventArgs e)
        {
            if (txtBuyerfn.Text.ToString().Trim() != "" && txtBuyerln.Text.ToString().Trim() != "" && txtBuyerAge.Text.ToString().Trim() != "")

            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:34814/");
                    BuyersClass buy = new BuyersClass { FirstName = txtBuyerfn.Text.ToString(), LastName = txtBuyerln.Text.ToString(), Age =Convert.ToInt32(txtBuyerAge.Text.ToString()) };
                    var response = client.PostAsJsonAsync("api/Buyers", buy).Result;
                    var a = response.Content.ReadAsStringAsync();
                    if (a.Result.ToString().Trim() == "\"Buyer was added successfully\"")
                    {
                        lblBuyerSubmitMsg.Text = "Buyer Added Successfully";
                        lblBuyerSubmitMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblBuyerSubmitMsg.Text = "Failed to add new buyer.";
                        lblBuyerSubmitMsg.ForeColor = Color.Red;
                    }
                    displayData();
                }
            }
        }

        private void btnBuyerBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnBuyerUpdate_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                BuyersClass buyer = new BuyersClass { BuyerID = buyerid, FirstName = txtBuyerfn.Text.ToString(), LastName = txtBuyerln.Text.ToString(), Age = Convert.ToInt32(txtBuyerAge.Text.ToString()) };
                var response = client.PutAsJsonAsync("api/Buyers", buyer).Result;
                var a = response.Content.ReadAsStringAsync();
                if (a.Result.ToString().Trim() == "\"Buyer detail was updated successfully\"")
                {
                    lblBuyerSubmitMsg.Text = "Buyer updated Successfully";
                    lblBuyerSubmitMsg.ForeColor = Color.Green;
                }
                else
                {
                    lblBuyerSubmitMsg.Text = "Failed to update buyer detail.";
                    lblBuyerSubmitMsg.ForeColor = Color.Red;
                }
                displayData();
            }

        }

        private void btnBuyerDelete_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                BuyersClass buyer = new BuyersClass { BuyerID = buyerid };
                var response = client.DeleteAsync("api/Buyers/" + buyer.BuyerID).Result;
                var a = response.Content.ReadAsStringAsync();
                if (a.Result.ToString().Trim() == "\"Buyer was deleted successfully\"")
                {
                    lblBuyerSubmitMsg.Text = "Buyer Deleted Successfully";
                    lblBuyerSubmitMsg.ForeColor = Color.Green;
                }
                else
                {
                    lblBuyerSubmitMsg.Text = "Failed to delete buyer.";
                    lblBuyerSubmitMsg.ForeColor = Color.Red;
                }
                displayData();
            }

        }

        private void btnBuyerClear_Click(object sender, EventArgs e)
        {
            txtBuyerfn.Text = txtBuyerln.Text = txtBuyerAge.Text = "";
        }
        private void displayData()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                HttpResponseMessage response = client.GetAsync("api/Buyers").Result;
                var buy = response.Content.ReadAsAsync<IEnumerable<BuyersClass>>().Result;
                dataGridBuyerList.DataSource = buy;
            }
        }

        private void dataGridBuyerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buyerid = Convert.ToInt32(dataGridBuyerList.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtBuyerfn.Text = dataGridBuyerList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBuyerln.Text = dataGridBuyerList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBuyerAge.Text = dataGridBuyerList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
