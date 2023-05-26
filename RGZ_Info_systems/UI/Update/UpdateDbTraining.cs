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

namespace RGZ_Info_systems.UI.Update
{
    public partial class UpdateDbTraining : Form
    {
        TrainingController trainingController = new TrainingController();
        public UpdateDbTraining()
        {
            InitializeComponent();

            dataGridView1.DataSource = trainingController.GetTraining();
        }

        private void UpdateDbTraining_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
