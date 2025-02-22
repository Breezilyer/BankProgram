namespace BankSystem
{
    partial class LoginPage
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
            LoginUsername = new TextBox();
            LoginPIN = new TextBox();
            Username = new Label();
            PINCode = new Label();
            label1 = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginUsername
            // 
            LoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUsername.Location = new Point(70, 139);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(169, 29);
            LoginUsername.TabIndex = 0;
            // 
            // LoginPIN
            // 
            LoginPIN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginPIN.Location = new Point(127, 207);
            LoginPIN.Name = "LoginPIN";
            LoginPIN.Size = new Size(47, 29);
            LoginPIN.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = SystemColors.ButtonFace;
            Username.Location = new Point(108, 115);
            Username.Name = "Username";
            Username.Size = new Size(91, 21);
            Username.TabIndex = 2;
            Username.Text = "Username:";
            // 
            // PINCode
            // 
            PINCode.AutoSize = true;
            PINCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PINCode.ForeColor = SystemColors.ButtonFace;
            PINCode.Location = new Point(127, 183);
            PINCode.Name = "PINCode";
            PINCode.Size = new Size(42, 21);
            PINCode.TabIndex = 3;
            PINCode.Text = "PIN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(70, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 4;
            label1.Text = "Bank Of Denmark";
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ControlText;
            LoginButton.Location = new Point(95, 275);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(118, 39);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(323, 326);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Controls.Add(PINCode);
            Controls.Add(Username);
            Controls.Add(LoginPIN);
            Controls.Add(LoginUsername);
            Name = "Form1";
            Text = "Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginUsername;
        private TextBox LoginPIN;
        private Label Username;
        private Label PINCode;
        private Label label1;
        private Button LoginButton;
    }
}
