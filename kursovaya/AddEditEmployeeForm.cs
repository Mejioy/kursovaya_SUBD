using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class AddEditEmployeeForm : Form
    {
        int currentid;
        string path;
        DataBase dataBase = new DataBase("root", "1q2w3e4r5");
        public AddEditEmployeeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public AddEditEmployeeForm(int id, string[] fio, string phone, string[] adress,string path)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            currentid = id;
            tSurname.Text = fio[0].Trim();
            tName.Text = fio[1].Trim();
            tPatronym.Text = fio[2].Trim();
            tPhone.Text = phone;
            tCity.Text = adress[0].Trim();
            tStreet.Text = adress[1].Trim();
            tHouse.Text = adress[2].Trim();
            if (adress.Length > 3)
                tAppartment.Text = adress[3].Trim();
            else
                tAppartment.Text = "";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if(File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
                this.path = path;
            }
        }
        private void bOk_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();

            if (!File.Exists(path))
            {
                MessageBox.Show("Не выбрано фото сотрудника", "Ошибка");
                return;
            }
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
            if (tCity.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Город\" не может быть пустым", "Ошибка");
                return;
            }
            if (tStreet.Text.Trim() == "")
            {
                MessageBox.Show("Поле \"Улица\" не может быть пустым", "Ошибка");
                return;
            }
            string surname = tSurname.Text.Trim();
            string name = tName.Text.Trim();
            string patronym = tPatronym.Text.Trim();
            string phone = tPhone.Text.Trim();
            string city = tCity.Text.Trim();
            string street = tStreet.Text.Trim();
            int house;
            int appartment;
            if (int.TryParse(tHouse.Text, out house))
            {
                if (house <= 0)
                {
                    MessageBox.Show("Неверно задан номер дома", "Ошибка");
                    return;
                }
                if (int.TryParse(tAppartment.Text, out appartment)||tAppartment.Text.Trim()=="")
                {
                    if (tAppartment.Text.Trim() == "")
                    {
                        if (this.Text == "Добавление сотрудника")
                        {
                            string addQuery = $"insert into employee (surname, name, patronym, phone, city, street, house, path) " +
                                $"values ('{surname}','{name}','{patronym}','{phone}','{city}','{street}','{house}','{path}')";
                            SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                        else
                        {
                            string editQuery = $"update employee set surname = '{surname}', name = '{name}', patronym = '{patronym}'," +
                                $" phone = '{phone}', city = '{city}', street = '{street}'," +
                                $" house = '{house}', appartment = NULL, path = '{path}' " +
                                $"where id = '{currentid}' ";
                            SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                    }
                    else
                    {
                        if (appartment <= 0)
                        {
                            MessageBox.Show("Неверно задан номер квартиры", "Ошибка");
                            return;
                        }
                        if (this.Text == "Добавление сотрудника")
                        {
                            string addQuery = $"insert into employee (surname, name, patronym, phone, city, street, house, appartment, path) " +
                                $"values ('{surname}','{name}','{patronym}','{phone}','{city}','{street}','{house}','{appartment}','{path}')";
                            SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                        else
                        {
                            string editQuery = $"update employee set surname = '{surname}', name = '{name}', patronym = '{patronym}'," +
                                $" phone = '{phone}', city = '{city}', street = '{street}'," +
                                $" house = '{house}', appartment = '{appartment}', path = '{path}' " +
                                $"where id = '{currentid}' ";
                            SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Неверно задан номер квартиры", "Ошибка");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверно задан номер дома", "Ошибка");
                return;
            }

            dataBase.CloseConnection();

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bChoicePhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"; //формат загружаемого файла |All files (*.*)|*.*
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                path = openFileDialog.FileName;
            }
        }

        private void tHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void tAppartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }
    }
}
