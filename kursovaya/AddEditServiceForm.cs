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
    public partial class AddEditServiceForm : Form
    {
        DataBase dataBase = new DataBase("root", "1q2w3e4r5");
        int currentid;
        public AddEditServiceForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public AddEditServiceForm(int id, string name, string duration, string price, string description)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            tName.Text = name;
            tDuration.Text = duration;
            tPrice.Text = price;
            tDescription.Text = description;
            currentid = id;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();
            if (tName.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Название\" не может быть пустым", "Ошибка");
                return;
            }
            string name = tName.Text;
            int duration;
            int price;
            
            if (int.TryParse(tDuration.Text, out duration))
            {
                if (duration <= 0)
                {
                    MessageBox.Show("Неверно задана продолжительность услуги", "Ошибка");
                    return;
                }
                if (int.TryParse(tPrice.Text, out price))
                {
                    if (price < 0)
                    {
                        MessageBox.Show("Неверно задана стоимость услуги", "Ошибка");
                        return;
                    }
                    if (tDescription.Text.Trim() == "")
                    {
                        if (this.Text == "Добавление услуги")
                        {
                            string addQuery = $"insert into service (name, duration, price) values ('{name}','{duration}','{price}')";
                            SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                        else
                        {
                            string editQuery = $"update service set name = '{name}', duration = '{duration}', price = '{price}', description = NULL where id = '{currentid}' ";
                            SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                    }
                    else 
                    {
                        string description = tDescription.Text.Trim();
                        if (this.Text == "Добавление услуги")
                        {
                            string addQuery = $"insert into service (name, duration, price, description) values ('{name}','{duration}','{price}','{description}')";
                            SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                        else
                        {
                            string editQuery = $"update service set name = '{name}', duration = '{duration}', price = '{price}', description = '{description}' where id = '{currentid}' ";
                            SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Запись не была добавлена", "Ошибка");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Запись не была добавлена","Ошибка");
                return;
            }
            dataBase.CloseConnection();
            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void tPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void tDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
