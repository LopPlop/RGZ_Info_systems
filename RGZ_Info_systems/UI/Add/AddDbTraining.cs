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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RGZ_Info_systems.UI.Add
{
    public partial class AddDbTraining : Form
    {
        TrainingController trainingController = new TrainingController();
        EmployeeController employeeController = new EmployeeController();
        CourseController courseController = new CourseController();
        public AddDbTraining()
        {
            InitializeComponent();

            var listEmp = employeeController.GetEmployees();
            var listCourse = courseController.GetCourses();

            for (int i = 0; i < listEmp.Count; i++)
                comboBox1.Items.Add(listEmp[i].LastName);
            for (int i = 0; i < listCourse.Count; i++)
                comboBox2.Items.Add(listCourse[i].Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                var listEmp = employeeController.GetEmployees();
                var listCourse = courseController.GetCourses();

                int e_id = 0;
                int c_id = 0;

                for(int i = 0; i < listEmp.Count; i++)
                {
                    if (listEmp[i].LastName.Equals(comboBox1.Text))
                        e_id = listEmp[i].Id;
                }

                for (int i = 0; i < listCourse.Count; i++)
                {
                    if (listCourse[i].Name.Equals(comboBox2.Text))
                        c_id = listCourse[i].Id;
                }

                Training training = new Training()
                {
                    EmployeeNumber = e_id,
                    CourseNumber = c_id,
                    DateOfPassage = dateTimePicker1.Value
                };

                trainingController.Insert(training);

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
    }
}
