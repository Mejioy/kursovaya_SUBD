namespace kursovaya
{
    partial class Employer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVProvidedList = new System.Windows.Forms.DataGridView();
            this.providedserviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientfio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeefio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providedservicedatatime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providedservicesClientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providedserviceIdservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providedserviceIdemployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providedserviceIdautomobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTPTO = new System.Windows.Forms.DateTimePicker();
            this.dTPFrom = new System.Windows.Forms.DateTimePicker();
            this.bChange = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bProvidedServiceAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lProvidedServices = new System.Windows.Forms.Label();
            this.dGVProvidedServicesOfCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lAutomobiles = new System.Windows.Forms.Label();
            this.bRemoveCar = new System.Windows.Forms.Button();
            this.bEditCar = new System.Windows.Forms.Button();
            this.bAddCar = new System.Windows.Forms.Button();
            this.dGVCarsOfClient = new System.Windows.Forms.DataGridView();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carGosnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bRemoveClient = new System.Windows.Forms.Button();
            this.bClientEdit = new System.Windows.Forms.Button();
            this.bAddClient = new System.Windows.Forms.Button();
            this.dGVClientsList = new System.Windows.Forms.DataGridView();
            this.employerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProvidedList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProvidedServicesOfCars)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarsOfClient)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 783);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1274, 754);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список оказанных услуг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGVProvidedList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 703);
            this.panel2.TabIndex = 1;
            // 
            // dGVProvidedList
            // 
            this.dGVProvidedList.AllowUserToAddRows = false;
            this.dGVProvidedList.AllowUserToDeleteRows = false;
            this.dGVProvidedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProvidedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providedserviceid,
            this.servicename,
            this.clientfio,
            this.automobile,
            this.employeefio,
            this.serviceprice,
            this.providedservicedatatime,
            this.providedservicesClientid,
            this.providedserviceIdservice,
            this.providedserviceIdemployee,
            this.providedserviceIdautomobile});
            this.dGVProvidedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProvidedList.Location = new System.Drawing.Point(0, 0);
            this.dGVProvidedList.Name = "dGVProvidedList";
            this.dGVProvidedList.ReadOnly = true;
            this.dGVProvidedList.RowHeadersWidth = 51;
            this.dGVProvidedList.RowTemplate.Height = 24;
            this.dGVProvidedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProvidedList.Size = new System.Drawing.Size(1268, 703);
            this.dGVProvidedList.TabIndex = 0;
            // 
            // providedserviceid
            // 
            this.providedserviceid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.providedserviceid.HeaderText = "ID";
            this.providedserviceid.MinimumWidth = 6;
            this.providedserviceid.Name = "providedserviceid";
            this.providedserviceid.ReadOnly = true;
            this.providedserviceid.Width = 49;
            // 
            // servicename
            // 
            this.servicename.HeaderText = "Название услуги";
            this.servicename.MinimumWidth = 6;
            this.servicename.Name = "servicename";
            this.servicename.ReadOnly = true;
            this.servicename.Width = 150;
            // 
            // clientfio
            // 
            this.clientfio.HeaderText = "ФИО Клиента";
            this.clientfio.MinimumWidth = 6;
            this.clientfio.Name = "clientfio";
            this.clientfio.ReadOnly = true;
            this.clientfio.Width = 170;
            // 
            // automobile
            // 
            this.automobile.HeaderText = "Информация об автомобиле";
            this.automobile.MinimumWidth = 6;
            this.automobile.Name = "automobile";
            this.automobile.ReadOnly = true;
            this.automobile.Width = 180;
            // 
            // employeefio
            // 
            this.employeefio.HeaderText = "ФИО сотрудника";
            this.employeefio.MinimumWidth = 6;
            this.employeefio.Name = "employeefio";
            this.employeefio.ReadOnly = true;
            this.employeefio.Width = 170;
            // 
            // serviceprice
            // 
            this.serviceprice.HeaderText = "Стоимость";
            this.serviceprice.MinimumWidth = 6;
            this.serviceprice.Name = "serviceprice";
            this.serviceprice.ReadOnly = true;
            this.serviceprice.Width = 70;
            // 
            // providedservicedatatime
            // 
            this.providedservicedatatime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.providedservicedatatime.HeaderText = "Дата оказания";
            this.providedservicedatatime.MinimumWidth = 6;
            this.providedservicedatatime.Name = "providedservicedatatime";
            this.providedservicedatatime.ReadOnly = true;
            // 
            // providedservicesClientid
            // 
            this.providedservicesClientid.HeaderText = "";
            this.providedservicesClientid.MinimumWidth = 6;
            this.providedservicesClientid.Name = "providedservicesClientid";
            this.providedservicesClientid.ReadOnly = true;
            this.providedservicesClientid.Visible = false;
            this.providedservicesClientid.Width = 125;
            // 
            // providedserviceIdservice
            // 
            this.providedserviceIdservice.HeaderText = "";
            this.providedserviceIdservice.MinimumWidth = 6;
            this.providedserviceIdservice.Name = "providedserviceIdservice";
            this.providedserviceIdservice.ReadOnly = true;
            this.providedserviceIdservice.Visible = false;
            this.providedserviceIdservice.Width = 125;
            // 
            // providedserviceIdemployee
            // 
            this.providedserviceIdemployee.HeaderText = "";
            this.providedserviceIdemployee.MinimumWidth = 6;
            this.providedserviceIdemployee.Name = "providedserviceIdemployee";
            this.providedserviceIdemployee.ReadOnly = true;
            this.providedserviceIdemployee.Visible = false;
            this.providedserviceIdemployee.Width = 125;
            // 
            // providedserviceIdautomobile
            // 
            this.providedserviceIdautomobile.HeaderText = "";
            this.providedserviceIdautomobile.MinimumWidth = 6;
            this.providedserviceIdautomobile.Name = "providedserviceIdautomobile";
            this.providedserviceIdautomobile.ReadOnly = true;
            this.providedserviceIdautomobile.Visible = false;
            this.providedserviceIdautomobile.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dTPTO);
            this.panel1.Controls.Add(this.dTPFrom);
            this.panel1.Controls.Add(this.bChange);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bProvidedServiceAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 706);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 45);
            this.panel1.TabIndex = 0;
            // 
            // dTPTO
            // 
            this.dTPTO.Location = new System.Drawing.Point(585, 15);
            this.dTPTO.Name = "dTPTO";
            this.dTPTO.Size = new System.Drawing.Size(200, 22);
            this.dTPTO.TabIndex = 6;
            this.dTPTO.ValueChanged += new System.EventHandler(this.dTPTO_ValueChanged);
            // 
            // dTPFrom
            // 
            this.dTPFrom.Location = new System.Drawing.Point(244, 15);
            this.dTPFrom.Name = "dTPFrom";
            this.dTPFrom.Size = new System.Drawing.Size(200, 22);
            this.dTPFrom.TabIndex = 5;
            this.dTPFrom.ValueChanged += new System.EventHandler(this.dTPFrom_ValueChanged);
            // 
            // bChange
            // 
            this.bChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bChange.Location = new System.Drawing.Point(1075, 12);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(90, 30);
            this.bChange.TabIndex = 4;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bDelete.Location = new System.Drawing.Point(1170, 12);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(90, 30);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bProvidedServiceAdd
            // 
            this.bProvidedServiceAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bProvidedServiceAdd.Location = new System.Drawing.Point(979, 12);
            this.bProvidedServiceAdd.Name = "bProvidedServiceAdd";
            this.bProvidedServiceAdd.Size = new System.Drawing.Size(90, 30);
            this.bProvidedServiceAdd.TabIndex = 0;
            this.bProvidedServiceAdd.Text = "Добавить";
            this.bProvidedServiceAdd.UseVisualStyleBackColor = true;
            this.bProvidedServiceAdd.Click += new System.EventHandler(this.bProvidedServiceAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1274, 754);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные о клиентах";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lProvidedServices);
            this.panel3.Controls.Add(this.dGVProvidedServicesOfCars);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 248);
            this.panel3.TabIndex = 4;
            // 
            // lProvidedServices
            // 
            this.lProvidedServices.AutoSize = true;
            this.lProvidedServices.Location = new System.Drawing.Point(22, 6);
            this.lProvidedServices.Name = "lProvidedServices";
            this.lProvidedServices.Size = new System.Drawing.Size(176, 16);
            this.lProvidedServices.TabIndex = 10;
            this.lProvidedServices.Text = "Список услуг автомобиля";
            // 
            // dGVProvidedServicesOfCars
            // 
            this.dGVProvidedServicesOfCars.AllowUserToAddRows = false;
            this.dGVProvidedServicesOfCars.AllowUserToDeleteRows = false;
            this.dGVProvidedServicesOfCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProvidedServicesOfCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProvidedServicesOfCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dGVProvidedServicesOfCars.Location = new System.Drawing.Point(25, 25);
            this.dGVProvidedServicesOfCars.Name = "dGVProvidedServicesOfCars";
            this.dGVProvidedServicesOfCars.ReadOnly = true;
            this.dGVProvidedServicesOfCars.RowHeadersWidth = 51;
            this.dGVProvidedServicesOfCars.RowTemplate.Height = 24;
            this.dGVProvidedServicesOfCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProvidedServicesOfCars.Size = new System.Drawing.Size(1030, 200);
            this.dGVProvidedServicesOfCars.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название услуги";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО сотрудника";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата оказания";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lAutomobiles);
            this.panel4.Controls.Add(this.bRemoveCar);
            this.panel4.Controls.Add(this.bEditCar);
            this.panel4.Controls.Add(this.bAddCar);
            this.panel4.Controls.Add(this.dGVCarsOfClient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1268, 250);
            this.panel4.TabIndex = 5;
            // 
            // lAutomobiles
            // 
            this.lAutomobiles.AutoSize = true;
            this.lAutomobiles.Location = new System.Drawing.Point(22, 3);
            this.lAutomobiles.Name = "lAutomobiles";
            this.lAutomobiles.Size = new System.Drawing.Size(145, 16);
            this.lAutomobiles.TabIndex = 9;
            this.lAutomobiles.Text = "Список автомобилей";
            // 
            // bRemoveCar
            // 
            this.bRemoveCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRemoveCar.Location = new System.Drawing.Point(1070, 140);
            this.bRemoveCar.Name = "bRemoveCar";
            this.bRemoveCar.Size = new System.Drawing.Size(185, 30);
            this.bRemoveCar.TabIndex = 7;
            this.bRemoveCar.Text = "Удалить";
            this.bRemoveCar.UseVisualStyleBackColor = true;
            this.bRemoveCar.Click += new System.EventHandler(this.bRemoveCar_Click);
            // 
            // bEditCar
            // 
            this.bEditCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bEditCar.Location = new System.Drawing.Point(1070, 95);
            this.bEditCar.Name = "bEditCar";
            this.bEditCar.Size = new System.Drawing.Size(185, 30);
            this.bEditCar.TabIndex = 6;
            this.bEditCar.Text = "Изменить";
            this.bEditCar.UseVisualStyleBackColor = true;
            this.bEditCar.Click += new System.EventHandler(this.bEditCar_Click);
            // 
            // bAddCar
            // 
            this.bAddCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bAddCar.Location = new System.Drawing.Point(1070, 50);
            this.bAddCar.Name = "bAddCar";
            this.bAddCar.Size = new System.Drawing.Size(185, 30);
            this.bAddCar.TabIndex = 5;
            this.bAddCar.Text = "Добавить";
            this.bAddCar.UseVisualStyleBackColor = true;
            this.bAddCar.Click += new System.EventHandler(this.bAddCar_Click);
            // 
            // dGVCarsOfClient
            // 
            this.dGVCarsOfClient.AllowUserToAddRows = false;
            this.dGVCarsOfClient.AllowUserToDeleteRows = false;
            this.dGVCarsOfClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVCarsOfClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarsOfClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carID,
            this.carMark,
            this.carModel,
            this.carGosnumber});
            this.dGVCarsOfClient.Location = new System.Drawing.Point(25, 25);
            this.dGVCarsOfClient.Name = "dGVCarsOfClient";
            this.dGVCarsOfClient.ReadOnly = true;
            this.dGVCarsOfClient.RowHeadersWidth = 51;
            this.dGVCarsOfClient.RowTemplate.Height = 24;
            this.dGVCarsOfClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVCarsOfClient.Size = new System.Drawing.Size(1030, 200);
            this.dGVCarsOfClient.TabIndex = 2;
            this.dGVCarsOfClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCarsOfClient_CellClick);
            // 
            // carID
            // 
            this.carID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.carID.HeaderText = "ID";
            this.carID.MinimumWidth = 6;
            this.carID.Name = "carID";
            this.carID.ReadOnly = true;
            this.carID.Width = 49;
            // 
            // carMark
            // 
            this.carMark.HeaderText = "Марка";
            this.carMark.MinimumWidth = 6;
            this.carMark.Name = "carMark";
            this.carMark.ReadOnly = true;
            this.carMark.Width = 160;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Модель";
            this.carModel.MinimumWidth = 6;
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            this.carModel.Width = 160;
            // 
            // carGosnumber
            // 
            this.carGosnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carGosnumber.HeaderText = "Гос. номер";
            this.carGosnumber.MinimumWidth = 6;
            this.carGosnumber.Name = "carGosnumber";
            this.carGosnumber.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.bRemoveClient);
            this.panel5.Controls.Add(this.bClientEdit);
            this.panel5.Controls.Add(this.bAddClient);
            this.panel5.Controls.Add(this.dGVClientsList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1268, 250);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Список клиентов";
            // 
            // bRemoveClient
            // 
            this.bRemoveClient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRemoveClient.Location = new System.Drawing.Point(1070, 140);
            this.bRemoveClient.Name = "bRemoveClient";
            this.bRemoveClient.Size = new System.Drawing.Size(185, 30);
            this.bRemoveClient.TabIndex = 4;
            this.bRemoveClient.Text = "Удалить";
            this.bRemoveClient.UseVisualStyleBackColor = true;
            this.bRemoveClient.Click += new System.EventHandler(this.bRemoveClient_Click);
            // 
            // bClientEdit
            // 
            this.bClientEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bClientEdit.Location = new System.Drawing.Point(1070, 95);
            this.bClientEdit.Name = "bClientEdit";
            this.bClientEdit.Size = new System.Drawing.Size(185, 30);
            this.bClientEdit.TabIndex = 3;
            this.bClientEdit.Text = "Изменить";
            this.bClientEdit.UseVisualStyleBackColor = true;
            this.bClientEdit.Click += new System.EventHandler(this.bClientEdit_Click);
            // 
            // bAddClient
            // 
            this.bAddClient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bAddClient.Location = new System.Drawing.Point(1070, 50);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(185, 30);
            this.bAddClient.TabIndex = 2;
            this.bAddClient.Text = "Добавить";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // dGVClientsList
            // 
            this.dGVClientsList.AllowUserToAddRows = false;
            this.dGVClientsList.AllowUserToDeleteRows = false;
            this.dGVClientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employerid,
            this.employerFIO,
            this.employerPhone});
            this.dGVClientsList.Location = new System.Drawing.Point(25, 25);
            this.dGVClientsList.Name = "dGVClientsList";
            this.dGVClientsList.ReadOnly = true;
            this.dGVClientsList.RowHeadersWidth = 51;
            this.dGVClientsList.RowTemplate.Height = 24;
            this.dGVClientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVClientsList.Size = new System.Drawing.Size(1030, 200);
            this.dGVClientsList.TabIndex = 1;
            this.dGVClientsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClientsList_CellClick);
            // 
            // employerid
            // 
            this.employerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.employerid.HeaderText = "ID";
            this.employerid.MinimumWidth = 6;
            this.employerid.Name = "employerid";
            this.employerid.ReadOnly = true;
            this.employerid.Width = 49;
            // 
            // employerFIO
            // 
            this.employerFIO.HeaderText = "Фамилия Имя Отчество";
            this.employerFIO.MinimumWidth = 6;
            this.employerFIO.Name = "employerFIO";
            this.employerFIO.ReadOnly = true;
            this.employerFIO.Width = 250;
            // 
            // employerPhone
            // 
            this.employerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employerPhone.HeaderText = "Номер телефона";
            this.employerPhone.MinimumWidth = 6;
            this.employerPhone.Name = "employerPhone";
            this.employerPhone.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Показать записи от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "до";
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 783);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1300, 830);
            this.Name = "Employer";
            this.Text = "Форма для сотрудника";
            this.Load += new System.EventHandler(this.Employer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProvidedList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProvidedServicesOfCars)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarsOfClient)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVProvidedList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bProvidedServiceAdd;
        private System.Windows.Forms.DataGridView dGVClientsList;
        private System.Windows.Forms.DataGridView dGVCarsOfClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerPhone;
        private System.Windows.Forms.DataGridView dGVProvidedServicesOfCars;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bRemoveClient;
        private System.Windows.Forms.Button bClientEdit;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.Button bRemoveCar;
        private System.Windows.Forms.Button bEditCar;
        private System.Windows.Forms.Button bAddCar;
        private System.Windows.Forms.Label lAutomobiles;
        private System.Windows.Forms.Label lProvidedServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carGosnumber;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedserviceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientfio;
        private System.Windows.Forms.DataGridViewTextBoxColumn automobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeefio;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedservicedatatime;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedservicesClientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedserviceIdservice;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedserviceIdemployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn providedserviceIdautomobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFrom;
        private System.Windows.Forms.DateTimePicker dTPTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}