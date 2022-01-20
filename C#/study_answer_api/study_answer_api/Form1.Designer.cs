namespace study_answer_api
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_info = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_answer1 = new System.Windows.Forms.Button();
            this.btn_answer2 = new System.Windows.Forms.Button();
            this.btn_answer3 = new System.Windows.Forms.Button();
            this.btn_answer4 = new System.Windows.Forms.Button();
            this.btn_answer5 = new System.Windows.Forms.Button();
            this.btn_answer6 = new System.Windows.Forms.Button();
            this.btn_answer7 = new System.Windows.Forms.Button();
            this.btn_answer8 = new System.Windows.Forms.Button();
            this.btn_answer9 = new System.Windows.Forms.Button();
            this.btn_answer10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(12, 12);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(90, 20);
            this.btn_info.TabIndex = 0;
            this.btn_info.Text = "내정보 출력";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(120, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(88, 21);
            this.txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(226, 12);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(88, 21);
            this.txt_age.TabIndex = 2;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(332, 12);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(88, 21);
            this.txt_gender.TabIndex = 3;
            this.txt_gender.TextChanged += new System.EventHandler(this.txt_gender_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "내정보 출력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "폼1 정보 넘기기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "태어난 연도는?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 21);
            this.textBox2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "숫자 맞추기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_answer1
            // 
            this.btn_answer1.Location = new System.Drawing.Point(12, 200);
            this.btn_answer1.Name = "btn_answer1";
            this.btn_answer1.Size = new System.Drawing.Size(75, 23);
            this.btn_answer1.TabIndex = 10;
            this.btn_answer1.Text = "1";
            this.btn_answer1.UseVisualStyleBackColor = true;
            // 
            // btn_answer2
            // 
            this.btn_answer2.Location = new System.Drawing.Point(93, 202);
            this.btn_answer2.Name = "btn_answer2";
            this.btn_answer2.Size = new System.Drawing.Size(75, 23);
            this.btn_answer2.TabIndex = 11;
            this.btn_answer2.Text = "2";
            this.btn_answer2.UseVisualStyleBackColor = true;
            this.btn_answer2.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_answer3
            // 
            this.btn_answer3.Location = new System.Drawing.Point(12, 228);
            this.btn_answer3.Name = "btn_answer3";
            this.btn_answer3.Size = new System.Drawing.Size(75, 23);
            this.btn_answer3.TabIndex = 12;
            this.btn_answer3.Text = "3";
            this.btn_answer3.UseVisualStyleBackColor = true;
            // 
            // btn_answer4
            // 
            this.btn_answer4.Location = new System.Drawing.Point(93, 228);
            this.btn_answer4.Name = "btn_answer4";
            this.btn_answer4.Size = new System.Drawing.Size(75, 23);
            this.btn_answer4.TabIndex = 13;
            this.btn_answer4.Text = "4";
            this.btn_answer4.UseVisualStyleBackColor = true;
            // 
            // btn_answer5
            // 
            this.btn_answer5.Location = new System.Drawing.Point(12, 257);
            this.btn_answer5.Name = "btn_answer5";
            this.btn_answer5.Size = new System.Drawing.Size(75, 23);
            this.btn_answer5.TabIndex = 14;
            this.btn_answer5.Text = "5";
            this.btn_answer5.UseVisualStyleBackColor = true;
            // 
            // btn_answer6
            // 
            this.btn_answer6.Location = new System.Drawing.Point(93, 257);
            this.btn_answer6.Name = "btn_answer6";
            this.btn_answer6.Size = new System.Drawing.Size(75, 23);
            this.btn_answer6.TabIndex = 15;
            this.btn_answer6.Text = "6";
            this.btn_answer6.UseVisualStyleBackColor = true;
            // 
            // btn_answer7
            // 
            this.btn_answer7.Location = new System.Drawing.Point(12, 285);
            this.btn_answer7.Name = "btn_answer7";
            this.btn_answer7.Size = new System.Drawing.Size(75, 23);
            this.btn_answer7.TabIndex = 16;
            this.btn_answer7.Text = "7";
            this.btn_answer7.UseVisualStyleBackColor = true;
            // 
            // btn_answer8
            // 
            this.btn_answer8.Location = new System.Drawing.Point(93, 285);
            this.btn_answer8.Name = "btn_answer8";
            this.btn_answer8.Size = new System.Drawing.Size(75, 23);
            this.btn_answer8.TabIndex = 17;
            this.btn_answer8.Text = "8";
            this.btn_answer8.UseVisualStyleBackColor = true;
            // 
            // btn_answer9
            // 
            this.btn_answer9.Location = new System.Drawing.Point(12, 314);
            this.btn_answer9.Name = "btn_answer9";
            this.btn_answer9.Size = new System.Drawing.Size(75, 23);
            this.btn_answer9.TabIndex = 18;
            this.btn_answer9.Text = "9";
            this.btn_answer9.UseVisualStyleBackColor = true;
            // 
            // btn_answer10
            // 
            this.btn_answer10.Location = new System.Drawing.Point(93, 312);
            this.btn_answer10.Name = "btn_answer10";
            this.btn_answer10.Size = new System.Drawing.Size(75, 23);
            this.btn_answer10.TabIndex = 19;
            this.btn_answer10.Text = "10";
            this.btn_answer10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "로또 번호 뽑기";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(219, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(307, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(395, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(483, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(571, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(659, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(747, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_answer10);
            this.Controls.Add(this.btn_answer9);
            this.Controls.Add(this.btn_answer8);
            this.Controls.Add(this.btn_answer7);
            this.Controls.Add(this.btn_answer6);
            this.Controls.Add(this.btn_answer5);
            this.Controls.Add(this.btn_answer4);
            this.Controls.Add(this.btn_answer3);
            this.Controls.Add(this.btn_answer2);
            this.Controls.Add(this.btn_answer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_info;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_answer1;
        private System.Windows.Forms.Button btn_answer2;
        private System.Windows.Forms.Button btn_answer3;
        private System.Windows.Forms.Button btn_answer4;
        private System.Windows.Forms.Button btn_answer5;
        private System.Windows.Forms.Button btn_answer6;
        private System.Windows.Forms.Button btn_answer7;
        private System.Windows.Forms.Button btn_answer8;
        private System.Windows.Forms.Button btn_answer9;
        private System.Windows.Forms.Button btn_answer10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

