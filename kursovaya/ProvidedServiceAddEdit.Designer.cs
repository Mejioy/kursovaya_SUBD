namespace kursovaya
{
    partial class ProvidedServiceAddEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVService = new System.Windows.Forms.DataGridView();
            this.serviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVEmployer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeefio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVAutomobile = new System.Windows.Forms.DataGridView();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carGosnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVClient = new System.Windows.Forms.DataGridView();
            this.employerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAutomobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 65);
            this.panel1.TabIndex = 10;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bCancel.Location = new System.Drawing.Point(995, 20);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 30);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bOk.Location = new System.Drawing.Point(899, 20);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(90, 30);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Дата оказания услуги";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(607, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(468, 22);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Список доступных услуг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Список сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Список автомобилей клиентов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Список клиентов";
            // 
            // dGVService
            // 
            this.dGVService.AllowUserToAddRows = false;
            this.dGVService.AllowUserToDeleteRows = false;
            this.dGVService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceid,
            this.servicename,
            this.duration,
            this.price,
            this.description});
            this.dGVService.Location = new System.Drawing.Point(32, 385);
            this.dGVService.Margin = new System.Windows.Forms.Padding(5);
            this.dGVService.Name = "dGVService";
            this.dGVService.ReadOnly = true;
            this.dGVService.RowHeadersWidth = 51;
            this.dGVService.RowTemplate.Height = 24;
            this.dGVService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVService.Size = new System.Drawing.Size(1043, 137);
            this.dGVService.TabIndex = 72;
            // 
            // serviceid
            // 
            this.serviceid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceid.HeaderText = "ID";
            this.serviceid.MinimumWidth = 6;
            this.serviceid.Name = "serviceid";
            this.serviceid.ReadOnly = true;
            this.serviceid.Width = 49;
            // 
            // servicename
            // 
            this.servicename.HeaderText = "Название услуги";
            this.servicename.MinimumWidth = 6;
            this.servicename.Name = "servicename";
            this.servicename.ReadOnly = true;
            this.servicename.Width = 150;
            // 
            // duration
            // 
            this.duration.HeaderText = "Продолжительность (минут)";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 90;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Описание";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // dGVEmployer
            // 
            this.dGVEmployer.AllowUserToAddRows = false;
            this.dGVEmployer.AllowUserToDeleteRows = false;
            this.dGVEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.employeefio,
            this.employeephone});
            this.dGVEmployer.Location = new System.Drawing.Point(32, 209);
            this.dGVEmployer.Name = "dGVEmployer";
            this.dGVEmployer.ReadOnly = true;
            this.dGVEmployer.RowHeadersWidth = 51;
            this.dGVEmployer.RowTemplate.Height = 24;
            this.dGVEmployer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEmployer.Size = new System.Drawing.Size(517, 137);
            this.dGVEmployer.TabIndex = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // employeefio
            // 
            this.employeefio.HeaderText = "Фамилия Имя Отчество";
            this.employeefio.MinimumWidth = 6;
            this.employeefio.Name = "employeefio";
            this.employeefio.ReadOnly = true;
            this.employeefio.Width = 170;
            // 
            // employeephone
            // 
            this.employeephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeephone.HeaderText = "Номер телефона";
            this.employeephone.MinimumWidth = 6;
            this.employeephone.Name = "employeephone";
            this.employeephone.ReadOnly = true;
            // 
            // dGVAutomobile
            // 
            this.dGVAutomobile.AllowUserToAddRows = false;
            this.dGVAutomobile.AllowUserToDeleteRows = false;
            this.dGVAutomobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAutomobile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAutomobile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carID,
            this.carMark,
            this.carModel,
            this.carGosnumber});
            this.dGVAutomobile.Location = new System.Drawing.Point(579, 39);
            this.dGVAutomobile.Name = "dGVAutomobile";
            this.dGVAutomobile.ReadOnly = true;
            this.dGVAutomobile.RowHeadersWidth = 51;
            this.dGVAutomobile.RowTemplate.Height = 24;
            this.dGVAutomobile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAutomobile.Size = new System.Drawing.Size(496, 137);
            this.dGVAutomobile.TabIndex = 70;
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
            this.carMark.Width = 80;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "Модель";
            this.carModel.MinimumWidth = 6;
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            this.carModel.Width = 80;
            // 
            // carGosnumber
            // 
            this.carGosnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carGosnumber.HeaderText = "Гос. номер";
            this.carGosnumber.MinimumWidth = 6;
            this.carGosnumber.Name = "carGosnumber";
            this.carGosnumber.ReadOnly = true;
            // 
            // dGVClient
            // 
            this.dGVClient.AllowUserToAddRows = false;
            this.dGVClient.AllowUserToDeleteRows = false;
            this.dGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employerid,
            this.employerFIO,
            this.employerPhone});
            this.dGVClient.Location = new System.Drawing.Point(32, 39);
            this.dGVClient.Name = "dGVClient";
            this.dGVClient.ReadOnly = true;
            this.dGVClient.RowHeadersWidth = 51;
            this.dGVClient.RowTemplate.Height = 24;
            this.dGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVClient.Size = new System.Drawing.Size(517, 137);
            this.dGVClient.TabIndex = 69;
            this.dGVClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClient_CellClick);
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
            this.employerFIO.Width = 170;
            // 
            // employerPhone
            // 
            this.employerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employerPhone.HeaderText = "Номер телефона";
            this.employerPhone.MinimumWidth = 6;
            this.employerPhone.Name = "employerPhone";
            this.employerPhone.ReadOnly = true;
            // 
            // ProvidedServiceAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVService);
            this.Controls.Add(this.dGVEmployer);
            this.Controls.Add(this.dGVAutomobile);
            this.Controls.Add(this.dGVClient);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "ProvidedServiceAddEdit";
            this.Text = "ProvidedServiceAddEdit";
            this.Load += new System.EventHandler(this.ProvidedServiceAddEdit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAutomobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridView dGVEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeefio;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeephone;
        private System.Windows.Forms.DataGridView dGVAutomobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn carMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn carGosnumber;
        private System.Windows.Forms.DataGridView dGVClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerPhone;
    }
}