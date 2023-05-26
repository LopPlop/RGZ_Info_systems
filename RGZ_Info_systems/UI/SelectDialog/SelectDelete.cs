using RGZ_Info_systems.UI.Add;
using RGZ_Info_systems.UI.Delete;
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

namespace RGZ_Info_systems.UI.SelectDialog
{
    public partial class SelectDelete : Form
    {
        public SelectDelete()
        {
            InitializeComponent();

            comboBox2.Items.AddRange(new string[] { "Курсы", "Сотрудники", "Пройденные курсы" });
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        DeleteDbCourse deleteDbCourse = new DeleteDbCourse();
                        deleteDbCourse.ShowDialog();
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        DeleteDbEmployee deleteDbEmployee = new DeleteDbEmployee();
                        deleteDbEmployee.ShowDialog();
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        DeleteDbTraining addDbTraining = new DeleteDbTraining();
                        addDbTraining.ShowDialog();
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
