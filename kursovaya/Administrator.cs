using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace kursovaya
{
    public partial class Administrator : Form
    {
        DataBase dataBase = new DataBase("root","1q2w3e4r5");
        int selectedRow;
        public Administrator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            switch (dgw.Name)
            {
                case "dGVServicesList":
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
                    break; 
                case "dGVEmployeeList":
                    int? value8 = null;
                    if (!record.IsDBNull(8))
                    {
                        value8 = record.GetInt32(8);
                    }
                    if (value8!=null)
                        dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1)+' '+record.GetString(2) + ' ' + record.GetString(3),
                        record.GetString(4),
                        record.GetString(5) + ", " + record.GetString(6) + ", " + record.GetInt32(7) + ", " + value8,
                        record.GetString(9)
                        );
                    else
                        dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1) + ' ' + record.GetString(2) + ' ' + record.GetString(3),
                        record.GetString(4),
                        record.GetString(5) + ", " + record.GetString(6) + ", " + record.GetInt32(7),
                        record.GetString(9)
                        );
                    break;
                default:
                    break;
            }            
        }
        private void FillLabel(Label label, string procedurename, string labeltext)
        {
            using (SqlCommand command = new SqlCommand($"{procedurename}", dataBase.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                dataBase.OpenConnection();
                var result = command.ExecuteScalar(); // Получение результата процедуры
                dataBase.CloseConnection();
                label.Text = $"{labeltext}" + result.ToString();
            }
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString="";            
            switch (dgw.Name)
            {
                case "dGVServicesList":
                    queryString = $"select * from service";
                    break;
                case "dGVEmployeeList":
                    queryString = $"select * from employee";
                    break;
                default:
                    break;
            }            
            SqlCommand cmd = new SqlCommand(queryString,dataBase.GetConnection());

            dataBase.OpenConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw,reader);
            }
            reader.Close();
            dataBase.CloseConnection();
            FillLabel(lServicesCount, "CountOfRecordsServices", "Количество услуг: ");
            FillLabel(lEmployerCount, "CountOfRecordsEmployers", "Количество сотрудников: ");
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dGVServicesList);
            RefreshDataGrid(dGVEmployeeList);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            AddEditServiceForm addEditServiceForm = new AddEditServiceForm();
            addEditServiceForm.Text = "Добавление услуги";            
            if(addEditServiceForm.ShowDialog() == DialogResult.OK)
            {                
                RefreshDataGrid(dGVServicesList);
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            if (dGVServicesList.Rows.Count > 0)
            {
                selectedRow = dGVServicesList.CurrentCell.RowIndex;
                if (dGVServicesList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    AddEditServiceForm addEditServiceForm = new AddEditServiceForm(
                        Convert.ToInt32(dGVServicesList.Rows[selectedRow].Cells[0].Value),
                        dGVServicesList.Rows[selectedRow].Cells[1].Value.ToString(),
                        dGVServicesList.Rows[selectedRow].Cells[2].Value.ToString(),
                        dGVServicesList.Rows[selectedRow].Cells[3].Value.ToString(),
                        dGVServicesList.Rows[selectedRow].Cells[4].Value.ToString());
                    addEditServiceForm.Text = "Изменение услуги";
                    if (addEditServiceForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDataGrid(dGVServicesList);
                    }
                }
            }
            else
            {
                MessageBox.Show("Список услуг пуст", "Уведомление");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dGVServicesList.Rows.Count > 0)
            {
                selectedRow = dGVServicesList.CurrentCell.RowIndex;
                if (dGVServicesList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(dGVServicesList.Rows[selectedRow].Cells[0].Value);
                    string deleteQuery = $"delete from service where id= {id}";
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись? Это приведёт к удалению всех записей связанных с этой услугой!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.OpenConnection();

                        SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        dataBase.CloseConnection();
                        RefreshDataGrid(dGVServicesList);
                    }
                }
            }
            else
            {
                MessageBox.Show("Список услуг пуст", "Уведомление");
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            selectedRow = dGVEmployeeList.CurrentCell.RowIndex;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;            
            if (dGVEmployeeList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
            {                
                if (File.Exists(dGVEmployeeList.Rows[selectedRow].Cells[4].Value.ToString()))
                {
                    pictureBox1.Image = Image.FromFile(dGVEmployeeList.Rows[selectedRow].Cells[4].Value.ToString());                    
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void bEmployeeAdd_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm addEditEmployeeForm = new AddEditEmployeeForm();
            addEditEmployeeForm.Text = "Добавление сотрудника";
            if (addEditEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGrid(dGVEmployeeList);
            }
        }

        private void bEmployeeEdit_Click(object sender, EventArgs e)
        {
            if (dGVEmployeeList.Rows.Count > 0)
            {
                selectedRow = dGVEmployeeList.CurrentCell.RowIndex;
                if (dGVEmployeeList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    string[] adress = dGVEmployeeList.Rows[selectedRow].Cells[3].Value.ToString().Split(',');
                    AddEditEmployeeForm addEditEmployeeForm = new AddEditEmployeeForm(
                        Convert.ToInt32(dGVEmployeeList.Rows[selectedRow].Cells[0].Value),
                        dGVEmployeeList.Rows[selectedRow].Cells[1].Value.ToString().Split(' '),
                        dGVEmployeeList.Rows[selectedRow].Cells[2].Value.ToString(),
                        adress,
                        dGVEmployeeList.Rows[selectedRow].Cells[4].Value.ToString());
                    addEditEmployeeForm.Text = "Изменение информации о сотруднике";
                    if (addEditEmployeeForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDataGrid(dGVEmployeeList);
                    }
                }
            }
            else
            {
                MessageBox.Show("Список сотрудников пуст", "Уведомление");
            }            
        }

        private void bEmployeeRemove_Click(object sender, EventArgs e)
        {
            if (dGVEmployeeList.Rows.Count > 0)
            {
                selectedRow = dGVEmployeeList.CurrentCell.RowIndex;
                if (dGVEmployeeList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(dGVEmployeeList.Rows[selectedRow].Cells[0].Value);
                    string deleteQuery = $"delete from employee where id= {id}";
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись? Это приведёт к удалению всех записей связанных с этим сотрудником!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.OpenConnection();

                        SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        dataBase.CloseConnection();
                        RefreshDataGrid(dGVEmployeeList);
                    }
                }
            }
            else
            {
                MessageBox.Show("Список сотрудников пуст", "Уведомление");
            }
        }
    }
}