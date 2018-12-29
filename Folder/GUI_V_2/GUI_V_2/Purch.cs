using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GUI_V_2.Core.View
{
    public partial class Purch : Form
    {
        public Purch()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string barcode = textBox5.Text;
            List<Product> products = GetProductsFromJson("path.txt");

            foreach (Product p in products)
            {
                if (p.barcode == barcode)
                {
                    MessageBox.Show(p.name+" was successfully puchasing!", "Info");
                    break;
                }
            }

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
    }
}