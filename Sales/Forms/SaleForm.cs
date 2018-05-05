using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class SaleForm : BaseDialogForm
    {
        public SaleForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        public async Task InsertOrUpdateAsync(Sale sale)
        {
            await FillEmployeesAsync();
            employee = sale.Employee;
            product = sale.Product;
            if (employee != null)
                employeeComboBox.SelectedItem = employeeComboBox.Items.Cast<Employee>().SingleOrDefault(x => x.Id == employee.Id);
            productTextBox.Text = product?.Name;
            amountUpDown.Value = sale.Amount;
            totalCostUpDown.Value = sale.TotalCost;
            saleDateTimePicker.Value = sale.SaleDate == DateTime.MinValue ? DateTime.Now : sale.SaleDate;
            if (ShowDialog() != DialogResult.OK)
                return;
            sale.Employee = employee;
            sale.Product = product;
            sale.Amount = Convert.ToInt32(amountUpDown.Value);
            sale.TotalCost = totalCostUpDown.Value;
            sale.SaleDate = saleDateTimePicker.Value;
            await AppCore.InsertOrUpdateAsync(sale);
        }

        protected override void OkExecute()
        {
            var errors = new List<string>();
            if (employee == null)
                errors.Add("Employee is not selected");
            if (product == null)
                errors.Add("Product is not selected");
            if (amountUpDown.Value == 0)
                errors.Add("Amount can not be 0");
            if (totalCostUpDown.Value == 0)
                errors.Add("Total cost can not be 0");
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\r\n", errors));
                return;
            }
            base.OkExecute();
        }

        private async Task FillEmployeesAsync()
        {
            employeeComboBox.DataSource = await AppCore.GetAllAsync((reader) => Employee.GetFromReader(reader));
            employeeComboBox.SelectedIndex = -1;
        }

        private Employee employee;
        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e) => employee = employeeComboBox.SelectedItem as Employee;

        private Product product;
        private async void productButton_Click(object sender, EventArgs e)
        {
            using (var form = new ProductSelectionForm(AppCore))
                product = await form.GetProduct();
            productTextBox.Text = product?.Name;
        }

        private void amountUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (product == null)
                return;
            totalCostUpDown.Value = amountUpDown.Value * product.Cost;
        }
    }
}
