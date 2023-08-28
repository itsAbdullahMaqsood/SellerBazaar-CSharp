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
           
                startpoint += 20;
                progressbarSplash.Value = startpoint;


            if (startpoint == 100)
            {
                timerSplash.Stop();
                formSignin formLogin = new formSignin();
                this.Hide();
                formLogin.Show(); 
            }
        }

        private void formSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }
    }
}
