using RGZ_Info_systems.UI.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RGZ_Info_systems.UI.SelectDialog
{
    public partial class SelectAdd : Form
    {
        public SelectAdd()
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
                        AddDbCourse addDbCourse = new AddDbCourse();
                        addDbCourse.ShowDialog();
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        AddDbEmloyee addDbEmloyee = new AddDbEmloyee();
                        addDbEmloyee.ShowDialog();
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        AddDbTraining addDbTraining = new AddDbTraining();
                        addDbTraining.ShowDialog();
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
