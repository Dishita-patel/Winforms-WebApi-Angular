using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm
{
    public partial class Cars : Form
    {
        int carid;
        public Cars()
        {
            InitializeComponent();
            displayData();
        }

        private void btnCarSubmit_Click(object sender, EventArgs e)
        {
            if (txtCarColor.Text.ToString().Trim() != "" && txtCarMake.Text.ToString().Trim() != "" && txtCarMileage.Text.ToString().Trim() != "" && txtCarModel.Text.ToString().Trim() != "" && txtCarPreviousOwners.Text.ToString().Trim() != "" && txtCarPrice.Text.ToString().Trim() != "" && txtCarYear.Text.ToString().Trim() != "")

            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:34814/");
                    CarsClass car = new CarsClass { Color = txtCarColor.Text.ToString(), Make = txtCarMake.Text.ToString(), Model = txtCarModel.Text.ToString(), Mileage = Convert.ToDecimal(txtCarMileage.Text.ToString()), PreviousOwners = Convert.ToInt32(txtCarPreviousOwners.Text.ToString()), Price = Convert.ToDecimal(txtCarPrice.Text.ToString()), Year = Convert.ToInt32(txtCarYear.Text.ToString()) };
                    var response = client.PostAsJsonAsync("api/Cars", car).Result;
                    var a = response.Content.ReadAsStringAsync();
                    if (a.Result.ToString().Trim() == "\"Car was added successfully\"")
                    {
                        lblCarSubmitMsg.Text = "Car Added Successfully";
                        lblCarSubmitMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblCarSubmitMsg.Text = "Failed to add new car.";
                        lblCarSubmitMsg.ForeColor = Color.Red;
                    }
                    displayData();
                }
            }
        }

        private void btnCarBack_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnCarUpdate_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                CarsClass car = new CarsClass { CarID=carid, Color = txtCarColor.Text.ToString(), Make = txtCarMake.Text.ToString(), Model = txtCarModel.Text.ToString(), Mileage = Convert.ToDecimal(txtCarMileage.Text.ToString()), PreviousOwners = Convert.ToInt32(txtCarPreviousOwners.Text.ToString()), Price = Convert.ToDecimal(txtCarPrice.Text.ToString()), Year = Convert.ToInt32(txtCarYear.Text.ToString()) };
                var response = client.PutAsJsonAsync("api/Cars", car).Result;
                var a = response.Content.ReadAsStringAsync();
                if (a.Result.ToString().Trim() == "\"Car detail was updated successfully\"")
                {
                    lblCarSubmitMsg.Text = "Car Added Successfully";
                    lblCarSubmitMsg.ForeColor = Color.Green;
                }
                else
                {
                    lblCarSubmitMsg.Text = "Failed to update car detail.";
                    lblCarSubmitMsg.ForeColor = Color.Red;
                }
                displayData();
            }
        }

        private void btnCarDelete_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                CarsClass car = new CarsClass { CarID = carid };
                var response = client.DeleteAsync("api/Cars/"+car.CarID).Result;
                var a = response.Content.ReadAsStringAsync();
                if (a.Result.ToString().Trim() == "\"Car was deleted successfully\"")
                {
                    lblCarSubmitMsg.Text = "Car Deleted Successfully";
                    lblCarSubmitMsg.ForeColor = Color.Green;
                }
                else
                {
                    lblCarSubmitMsg.Text = "Failed to delete car.";
                    lblCarSubmitMsg.ForeColor = Color.Red;
                }
                displayData();
            }
        }

        private void dataGridCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carid = Convert.ToInt32(dataGridCarList.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCarColor.Text = dataGridCarList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCarMake.Text = dataGridCarList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCarModel.Text = dataGridCarList.Rows[e.RowIndex].Cells[3].Value.ToString() ;
            txtCarMileage.Text = dataGridCarList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCarPreviousOwners.Text = dataGridCarList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCarPrice.Text = dataGridCarList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCarYear.Text = dataGridCarList.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        public void displayData()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:34814/");
                HttpResponseMessage response = client.GetAsync("api/Cars").Result;
                var car = response.Content.ReadAsAsync<IEnumerable<CarsClass>>().Result;
                dataGridCarList.DataSource = car;
            }
        }

        private void btnCarClear_Click(object sender, EventArgs e)
        {
            txtCarColor.Text = txtCarMake.Text = txtCarModel.Text = txtCarMileage.Text = "";
            txtCarPreviousOwners.Text = txtCarPrice.Text = txtCarYear.Text = "";
        }
    }
}
