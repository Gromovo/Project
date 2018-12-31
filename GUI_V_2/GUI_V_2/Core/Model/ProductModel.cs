using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using GUI_V_2.Core.Interfaces;
using Newtonsoft.Json;

namespace GUI_V_2.Core.View.Core.Model
{
    public class ProductModel : IProductModel
    {
        public string Name { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Barcode { get; set; } = string.Empty;

        public string Path { get; } = "products.json";

        public List<IProductModel> GetFromDatabase()
        {
            string json = string.Empty;
            string url = "http://fuckyou.kl.com.ua/secret_api.php?sivakamamka=hi&get_products";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<IProductModel>>(json);
        }

        public List<IProductModel> GetFromGrid(DataGridView gridView)
        {
            List<IProductModel> products = new List<IProductModel>();

            foreach (DataGridViewRow row in gridView.Rows)
            {
                try
                {
                    ProductModel product = new ProductModel();
                    product.Name = row.Cells[0].Value.ToString();
                    product.Category = row.Cells[1].Value.ToString();
                    product.Barcode = row.Cells[2].Value.ToString();

                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetBaseException());
                }
            }

            return products;
        }

        public List<IProductModel> GetFromStorage()
        {
            if (!File.Exists(this.Path))
                return null;

            return JsonConvert.DeserializeObject<List<IProductModel>>(File.ReadAllText(this.Path));
        }
    }
}
