using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWorkoutGenerator
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=deneme;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        String[] LowerBody = { "Air Squat", "Lunge", "Backward Lunge", "Glute Bridge", "Plyo Lunge", "Calf Raise", "Squat Jump", "Squat Thrusht", "Shuffle", "Squat Rotate","Calf raise Squat" };  //11
        String[] UpperBody = { "Push Up", "Wide Push Up", "Narrow Push Up", "Crawl Out to Push Up", "Bear Crawl", "Barfix", "Super Man", "Pike Push Up", "Plyo Push Up", "Wide Barfix", "Narrow Barfix" }; //11
        String[] Core = { "Plank", "Mountain Climber", "Flutter Kicks", "Russian Twist", "Leg Raise", "Bicycle Crunch", "Sit Up", "Leg Lift Push", "Reverse Crunch", "Half L-Sit" };
        String[] HIIT = { "Jumping Jack", "Burpee", "Jump rope", "HighKnees", "Plank To Knee Tap", "Cross Skater" };
        String[] CreatedWorkout = new string[13];
        public  string content_fromDB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkoutGridRefresh();
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
                return_rest = 15;
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
            string[] shuffled_array = ShuffleUpperLower();
            int exercise_element, i = 0;
            Random rnd = new Random();

            while (i < exercise_num)
            {
                exercise_element = rnd.Next(0, shuffled_array.Length);

                if (i == 0)
                {
                    CreatedWorkout[i] = shuffled_array[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;
                }

                else if (!CreatedWorkout.Contains(shuffled_array[exercise_element]))
                {
                    CreatedWorkout[i] = shuffled_array[exercise_element];
                    listBox1.Items.Add(CreatedWorkout[i] + " " + work_time.ToString() + " " + "Sn Egzersiz");
                    listBox1.Items.Add(rest_time.ToString() + " " + "Sn Dinlenme");
                    i++;
                }
            }
        }

        private string[] ShuffleUpperLower()
        {
            return UpperBody.Concat(LowerBody).ToArray();            
        }

        private void CleanWorkoutArray()
        {
            Array.Clear(CreatedWorkout, 0, CreatedWorkout.Length);
            listBox1.Items.Clear();
            create_btn.Enabled = true;
        }

        private void WorkoutGridRefresh()
        {
            conn.Open();
            cmd = new SqlCommand("Select * from workout", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_workout.DataSource = dt;
            conn.Close();
        }

        private void WorkoutSaveToDB()
        {
            string context = "";

            foreach (string exercise in listBox1.Items)
            {
                context += exercise + "\n";
            }

            conn.Open();
            cmd = new SqlCommand("insert into workout(workout_content,workout_exercise_time, workout_rest_time, workout_total_time) values (@ct,@et,@rt,@tt)",conn);
            cmd.Parameters.AddWithValue("@ct", context);
            cmd.Parameters.AddWithValue("@et", CheckedWorkTime());
            cmd.Parameters.AddWithValue("@rt", CheckedRestTime());
            cmd.Parameters.AddWithValue("@tt", Convert.ToInt32(CalculateTotalWorkoutTime(Convert.ToInt32(sayi_combo.Text), CheckedWorkTime(), CheckedRestTime())));
            cmd.ExecuteNonQuery();
            conn.Close();
            WorkoutGridRefresh();
        }

        private void btn_save_workout_Click(object sender, EventArgs e)
        {
            WorkoutSaveToDB();  
        }

        private float CalculateTotalWorkoutTime(int exercise_num, int exercise_time, int rest_time)
        {
            return (exercise_time + rest_time) * exercise_num  - rest_time;
        }

        private string SelectExercisesFromDB()
        {

            cmd = new SqlCommand("SELECT workout_content FROM workout WHERE workout_no=5", conn);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            content_fromDB = dr["workout_content"].ToString();
            dr.Close();

            conn.Close();

            return content_fromDB;
        }

        private void btn_show_exercises_Click(object sender, EventArgs e)
        {
            content_fromDB = SelectExercisesFromDB();
            Egzersizler frm = new Egzersizler(content_fromDB);
            frm.Show();
            this.Hide();
        }
    }
}
