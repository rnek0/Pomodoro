using System;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Task value time.
        /// </summary>
        int WORK { get; set; }
        /// <summary>
        /// Rest value time.
        /// </summary>
        int REST { get; set; }
        /// <summary>
        /// Number of tasks acomplished.
        /// </summary>
        int TASKS { get; set; }

        DateTime timeStart;
        TimeSpan timeSpan;
        DateTime timeEnd;
        TimeSpan interval;

        System.IO.Stream sound;
        SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();

            btnWorking.Click    += (s, e) => Pomodoro((int)(s as Button).Tag);
            btnRest.Click       += (s, e) => Pomodoro((int)btnRest.Tag);
            btnStop.Click       += (s, e) => StopPomodoroTask();
            btnSettings.Click   += (s, e) => SettingsPomodoro();

            FormClosing         += (s, e) => Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Instantiates classes & params.
        /// </summary>
        private void InitializeControls()
        {
            sound       = Properties.Resources.clochette;
            soundPlayer = new SoundPlayer(sound);

            WORK        = Properties.Settings.Default.WorkValue;
            REST        = Properties.Settings.Default.RestValue;
            TASKS       = Properties.Settings.Default.TasksFinished;

            #region DEV TESTS ---------------------------------------------
            //TASKS = 5;
            //Properties.Settings.Default.TasksFinished = TASKS;
            //Properties.Settings.Default.Save();
            //WORK = 25;
            //WORK = 1;
            //REST = 15;
            //REST = 5;
            #endregion END TEST -------------------------------------------

            btnWorking.Focus();
            btnWorking.Tag = WORK;
            btnRest.Tag = REST;
            btnStop.Enabled = false;

            lblTime.Text = $"{WORK}:00";
            DisplayTasksLabel(TASKS);
        }

        /// <summary>
        /// Display number of tasks acomplished.
        /// </summary>
        /// <param name="tasksAcomplished">Number of tasks.</param>
        private void DisplayTasksLabel(int tasksAcomplished)
        {
            lblTasksFinished.Text = $"Tâches finies : {tasksAcomplished}";
        }

        /// <summary>
        /// Open Settings Window.
        /// </summary>
        private void SettingsPomodoro()
        {
            Settings settings = new Settings();

            settings.RadioSelected += (s, e) => 
            {
                WORK = e.TimeTaskSelected;
                REST = e.PRestValue;
                TASKS = e.TasksFinished;

                Properties.Settings.Default.WorkValue = WORK;
                Properties.Settings.Default.RestValue = REST;
                Properties.Settings.Default.TasksFinished = TASKS;
                Properties.Settings.Default.Save();

                btnWorking.Tag = WORK;
                btnRest.Tag = REST;
                lblTime.Text = $"{WORK.ToString()}:00";
            };

            settings.PomSelected += (sen, eve) =>
            {
                WORK = eve.TimeTaskSelected;
                REST = eve.PRestValue;
                TASKS = eve.TasksFinished;

                Properties.Settings.Default.WorkValue = WORK;
                Properties.Settings.Default.RestValue = REST;
                Properties.Settings.Default.TasksFinished = TASKS;
                Properties.Settings.Default.Save();

                btnWorking.Tag = WORK;
                btnRest.Tag = REST;
                lblTime.Text = $"{WORK.ToString()}:00";
            };

            settings.RazSelected += (sn, ev) =>
            {
                WORK = ev.TimeTaskSelected;
                REST = ev.PRestValue;
                TASKS = ev.TasksFinished;

                Properties.Settings.Default.WorkValue = WORK;
                Properties.Settings.Default.RestValue = REST;
                Properties.Settings.Default.TasksFinished = TASKS;
                Properties.Settings.Default.Save();

                btnWorking.Tag = WORK;
                btnRest.Tag    = REST;
                DisplayTasksLabel(TASKS);
            };

            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog();
        }

        /// <summary>
        /// Start the pomodoro counter with a given duration.
        /// </summary>
        /// <param name="taskTimeDuration">task duration: work or rest. Int between 1 & 59 </param>
        private void Pomodoro(int taskTimeDuration)
        {
            #region SETTINGS
            btnStop.Enabled     = true;
            btnSettings.Enabled = false;

            btnWorking.Enabled  = false;
            btnRest.Enabled     = false;

            timeStart = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")); 
            timeSpan = new TimeSpan(0, taskTimeDuration, 1); // Starts 1 sec after.
            timeEnd = timeStart.Add(timeSpan);

            timerPomodoro.Interval = 1000;
            timerPomodoro.Enabled = true;
            timerPomodoro.Start();

            interval = timeEnd - DateTime.Now;
            lblTime.Text = string.Format("{0:mm\\:ss}", interval);
            lblTime.ForeColor = System.Drawing.Color.Red;
            #endregion

            timerPomodoro.Tick += (o, snd) =>
            {
                interval = timeEnd - DateTime.Now;
                lblTime.Text = string.Format("{0:mm\\:ss}", interval);
                this.Text = string.Format("{0:mm\\:ss}", interval);

                // STOP COUNTER
                if (timeEnd.CompareTo(DateTime.Now) < 0)
                {
                    StopPomodoroTask();

                    switch (taskTimeDuration)
                    {
                        case (int)PomodoroValues.light:
                            TASKS += 1;
                            break;
                        case (int)PomodoroValues.hard:
                            TASKS += 1;
                            break;
                        case (int)PomodoroValues.rest:
                            
                            break;
                        case (int)PomodoroValues.bigRest:
                            
                            break;
                        default:
                            break;
                    }
                    Properties.Settings.Default.TasksFinished = TASKS;
                    Properties.Settings.Default.Save();

                    UpdateRestValue(TASKS);
                    DisplayTasksLabel(TASKS);

                    Task.Factory.StartNew(() => soundPlayer.Play());

                    btnStop.Enabled = false;
                    btnSettings.Enabled = true;
                }
            };
        }

        /// <summary>
        /// Stop pomodoro task time counter.
        /// </summary>
        private void StopPomodoroTask()
        {
            if (timerPomodoro.Enabled)
            {
                timerPomodoro.Stop();
                timerPomodoro.Enabled = false;

                this.Text = "Pomodoro";
                lblTime.ForeColor = System.Drawing.Color.White;
                lblTime.Text = $"{WORK}:00";

                btnStop.Enabled = false;
                btnSettings.Enabled = true;
                btnWorking.Enabled = true;
                btnRest.Enabled = true;

                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        /// <summary>
        /// Update rest time value & update Tag btnRest button.
        /// </summary>
        /// <param name="tasksFinished">Number of finished tasks</param>
        private void UpdateRestValue(int tasksFinished)
        {
            // From the 4 tasks, a longer pause (15-20 minutes).
            if (tasksFinished >= 4)
            {
                btnRest.Tag = (int)PomodoroValues.bigRest;
                Properties.Settings.Default.RestValue = (int)PomodoroValues.bigRest;
            }
            else
            {
                btnRest.Tag = (int)PomodoroValues.rest;
                Properties.Settings.Default.RestValue = (int)PomodoroValues.rest;
            }
            
            //Properties.Settings.Default.RestValue = (int)btnRest.Tag;
            Properties.Settings.Default.Save();
        }
    }
}
