using RGZ_Info_systems.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_Info_systems.UI.Delete
{
    public partial class DeleteDbTraining : Form
    {
        TrainingController trainingController = new TrainingController();
        int selectedRow = -1;
        public DeleteDbTraining()
        {
            InitializeComponent();

            dataGridView1.DataSource = trainingController.GetTraining();
        }

        private void DeleteDbTraining_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < 0)
                return;

                var row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

                int e_id = (int)row.Cells[0].Value;
                int c_id = (int)row.Cells[1].Value;
                trainingController.Delete(new Models.Training()
                {
                    CourseNumber = c_id,
                    EmployeeNumber = e_id,
                });
            dataGridView1.DataSource = trainingController.GetTraining();
            MessageBox.Show(
                  "Данные успешно удалены!",
                  "Сообщение",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
