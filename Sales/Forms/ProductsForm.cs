using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class ProductsForm : BaseGridForm
    {
        public ProductsForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        protected override async Task<IEnumerable<object>> FillDataAsync()
        {
            var products = new List<Product>();
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                try
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("sp_GetProducts", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                        products.Add(new Product
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Cost = (decimal)reader["Cost"]
                        });
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            return products;
        }

        protected override async Task OnAddItemAsync()
        {
            using (var form = new ProductForm())
                await form.InsertOrUpdateAsync(new Product());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Product product))
                return;
            using (var form = new ProductForm())
                await form.InsertOrUpdateAsync(product);
            await base.OnEditItemAsync();
        }

        protected override async Task OnRemoveItemAsync()
        {
            await RemoveItemAsync<Product>("sp_DeleteProduct");
            await base.OnRemoveItemAsync();
        }
    }
}
