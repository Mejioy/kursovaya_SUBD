using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovaya
{
    public partial class ProvidedServiceAddEdit : Form
    {
        DataBase dataBase = new DataBase("employer", "1q2w3e4r5");
        int currentid;
        int selectedRow;
        int? currentClientId = null;
        int? currentCarId = null;
        int? currentServiceId = null;
        int? currentEmployerId = null;        
        public ProvidedServiceAddEdit()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public ProvidedServiceAddEdit(int idProvidedService, int currentClientId, int currentServiceId, int currentEmployerId, int currentCarId, DateTime dateTime)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            currentid = idProvidedService;
            this.currentClientId = currentClientId;
            this.currentCarId = currentCarId;
            this.currentServiceId = currentServiceId;
            this.currentEmployerId = currentEmployerId;
            dateTimePicker1.Value = dateTime;
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            switch (dgw.Name)
            {
                case "dGVClient":
                    dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1) + ' ' + record.GetString(2) + ' ' + record.GetString(3),
                        record.GetString(4));
                    break;
                case "dGVAutomobile":
                    dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3)                        
                        );
                    break;
                case "dGVService":
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
                case "dGVEmployer":
                    dgw.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1) + ' ' + record.GetString(2) + ' ' + record.GetString(3),
                        record.GetString(4));
                    break;
                default:
                    break;
            }
        }
        private void RefreshDataGrid(DataGridView dgw, int id = -1)
        {
            dgw.Rows.Clear();
            string queryString = "";
            switch (dgw.Name)
            {
                case "dGVClient":
                    queryString = "select DISTINCT client.id, client.surname, client.name, client.patronym, client.phone from automobile " +
                        "INNER JOIN client ON automobile.idclient = client.id";
                    break;
                case "dGVAutomobile":
                    queryString = $"select * from automobile where idclient='{id}'";
                    break;
                case "dGVService":
                    queryString = "select * from service";
                    break;
                case "dGVEmployer":
                    queryString = "select * from employee";
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

        private void ProvidedServiceAddEdit_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dGVClient);
            if (dGVClient.Rows.Count > 0)
                RefreshDataGrid(dGVAutomobile, Convert.ToInt32(dGVClient.Rows[0].Cells[0].Value));
            RefreshDataGrid(dGVEmployer);
            RefreshDataGrid(dGVService);
            if (currentClientId != null)
            {                
                SetNecessaryRow(dGVClient, currentClientId);
                int selectedRow = dGVClient.SelectedRows[0].Index;
                RefreshDataGrid(dGVAutomobile, Convert.ToInt32(dGVClient.Rows[selectedRow].Cells[0].Value));                              
                SetNecessaryRow(dGVService, currentServiceId);                
                SetNecessaryRow(dGVEmployer, currentEmployerId);
                SetNecessaryRow(dGVAutomobile, currentCarId);
            }   
        }
        private void SetNecessaryRow(DataGridView dgw, int? id)
        {
            int selectedRow = dgw.CurrentCell.RowIndex;
            dgw.Rows[selectedRow].Selected = false;
            foreach (DataGridViewRow row in dgw.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {                    
                    row.Selected = true;                    
                }
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            dataBase.OpenConnection();            
            if (dateTimePicker1 != null)
            {
                DateTime datatime = dateTimePicker1.Value;
                if(dGVAutomobile.Rows.Count<=0)
                {
                    MessageBox.Show("Не выбран автомобиль, т.к. список автомобилей пуст", "Ошибка");
                    return;
                }
                selectedRow = dGVAutomobile.CurrentCell.RowIndex;
                int idautomobile = Convert.ToInt32(dGVAutomobile.Rows[selectedRow].Cells[0].Value);
                if (dGVEmployer.Rows.Count <= 0)
                {
                    MessageBox.Show("Не выбран сотрудник, т.к. список сотрудников пуст", "Ошибка");
                    return;
                }
                selectedRow = dGVEmployer.CurrentCell.RowIndex;
                int idemployee = Convert.ToInt32(dGVEmployer.Rows[selectedRow].Cells[0].Value);
                if (dGVService.Rows.Count <= 0)
                {
                    MessageBox.Show("Не выбрана услгуа, т.к. список услуг пуст", "Ошибка");
                    return;
                }
                selectedRow = dGVService.CurrentCell.RowIndex;
                int idservice = Convert.ToInt32(dGVService.Rows[selectedRow].Cells[0].Value);
                if (this.Text == "Добавление оказанной услуги")
                {
                    string addQuery = $"insert into provided_service (idservice, idemployee, idautomobile, datatime) " +
                        $"values ('{idservice}','{idemployee}','{idautomobile}','{datatime}')";
                    SqlCommand command = new SqlCommand(addQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                else
                {
                    string editQuery = $"update provided_service set idservice = '{idservice}', idemployee = '{idemployee}', " +
                        $"idautomobile = '{idautomobile}', datatime = '{datatime}' where id = '{currentid}' ";
                    SqlCommand command = new SqlCommand(editQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Поле \"Дата оказания услуги\" не может быть пустым", "Ошибка");
                return;
            }            
            dataBase.CloseConnection();

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dGVClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            selectedRow = dGVClient.CurrentCell.RowIndex;
            RefreshDataGrid(dGVAutomobile, Convert.ToInt32(dGVClient.Rows[selectedRow].Cells[0].Value));            
        }
    }
}
