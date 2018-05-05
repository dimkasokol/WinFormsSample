using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales.Entities;
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

        public async Task<IEnumerable<T>> GetAllAsync<T>(Func<SqlDataReader, T> fromReader) where T : BaseEntity
        {
            var items = new List<T>();
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            using (var command = new SqlCommand(GetProcedures<T>()?.GetAll, connection))
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                        items.Add(fromReader.Invoke(reader));
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            return items;
        }

        public async Task InsertOrUpdateAsync(BaseEntity entity)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            using (var command = new SqlCommand(GetProcedures(entity.GetType())?.InsertOrUpdate, connection))
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(entity.GetParameters());
                    await connection.OpenAsync();
                    if (await command.ExecuteScalarAsync() is int id)
                        entity.Id = id;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
        }

        public async Task DeleteAsync(BaseEntity entity)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            using (var command = new SqlCommand(GetProcedures(entity.GetType())?.Delete, connection))
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("id", entity.Id));
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
        }

        private SqlProceduresAttribute GetProcedures<T>() => typeof(T).GetCustomAttributes(typeof(SqlProceduresAttribute), false).SingleOrDefault() as SqlProceduresAttribute;

        private SqlProceduresAttribute GetProcedures(Type type) => type.GetCustomAttributes(typeof(SqlProceduresAttribute), false).SingleOrDefault() as SqlProceduresAttribute;

        private void CheckConnection()
        {
            var connectionString = Properties.Settings.Default.ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var retry = false;
                while (connection.State != ConnectionState.Open)
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
