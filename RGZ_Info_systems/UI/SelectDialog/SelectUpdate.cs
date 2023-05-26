using RGZ_Info_systems.UI.Add;
using RGZ_Info_systems.UI.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_Info_systems.UI.SelectDialog
{
    public partial class SelectUpdate : Form
    {
        public SelectUpdate()
        {
            InitializeComponent();

            comboBox2.Items.AddRange(new string[] { "Курсы", "Сотрудники" });
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        UpdateDbCourse deleteDbCourse = new UpdateDbCourse();
                        deleteDbCourse.ShowDialog();
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        UpdateDbEmployee deleteDbEmployee = new UpdateDbEmployee();
                        deleteDbEmployee.ShowDialog();
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        UpdateDbTraining addDbTraining = new UpdateDbTraining();
                        addDbTraining.ShowDialog();
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
