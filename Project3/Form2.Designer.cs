namespace Project3
{
    partial class Form2
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
            this.SignInLabel2 = new System.Windows.Forms.Label();
            this.SignInPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignInLabel2
            // 
            this.SignInLabel2.AutoSize = true;
            this.SignInLabel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel2.Location = new System.Drawing.Point(98, 61);
            this.SignInLabel2.Name = "SignInLabel2";
            this.SignInLabel2.Size = new System.Drawing.Size(95, 33);
            this.SignInLabel2.TabIndex = 0;
            this.SignInLabel2.Text = "Sign In";
            // 
            // SignInPassword
            // 
            this.SignInPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInPassword.Location = new System.Drawing.Point(104, 161);
            this.SignInPassword.Name = "SignInPassword";
            this.SignInPassword.Size = new System.Drawing.Size(100, 30);
            this.SignInPassword.TabIndex = 1;
            this.SignInPassword.Text = "Password";
            this.SignInPassword.TextChanged += new System.EventHandler(this.SignInPassword_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 402);
            this.Controls.Add(this.SignInPassword);
            this.Controls.Add(this.SignInLabel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel2;
        private System.Windows.Forms.TextBox SignInPassword;
    }
}