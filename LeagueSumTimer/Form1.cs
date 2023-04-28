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
using System.Windows.Input;
using System.Windows.Forms;
//
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;
using Utilities;
//using KeyEventHandler = System.Windows.Forms.KeyEventHandler;

namespace LeagueSumTimer
{
    

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // the total cooldown values for each role
        // may be changed if the corresponding enemy take the specific rune or item
        private int[] FlashTotalCooldown = { 300, 300, 300, 300, 300 };

        // names for each enemy
        string[] RoleNames = { "top", "jug", "mid", "bot", "sup" };

        // flash counters for each enemy
        static int [] Counters = { 0, 0, 0, 0, 0 };

        // exit flags for each enemy
        static bool [] ExitFlags = { false, false, false, false, false };

        // timer for each enemy
        static System.Windows.Forms.Timer[] Timers =
        {
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
            new System.Windows.Forms.Timer(),
        };

        // flag used for show/hide the form
        public static bool flag = true;

        public Form1()
        {

            InitializeComponent();
            //this.Opacity = .75;
            Timers[0].Tick += new EventHandler(topTimerEventProcessor);
            Timers[1].Tick += new EventHandler(jugTimerEventProcessor);
            Timers[2].Tick += new EventHandler(midTimerEventProcessor);
            Timers[3].Tick += new EventHandler(botTimerEventProcessor);
            Timers[4].Tick += new EventHandler(supTimerEventProcessor);
            this.MouseDown += Form1_MouseDown;
            this.Load += Form1_Load;
            this.pictureBox1.MouseDown += Form1_MouseDown;
            this.pictureBox2.MouseDown += Form1_MouseDown;
            this.pictureBox3.MouseDown += Form1_MouseDown;
            this.pictureBox4.MouseDown += Form1_MouseDown;
            this.pictureBox5.MouseDown += Form1_MouseDown;
            this.label1.MouseDown += Form1_MouseDown;
            this.FormClosed += new FormClosedEventHandler(Form1_Closing);
        }

        globalKeyboardHook gkh = new globalKeyboardHook();

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load...");
            gkh.HookedKeys.Add(Keys.F1);
            gkh.KeyDown += new System.Windows.Forms.KeyEventHandler(gkh_KeyDown);

            // thread that prints the cooldown info to in-game team chatbox
            Thread t = new Thread(() =>
            {
            while (true)
            {
                if (Keyboard.IsKeyDown(Key.F2))
                {
                    string text = "flash: ";
                    for (int i = 0; i < Counters.Length; i++)
                    {
                        if (Counters[i] != 0)
                        {
                            text += RoleNames[i] + " " + Counters[i] + "s; ";
                        }
                    }
                    SendKeys.SendWait(text);
                    SendKeys.SendWait("{ENTER}");
                    }
                }
            });
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }



        // show/hide the form
        void gkh_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Console.WriteLine("gkh_KeyDown...");
            if (flag)
            {
                //Hide();
                //Visible = false;
                WindowState = FormWindowState.Minimized;
                flag = false;
            }
            else
            {
                //Show();
                //Visible = true;
                WindowState = FormWindowState.Normal;
                flag = true;
            }

            e.Handled = true;
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Closing...");
            gkh.unhook();
        }


        private void btnTopFlash_Click(object sender, EventArgs e)
        {
            int role = 0;
            switch ((sender as Button).Name)
            {
                case "btnTopFlash":
                    Counters[role] = FlashTotalCooldown[role];
                    break;
                case "btnTop10":
                    Counters[role] = FlashTotalCooldown[role] - 10;
                    break;
                case "btnTop30":
                    Counters[role] = FlashTotalCooldown[role] - 30;
                    break;
                default:
                    break;
            }

            Timers[role].Stop();
            
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

            switch ((sender as Button).Name)
            {
                case "btnJugFlash":
                    Counters[role] = FlashTotalCooldown[role];
                    break;
                case "btnJug10":
                    Counters[role] = FlashTotalCooldown[role] - 10;
                    break;
                case "btnJug30":
                    Counters[role] = FlashTotalCooldown[role] - 30;
                    break;
                default:
                    break;
            }
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
            switch ((sender as Button).Name)
            {
                case "btnMidFlash":
                    Counters[role] = FlashTotalCooldown[role];
                    break;
                case "btnMid10":
                    Counters[role] = FlashTotalCooldown[role] - 10;
                    break;
                case "btnMid30":
                    Counters[role] = FlashTotalCooldown[role] - 30;
                    break;
                default:
                    break;
            }
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
            switch ((sender as Button).Name)
            {
                case "btnBotFlash":
                    Counters[role] = FlashTotalCooldown[role];
                    break;
                case "btnBot10":
                    Counters[role] = FlashTotalCooldown[role] - 10;
                    break;
                case "btnBot30":
                    Counters[role] = FlashTotalCooldown[role] - 30;
                    break;
                default:
                    break;
            }
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
            switch ((sender as Button).Name)
            {
                case "btnSupFlash":
                    Counters[role] = FlashTotalCooldown[role];
                    break;
                case "btnSup10":
                    Counters[role] = FlashTotalCooldown[role] - 10;
                    break;
                case "btnSup30":
                    Counters[role] = FlashTotalCooldown[role] - 30;
                    break;
                default:
                    break;
            }
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




        //private void btnClipboard_Click(object sender, EventArgs e)
        //{
            
        //    string cb_text = "Flash cooldown remains: ";
        //    for (int i = 0; i < Counters.Length; i++)
        //    {
        //        if (Counters[i] != 0){
        //            cb_text += RoleNames[i] + " " + Counters[i] + "s; ";
        //        }
        //    }
        //    Console.WriteLine(cb_text);
        //    Clipboard.SetText(cb_text);
        //}

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
