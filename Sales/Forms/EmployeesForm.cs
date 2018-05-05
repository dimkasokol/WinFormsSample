using System.Collections.Generic;
using System.Threading.Tasks;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class EmployeesForm : BaseGridForm
    {
        public EmployeesForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        protected override async Task<IEnumerable<object>> FillDataAsync() => await AppCore.GetAllAsync((reader) => Employee.GetFromReader(reader));

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
    }
}
