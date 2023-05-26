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
    public partial class AddDbCourse : Form
    {
        CourseController courseController = new CourseController();
        public AddDbCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(textBox1.Text != null && comboBox1.SelectedIndex >=0 && comboBox1.SelectedIndex <=3 && comboBox2.SelectedIndex >=0 && comboBox2.SelectedIndex <=3)
            {
                Course course = new Course()
                {
                    Name = textBox1.Text,
                    Duration = int.Parse(comboBox1.Text),
                    Purpose = comboBox2.SelectedIndex,
                    Summary = richTextBox1.Text
                };

                courseController.Insert(course);

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

        private void AddDbCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
