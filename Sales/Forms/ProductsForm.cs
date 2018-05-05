using System.Collections.Generic;
using System.Threading.Tasks;
using Sales.Entities;

namespace Sales.Forms
{
    public partial class ProductsForm : BaseGridForm
    {
        public ProductsForm(AppCore appCore) : base(appCore)
        {
            InitializeComponent();
        }

        protected override async Task<IEnumerable<object>> FillDataAsync() => await AppCore.GetAllAsync((reader) => Product.GetFromReader(reader));

        protected override async Task OnAddItemAsync()
        {
            using (var form = new ProductForm(AppCore))
                await form.InsertOrUpdateAsync(new Product());
            await base.OnAddItemAsync();
        }

        protected override async Task OnEditItemAsync()
        {
            if (dataGridView.SelectedRows.Count < 1 || !(dataGridView.SelectedRows[0].DataBoundItem is Product product))
                return;
            using (var form = new ProductForm(AppCore))
                await form.InsertOrUpdateAsync(product);
            await base.OnEditItemAsync();
        }
    }
}
