namespace RailwayTest
{
    partial class Login
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
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(383, 211);
            Username.Name = "Username";
            Username.Size = new Size(162, 23);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(383, 240);
            Password.Name = "Password";
            Password.Size = new Size(162, 23);
            Password.TabIndex = 1;
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 214);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 243);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(391, 279);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 26);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 551);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button LoginButton;
    }
}
