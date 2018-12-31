using System.Collections.Generic;
using System.Windows.Forms;
using GUI_V_2.Core.Interfaces;

namespace GUI_V_2.Core.View.Core.Interfaces
{
    public interface IProductController
    {
        /// <summary>
        /// Clear given DataGridView from data
        /// </summary>
        /// <param name="gridView">DataGridView for clean</param>
        void ClearGrid(DataGridView gridView);

        /// <summary>
        /// Saving data from DataGridView to local storage
        /// </summary>
        /// <param name="products">List of IProductModel for saving data from it into local storage</param>
        /// <param name="path">Path to place for saving</param>
        /// <returns>If saving was successfully then returns true else returns false</returns>
        bool SaveToStorage(List<IProductModel> products, string path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="products">List of IProductModel for saving data from it into datebase</param>
        /// <returns>If saving was successfully then returns true else returns false</returns>
        bool SaveToDatabase(List<IProductModel> products);

        /// <summary>
        /// Load products from list of IProductModel into DataGridView
        /// </summary>
        /// <param name="products">List of IProductModel for loading it into DataGridView</param>
        /// <param name="gridView">DataGridView for loading products into it</param>
        void LoadProductsToGrid(List<IProductModel> products, DataGridView gridView);
    }
}
