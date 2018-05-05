using System.Windows.Forms;

namespace Sales.Forms
{
    public partial class BaseCoreForm : Form
    {
        public BaseCoreForm()
        {
            InitializeComponent();
        }

        public BaseCoreForm(AppCore appCore)
        {
            InitializeComponent();
            AppCore = appCore;
        }

        protected AppCore AppCore { get; private set; }
    }
}
