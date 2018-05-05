using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class SalesForm : BaseGridForm
    {
        public SalesForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
            toolStrip.Items.Add(new ToolStripSeparator());
            toolStrip.Items.Add(new ToolStripButton("Employyes", null, employeesToolStripButton_Click));
            toolStrip.Items.Add(new ToolStripButton("Products", null, productsToolStripButton_Click));
        }

        protected override async Task<IEnumerable<object>> FillDataAsync() => await AppCore.GetAllAsync((reader) => Sale.GetFromReader(reader));

        protected override async Task OnAddItemAsync()
        {
            using (var form = new SaleForm(AppCore))
                await form.InsertOrUpdateAsync(new Sale());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Sale sale))
                return;
            using (var form = new SaleForm(AppCore))
                await form.InsertOrUpdateAsync(sale);
            await base.OnEditItemAsync();
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
