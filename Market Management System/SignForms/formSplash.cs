using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management_System
{
    public partial class formSplash : Form
    {
        public formSplash()
        {
            InitializeComponent();
            
        }


        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                startpoint += 2;
                progressbarSplash.Value = startpoint;


            if (startpoint == 100)
            {
                timerSplash.Stop();
                formSelectRole formSelectRole = new formSelectRole();
                this.Hide();
                formSelectRole.Show(); 
            }
        }

        private void formSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }
    }
}
