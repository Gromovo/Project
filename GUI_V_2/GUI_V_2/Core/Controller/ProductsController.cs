using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GUI_V_2.Core.Interfaces;
using GUI_V_2.Core.View.Core.Interfaces;
using Newtonsoft.Json;

namespace GUI_V_2.Core.View.Core.Controller
{
    public class ProductsController : IProductController
    {
        public void ClearGrid(DataGridView gridView)
        {
            gridView.Rows.Clear();
        }

        public void LoadProductsToGrid(List<IProductModel> products, DataGridView gridView)
        {
            ClearGrid(gridView);

            foreach (IProductModel product in products)
            {
                gridView.Rows.Add(product.Name, product.Category, product.Barcode);
            }
        }

        public bool SaveToStorage(List<IProductModel> products, string path)
        {
            if (path == null || products == null)
                return false;

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            TextWriter txt = new StreamWriter(path);
            txt.Write(json);
            txt.Close();

            return true;
            
        }

        public bool SaveToDatabase(List<IProductModel> products)
        {
            string json = Regex.Replace(JsonConvert.SerializeObject(products, Formatting.Indented), @"\s+", ""); ;
            string url = "http://fuckyou.kl.com.ua/secret_api.php?sivakamamka=hi&save_products=";

            var result = new HttpClient().GetAsync(url).Result;

            if (int.Parse(result.StatusCode.ToString()) == 200)
                return true;
            else
                return false;
        }
    }
}
