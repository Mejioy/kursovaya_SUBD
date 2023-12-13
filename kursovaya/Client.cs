using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Client : Form
    {
        DataBase dataBase = new DataBase("client", "1q2w3e4r5");
        public Client()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            string value4 = null;
            if (!record.IsDBNull(4))
            {
                value4 = record.GetString(4);
            }
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetInt32(2),
                record.GetInt32(3),
                value4
                );
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from service";           
            SqlCommand cmd = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dataBase.CloseConnection();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dGVServicesList);
        }
    }
}