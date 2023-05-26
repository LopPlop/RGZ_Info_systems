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

namespace RGZ_Info_systems.UI
{
    public partial class DeleteDbEmployee : Form
    {
        EmployeeController employeeController = new EmployeeController();
        public DeleteDbEmployee()
        {
            InitializeComponent();

            dataGridView1.DataSource = employeeController.GetEmployees();
        }

        private void DeleteDbEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < 0)
                return;

            var row = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

            int e_id = (int)row.Cells[0].Value;
            employeeController.Delete(new Models.Employee
            {
                Id = e_id
            });
            dataGridView1.DataSource = employeeController.GetEmployees();
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
