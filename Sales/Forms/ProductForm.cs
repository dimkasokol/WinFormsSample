using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class ProductForm : BaseDialogForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        public async Task InsertOrUpdateAsync(Product product)
        {
            nameTextBox.Text = product.Name;
            costUpDown.Value = product.Cost;
            if (ShowDialog() != DialogResult.OK)
                return;
            await AppCore.InsertOrUpdateAsync<Product>(new[]
            {
                new SqlParameter("id", product.Id),
                new SqlParameter("name", nameTextBox.Text),
                new SqlParameter("cost", costUpDown.Value)
            });
        }

        protected override void OkExecute()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                errors.Add("Product name can not be empty");
            if (costUpDown.Value == 0)
                errors.Add("Product cost can not be 0");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\r\n", errors));
                return;
            }
            base.OkExecute();
        }
    }
}
