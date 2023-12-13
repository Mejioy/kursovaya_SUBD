namespace kursovaya
{
    partial class AddEditEmployeeForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bChoicePhoto = new System.Windows.Forms.Button();
            this.tHouse = new System.Windows.Forms.TextBox();
            this.tStreet = new System.Windows.Forms.TextBox();
            this.tCity = new System.Windows.Forms.TextBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.tPatronym = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tAppartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 65);
            this.panel1.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bCancel.Location = new System.Drawing.Point(550, 20);
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
            this.bOk.Location = new System.Drawing.Point(454, 20);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(90, 30);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bChoicePhoto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 408);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фотография сотрудника";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(17, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 254);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bChoicePhoto
            // 
            this.bChoicePhoto.Location = new System.Drawing.Point(55, 351);
            this.bChoicePhoto.Name = "bChoicePhoto";
            this.bChoicePhoto.Size = new System.Drawing.Size(140, 54);
            this.bChoicePhoto.TabIndex = 4;
            this.bChoicePhoto.Text = "Выбрать фото";
            this.bChoicePhoto.UseVisualStyleBackColor = true;
            this.bChoicePhoto.Click += new System.EventHandler(this.bChoicePhoto_Click);
            // 
            // tHouse
            // 
            this.tHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tHouse.Location = new System.Drawing.Point(180, 325);
            this.tHouse.Name = "tHouse";
            this.tHouse.Size = new System.Drawing.Size(217, 22);
            this.tHouse.TabIndex = 6;
            this.tHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tHouse_KeyPress);
            // 
            // tStreet
            // 
            this.tStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tStreet.Location = new System.Drawing.Point(180, 275);
            this.tStreet.Name = "tStreet";
            this.tStreet.Size = new System.Drawing.Size(217, 22);
            this.tStreet.TabIndex = 5;
            // 
            // tCity
            // 
            this.tCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCity.Location = new System.Drawing.Point(180, 225);
            this.tCity.Name = "tCity";
            this.tCity.Size = new System.Drawing.Size(217, 22);
            this.tCity.TabIndex = 4;
            // 
            // tPhone
            // 
            this.tPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPhone.Location = new System.Drawing.Point(180, 175);
            this.tPhone.MaxLength = 15;
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(217, 22);
            this.tPhone.TabIndex = 3;
            // 
            // tPatronym
            // 
            this.tPatronym.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPatronym.Location = new System.Drawing.Point(180, 125);
            this.tPatronym.Name = "tPatronym";
            this.tPatronym.Size = new System.Drawing.Size(217, 22);
            this.tPatronym.TabIndex = 2;
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Location = new System.Drawing.Point(180, 75);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(217, 22);
            this.tName.TabIndex = 1;
            // 
            // tSurname
            // 
            this.tSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSurname.Location = new System.Drawing.Point(180, 25);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(217, 22);
            this.tSurname.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tAppartment);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.tHouse);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tStreet);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tCity);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tPhone);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tPatronym);
            this.panel4.Controls.Add(this.tName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tSurname);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(238, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 408);
            this.panel4.TabIndex = 3;
            // 
            // tAppartment
            // 
            this.tAppartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tAppartment.Location = new System.Drawing.Point(180, 375);
            this.tAppartment.Name = "tAppartment";
            this.tAppartment.Size = new System.Drawing.Size(217, 22);
            this.tAppartment.TabIndex = 7;
            this.tAppartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tAppartment_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Номер телефона";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Квартира";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дом";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Улица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Город";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 473);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "AddEditEmployeeForm";
            this.Text = "AddEditEmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tPatronym;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bChoicePhoto;
        private System.Windows.Forms.TextBox tHouse;
        private System.Windows.Forms.TextBox tStreet;
        private System.Windows.Forms.TextBox tCity;
        private System.Windows.Forms.TextBox tAppartment;
        private System.Windows.Forms.Label label9;
    }
}