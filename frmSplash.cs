using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splahScreen_and_Login
{
    public partial class frmSplash : Form
        


    {
        Random ran = new Random();
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void bnProgressBar_progressChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bnProgressBar.Value == 100)
            {
                TimerPrbar.Stop();
                //this.Close();
                this.Hide();
                new frmMain().Show();
                return; 
            }

           try {
                 bnProgressBar.Value += ran.Next(1, 10);
               }
            catch (Exception){
                TimerPrbar.Stop();
                //this.Close();
                this.Hide();
                new frmMain().Show();

            }
          
        }

        private void frmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
           // new frmMain().Show(); 

        }
    }
}
