namespace Project3
{
    partial class DunwoodyResidenceHallFormUN
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
            this.SignInLabel1 = new System.Windows.Forms.Label();
            this.SignInUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignInLabel1
            // 
            this.SignInLabel1.AutoSize = true;
            this.SignInLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel1.Location = new System.Drawing.Point(136, 38);
            this.SignInLabel1.Name = "SignInLabel1";
            this.SignInLabel1.Size = new System.Drawing.Size(95, 33);
            this.SignInLabel1.TabIndex = 0;
            this.SignInLabel1.Text = "Sign In";
            this.SignInLabel1.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // SignInUserName
            // 
            this.SignInUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInUserName.Location = new System.Drawing.Point(142, 138);
            this.SignInUserName.Name = "SignInUserName";
            this.SignInUserName.Size = new System.Drawing.Size(149, 30);
            this.SignInUserName.TabIndex = 1;
            this.SignInUserName.Text = "User Name";
            this.SignInUserName.TextChanged += new System.EventHandler(this.SignInUserName_TextChanged);
            // 
            // DunwoodyResidenceHallFormUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 366);
            this.Controls.Add(this.SignInUserName);
            this.Controls.Add(this.SignInLabel1);
            this.Name = "DunwoodyResidenceHallFormUN";
            this.Text = "DunwoodyResidenceHallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel1;
        private System.Windows.Forms.TextBox SignInUserName;
    }
}

