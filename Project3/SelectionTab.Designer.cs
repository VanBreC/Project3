namespace Project3
{
    partial class SelectionTab
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
            this.CreateStudent = new System.Windows.Forms.Button();
            this.SearchStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateStudent
            // 
            this.CreateStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStudent.Location = new System.Drawing.Point(89, 60);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(264, 54);
            this.CreateStudent.TabIndex = 0;
            this.CreateStudent.Text = "Click To Create New Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // SearchStudent
            // 
            this.SearchStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudent.Location = new System.Drawing.Point(89, 201);
            this.SearchStudent.Name = "SearchStudent";
            this.SearchStudent.Size = new System.Drawing.Size(264, 56);
            this.SearchStudent.TabIndex = 1;
            this.SearchStudent.Text = "Click To Search Current Students";
            this.SearchStudent.UseVisualStyleBackColor = true;
            this.SearchStudent.Click += new System.EventHandler(this.SearchStudent_Click);
            // 
            // SelectionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 348);
            this.Controls.Add(this.SearchStudent);
            this.Controls.Add(this.CreateStudent);
            this.Name = "SelectionTab";
            this.Text = "SelectionTab";
            this.Load += new System.EventHandler(this.SelectionTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button SearchStudent;
    }
}