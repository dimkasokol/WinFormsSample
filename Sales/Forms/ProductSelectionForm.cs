using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class ProductSelectionForm : BaseDialogForm
    {
        public ProductSelectionForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        public async Task<Product> GetProduct()
        {
            PrepareDataGrid();
            await FillProductsAsync();
            return ShowDialog() == DialogResult.OK ? selectedProduct : null;
        }

        private Product selectedProduct;
        protected override void OkExecute()
        {
            if (!(productsGridView.SelectedRows.Count > 0) || !(productsGridView.SelectedRows[0].DataBoundItem is Product product))
                return;
            selectedProduct = product;
            base.OkExecute();
        }

        private IEnumerable<Product> products;
        private async Task FillProductsAsync()
        {
            products = await AppCore.GetAllAsync((reader) => Product.GetFromReader(reader));
            productsGridView.DataSource = products;
        }

        private void PrepareDataGrid()
        {
            productsGridView.AutoGenerateColumns = false;
            foreach (var property in typeof(Product).GetProperties())
                if (property.GetCustomAttributes(typeof(ColumnAttribute), false).SingleOrDefault() is ColumnAttribute attribute)
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        Name = property.Name,
                        DataPropertyName = property.Name,
                        HeaderText = attribute.Name,
                        FillWeight = attribute.FillWeight
                    };
                    productsGridView.Columns.Add(column);
                }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var displayedRow = 0;
            if (productsGridView.Rows.Count > 0 && productsGridView.FirstDisplayedCell != null)
                displayedRow = productsGridView.FirstDisplayedCell.RowIndex;
            var selectedRow = 0;
            if (productsGridView.SelectedRows.Count > 0)
                selectedRow = productsGridView.SelectedRows[0].Index;

            productsGridView.DataSource = products.Where(x => x.Name.Contains(searchTextBox.Text)).ToList();

            if (displayedRow != 0 && displayedRow < productsGridView.Rows.Count)
                productsGridView.FirstDisplayedScrollingRowIndex = displayedRow;
            if (selectedRow != 0 && selectedRow < productsGridView.Rows.Count)
                productsGridView.Rows[selectedRow].Selected = true;
        }
    }
}
