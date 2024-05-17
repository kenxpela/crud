using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace crud
{
    public partial class Form1 : Form
    {
        private HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void btnGetProducts_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("http://localhost/api.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseBody);

                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProductName.Text;
                int categoryId = Convert.ToInt32(txtCategoryId.Text);
                decimal price = Convert.ToDecimal(txtPrice.Text);
                string description = txtDescription.Text;

                var content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "product_name", productName },
                    { "category_id", categoryId.ToString() },
                    { "price", price.ToString() },
                    { "description", description }
                });

                HttpResponseMessage response = await _httpClient.PostAsync("http://localhost/api.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Product added successfully!");

                // Clear input fields
                ClearInputFields();

                // Refresh product list
                btnGetProducts_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       

      
        private void ClearInputFields()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtCategoryId.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
        }
    }

    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public string category_name { get; set; }
    }
}
