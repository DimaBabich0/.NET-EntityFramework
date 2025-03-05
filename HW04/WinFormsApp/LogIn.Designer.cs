namespace WinFormsApp
{
    partial class LogIn
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
            label1 = new Label();
            buttonLogIn = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 26);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(13, 147);
            buttonLogIn.Margin = new Padding(4);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(130, 45);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(13, 39);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(275, 33);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(13, 106);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(275, 33);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(158, 147);
            buttonSignUp.Margin = new Padding(4);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(130, 45);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 211);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonLogIn);
            Controls.Add(label1);
            Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LogIn";
            Text = "Log In";
            FormClosed += LogIn_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonLogIn;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonSignUp;
    }
}