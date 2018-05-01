using System;
using System.Windows.Forms;

namespace Sales.Forms
{
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
        }

        protected virtual void OkExecute()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void CancelExecute()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OkExecute();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelExecute();
        }
    }
}
