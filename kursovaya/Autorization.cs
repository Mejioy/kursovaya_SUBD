using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private int index = -1;
        public int Index { get { return index; } }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            switch (index)
            {
                case 0:
                    Client client = new Client();
                    client.ShowDialog();
                    break;
                case 1:
                    Employer employer = new Employer();
                    employer.ShowDialog();
                    break;
                case 2:
                    Administrator administrator = new Administrator();
                    administrator.ShowDialog();                    
                    break;
                default:
                    MessageBox.Show("Не выбран пользователь для работы", "Ошибка");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;
        }
    }
}
