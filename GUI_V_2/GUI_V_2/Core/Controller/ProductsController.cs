using GUI_V_2.Core.View.Core.Model;
using GUI_V_2.Core.View.Core.Interfaces;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GUI_V_2.Core.View.Core.Controller
{
    public class ProductsController : IProductsController
    {
        public ProductsController(ProductsView view, ProductModel model)
        {
        }

        /// <summary>
        /// Add product to grid view
        /// </summary>
        /// <param name="name">The name of product</param>
        /// <param name="category">The name of category it's product</param>
        /// <param name="barcode">The barcode it's product</param>
        /// <param name="grid">DataGridView for adding product into it</param>
        public void AddProduct(TextBox name, TextBox category, TextBox barcode, DataGridView grid)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Clear all rows from DataGridView
        /// </summary>
        /// <param name="grid">DataGridView for cleaning all of rows in it</param>
        public void ClearGrid(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        /// <summary>
        /// Load data of products from database into grid view
        /// </summary>
        /// <param name="grid">DataGridView for inserting data of products into it</param>
        public void LoadProductsToGrid(DataGridView grid)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Save data from list of products into database
        /// </summary>
        /// <param name="products">List of products for saving</param>
        public void SaveProductsToDatabase(List<ProductModel> products)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Show loading message while do something durable
        /// </summary>
        public void ShowLoadingMessage()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Insert data from list into grid view
        /// </summary>
        /// <param name="grid">DataGridViw for adding products into it</param>
        /// <param name="products">List of products for adding into DataGridView</param>
        public void UpdateGrid(DataGridView grid, List<ProductModel> products)
        {
            throw new System.NotImplementedException();
        }
    }
}
