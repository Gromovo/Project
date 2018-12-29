namespace GUI_V_2.Core.View.Core.Model
{
    /// <summary>
    /// The class represents product from the real life
    /// The product contains it's name, category and barcode
    /// </summary>
    public class ProductModel
    {
        /// <summary>
        /// The name of product
        /// </summary>
        private string name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// The category of product
        /// </summary>
        private string category
        {
            get
            {
                return category;
            }
            set
            {
                this.category = value;
            }
        }

        /// <summary>
        /// The barcode of product
        /// </summary>
        private int barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                this.barcode = value;
            }
        }
    }
}
