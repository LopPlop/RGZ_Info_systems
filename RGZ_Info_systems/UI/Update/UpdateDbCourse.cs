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
using Microsoft.VisualBasic;


namespace RGZ_Info_systems.UI
{
    public partial class UpdateDbCourse : Form
    {
        CourseController courseController = new CourseController();
        List<Course> list = new List<Course>();

        public UpdateDbCourse()
        {
            InitializeComponent();

            dataGridView1.DataSource = courseController.GetCourses();
        }

        private void UpdateDbCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                courseController.Update(list[i]);
            }

            MessageBox.Show(
                  "Данные успешно обновлены!",
                  "Сообщение",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = (int)e.RowIndex;
            int selectedColumn = (int)e.ColumnIndex;

            var row = new DataGridViewRow();

            row = dataGridView1.Rows[selectedRow];

            string Name = row.Cells[1].Value.ToString();
            int Duration = int.Parse(row.Cells[2].Value.ToString());
            int Purpose = int.Parse(row.Cells[3].Value.ToString());
            string Summary = row.Cells[4].Value.ToString();

            switch (selectedColumn)
            {
                case 1:
                    {
                        string name = Interaction.InputBox("Наименование", "Значениe", Name, -1, -1);
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = name;
                        list.Add(new Course
                        {
                            Id = (int)dataGridView1.Rows[selectedRow].Cells[0].Value,
                            Name = name,
                            Duration = (int)dataGridView1.Rows[selectedRow].Cells[2].Value,
                            Purpose = (int)dataGridView1.Rows[selectedRow].Cells[3].Value,
                            Summary = (string)dataGridView1.Rows[selectedRow].Cells[4].Value
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 2:
                    {
                        int duration = int.Parse(Interaction.InputBox("Длительность", "Значение", Duration.ToString(), -1, -1));
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = duration;
                        list.Add(new Course
                        {
                            Id = (int)dataGridView1.Rows[selectedRow].Cells[0].Value,
                            Name = (string)dataGridView1.Rows[selectedRow].Cells[1].Value,
                            Duration = duration,
                            Purpose = (int)dataGridView1.Rows[selectedRow].Cells[3].Value,
                            Summary = (string)dataGridView1.Rows[selectedRow].Cells[4].Value
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 3:
                    {
                        int purpose = int.Parse(Interaction.InputBox("Предназначение", "Значение", Purpose.ToString(), -1, -1));
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = purpose;
                        list.Add(new Course
                        {
                            Id = (int)dataGridView1.Rows[selectedRow].Cells[0].Value,
                            Name = (string)dataGridView1.Rows[selectedRow].Cells[1].Value,
                            Duration = (int)dataGridView1.Rows[selectedRow].Cells[2].Value,
                            Purpose = purpose,
                            Summary = (string)dataGridView1.Rows[selectedRow].Cells[4].Value
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
                case 4:
                    {
                        string summary = Interaction.InputBox("Описание", "Значение", Summary, -1, -1);
                        dataGridView1.Rows[selectedRow].Cells[selectedColumn].Value = summary;
                        list.Add(new Course
                        {
                            Id = (int)dataGridView1.Rows[selectedRow].Cells[0].Value,
                            Name = (string)dataGridView1.Rows[selectedRow].Cells[1].Value,
                            Duration = (int)dataGridView1.Rows[selectedRow].Cells[2].Value,
                            Purpose = Duration = (int)dataGridView1.Rows[selectedRow].Cells[3].Value,
                            Summary = summary
                        });
                        dataGridView1.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
