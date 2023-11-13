namespace LR_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GroupBox1 = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            GroupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(478, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(478, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 4;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 62);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 98);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(checkBox4);
            GroupBox1.Controls.Add(checkBox5);
            GroupBox1.Controls.Add(checkBox6);
            GroupBox1.Controls.Add(checkBox3);
            GroupBox1.Controls.Add(checkBox2);
            GroupBox1.Controls.Add(checkBox1);
            GroupBox1.Location = new Point(25, 142);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(194, 101);
            GroupBox1.TabIndex = 9;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Увлечения";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(101, 50);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(58, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Театр";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(11, 75);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(64, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Танцы";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox6.Location = new Point(101, 75);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(86, 19);
            checkBox6.TabIndex = 3;
            checkBox6.Text = "Рукоделие";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(101, 25);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(55, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Кино";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(11, 50);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Музыка";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(11, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Спорт";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(225, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 101);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Образование";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(6, 71);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(225, 23);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Высшее профессиональное";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(6, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(226, 23);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Среднее профессиональное";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(6, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(135, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Среднее общее";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Font = new Font("Microsoft New Tai Lue", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(515, 142);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(122, 101);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пол";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(8, 57);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(93, 23);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Женский";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = SystemColors.ButtonFace;
            radioButton6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.Location = new Point(7, 25);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(96, 23);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Мужской";
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(257, 264);
            button1.Name = "button1";
            button1.Size = new Size(171, 79);
            button1.TabIndex = 12;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 355);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Лабораторная работа №1";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox GroupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button1;
    }
}
