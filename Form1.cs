using System.Security.Cryptography.X509Certificates;

namespace CISESPORT
{
    public partial class Form1 : Form
    {
        private player _Newplayer;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text; ;
            string Lastname = tbLastname.Text;
            string Id = tbID.Text;
            string Mj = tbMajor.Text;
            string displaygame = tbDisplaygame.Text;
            string Mail = tbMail.Text;
            string Number = tbNumber.Text;
            try
            {
                _Newplayer = new player(name, Lastname, Id, Mj, displaygame, Mail, Number, iAge);

                this.DialogResult= DialogResult.OK;
                this.Close();

            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("ใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            try
            {
                string Age = tbAge.Text;
                int iAge = Int32.Parse(tbAge.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ใส่ข้อมูลไม่ถูกต้อง");
                return;
            }



            
        }
        public player getPlayer() {
            return _Newplayer;
        }
    }
}