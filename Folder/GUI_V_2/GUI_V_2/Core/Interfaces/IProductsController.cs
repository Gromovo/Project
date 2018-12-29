using System.Collections.Generic;
using System.Windows.Forms;
using GUI_V_2.Core.View.Core.Model;

namespace GUI_V_2.Core.View.Core.Interfaces
{
    public interface IProductsController
    {
        // Insert data from list into grid view
        void UpdateGrid(DataGridView grid, List<ProductModel> products);

        // Show loading message while do something durable
        void ShowLoadingMessage();

        // Clear all rows from DataGridView
        void ClearGrid(DataGridView grid);

        // Save data from list of products into database
        void SaveProductsToDatabase(List<ProductModel> products);

        // Load data of products from database into grid view
        void LoadProductsToGrid(DataGridView grid);

        // Add product to grid view
        void AddProduct(TextBox name, TextBox category, TextBox barcode, DataGridView grid);
    }
}
