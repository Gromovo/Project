using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace GUI_V_2.Core.View
{
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();

            if (File.Exists("path.txt"))
            {
                List<Product> products = GetProductsFromJson("path.txt");
                LoadDataToGrid(products, dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {                  
            string name = textBox1.Text;
            string category = textBox2.Text;
            string barcode = textBox3.Text;
            dataGridView1.Rows.Add(name, category, barcode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
            } catch (System.InvalidOperationException)
            {
                MessageBox.Show("In this table does NOT exists any rows!", "Ahtung!");
            }
        }
        
        private void button4_Click(object sender, EventArgs e) // Save button
        {
            List<Product> productsList = GetProducts(dataGridView1);

            if (!productsList.Any())
            {
                MessageBox.Show("Table is empty!", "Ahtung!");
            }
            else
            {
                SaveProductsAsJson("path.txt", productsList);
                MessageBox.Show("Database was saved successfully!", "Info");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            List<Product> products = GetProductsFromJson("path.txt");

            if (products == null)
                MessageBox.Show("Database does NOT exist!", "Ahtung!");
            else
                LoadDataToGrid(products, dataGridView1);
        }

        // GetProducts method let you to get products array
        private List<Product> GetProducts(DataGridView grid)
        {
            int len = grid.RowCount - 1;
            Product product = new Product();
            List<Product> productsList = new List<Product>();

            for (int i = 0; i < len; i++)
            {
                try
                {
                    product.name = grid.Rows[i].Cells[0].Value.ToString();
                    product.category = grid.Rows[i].Cells[1].Value.ToString();
                    product.barcode = grid.Rows[i].Cells[2].Value.ToString();

                    productsList.Add(product);
                }
                catch (System.NullReferenceException)
                {
                    System.Console.WriteLine("DataGridView: cell in row is NULL!");
                }
            }

            return productsList;
        }

        // Save products array as sa json file
        // path is not path it's just filename :)
        private void SaveProductsAsJson(string path, List<Product> productsList)
        {
            string json = JsonConvert.SerializeObject(productsList, Formatting.Indented);

            TextWriter txt = new StreamWriter(path);
            txt.Write(json);
            txt.Close();
        }

        // Get data from json file if it exists
        private List<Product> GetProductsFromJson(string path)
        {
            if (!File.Exists(path))
                return null;

            string json = File.ReadAllText(path, Encoding.UTF8);
            List<Product> productsList = JsonConvert.DeserializeObject<List<Product>>(json);

            return productsList;
        }

        // Just load data to DataGridView!
        private void LoadDataToGrid(List<Product> products, DataGridView grid)
        {
            grid.Rows.Clear();

            foreach (Product p in products)
            {
                grid.Rows.Add(p.name, p.category, p.barcode);
            }
        }

        // Just delete json file by path, it's does NOT delete database :)
        private bool DeleteDatabase(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                return false;

            return true;
        }

        private bool DeleteProduct(Product p, List<Product> products)
        {
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}