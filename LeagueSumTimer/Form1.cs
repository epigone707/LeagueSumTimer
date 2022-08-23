using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace LeagueSumTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timers[0].Tick += new EventHandler(topTimerEventProcessor);
            Timers[1].Tick += new EventHandler(jugTimerEventProcessor);
            Timers[2].Tick += new EventHandler(midTimerEventProcessor);
            Timers[3].Tick += new EventHandler(botTimerEventProcessor);
            Timers[4].Tick += new EventHandler(supTimerEventProcessor);
        }

        private int[] FlashTotalCooldown = { 300, 300, 300, 300, 300 };

        string[] RoleNames = { "top", "jug", "mid", "bot", "sup" };
        static int [] Counters = { 0, 0, 0, 0, 0 };
        static bool [] ExitFlags = { false, false, false, false, false };
        static System.Windows.Forms.Timer[] Timers =
        {
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
        };

        private void btnTopFlash_Click(object sender, EventArgs e)
        {
            
            int role = 0;
            Timers[role].Stop();
            //Console.WriteLine("btnTopFlash_Click...");
            
            Counters[role] = FlashTotalCooldown[role];
            btnTopFlash.Text = Counters[role].ToString();
            btnTopFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            Timers[role].Interval = 1000;
            Timers[role].Start();
        }
        private void topTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 0;
            Timers[role].Stop();

            if (Counters[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counters[role] -= 1;
                Timers[role].Enabled = true;
                btnTopFlash.Text = Counters[role].ToString();
            }
            else
            {
                // Stops the timer.
                ExitFlags[role] = true;
                btnTopFlash.Text = "";
                btnTopFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }



        private void btnJugFlash_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("btnJugFlash_Click...");
            
            int role = 1;
            Counters[role] = FlashTotalCooldown[role];
            btnJugFlash.Text = Counters[role].ToString();
            btnJugFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            Timers[role].Interval = 1000;
            Timers[role].Start();
        }

        private void jugTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 1;
            Timers[role].Stop();

            if (Counters[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counters[role] -= 1;
                Timers[role].Enabled = true;
                btnJugFlash.Text = Counters[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlags[role] = true;
                btnJugFlash.Text = "";
                btnJugFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }

        private void btnMidFlash_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("btnJugFlash_Click...");

            int role = 2;
            Counters[role] = FlashTotalCooldown[role];
            btnMidFlash.Text = Counters[role].ToString();
            btnMidFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            Timers[role].Interval = 1000;
            Timers[role].Start();
        }

        private void midTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 2;
            Timers[role].Stop();

            if (Counters[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counters[role] -= 1;
                Timers[role].Enabled = true;
                btnMidFlash.Text = Counters[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlags[role] = true;
                btnMidFlash.Text = "";
                btnMidFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }

        private void btnBotFlash_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("btnJugFlash_Click...");

            int role = 3;
            Counters[role] = FlashTotalCooldown[role];
            btnBotFlash.Text = Counters[role].ToString();
            btnBotFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            Timers[role].Interval = 1000;
            Timers[role].Start();
        }

        private void botTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 3;
            Timers[role].Stop();

            if (Counters[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counters[role] -= 1;
                Timers[role].Enabled = true;
                btnBotFlash.Text = Counters[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlags[role] = true;
                btnBotFlash.Text = "";
                btnBotFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }

        private void btnSupFlash_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("btnJugFlash_Click...");

            int role = 4;
            Counters[role] = FlashTotalCooldown[role];
            btnSupFlash.Text = Counters[role].ToString();
            btnSupFlash.BackgroundImage = Properties.Resources.FlashNotReady;

            Timers[role].Interval = 1000;
            Timers[role].Start();
        }

        private void supTimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            int role = 4;
            Timers[role].Stop();

            if (Counters[role] > 0)
            {
                // Restarts the timer and increments the counter.
                Counters[role] -= 1;
                Timers[role].Enabled = true;
                btnSupFlash.Text = Counters[role].ToString();

            }
            else
            {
                // Stops the timer.
                ExitFlags[role] = true;
                btnSupFlash.Text = "";
                btnSupFlash.BackgroundImage = Properties.Resources.Flash;
            }
        }




        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnClipboard_Click...");
            string cb_text = "Flash cooldown remains: ";
            for (int i = 0; i < Counters.Length; i++)
            {
                if (Counters[i] != 0){
                    cb_text += RoleNames[i] + " " + Counters[i] + "s; ";
                }
            }
            
            Clipboard.SetText(cb_text);
        }

        private void checkBoxTop_CheckedChanged(object sender, EventArgs e)
        {
            int role = 0; 
            //Console.WriteLine("checkBoxTop_CheckedChanged");
            if (checkBoxTopIns.Checked && checkBoxTopBoot.Checked)
            {
                FlashTotalCooldown[role] = 230;
            }
            else if (checkBoxTopIns.Checked)
            {
                FlashTotalCooldown[role] = 254;
            }else if (checkBoxTopBoot.Checked)
            {
                FlashTotalCooldown[role] = 267;
            }
            else
            {
                FlashTotalCooldown[role] = 300;
            }
        }
        private void checkBoxJug_CheckedChanged(object sender, EventArgs e)
        {
            int role = 1;
            //Console.WriteLine("checkBoxTop_CheckedChanged");
            if (checkBoxJugIns.Checked && checkBoxJugBoot.Checked)
            {
                FlashTotalCooldown[role] = 230;
            }
            else if (checkBoxJugIns.Checked)
            {
                FlashTotalCooldown[role] = 254;
            }
            else if (checkBoxJugBoot.Checked)
            {
                FlashTotalCooldown[role] = 267;
            }
            else
            {
                FlashTotalCooldown[role] = 300;
            }
        }
        private void checkBoxMid_CheckedChanged(object sender, EventArgs e)
        {
            int role = 2;
            //Console.WriteLine("checkBoxTop_CheckedChanged");
            if (checkBoxMidIns.Checked && checkBoxMidBoot.Checked)
            {
                FlashTotalCooldown[role] = 230;
            }
            else if (checkBoxMidIns.Checked)
            {
                FlashTotalCooldown[role] = 254;
            }
            else if (checkBoxMidBoot.Checked)
            {
                FlashTotalCooldown[role] = 267;
            }
            else
            {
                FlashTotalCooldown[role] = 300;
            }
        }
        private void checkBoxBot_CheckedChanged(object sender, EventArgs e)
        {
            int role = 3;
            //Console.WriteLine("checkBoxBot_CheckedChanged");
            if (checkBoxBotIns.Checked && checkBoxBotBoot.Checked)
            {
                FlashTotalCooldown[role] = 230;
            }
            else if (checkBoxBotIns.Checked)
            {
                FlashTotalCooldown[role] = 254;
            }
            else if (checkBoxBotBoot.Checked)
            {
                FlashTotalCooldown[role] = 267;
            }
            else
            {
                FlashTotalCooldown[role] = 300;
            }
        }
        private void checkBoxSup_CheckedChanged(object sender, EventArgs e)
        {
            int role = 4;
            //Console.WriteLine("checkBoxTop_CheckedChanged");
            if (checkBoxSupIns.Checked && checkBoxSupBoot.Checked)
            {
                FlashTotalCooldown[role] = 230;
            }
            else if (checkBoxSupIns.Checked)
            {
                FlashTotalCooldown[role] = 254;
            }
            else if (checkBoxSupBoot.Checked)
            {
                FlashTotalCooldown[role] = 267;
            }
            else
            {
                FlashTotalCooldown[role] = 300;
            }
        }
    }
}
