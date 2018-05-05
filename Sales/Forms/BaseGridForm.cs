using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class BaseGridForm : BaseCoreForm
    {
        public BaseGridForm()
        {
            InitializeComponent();
        }

        public BaseGridForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
            AppCore.Forms.Add(this);
        }

        protected virtual async Task<IEnumerable<object>> FillDataAsync() => await new Task<IEnumerable<object>>(() => new List<object>());

        protected virtual async Task OnAddItemAsync() => await RefreshDataGridAsync();

        protected virtual async Task OnEditItemAsync() => await RefreshDataGridAsync();

        protected virtual async Task OnRemoveItemAsync()
        {
            await RemoveItemAsync();
            await RefreshDataGridAsync();
        }

        protected override async void OnShown(EventArgs e)
        {
            await RefreshDataGridAsync();
            base.OnShown(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            AppCore.Forms.Remove(this);
            base.OnClosed(e);
        }

        private async Task RemoveItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is BaseEntity item))
                return;
            await AppCore.DeleteAsync(item);
        }

        private async Task RefreshDataGridAsync()
        {
            var displayedRow = 0;
            if (dataGridView.Rows.Count > 0 && dataGridView.FirstDisplayedCell != null)
                displayedRow = dataGridView.FirstDisplayedCell.RowIndex;
            var selectedRow = 0;
            if (dataGridView.SelectedRows.Count > 0)
                selectedRow = dataGridView.SelectedRows[0].Index;

            var data = await FillDataAsync();
            if (!prepared)
                PrepareDataGrid(data.GetType().GenericTypeArguments.FirstOrDefault());
            dataGridView.DataSource = data;

            if (displayedRow != 0 && displayedRow < dataGridView.Rows.Count)
                dataGridView.FirstDisplayedScrollingRowIndex = displayedRow;
            if (selectedRow != 0 && selectedRow < dataGridView.Rows.Count)
                dataGridView.Rows[selectedRow].Selected = true;
        }

        private bool prepared;
        private void PrepareDataGrid(Type type)
        {
            dataGridView.AutoGenerateColumns = false;
            foreach (var property in type.GetProperties())
                if (property.GetCustomAttributes(typeof(ColumnAttribute), false).SingleOrDefault() is ColumnAttribute attribute)
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        Name = property.Name,
                        DataPropertyName = property.Name,
                        HeaderText = attribute.Name,
                        FillWeight = attribute.FillWeight
                    };
                    dataGridView.Columns.Add(column);
                }
            prepared = true;
        }

        private async void addToolStripButton_Click(object sender, EventArgs e) => await OnAddItemAsync();

        private async void editToolStripButton_Click(object sender, EventArgs e) => await OnEditItemAsync();

        private async void removeToolStripButton_Click(object sender, EventArgs e) => await OnRemoveItemAsync();
    }
}
