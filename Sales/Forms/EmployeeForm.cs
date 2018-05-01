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

        public async Task InsertOrUpdateAsync(Employee employee)
        {
            nameTextBox.Text = employee.Name;
            if (ShowDialog() != DialogResult.OK)
                return;
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                try
                {
                    await connection.OpenAsync();
                    var command = new SqlCommand("sp_InsertOrUpdateEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("id", employee.Id));
                    command.Parameters.Add(new SqlParameter("name", nameTextBox.Text));
                    if (await command.ExecuteScalarAsync() is int id)
                        employee.Id = id;
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
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
