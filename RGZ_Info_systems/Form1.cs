using RGZ_Info_systems.Controllers;
using RGZ_Info_systems.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_Info_systems
{
    public partial class Form1 : Form
    {
        CourseController courseController = new CourseController();
        EmployeeController employeeController = new EmployeeController();
        TrainingController trainingController = new TrainingController();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = courseController.GetCourses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.SelectDialog.SelectAdd selectAdd = new UI.SelectDialog.SelectAdd();
            selectAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.SelectDialog.SelectUpdate selectAdd = new UI.SelectDialog.SelectUpdate();
            selectAdd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UI.SelectDialog.SelectDelete selectAdd = new UI.SelectDialog.SelectDelete();
            selectAdd.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataGridView1.DataSource = courseController.GetCourses();
                        break;
                    }
                case 1:
                    {
                        dataGridView1.DataSource = employeeController.GetEmployees();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = trainingController.GetTraining();
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataGridView1.DataSource = courseController.GetCourses();
                        break;
                    }
                case 1:
                    {
                        dataGridView1.DataSource = employeeController.GetEmployees();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = trainingController.GetTraining();
                        break;
                    }
            }
        }

        private void прошлиВЭтомМесяцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordHandler = new WordHandler("C:\\Users\\Ilya\\source\\repos\\RGZ_Info_systems\\RGZ_Info_systems\\Resources\\Отчет о сотрудниках, прошедших курсы за последний месяц.docx");

            var dictionary = new Dictionary<string, string>()
            {
                { "<DD>", DateTime.Now.Date.Day.ToString() },
                { "<MM>", DateTime.Now.Date.Month.ToString() },
                { "<YY>", DateTime.Now.Date.Year.ToString() },
                { "<PEOPLE_COUNT>", trainingController.GetPassedPeopleYY().Count.ToString() },
                { "<PEOPLE_LIST>",string.Join(Environment.NewLine, trainingController.GetPassedPeopleYY()) }
            };

            wordHandler.Process(dictionary);
        }

        private void должныПройтиВЭтомГодуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordHandler = new WordHandler("C:\\Users\\Ilya\\source\\repos\\RGZ_Info_systems\\RGZ_Info_systems\\Resources\\Отчет о сотрудниках, которые должны пройти.docx");

            var dictionary = new Dictionary<string, string>()
            {
                { "<DD>", DateTime.Now.Date.Day.ToString() },
                { "<MM>", DateTime.Now.Date.Month.ToString() },
                { "<YY>", DateTime.Now.Date.Year.ToString() },
                { "<PEOPLE_COUNT>", trainingController.GetPassedPeople().Count.ToString() },
                { "<PEOPLE_LIST>", string.Join(Environment.NewLine, trainingController.GetPassedPeople()) }
            };

            wordHandler.Process(dictionary);
        }

        private void инфоПоПройденымКурсамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wordHandler = new WordHandler("C:\\Users\\Ilya\\source\\repos\\RGZ_Info_systems\\RGZ_Info_systems\\Resources\\Отчет по курсам.docx");

            var dictionary = new Dictionary<string, string>()
            {
                { "<DD>", DateTime.Now.Date.Day.ToString() },
                { "<MM>", DateTime.Now.Date.Month.ToString() },
                { "<YY>", DateTime.Now.Date.Year.ToString() },
                { "<COURSE_COUNT>", courseController.GetCountCourses().ToString() },
                { "<COURSE_TIME>", courseController.GetTimeCourses().ToString() },
                { "<COUNT_PEOPLE>", trainingController.GetPassedPeople().Count.ToString() }
            };

            wordHandler.Process(dictionary);
        }
    }
}
