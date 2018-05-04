using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class EmployeeForm : BaseDialogForm
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        public async Task InsertOrUpdateAsync(Employee employee)
        {
            nameTextBox.Text = employee.Name;
            if (ShowDialog() != DialogResult.OK)
                return;
            await AppCore.InsertOrUpdateAsync<Employee>(new[]
            {
                new SqlParameter("id", employee.Id),
                new SqlParameter("name", nameTextBox.Text)
            });
        }

        protected override void OkExecute()
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Product name can not be empty");
                return;
            }
            base.OkExecute();
        }
    }
}
