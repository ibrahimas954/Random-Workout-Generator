using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWorkoutGenerator
{
    public partial class Form1 : Form
    {
        String[] LowerBody = { "Air Squat", "Lunge", "Backward Lunge", "Glute Bridge", "Plyo Lunge", "Calf Raise", "Squat Jump", "Squat Thrusht", "Shuffle", "Squat Rotate","Calf raise Squat" };  //11
        String[] UpperBody = { "Push Up", "Wide Push Up", "Narrow Push Up", "Crawl Out to Push Up", "Bear Crawl", "Barfix", "Super Man", "Pike Push Up", "Plyo Push Up", "Wide Barfix", "Narrow Barfix" }; //11
        String[] Core = { "Plank", "Mountain Climber", "Flutter Kicks", "Russian Twist", "Leg Raise", "Bicycle Crunch", "Sit Up", "Leg Lift Push", "Reverse Crunch", "Half L-Sit" };
        String[] HIIT = { "Jumping Jack", "Burpee", "Jump rope", "HighKnees", "Plank To Knee Tap", "Cross Skater" };
        String[] CreatedWorkout = new string[12];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (antreman_combo.Text == "Full Body")
            {
                GenerateFullBodyWorkout(Convert.ToInt32(sayi_combo.Text), CheckedWorkTime(), CheckedRestTime());
            }

            else if (antreman_combo.Text == "Cardio")
            {
                GenerateCardioWorkout(Convert.ToInt32(sayi_combo.Text), CheckedWorkTime(), CheckedRestTime());
            }

            else if (antreman_combo.Text == "ABS")
            {
                GenerateABSWorkout(Convert.ToInt32(sayi_combo.Text), CheckedWorkTime(), CheckedRestTime());
            }

            create_btn.Enabled = false;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            CleanWorkoutArray();
        }

        private int CheckedWorkTime()
        {
            int return_work = 0;

            if (radio_20.Checked)
            {
                return_work = 20;
            }
            
            else if(radio_30.Checked)
            {
                return_work = 30;
            }

            else if(radio_40.Checked)
            
            {
                return_work = 40;
            }

            return return_work;
        }

        private int CheckedRestTime()
        {
            int return_rest = 0;

            if (radio_10.Checked)
            {
                return_rest = 10;
            }

            else if (radio_15.Checked)
            {
                return_rest = 30;
            }

            else if (radio_20dinlen.Checked)

            {
                return_rest = 20;
            }

            return return_rest;
        }

        private void GenerateABSWorkout(int exercise_num, int work_time, int rest_time)
        {
            int exercises_length = Core.Length;
            int exercise_element,i = 0;
            Random rndm = new Random();

            while( i < exercise_num)
            {
                exercise_element = rndm.Next(0, exercises_length);

                if (i == 0)
                {
                    CreatedWorkout[i] = Core[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;
                }

                else if (!CreatedWorkout.Contains(Core[exercise_element]))
                {
                    CreatedWorkout[i] = Core[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;
                      
                }
                
            }

        }

        private void GenerateCardioWorkout(int exercise_num, int work_time, int rest_time)
        {
            int exercises_length = HIIT.Length;
            int exercise_element, i = 0;

            Random rndm = new Random();

            while (i < exercise_num)
            {
                exercise_element = rndm.Next(0, exercises_length);

                if (i == 0)
                {
                    CreatedWorkout[i] = HIIT[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;
                }

                else if (!CreatedWorkout.Contains(HIIT[exercise_element]))
                {
                    CreatedWorkout[i] = HIIT[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;

                }

            }
        }

        private void GenerateFullBodyWorkout(int exercise_num, int work_time, int rest_time)
        {
            ShuffleUpperLower(exercise_num);   
        }

        private void ShuffleUpperLower(int exercise_num)
        {
          // Upper ve Lower adlı array bir listeye kopyalanacak ve arasında rastgele seçim yapılacak seçim oranı %50 olacaktır.
        }

        private void CleanWorkoutArray()
        {
            Array.Clear(CreatedWorkout, 0, CreatedWorkout.Length);
            listBox1.Items.Clear();
            create_btn.Enabled = true;
        }

       
    }
}
