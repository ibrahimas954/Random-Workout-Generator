
namespace RandomWorkoutGenerator
{
    partial class Egzersizler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_exercise_name = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.list_current_exercises = new System.Windows.Forms.ListBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.lbl_workout_state = new System.Windows.Forms.Label();
            this.timer_pause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_exercise_name
            // 
            this.lbl_exercise_name.AutoSize = true;
            this.lbl_exercise_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exercise_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_exercise_name.Location = new System.Drawing.Point(272, 139);
            this.lbl_exercise_name.Name = "lbl_exercise_name";
            this.lbl_exercise_name.Size = new System.Drawing.Size(219, 37);
            this.lbl_exercise_name.TabIndex = 0;
            this.lbl_exercise_name.Text = "Egzersiz İsmi";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(322, 298);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 59);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Başlat";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // list_current_exercises
            // 
            this.list_current_exercises.FormattingEnabled = true;
            this.list_current_exercises.Items.AddRange(new object[] {
            "Workout !",
            "Time!"});
            this.list_current_exercises.Location = new System.Drawing.Point(609, 90);
            this.list_current_exercises.Name = "list_current_exercises";
            this.list_current_exercises.Size = new System.Drawing.Size(134, 212);
            this.list_current_exercises.TabIndex = 2;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_timer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_timer.Location = new System.Drawing.Point(272, 224);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(241, 37);
            this.lbl_timer.TabIndex = 3;
            this.lbl_timer.Text = "Sayaç Durumu";
            // 
            // lbl_workout_state
            // 
            this.lbl_workout_state.AutoSize = true;
            this.lbl_workout_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_workout_state.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_workout_state.Location = new System.Drawing.Point(12, 72);
            this.lbl_workout_state.Name = "lbl_workout_state";
            this.lbl_workout_state.Size = new System.Drawing.Size(266, 37);
            this.lbl_workout_state.TabIndex = 4;
            this.lbl_workout_state.Text = "Hareket Durumu";
            // 
            // timer_pause
            // 
            this.timer_pause.Location = new System.Drawing.Point(461, 298);
            this.timer_pause.Name = "timer_pause";
            this.timer_pause.Size = new System.Drawing.Size(112, 59);
            this.timer_pause.TabIndex = 5;
            this.timer_pause.Text = "Durdur";
            this.timer_pause.UseVisualStyleBackColor = true;
            this.timer_pause.Click += new System.EventHandler(this.timer_pause_Click);
            // 
            // Egzersizler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer_pause);
            this.Controls.Add(this.lbl_workout_state);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.list_current_exercises);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_exercise_name);
            this.Name = "Egzersizler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egzersizler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Egzersizler_FormClosing);
            this.Load += new System.EventHandler(this.Egzersizler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_exercise_name;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox list_current_exercises;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label lbl_workout_state;
        private System.Windows.Forms.Button timer_pause;
    }
}