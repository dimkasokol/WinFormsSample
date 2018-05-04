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
            return await AppCore.GetAllAsync((reader) => new Employee
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"]
            });
        }

        protected override async Task OnAddItemAsync()
        {
            using (var form = new EmployeeForm(AppCore))
                await form.InsertOrUpdateAsync(new Employee());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Employee employee))
                return;
            using (var form = new EmployeeForm(AppCore))
                await form.InsertOrUpdateAsync(employee);
            await base.OnEditItemAsync();
        }

        protected override async Task OnRemoveItemAsync()
        {
            await RemoveItemAsync<Employee>();
            await base.OnRemoveItemAsync();
        }
    }
}
