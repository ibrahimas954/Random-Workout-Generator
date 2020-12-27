using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWorkoutGenerator
{
    public partial class Egzersizler : Form
    {
        public enum workout_state
        {
            Preapare,
            Work,
            Rest
        }
        public int state;
        Form1 frm = new Form1();
        string line;
        public int sayac = 0;

        public Egzersizler(string cntnt)
        {
            InitializeComponent();
            
            StringReader reader = new StringReader(cntnt);

            while ((line = reader.ReadLine()) != null)
            {
                list_current_exercises.Items.Add(line);
            }

        }

        private void Egzersizler_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();           
            frm.Show();
        }

        private void Egzersizler_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            list_current_exercises.SelectedIndex = 2;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            TimerStart();
            PreapareScreen(sayac);
           
        }

        private void timer_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerToLabel();
             
            if ( state == Convert.ToInt32(workout_state.Preapare))
            {
                PreapareTimerControl(sayac);
            }

            else if( state == Convert.ToInt32(workout_state.Work))
            {
                WorkTimerControl(sayac);
            }

            else if(state == Convert.ToInt32(workout_state.Rest))
            {
                RestTimerControl(sayac);
            }   
            
        }

        private void PreapareTimerControl(int sayac)
        {
            if (sayac %6 == 0)
            {
                TimerReset();
                WorkoutScreen();
            }
        }

        private void WorkTimerControl(int sayac)
        {
            if (sayac % 11 == 0)
            {
                TimerReset();
                RestScreen();      
            }
        }

        private void RestTimerControl(int sayac)
        {
            if(sayac % 6 == 0)
            { 
                TimerReset();
                WorkoutScreen();    
            }
        }

        private void PreapareScreen(int sayac)
        {
            state = Convert.ToInt32(workout_state.Preapare);
            this.BackColor = Color.Orange;
            lbl_workout_state.Text = "Preapare";       
        }

        private void WorkoutScreen()
        {
            state = Convert.ToInt32(workout_state.Work);
            this.BackColor = Color.Green;
            lbl_workout_state.Text = "Work!";
            lbl_exercise_name.Text = list_current_exercises.SelectedItem.ToString();
        }

        private void RestScreen()
        {
            state = Convert.ToInt32(workout_state.Rest);
            this.BackColor = Color.Red;
            lbl_workout_state.Text = "Rest";
        }

        private void TimerStart()
        {
            timer1.Start();
        }

        private void TimerReset()
        {
            lbl_timer.Text = "0";
            sayac = 0;
        }

        private void TimerToLabel()
        {
            sayac++;
            lbl_timer.Text = sayac.ToString();
        }

    }
}
