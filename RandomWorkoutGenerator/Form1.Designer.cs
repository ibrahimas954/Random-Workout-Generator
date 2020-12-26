
namespace RandomWorkoutGenerator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.antreman_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_40 = new System.Windows.Forms.RadioButton();
            this.radio_30 = new System.Windows.Forms.RadioButton();
            this.radio_20 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_20dinlen = new System.Windows.Forms.RadioButton();
            this.radio_15 = new System.Windows.Forms.RadioButton();
            this.radio_10 = new System.Windows.Forms.RadioButton();
            this.sayi_combo = new System.Windows.Forms.ComboBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.dgv_workout = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_workout = new System.Windows.Forms.Button();
            this.btn_show_exercises = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workout)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(522, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 199);
            this.listBox1.TabIndex = 0;
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(376, 308);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(73, 31);
            this.create_btn.TabIndex = 1;
            this.create_btn.Text = "Oluştur";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // antreman_combo
            // 
            this.antreman_combo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antreman_combo.FormattingEnabled = true;
            this.antreman_combo.Items.AddRange(new object[] {
            "Full Body",
            "Cardio",
            "ABS"});
            this.antreman_combo.Location = new System.Drawing.Point(173, 110);
            this.antreman_combo.Name = "antreman_combo";
            this.antreman_combo.Size = new System.Drawing.Size(276, 27);
            this.antreman_combo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hareket Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_40);
            this.groupBox1.Controls.Add(this.radio_30);
            this.groupBox1.Controls.Add(this.radio_20);
            this.groupBox1.Location = new System.Drawing.Point(173, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egzersiz Süresi";
            // 
            // radio_40
            // 
            this.radio_40.AutoSize = true;
            this.radio_40.Location = new System.Drawing.Point(204, 14);
            this.radio_40.Name = "radio_40";
            this.radio_40.Size = new System.Drawing.Size(51, 17);
            this.radio_40.TabIndex = 12;
            this.radio_40.TabStop = true;
            this.radio_40.Text = "40 sn";
            this.radio_40.UseVisualStyleBackColor = true;
            // 
            // radio_30
            // 
            this.radio_30.AutoSize = true;
            this.radio_30.Location = new System.Drawing.Point(115, 14);
            this.radio_30.Name = "radio_30";
            this.radio_30.Size = new System.Drawing.Size(51, 17);
            this.radio_30.TabIndex = 11;
            this.radio_30.TabStop = true;
            this.radio_30.Text = "30 sn";
            this.radio_30.UseVisualStyleBackColor = true;
            // 
            // radio_20
            // 
            this.radio_20.AutoSize = true;
            this.radio_20.Location = new System.Drawing.Point(22, 14);
            this.radio_20.Name = "radio_20";
            this.radio_20.Size = new System.Drawing.Size(51, 17);
            this.radio_20.TabIndex = 10;
            this.radio_20.TabStop = true;
            this.radio_20.Text = "20 sn";
            this.radio_20.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_20dinlen);
            this.groupBox2.Controls.Add(this.radio_15);
            this.groupBox2.Controls.Add(this.radio_10);
            this.groupBox2.Location = new System.Drawing.Point(173, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 44);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dinlenme Süresi";
            // 
            // radio_20dinlen
            // 
            this.radio_20dinlen.AutoSize = true;
            this.radio_20dinlen.Location = new System.Drawing.Point(204, 14);
            this.radio_20dinlen.Name = "radio_20dinlen";
            this.radio_20dinlen.Size = new System.Drawing.Size(51, 17);
            this.radio_20dinlen.TabIndex = 12;
            this.radio_20dinlen.TabStop = true;
            this.radio_20dinlen.Text = "20 sn";
            this.radio_20dinlen.UseVisualStyleBackColor = true;
            // 
            // radio_15
            // 
            this.radio_15.AutoSize = true;
            this.radio_15.Location = new System.Drawing.Point(115, 14);
            this.radio_15.Name = "radio_15";
            this.radio_15.Size = new System.Drawing.Size(51, 17);
            this.radio_15.TabIndex = 11;
            this.radio_15.TabStop = true;
            this.radio_15.Text = "15 sn";
            this.radio_15.UseVisualStyleBackColor = true;
            // 
            // radio_10
            // 
            this.radio_10.AutoSize = true;
            this.radio_10.Location = new System.Drawing.Point(22, 14);
            this.radio_10.Name = "radio_10";
            this.radio_10.Size = new System.Drawing.Size(51, 17);
            this.radio_10.TabIndex = 10;
            this.radio_10.TabStop = true;
            this.radio_10.Text = "10 sn";
            this.radio_10.UseVisualStyleBackColor = true;
            // 
            // sayi_combo
            // 
            this.sayi_combo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi_combo.FormattingEnabled = true;
            this.sayi_combo.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.sayi_combo.Location = new System.Drawing.Point(173, 60);
            this.sayi_combo.Name = "sayi_combo";
            this.sayi_combo.Size = new System.Drawing.Size(276, 27);
            this.sayi_combo.TabIndex = 9;
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(276, 308);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(73, 31);
            this.btn_clean.TabIndex = 10;
            this.btn_clean.Text = "Temizle";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // dgv_workout
            // 
            this.dgv_workout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_workout.Location = new System.Drawing.Point(522, 267);
            this.dgv_workout.Name = "dgv_workout";
            this.dgv_workout.RowHeadersWidth = 25;
            this.dgv_workout.Size = new System.Drawing.Size(531, 283);
            this.dgv_workout.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Antreman Türü:";
            // 
            // btn_save_workout
            // 
            this.btn_save_workout.Location = new System.Drawing.Point(173, 308);
            this.btn_save_workout.Name = "btn_save_workout";
            this.btn_save_workout.Size = new System.Drawing.Size(73, 31);
            this.btn_save_workout.TabIndex = 13;
            this.btn_save_workout.Text = "Kaydet";
            this.btn_save_workout.UseVisualStyleBackColor = true;
            this.btn_save_workout.Click += new System.EventHandler(this.btn_save_workout_Click);
            // 
            // btn_show_exercises
            // 
            this.btn_show_exercises.Location = new System.Drawing.Point(276, 390);
            this.btn_show_exercises.Name = "btn_show_exercises";
            this.btn_show_exercises.Size = new System.Drawing.Size(73, 31);
            this.btn_show_exercises.TabIndex = 14;
            this.btn_show_exercises.Text = "Görüntüle";
            this.btn_show_exercises.UseVisualStyleBackColor = true;
            this.btn_show_exercises.Click += new System.EventHandler(this.btn_show_exercises_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 665);
            this.Controls.Add(this.btn_show_exercises);
            this.Controls.Add(this.btn_save_workout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_workout);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.sayi_combo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.antreman_combo);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.ComboBox antreman_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_40;
        private System.Windows.Forms.RadioButton radio_30;
        private System.Windows.Forms.RadioButton radio_20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_20dinlen;
        private System.Windows.Forms.RadioButton radio_15;
        private System.Windows.Forms.RadioButton radio_10;
        private System.Windows.Forms.ComboBox sayi_combo;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.DataGridView dgv_workout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save_workout;
        private System.Windows.Forms.Button btn_show_exercises;
    }
}

