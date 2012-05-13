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

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            /* if (FormWindowState.Minimized == this.WindowState)
           {
               mynotifyicon.Visible = true;
               mynotifyicon.ShowBalloonTip(500);
               this.Hide();
           }
           else if (FormWindowState.Normal == this.WindowState)
           {
               mynotifyicon.Visible = false;
           } */

            if (this.WindowState == FormWindowState.Minimized)//this code gets fired on every resize
            {																					   //so we check if the form was minimized
                Hide();//hides the program on the taskbar
                mynotifyicon.Visible = true;//shows our tray icon

                Thread.Sleep(3000);//pause for 3 seconds
                //shows a balloon for 1 sec with a title, some text, and the info icon
                //other possibilities are: TooltipIcon.None, Tooltipicon.Error, and TooltipIcon.Warning
                mynotifyicon.ShowBalloonTip(1000, "Hello", "This is a balloontip!", ToolTipIcon.Info);
            }
              
          

           /* if (FormWindowState.Minimized == WindowState)
                Hide();
             */
        }

        private void mynotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             Show();//shows the program on taskbar
            this.WindowState = FormWindowState.Normal;//undoes the minimized state of the form
            mynotifyicon.Visible = false;//hides tray icon again

         

            /* Show();
            WindowState = FormWindowState.Normal;
            mynotifyicon.Visible = true;
              */
        }
    }
}
