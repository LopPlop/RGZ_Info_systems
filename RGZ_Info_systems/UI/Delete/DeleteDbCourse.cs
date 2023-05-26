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
    public partial class DeleteDbCourse : Form
    {
        CourseController courseController = new CourseController();
        public DeleteDbCourse()
        {
            InitializeComponent();

            dataGridView1.DataSource = courseController.GetCourses();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteDbCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < 0)
                return;

            var row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

            int c_id = (int)row.Cells[0].Value;
            courseController.Delete(new Course
            {
                Id = c_id
            });
            dataGridView1.DataSource = courseController.GetCourses();
            MessageBox.Show(
                  "Данные успешно удалены!",
                  "Сообщение",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
