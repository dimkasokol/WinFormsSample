using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class SalesForm : BaseGridForm
    {
        private List<Sale> sales = new List<Sale>();

        public SalesForm()
        {
            InitializeComponent();
        }

        public SalesForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
            toolStrip.Items.Add(new ToolStripSeparator());
            toolStrip.Items.Add(new ToolStripButton("Employyes", null, employeesToolStripButton_Click));
            toolStrip.Items.Add(new ToolStripButton("Products", null, productsToolStripButton_Click));
        }

        protected override async Task<IEnumerable<object>> FillDataAsync()
        {
            var sales = new List<Sale>();
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                try
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("sp_GetSales", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                        sales.Add(new Sale
                        {
                            Id = (int)reader["Id"],
                            Employee = new Employee { Id = (int)reader["EmployeeId"], Name = (string)reader["EmployeeName"] },
                            Product = new Product { Id = (int)reader["ProductId"], Name = (string)reader["ProductName"], Cost = (decimal)reader["Cost"] },
                            Amount = (int)reader["Amount"],
                            TotalCost = (decimal)reader["TotalCost"],
                            SaleDate = (DateTime)reader["SaleDate"]
                        });
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            return sales;
        }

        protected override async Task OnAddItemAsync()
        {
            using (var form = new SaleForm())
                await form.InsertOrUpdateAsync(new Sale());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Sale sale))
                return;
            using (var form = new SaleForm())
                await form.InsertOrUpdateAsync(sale);
            await base.OnEditItemAsync();
        }

        protected override async Task OnRemoveItemAsync()
        {
            await RemoveItemAsync<Sale>("sp_DeleteSale");
            await base.OnRemoveItemAsync();
        }

        private void employeesToolStripButton_Click(object sender, EventArgs e)
        {
            var form = AppCore.GetForm<EmployeesForm>();
            if (form == null)
            {
                form = new EmployeesForm(AppCore);
                form.Show();
                return;
            }
            form.Activate();
        }

        private void productsToolStripButton_Click(object sender, EventArgs e)
        {
            var form = AppCore.GetForm<ProductsForm>();
            if (form == null)
            {
                form = new ProductsForm(AppCore);
                form.Show();
                return;
            }
            form.Activate();
        }
    }
}
