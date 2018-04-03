namespace Project3
{
    partial class ProcessSelectionTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateStudentPage = new System.Windows.Forms.TabPage();
            this.CreateStudent = new System.Windows.Forms.Button();
            this.LastNTextBox = new System.Windows.Forms.TextBox();
            this.FirstNTextBox = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.StudentWorkerBox = new System.Windows.Forms.CheckBox();
            this.AthleteBox = new System.Windows.Forms.CheckBox();
            this.ScholorshipBox = new System.Windows.Forms.CheckBox();
            this.CheckBoxLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CreateStudentPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateStudentPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // CreateStudentPage
            // 
            this.CreateStudentPage.Controls.Add(this.CreateStudent);
            this.CreateStudentPage.Controls.Add(this.LastNTextBox);
            this.CreateStudentPage.Controls.Add(this.FirstNTextBox);
            this.CreateStudentPage.Controls.Add(this.LNameLabel);
            this.CreateStudentPage.Controls.Add(this.FNameLabel);
            this.CreateStudentPage.Controls.Add(this.StudentWorkerBox);
            this.CreateStudentPage.Controls.Add(this.AthleteBox);
            this.CreateStudentPage.Controls.Add(this.ScholorshipBox);
            this.CreateStudentPage.Controls.Add(this.CheckBoxLabel);
            this.CreateStudentPage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStudentPage.Location = new System.Drawing.Point(4, 25);
            this.CreateStudentPage.Name = "CreateStudentPage";
            this.CreateStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateStudentPage.Size = new System.Drawing.Size(953, 494);
            this.CreateStudentPage.TabIndex = 0;
            this.CreateStudentPage.Text = "Create a Student";
            this.CreateStudentPage.UseVisualStyleBackColor = true;
            this.CreateStudentPage.Click += new System.EventHandler(this.CreateStudentPage_Click);
            // 
            // CreateStudent
            // 
            this.CreateStudent.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStudent.Location = new System.Drawing.Point(375, 331);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(201, 48);
            this.CreateStudent.TabIndex = 8;
            this.CreateStudent.Text = "Create Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // LastNTextBox
            // 
            this.LastNTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNTextBox.Location = new System.Drawing.Point(610, 225);
            this.LastNTextBox.Name = "LastNTextBox";
            this.LastNTextBox.Size = new System.Drawing.Size(166, 30);
            this.LastNTextBox.TabIndex = 7;
            this.LastNTextBox.TextChanged += new System.EventHandler(this.LastNTextBox_TextChanged);
            // 
            // FirstNTextBox
            // 
            this.FirstNTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNTextBox.Location = new System.Drawing.Point(610, 124);
            this.FirstNTextBox.Name = "FirstNTextBox";
            this.FirstNTextBox.Size = new System.Drawing.Size(166, 30);
            this.FirstNTextBox.TabIndex = 6;
            this.FirstNTextBox.TextChanged += new System.EventHandler(this.FirstNTextBox_TextChanged);
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(504, 228);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(100, 22);
            this.LNameLabel.TabIndex = 5;
            this.LNameLabel.Text = "Last Name:";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(500, 127);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(104, 22);
            this.FNameLabel.TabIndex = 4;
            this.FNameLabel.Text = "First Name:";
            // 
            // StudentWorkerBox
            // 
            this.StudentWorkerBox.AutoSize = true;
            this.StudentWorkerBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentWorkerBox.Location = new System.Drawing.Point(148, 271);
            this.StudentWorkerBox.Name = "StudentWorkerBox";
            this.StudentWorkerBox.Size = new System.Drawing.Size(153, 26);
            this.StudentWorkerBox.TabIndex = 3;
            this.StudentWorkerBox.Text = "Student Worker";
            this.StudentWorkerBox.UseVisualStyleBackColor = true;
            this.StudentWorkerBox.CheckedChanged += new System.EventHandler(this.StudentWorkerBox_CheckedChanged);
            // 
            // AthleteBox
            // 
            this.AthleteBox.AutoSize = true;
            this.AthleteBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteBox.Location = new System.Drawing.Point(148, 200);
            this.AthleteBox.Name = "AthleteBox";
            this.AthleteBox.Size = new System.Drawing.Size(89, 26);
            this.AthleteBox.TabIndex = 2;
            this.AthleteBox.Text = "Athlete";
            this.AthleteBox.UseVisualStyleBackColor = true;
            this.AthleteBox.CheckedChanged += new System.EventHandler(this.AthleteBox_CheckedChanged);
            // 
            // ScholorshipBox
            // 
            this.ScholorshipBox.AutoSize = true;
            this.ScholorshipBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholorshipBox.Location = new System.Drawing.Point(148, 127);
            this.ScholorshipBox.Name = "ScholorshipBox";
            this.ScholorshipBox.Size = new System.Drawing.Size(127, 26);
            this.ScholorshipBox.TabIndex = 1;
            this.ScholorshipBox.Text = "Scholorship";
            this.ScholorshipBox.UseVisualStyleBackColor = true;
            this.ScholorshipBox.CheckedChanged += new System.EventHandler(this.ScholorshipBox_CheckedChanged);
            // 
            // CheckBoxLabel
            // 
            this.CheckBoxLabel.AutoSize = true;
            this.CheckBoxLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxLabel.Location = new System.Drawing.Point(132, 50);
            this.CheckBoxLabel.Name = "CheckBoxLabel";
            this.CheckBoxLabel.Size = new System.Drawing.Size(367, 33);
            this.CheckBoxLabel.TabIndex = 0;
            this.CheckBoxLabel.Text = "Select which one applies to you";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search For Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(749, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(227, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student ID";
            // 
            // ProcessSelectionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProcessSelectionTab";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.CreateStudentPage.ResumeLayout(false);
            this.CreateStudentPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateStudentPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label CheckBoxLabel;
        private System.Windows.Forms.CheckBox ScholorshipBox;
        private System.Windows.Forms.CheckBox StudentWorkerBox;
        private System.Windows.Forms.CheckBox AthleteBox;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.TextBox LastNTextBox;
        private System.Windows.Forms.TextBox FirstNTextBox;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}