using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        Boolean active = false;
        int z = 3;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (active == false)
            {

                active = true;
                timer1.Start();
            }
            else
            {

                active = false;
                timer1.Stop();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            
            if(z>0)
            {
                label1.Text = z.ToString();
                z -= 1;
            
            }
        else
            {
                label1.Text = "completed";
                z = 3;
            }


            
        }
    }
}
