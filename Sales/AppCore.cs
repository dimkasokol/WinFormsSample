using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Sales.Forms;

namespace Sales
{
    public class AppCore : ApplicationContext
    {
        public AppCore() : base()
        {
            CheckConnection();
            Forms = new List<BaseGridForm>();
            MainForm = new SalesForm(this);
        }

        public List<BaseGridForm> Forms { get; private set; }

        public T GetForm<T>() where T : BaseGridForm
        {
            if (Forms.OfType<T>().SingleOrDefault() is T form)
                return form;
            return null;
        }

        private void CheckConnection()
        {
            var connectionString = Properties.Settings.Default.ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var retry = false;
                while (connection.State != System.Data.ConnectionState.Open)
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception exc)
                    {
                        if (retry)
                            MessageBox.Show(exc.Message);
                        using (var connectionForm = new ConnectionForm())
                            connectionString = connectionForm.GetConnectionString();
                        connection.ConnectionString = connectionString;
                        retry = true;
                    }
            }
            Properties.Settings.Default.ConnectionString = connectionString;
            Properties.Settings.Default.Save();
        }
    }
}
