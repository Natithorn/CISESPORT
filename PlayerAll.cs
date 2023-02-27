using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class PlayerAll : Form
    {
        public PlayerAll()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formInfo = new Form1();
            formInfo.Show();

            if(formInfo.DialogResult == DialogResult.OK) {
                MessageBox.Show("hum");
                player newPlayer = formInfo.getPlayer();
                formInfo.Close();
                dataGridView1.Rows.Add(formInfo.getPlayer());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
