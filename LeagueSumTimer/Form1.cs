using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace LeagueSumTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            topTimer.Tick += new EventHandler(topTimerEventProcessor);
            jugTimer.Tick += new EventHandler(jugTimerEventProcessor);
        }

        private int[] FlashTotalCooldown = { 300, 300, 300, 300, 300 };

        static System.Windows.Forms.Timer topTimer = new System.Windows.Forms.Timer();
        static int [] Counter = { 0, 0, 0, 0, 0 };
        static bool [] ExitFlag = { false, false, false, false, false };

        static System.Windows.Forms.Timer jugTimer = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer midTimer = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer botTimer = new System.Windows.Forms.Timer();

        static System.Windows.Forms.Timer supTimer = new System.Windows.Forms.Timer();


        private void btnTopFlash_Click(object sender, EventArgs e)
        {
            topTimer.Stop();
            Console.WriteLine("btnTopFlash_Click...");
            btnTopFlash.Text = "300";
            int role = 0;
            Counter[role] = 300;
            btnTopFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            
            
            // Sets the timer interval to 5 seconds.
            topTimer.Interval = 1000;
            topTimer.Start();

            //// Runs the timer, and raises the event.
            //while (ExitFlag[role] == false)
            //{
            //    // Processes all the events in the queue.

            //    Application.DoEvents();
            //}



        }
        private void topTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 0;
            topTimer.Stop();

            if (Counter[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counter[role] -= 1;
                topTimer.Enabled = true;
                btnTopFlash.Text = Counter[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlag[role] = true;
                btnTopFlash.Text = "";
                btnTopFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }



        private void btnJugFlash_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnJugFlash_Click...");
            btnJugFlash.Text = "300";
            int role = 1;
            Counter[role] = 300;
            btnJugFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            
            
            // Sets the timer interval to 5 seconds.
            jugTimer.Interval = 1000;
            jugTimer.Start();
            // Runs the timer, and raises the event.
            //while (ExitFlag[role] == false)
            //{
            //    // Processes all the events in the queue.
            //    Application.DoEvents();
            //}

            
            

        }
        private void jugTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 1;
            jugTimer.Stop();

            if (Counter[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counter[role] -= 1;
                jugTimer.Enabled = true;
                btnJugFlash.Text = Counter[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlag[role] = true;
                btnJugFlash.Text = "";
                btnJugFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnClipboard_Click...");
            Clipboard.SetText("Hello, clipboard");
        }

    }
}
