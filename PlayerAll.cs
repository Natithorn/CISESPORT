using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class PlayerAll : Form
    {
        List<player> players = new();
        public PlayerAll()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formInfo = new Form1();
            formInfo.ShowDialog();

            if(formInfo.DialogResult == DialogResult.OK) {
                MessageBox.Show("Test");
                player newPlayer = formInfo.getPlayer();
                formInfo.Close();
                players.Add(newPlayer);
                dataGridView1.Rows.Clear();
                foreach(player player in players)
                {
                    dataGridView1.Rows.Add(player.name_, player.Lastname, player.Id, player.Mj, 
                                    player.displayname, player.Mail,player.Number,player.Age);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            //File.WriteAllText("c:/PlayerInfo.CSV",);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.ReadAllText("c:/PlayerInfo");
        }
    }
}
