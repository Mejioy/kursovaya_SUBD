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
    public partial class Employer : Form
    {
        DataBase dataBase = new DataBase("employer", "1q2w3e4r5");        
        int selectedRow;
        public Employer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            switch (dgw.Name)
            {
                case "dGVProvidedList":
                    dgw.Rows.Add(                        
                        record.GetInt32(0),
                        record.GetString(1), 
                        record.GetString(2) + ' ' + record.GetString(3) + ' ' + record.GetString(4),
                        record.GetString(5) + ' ' + record.GetString(6) + ' ' + record.GetString(7),
                        record.GetString(8) + ' ' + record.GetString(9) + ' ' + record.GetString(10),
                        record.GetInt32(11),
                        record.GetDateTime(12).ToShortDateString(),
                        record.GetInt32(13),
                        record.GetInt32(14),
                        record.GetInt32(15),
                        record.GetInt32(16)
                        );
                    break;
                case "dGVClientsList":
                    dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1) + ' ' + record.GetString(2) + ' ' + record.GetString(3),
                        record.GetString(4));
                    break;
                case "dGVCarsOfClient":
                    dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3)
                        );
                    break;
                case "dGVProvidedServicesOfCars":
                    dgw.Rows.Add(
                        record.GetString(0),
                        record.GetInt32(1),
                        record.GetString(2) + ' ' + record.GetString(3) + ' ' + record.GetString(4),
                        record.GetDateTime(5).ToShortDateString()
                        );
                    break;
                default:
                    break;
            }
        }
        private void RefreshDataGrid(DataGridView dgw, int id=-1)
        {            
            dgw.Rows.Clear();
            string queryString = "";
            switch (dgw.Name)
            {
                case "dGVProvidedList":
                    queryString = $"select provided_service.id, service.name, client.surname, client.name, client.patronym, " +
                        $"automobile.mark,  automobile.model, automobile.gosnumber, " +
                        $"employee.surname, employee.name, employee.patronym, " +
                        $"service.price,  provided_service.datatime, " +
                        $"client.id, provided_service.idservice, provided_service.idemployee, provided_service.idautomobile " +
                        $"from  provided_service " +
                        $"INNER JOIN service ON provided_service.idservice = service.id " +
                        $"INNER JOIN employee ON provided_service.idemployee = employee.id " +
                        $"INNER JOIN automobile ON provided_service.idautomobile = automobile.id " +
                        $"INNER JOIN client ON automobile.idclient = client.id";
                    break;
                case "dGVClientsList":
                    queryString = $"select * from client";
                    break;
                case "dGVCarsOfClient":
                    queryString = $"select * from automobile where idclient='{id}'";
                    break;
                case "dGVProvidedServicesOfCars":
                    queryString = $"select service.name,  service.price,  employee.surname, employee.name, employee.patronym, provided_service.datatime " +
                    $"from  provided_service " +
                    $"INNER JOIN service ON provided_service.idservice = service.id " +
                    $"INNER JOIN employee ON provided_service.idemployee = employee.id " +
                    $"INNER JOIN automobile ON provided_service.id = automobile.id " +
                    $"where provided_service.idautomobile = '{id}'";
                    break;
                default:
                    break;
            }
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

        private void RefreshAll()
        {            
            RefreshDataGrid(dGVClientsList);
            if (dGVClientsList.Rows.Count > 0)
            {
                RefreshDataGrid(dGVCarsOfClient, Convert.ToInt32(dGVClientsList.Rows[0].Cells[0].Value));
                if (dGVCarsOfClient.Rows.Count > 0)
                {
                    lProvidedServices.Text = $"Список услуг автомобиля {dGVCarsOfClient.Rows[0].Cells[1].Value} {dGVCarsOfClient.Rows[0].Cells[2].Value}        Гос.номер: {dGVCarsOfClient.Rows[0].Cells[3].Value}:";
                    RefreshDataGrid(dGVProvidedServicesOfCars, Convert.ToInt32(dGVCarsOfClient.Rows[0].Cells[0].Value));
                }
            }
        }
        
        private void Employer_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dGVProvidedList);
            RefreshAll();
        }      
        

        private void bAddClient_Click(object sender, EventArgs e)
        {
            ClientAddEdit clientAddEdit = new ClientAddEdit();
            clientAddEdit.Text = "Добавление клиента";
            if (clientAddEdit.ShowDialog() == DialogResult.OK)
            {
                RefreshAll();
            }
        }

        private void bClientEdit_Click(object sender, EventArgs e)
        {
            if (dGVClientsList.Rows.Count>0)
            {
                selectedRow = dGVClientsList.CurrentCell.RowIndex;
                if (dGVClientsList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    ClientAddEdit clientAddEdit = new ClientAddEdit(
                        Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value),
                        dGVClientsList.Rows[selectedRow].Cells[1].Value.ToString().Split(' '),
                        dGVClientsList.Rows[selectedRow].Cells[2].Value.ToString()
                        );
                    clientAddEdit.Text = "Изменение информации о клиенте";
                    if (clientAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        RefreshAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Список клиентов пуст", "Уведомление");
            }
            
        }

        private void bRemoveClient_Click(object sender, EventArgs e)
        {
            if (dGVClientsList.Rows.Count > 0)
            {
                selectedRow = dGVClientsList.CurrentCell.RowIndex;
                if (dGVClientsList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value);
                    string deleteQuery = $"delete from client where id= {id}";
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись? Это приведёт к удалению всех записей связанных с этим клиентом!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.OpenConnection();

                        SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        dataBase.CloseConnection();
                        RefreshAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Список клиентов пуст", "Уведомление");
            }

        }

        private void bAddCar_Click(object sender, EventArgs e)
        {
            if(dGVClientsList.Rows.Count>0)
            {
                selectedRow = dGVClientsList.CurrentCell.RowIndex;
                CarAddEdit carAddEdit = new CarAddEdit(Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value));
                carAddEdit.Text = "Добавление автомобиля клиенту";
                if (carAddEdit.ShowDialog() == DialogResult.OK)
                {
                    selectedRow = dGVClientsList.CurrentCell.RowIndex;
                    RefreshDataGrid(dGVCarsOfClient, Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value));
                }
            }
            else
            {
                MessageBox.Show("Для добавления автомобиля сначала необходимо выбрать клиента из списка, но список клиентов пуст", "Уведомление");
            }            
        }

        private void bEditCar_Click(object sender, EventArgs e)
        {
            if (dGVCarsOfClient.Rows.Count > 0)
            {
                selectedRow = dGVClientsList.CurrentCell.RowIndex;
                int selectedCarRow = dGVCarsOfClient.CurrentCell.RowIndex;
                if (dGVCarsOfClient.Rows[selectedCarRow].Cells[0].Value.ToString() != string.Empty)
                {
                    CarAddEdit carAddEdit = new CarAddEdit(Convert.ToInt32(dGVCarsOfClient.Rows[selectedCarRow].Cells[0].Value),
                        dGVCarsOfClient.Rows[selectedCarRow].Cells[1].Value.ToString(),
                        dGVCarsOfClient.Rows[selectedCarRow].Cells[2].Value.ToString(),
                        dGVCarsOfClient.Rows[selectedCarRow].Cells[3].Value.ToString(),
                        Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value)
                        );
                    carAddEdit.Text = "Изменение информации об автомобиле клиента";
                    if (carAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        selectedRow = dGVClientsList.CurrentCell.RowIndex;
                        RefreshDataGrid(dGVCarsOfClient, Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value));
                    }
                }
            }
            else
            {
                MessageBox.Show("Список автомобилей пуст", "Уведомление");
            }
        }

        private void bRemoveCar_Click(object sender, EventArgs e)
        {
            if (dGVCarsOfClient.Rows.Count > 0)
            {
                selectedRow = dGVCarsOfClient.CurrentCell.RowIndex;                
                if (dGVCarsOfClient.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(dGVCarsOfClient.Rows[selectedRow].Cells[0].Value);
                    string deleteQuery = $"delete from automobile where id= {id}";
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись? Это приведёт к удалению всех записей связанных с этим автомобилем!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.OpenConnection();

                        SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        dataBase.CloseConnection();
                        selectedRow = dGVClientsList.CurrentCell.RowIndex;
                        RefreshDataGrid(dGVCarsOfClient, Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value));
                    }
                }
            }
            else
            {
                MessageBox.Show("Список автомобилей пуст", "Уведомление");
            }
        }            

        private void dGVClientsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGVProvidedServicesOfCars.Rows.Clear();
            selectedRow = dGVClientsList.CurrentCell.RowIndex;
            RefreshDataGrid(dGVCarsOfClient, Convert.ToInt32(dGVClientsList.Rows[selectedRow].Cells[0].Value));
            lAutomobiles.Text = $"Список автомобилей клиента \"{dGVClientsList.Rows[selectedRow].Cells[1].Value}\":";
            if (dGVCarsOfClient.Rows.Count > 0)
            {
                selectedRow = dGVCarsOfClient.CurrentCell.RowIndex;
                RefreshDataGrid(dGVProvidedServicesOfCars, Convert.ToInt32(dGVCarsOfClient.Rows[selectedRow].Cells[0].Value));
                if (dGVProvidedServicesOfCars.Rows.Count == 0)
                {                    
                    lProvidedServices.Text = "Данному автомобилю не оказывались услуги";
                }
                else
                {
                    lProvidedServices.Text = $"Список услуг автомобиля {dGVCarsOfClient.Rows[selectedRow].Cells[1].Value} {dGVCarsOfClient.Rows[selectedRow].Cells[2].Value}        Гос.номер: {dGVCarsOfClient.Rows[selectedRow].Cells[3].Value}:";
                }
            }
            else
                lProvidedServices.Text = "Список автомобилей клиента пуст";
        }

        private void dGVCarsOfClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVCarsOfClient.Rows.Count > 0)
            {
                selectedRow = dGVCarsOfClient.CurrentCell.RowIndex;
                RefreshDataGrid(dGVProvidedServicesOfCars, Convert.ToInt32(dGVCarsOfClient.Rows[selectedRow].Cells[0].Value));
                if (dGVProvidedServicesOfCars.Rows.Count == 0)
                {                    
                    lProvidedServices.Text = "Данному автомобилю не оказывались услуги";
                }
                else
                {
                    lProvidedServices.Text = $"Список услуг автомобиля {dGVCarsOfClient.Rows[selectedRow].Cells[1].Value} {dGVCarsOfClient.Rows[selectedRow].Cells[2].Value}        Гос.номер: {dGVCarsOfClient.Rows[selectedRow].Cells[3].Value}:";
                }
            }
        }

        private void bProvidedServiceAdd_Click(object sender, EventArgs e)
        {
            ProvidedServiceAddEdit providedServiceAddEdit = new ProvidedServiceAddEdit();
            providedServiceAddEdit.Text = "Добавление оказанной услуги";
            if (providedServiceAddEdit.ShowDialog() == DialogResult.OK)
            {
                RefreshDataGrid(dGVProvidedList);
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            if (dGVProvidedList.Rows.Count > 0)
            {
                selectedRow = dGVProvidedList.CurrentCell.RowIndex;
                if (dGVProvidedList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    ProvidedServiceAddEdit providedServiceAddEdit = new ProvidedServiceAddEdit(
                        Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[0].Value),
                        Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[7].Value),
                        Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[8].Value),
                        Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[9].Value),
                        Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[10].Value),
                        Convert.ToDateTime(dGVProvidedList.Rows[selectedRow].Cells[6].Value)
                        );
                    providedServiceAddEdit.Text = "Изменение информации об оказанной услуге";
                    if (providedServiceAddEdit.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDataGrid(dGVProvidedList);
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствуют записи для изменения", "Уведомление");
            }
            
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if(dGVProvidedList.Rows.Count > 0)
            {
                selectedRow = dGVProvidedList.CurrentCell.RowIndex;
                if (dGVProvidedList.Rows[selectedRow].Cells[0].Value.ToString() != string.Empty)
                {
                    int id = Convert.ToInt32(dGVProvidedList.Rows[selectedRow].Cells[0].Value);
                    string deleteQuery = $"delete from provided_service where id= {id}";
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись? Информацию о удалённой оказанной услуге будет невозможно восстановить!", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.OpenConnection();

                        SqlCommand command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                        command.ExecuteNonQuery();

                        dataBase.CloseConnection();
                        RefreshDataGrid(dGVProvidedList);
                    }
                }
            }            
            else
            {
                MessageBox.Show("Отсутствуют записи для удаления", "Уведомление");
            }
        }
    }
}
