namespace kursovaya
{
    partial class Administrator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dGVEmployeeList = new System.Windows.Forms.DataGridView();
            this.employerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeefio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bEmployeeAdd = new System.Windows.Forms.Button();
            this.bEmployeeEdit = new System.Windows.Forms.Button();
            this.bEmployeeRemove = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVServicesList = new System.Windows.Forms.DataGridView();
            this.serviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bChange = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1374, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список сотрудников";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dGVEmployeeList);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1374, 316);
            this.panel6.TabIndex = 6;
            // 
            // dGVEmployeeList
            // 
            this.dGVEmployeeList.AllowUserToAddRows = false;
            this.dGVEmployeeList.AllowUserToDeleteRows = false;
            this.dGVEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employerid,
            this.employeefio,
            this.employeephone,
            this.adress,
            this.path});
            this.dGVEmployeeList.Location = new System.Drawing.Point(3, 3);
            this.dGVEmployeeList.Name = "dGVEmployeeList";
            this.dGVEmployeeList.ReadOnly = true;
            this.dGVEmployeeList.RowHeadersWidth = 51;
            this.dGVEmployeeList.RowTemplate.Height = 24;
            this.dGVEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEmployeeList.Size = new System.Drawing.Size(1090, 310);
            this.dGVEmployeeList.TabIndex = 0;
            this.dGVEmployeeList.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
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
            // employeefio
            // 
            this.employeefio.HeaderText = "Фамилия Имя Отчество";
            this.employeefio.MinimumWidth = 6;
            this.employeefio.Name = "employeefio";
            this.employeefio.ReadOnly = true;
            this.employeefio.Width = 250;
            // 
            // employeephone
            // 
            this.employeephone.HeaderText = "Номер телефона";
            this.employeephone.MinimumWidth = 6;
            this.employeephone.Name = "employeephone";
            this.employeephone.ReadOnly = true;
            this.employeephone.Width = 150;
            // 
            // adress
            // 
            this.adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adress.HeaderText = "Адрес(Город, улица, дом, квартира)";
            this.adress.MinimumWidth = 6;
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            // 
            // path
            // 
            this.path.HeaderText = "";
            this.path.MinimumWidth = 6;
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Visible = false;
            this.path.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1164, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фотография сотрудника";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(1144, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 254);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bEmployeeAdd);
            this.panel4.Controls.Add(this.bEmployeeEdit);
            this.panel4.Controls.Add(this.bEmployeeRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 316);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 63);
            this.panel4.TabIndex = 3;
            // 
            // bEmployeeAdd
            // 
            this.bEmployeeAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bEmployeeAdd.Location = new System.Drawing.Point(1077, 18);
            this.bEmployeeAdd.Name = "bEmployeeAdd";
            this.bEmployeeAdd.Size = new System.Drawing.Size(90, 30);
            this.bEmployeeAdd.TabIndex = 3;
            this.bEmployeeAdd.Text = "Добавить";
            this.bEmployeeAdd.UseVisualStyleBackColor = true;
            this.bEmployeeAdd.Click += new System.EventHandler(this.bEmployeeAdd_Click);
            // 
            // bEmployeeEdit
            // 
            this.bEmployeeEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bEmployeeEdit.Location = new System.Drawing.Point(1172, 18);
            this.bEmployeeEdit.Name = "bEmployeeEdit";
            this.bEmployeeEdit.Size = new System.Drawing.Size(90, 30);
            this.bEmployeeEdit.TabIndex = 2;
            this.bEmployeeEdit.Text = "Изменить";
            this.bEmployeeEdit.UseVisualStyleBackColor = true;
            this.bEmployeeEdit.Click += new System.EventHandler(this.bEmployeeEdit_Click);
            // 
            // bEmployeeRemove
            // 
            this.bEmployeeRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bEmployeeRemove.Location = new System.Drawing.Point(1267, 18);
            this.bEmployeeRemove.Name = "bEmployeeRemove";
            this.bEmployeeRemove.Size = new System.Drawing.Size(90, 30);
            this.bEmployeeRemove.TabIndex = 0;
            this.bEmployeeRemove.Text = "Удалить";
            this.bEmployeeRemove.UseVisualStyleBackColor = true;
            this.bEmployeeRemove.Click += new System.EventHandler(this.bEmployeeRemove_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1374, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список услуг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGVServicesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 316);
            this.panel2.TabIndex = 2;
            // 
            // dGVServicesList
            // 
            this.dGVServicesList.AllowUserToAddRows = false;
            this.dGVServicesList.AllowUserToDeleteRows = false;
            this.dGVServicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVServicesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceid,
            this.servicename,
            this.duration,
            this.price,
            this.description});
            this.dGVServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVServicesList.Location = new System.Drawing.Point(0, 0);
            this.dGVServicesList.Margin = new System.Windows.Forms.Padding(5);
            this.dGVServicesList.Name = "dGVServicesList";
            this.dGVServicesList.ReadOnly = true;
            this.dGVServicesList.RowHeadersWidth = 51;
            this.dGVServicesList.RowTemplate.Height = 24;
            this.dGVServicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVServicesList.Size = new System.Drawing.Size(1374, 316);
            this.dGVServicesList.TabIndex = 0;
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
            this.servicename.Width = 170;
            // 
            // duration
            // 
            this.duration.HeaderText = "Продолжительность (минут)";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 220;
            // 
            // price
            // 
            this.price.HeaderText = "Стоимость";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 106;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Описание";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Controls.Add(this.bChange);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 63);
            this.panel1.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bAdd.Location = new System.Drawing.Point(1078, 18);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(90, 30);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bChange
            // 
            this.bChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bChange.Location = new System.Drawing.Point(1173, 18);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(90, 30);
            this.bChange.TabIndex = 2;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bDelete.Location = new System.Drawing.Point(1268, 18);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(90, 30);
            this.bDelete.TabIndex = 0;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 408);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1400, 455);
            this.Name = "Administrator";
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVServicesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dGVEmployeeList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bEmployeeAdd;
        private System.Windows.Forms.Button bEmployeeEdit;
        private System.Windows.Forms.Button bEmployeeRemove;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeefio;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

