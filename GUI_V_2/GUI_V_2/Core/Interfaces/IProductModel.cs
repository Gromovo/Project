using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_V_2.Core.Interfaces
{
    public interface IProductModel
    {
        /// <summary>
        /// Name of product
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Category of product
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Barcode of product
        /// </summary>
        string Barcode { get; set; }

        /// <summary>
        /// Path to products' json file.
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Getting list of products from storage by path which contains in path variable
        /// </summary>
        /// <returns>List of IProductModel instances</returns>
        List<IProductModel> GetFromStorage();

        /// <summary>
        /// Getting list of products from DataGridView
        /// </summary>
        /// <param name="gridView">DataGridView of IProductModel</param>
        /// <returns></returns>
        List<IProductModel> GetFromGrid(DataGridView gridView);

        /// <summary>
        ///  Getting list of products from database
        /// </summary>
        /// <returns>List of IProductModel instances</returns>
        List<IProductModel> GetFromDatabase();
    }
}
