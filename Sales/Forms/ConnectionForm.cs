using System;
using System.Windows.Forms;

namespace Sales.Forms
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        public string GetConnectionString()
        {
            if (ShowDialog() != DialogResult.OK)
                return string.Empty;
            return $"Data Source={dataSourceTextBox.Text};Initial Catalog={initialCatalogTextBox.Text};"
                + (integratedSecurityCheckBox.Checked ? "Integrated Security=True" : $"User Id={userIdTextBox.Text};Password={passwordTextBox.Text}");
        }

        private void integratedSecurityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            userIdTextBox.Enabled = !integratedSecurityCheckBox.Checked;
            passwordTextBox.Enabled = !integratedSecurityCheckBox.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dataSourceTextBox.Text) ||
                string.IsNullOrWhiteSpace(initialCatalogTextBox.Text) ||
                !integratedSecurityCheckBox.Checked && (string.IsNullOrWhiteSpace(userIdTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text)))
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
