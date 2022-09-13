using System;
using System.Windows.Forms;

namespace Pomodoro
{
    public delegate void PomodoroSelected(object sender, PomodoroEventArgs eventArgs);
    

    /// <summary>
    /// Values of pomodoro task and rest.
    /// </summary>
    public enum PomodoroValues
    {
        /// <summary>
        /// Rest 5 min.
        /// </summary>
        rest = 5,
        /// <summary>
        /// Rest 15 min.
        /// </summary>
        bigRest = 15,
        /// <summary>
        /// Work duration 25 min.
        /// </summary>
        light = 25,
        /// <summary>
        /// Work duration 30 min.
        /// </summary>
        hard = 30
    }

    public partial class Settings : Form
    {
        public Action<object, PomodoroEventArgs> PomSelected;

        /// <summary>
        /// Task duration on app settings.
        /// </summary>
        int WorkValue { get; set; }
        /// <summary>
        /// Rest duration on app settings.
        /// </summary>
        int RestValue { get; set; }
        /// <summary>
        /// Number of tasks completed.
        /// </summary>
        int TasksCompleted { get; set; }

        /// <summary>
        /// On radio settings duration of pomodoro selected.
        /// </summary>
        public event PomodoroSelected RadioSelected;
        /// <summary>
        /// On reset pomodoro settings.
        /// </summary>
        public event PomodoroSelected RazSelected;

        public Settings()
        {
            InitializeComponent();

            WorkValue = Properties.Settings.Default.WorkValue;
            RestValue = Properties.Settings.Default.RestValue;
            TasksCompleted = Properties.Settings.Default.TasksFinished;

            lblTasks.Text = TasksCompleted.ToString();
            SelectRadio(WorkValue);

            radioButton25.Click += (s, e) =>
            {
                Properties.Settings.Default.WorkValue = (int)PomodoroValues.light;
                Properties.Settings.Default.RestValue = RestValue;
                Properties.Settings.Default.TasksFinished = TasksCompleted;
                Properties.Settings.Default.Save();

                PomSelected?.Invoke(this, new PomodoroEventArgs() {
                    TimeTaskSelected = (int)PomodoroValues.light,
                    PRestValue = RestValue,
                    TasksFinished = TasksCompleted
                });
            };
            radioButton30.Click += (s, ev) =>
            {
                Properties.Settings.Default.WorkValue = (int)PomodoroValues.hard;
                Properties.Settings.Default.RestValue = RestValue;
                Properties.Settings.Default.TasksFinished = TasksCompleted;
                Properties.Settings.Default.Save();

                RadioSelected?.Invoke(this, new PomodoroEventArgs() {
                    TimeTaskSelected = (int)PomodoroValues.hard,
                    PRestValue = RestValue,
                    TasksFinished = TasksCompleted
                });
            };

            // CLOSE SETTINGS
            btnValider.Click += (s, e) => this.Close();

            // RAZ
            btnRAZ.Click += (s, e) =>
            {
                SelectRadio((int)PomodoroValues.light);

                Properties.Settings.Default.WorkValue = (int)PomodoroValues.light;
                Properties.Settings.Default.RestValue = (int)PomodoroValues.rest;
                Properties.Settings.Default.TasksFinished = 0;
                Properties.Settings.Default.Save();

                lblTasks.Text = "0";

                RazSelected?.Invoke(this, new PomodoroEventArgs()
                {
                    TimeTaskSelected = (int)PomodoroValues.light,
                    PRestValue = (int)PomodoroValues.rest,
                    TasksFinished = 0
                });
            };
        }

        /// <summary>
        /// Selection radio control on settings.
        /// </summary>
        /// <param name="workValue"></param>
        private void SelectRadio(int workValue)
        {
            switch (workValue)
            {
                case (int)PomodoroValues.hard:
                    radioButton30.Select();
                    break;
                case (int)PomodoroValues.light:
                    radioButton25.Select();
                    break;
                default:
                    break;
            }
        }
    }

    public class PomodoroEventArgs : EventArgs
    {
        /// <summary>
        /// Selection of task pomodoro duration.
        /// </summary>
        public int TimeTaskSelected { get; set; }
        /// <summary>
        /// Rest value selected.
        /// </summary>
        public int PRestValue { get; set; }
        /// <summary>
        /// Number of pomodoro tasks completed.
        /// </summary>
        public int TasksFinished { get; set; }
    }
}