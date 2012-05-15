using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Minimize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            //Display the Notify Baloon for 1 second  
            /* mynotifyicon.ShowBalloonTip(1000); */

            //Set the WindowState in Minimized Mode  
           /* WindowState = FormWindowState.Minimized; */
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            mynotifyicon.BalloonTipTitle = "My Sample Application";
            mynotifyicon.BalloonTipText = "This application was minimized to tray";
           

            //On minimize mode, show the form in System Tray only  
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                mynotifyicon.ShowBalloonTip(500);
                this.Hide();
            }else if(FormWindowState.Normal == this.WindowState){
                mynotifyicon.Visible = false;
            }
        }

        private void mynotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /* Show();//shows the program on taskbar
            this.WindowState = FormWindowState.Normal;//undoes the minimized state of the form
            mynotifyicon.Visible = false;//hides tray icon again */

            /* Show();
            WindowState = FormWindowState.Normal;
            mynotifyicon.Visible = true;
              */

            //Display the Form in normal state  
            this.Show(); 
            this.WindowState = FormWindowState.Normal;
             
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void TrayMinimizerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
