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
    public partial class CarAddEdit : Form
    {
        DataBase dataBase = new DataBase("employer", "1q2w3e4r5");
        int currentid, idclient;
        public CarAddEdit(int idclient)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.idclient = idclient;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            if (tMark.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Марка\" не может быть пустым", "Ошибка");
                return;
            }
            if (tModel.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Модель\" не может быть пустым", "Ошибка");
                return;
            }
            if (tGosnumber.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Гос. номер\" не может быть пустым", "Ошибка");
                return;
            }            
            string mark = tMark.Text.Trim();
            string model = tModel.Text.Trim();
            string gosnumber = tGosnumber.Text.Trim();           
            if (this.Text == "Добавление автомобиля клиенту")
            {
                string addQuery = $"insert into automobile (mark, model, gosnumber, idclient) " +
                    $"values ('{mark}','{model}','{gosnumber}','{idclient}')";
                SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            else
            {
                string editQuery = $"update automobile set mark = '{mark}', model = '{model}', gosnumber = '{gosnumber}', " +
                    $"idclient = '{idclient}' where id = '{currentid}' ";
                SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }

            dataBase.CloseConnection();

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public CarAddEdit(int id, string mark, string model, string gosnumber, int idclient)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            currentid = id;
            this.idclient = idclient;
            tMark.Text = mark;
            tModel.Text = model;
            tGosnumber.Text = gosnumber;
        }
    }
}
