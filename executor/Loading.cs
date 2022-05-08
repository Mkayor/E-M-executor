using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace executor
{
    public partial class Loading : yes
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 689)
            {
                timer1.Stop();
                MessageBox.Show("thank you for downloading E&M executor");
                yes exploit = new yes();
                exploit.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
