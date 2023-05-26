using Microsoft.VisualBasic;
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
    public partial class UpdateDbEmployee : Form
    {

        EmployeeController employeeController = new EmployeeController();
        List<Employee> list = new List<Employee>();
        public UpdateDbEmployee()
        {
            InitializeComponent();

            dataGridView1.DataSource = employeeController.GetEmployees();
        }

        private void UpdateDbEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < list.Count; i++)
            {
                employeeController.Update(list[i]);
            }

            MessageBox.Show(
                  "Данные успешно обновлены!",
                  "Сообщение",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = (int)e.RowIndex;
            int selectedColumn = (int)e.ColumnIndex;

            var row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRow];

            int Id = (int)row.Cells[0].Value;
            string FirstName = row.Cells[1].Value.ToString();
            string LastName = row.Cells[2].Value.ToString();
            int Position = int.Parse(row.Cells[3].Value.ToString());
            int Department = int.Parse(row.Cells[4].Value.ToString());
            DateTime EmploymentDate = (DateTime)row.Cells[5].Value;

            switch (selectedColumn)
            {
                case 1:
                    {
                        string firstName = Interaction.InputBox("Наименование", "Значениe", FirstName, -1, -1);
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = firstName;
                        list.Add(new Employee
                        {
                            Id = Id,
                            FirstName = firstName,
                            LastName = LastName,
                            Position = Position,
                            Department = Department,
                            EmploymentDate = EmploymentDate,
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 2:
                    {
                        string lastName = Interaction.InputBox("Наименование", "Значениe", LastName, -1, -1);
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = lastName;
                        list.Add(new Employee
                        {
                            Id = Id,
                            FirstName = FirstName,
                            LastName = lastName,
                            Position = Position,
                            Department = Department,
                            EmploymentDate = EmploymentDate,
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 3:
                    {
                        int position = int.Parse(Interaction.InputBox("Наименование", "Значениe", Position.ToString(), -1, -1));
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = position;
                        list.Add(new Employee
                        {
                            Id = Id,
                            FirstName = FirstName,
                            LastName = LastName,
                            Position = position,
                            Department = Department,
                            EmploymentDate = EmploymentDate,
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 4:
                    {
                        int department = int.Parse(Interaction.InputBox("Наименование", "Значениe", Department.ToString(), -1, -1));
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = department;
                        list.Add(new Employee
                        {
                            Id = Id,
                            FirstName = FirstName,
                            LastName = LastName,
                            Position = Position,
                            Department = department,
                            EmploymentDate = EmploymentDate,
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 5:
                    {
                        DateTime employmentDate = DateTime.Parse(Interaction.InputBox("Наименование", "Значениe", EmploymentDate.ToString(), -1, -1));
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = employmentDate;
                        list.Add(new Employee
                        {
                            Id = Id,
                            FirstName = FirstName,
                            LastName = LastName,
                            Position = Position,
                            Department = Department,
                            EmploymentDate = employmentDate,
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
            }
        }
    }
}
