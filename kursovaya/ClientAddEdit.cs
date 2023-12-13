using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class ClientAddEdit : Form
    {
        DataBase dataBase = new DataBase("employer", "1q2w3e4r5");
        int currentid;
        public ClientAddEdit()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public ClientAddEdit(int id, string[] fio, string phone)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            currentid = id;
            tSurname.Text = fio[0].Trim();
            tName.Text = fio[1].Trim();
            tPatronym.Text = fio[2].Trim();
            tPhone.Text = phone;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            if (tSurname.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Фамилия\" не может быть пустым", "Ошибка");
                return;
            }
            if (tName.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Имя\" не может быть пустым", "Ошибка");
                return;
            }
            if (tPatronym.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Отчество\" не может быть пустым", "Ошибка");
                return;
            }
            if (tPhone.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Номер телефона\" не может быть пустым", "Ошибка");
                return;
            }
            string surname = tSurname.Text.Trim();
            string name = tName.Text.Trim();
            string patronym = tPatronym.Text.Trim();
            string phone = tPhone.Text.Trim();
            if (this.Text == "Добавление клиента")
            {
                string addQuery = $"insert into client (surname, name, patronym, phone) " +
                    $"values ('{surname}','{name}','{patronym}','{phone}')";
                SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();                
            }
            else
            {
                string editQuery = $"update client set surname = '{surname}', name = '{name}', patronym = '{patronym}', " +
                    $"phone = '{phone}' where id = '{currentid}' ";
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
    }
}
