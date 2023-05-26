using RGZ_Info_systems.Controllers;
using RGZ_Info_systems.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_Info_systems.UI
{
    public partial class AddDbEmloyee : Form
    {
        EmployeeController employeeController = new EmployeeController();
        public AddDbEmloyee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text !=null && comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex <= 3 && comboBox2.SelectedIndex >= 0 && comboBox2.SelectedIndex <= 3)
            {
                Employee employee = new Employee()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Position= comboBox1.SelectedIndex,
                    Department= comboBox2.SelectedIndex,
                    EmploymentDate = dateTimePicker1.Value
                };

                employeeController.Insert(employee);

                MessageBox.Show(
                   "Данные успешно добавлены!",
                   "Сообщение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
            }
            else
                MessageBox.Show(
                   "Вы ввели невеные данные",
                   "Ошибка",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
        }

        private void AddDbEmloyee_Load(object sender, EventArgs e)
        {

        }
    }
}
