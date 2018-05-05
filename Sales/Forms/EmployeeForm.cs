using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class EmployeeForm : BaseDialogForm
    {
        public EmployeeForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        public async Task InsertOrUpdateAsync(Employee employee)
        {
            nameTextBox.Text = employee.Name;
            if (ShowDialog() != DialogResult.OK)
                return;
            employee.Name = nameTextBox.Text;
            await AppCore.InsertOrUpdateAsync(employee);
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
