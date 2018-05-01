using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class EmployeesForm : BaseGridForm
    {
        public EmployeesForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        protected override async Task<IEnumerable<object>> FillDataAsync()
        {
            var employees = new List<Employee>();
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                try
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("sp_GetEmployees", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                        employees.Add(new Employee
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"]
                        });
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            return employees;
        }

        protected override async Task OnAddItemAsync()
        {
            using (var form = new EmployeeForm())
                await form.InsertOrUpdateAsync(new Employee());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Employee employee))
                return;
            using (var form = new EmployeeForm())
                await form.InsertOrUpdateAsync(employee);
            await base.OnEditItemAsync();
        }

        protected override async Task OnRemoveItemAsync()
        {
            await RemoveItemAsync<Employee>("sp_DeleteEmployee");
            await base.OnRemoveItemAsync();
        }
    }
}
