namespace kursovaya
{
    partial class Client
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
            this.dGVServicesList = new System.Windows.Forms.DataGridView();
            this.serviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lServicesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dGVServicesList.Location = new System.Drawing.Point(10, 10);
            this.dGVServicesList.Margin = new System.Windows.Forms.Padding(5);
            this.dGVServicesList.Name = "dGVServicesList";
            this.dGVServicesList.ReadOnly = true;
            this.dGVServicesList.RowHeadersWidth = 51;
            this.dGVServicesList.RowTemplate.Height = 24;
            this.dGVServicesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVServicesList.Size = new System.Drawing.Size(858, 383);
            this.dGVServicesList.TabIndex = 1;
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
            this.panel1.Controls.Add(this.dGVServicesList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(882, 453);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lServicesCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 52);
            this.panel2.TabIndex = 3;
            // 
            // lServicesCount
            // 
            this.lServicesCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lServicesCount.AutoSize = true;
            this.lServicesCount.Location = new System.Drawing.Point(392, 19);
            this.lServicesCount.Name = "lServicesCount";
            this.lServicesCount.Size = new System.Drawing.Size(0, 16);
            this.lServicesCount.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Client";
            this.Text = "Приложение для клиента (список доступных услуг)";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVServicesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVServicesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lServicesCount;
    }
}