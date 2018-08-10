using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Mymessage : Form
    {
        public Mymessage(string msg)
        {
            InitializeComponent();
            lblMessage.Text = msg;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       public void Show(string msg)
        {
            Mymessage mymessage = new Mymessage(msg);
            mymessage.Show();
        }
        private void lblMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
