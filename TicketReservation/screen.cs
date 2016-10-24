using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservation
{
    public partial class screen : Form
    {
        public static string price = "", time = "", title = "", cinema = "";

        public screen()
        {
            InitializeComponent();

        }

        private void screen_Load(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            price = label5.Text;
            time = label6.Text;
            title = label7.Text;
            cinema = label8.Text;
            this.Hide();
            movies frm2 = new movies();
            frm2.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
