namespace BankSystem
{
    partial class AddCustomerPage
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
            cUsername = new TextBox();
            cPin = new TextBox();
            cPhoneNumber = new TextBox();
            cCPRNumber = new TextBox();
            cEmail = new TextBox();
            cCardNumber = new TextBox();
            cBalance = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CreateCustomerButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // cUsername
            // 
            cUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cUsername.Location = new Point(63, 44);
            cUsername.Name = "cUsername";
            cUsername.Size = new Size(100, 29);
            cUsername.TabIndex = 0;
            // 
            // cPin
            // 
            cPin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cPin.Location = new Point(63, 100);
            cPin.Name = "cPin";
            cPin.Size = new Size(100, 29);
            cPin.TabIndex = 1;
            // 
            // cPhoneNumber
            // 
            cPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cPhoneNumber.Location = new Point(63, 156);
            cPhoneNumber.Name = "cPhoneNumber";
            cPhoneNumber.Size = new Size(100, 29);
            cPhoneNumber.TabIndex = 2;
            // 
            // cCPRNumber
            // 
            cCPRNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cCPRNumber.Location = new Point(63, 212);
            cCPRNumber.Name = "cCPRNumber";
            cCPRNumber.Size = new Size(100, 29);
            cCPRNumber.TabIndex = 3;
            // 
            // cEmail
            // 
            cEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cEmail.Location = new Point(63, 268);
            cEmail.Name = "cEmail";
            cEmail.Size = new Size(100, 29);
            cEmail.TabIndex = 4;
            // 
            // cCardNumber
            // 
            cCardNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cCardNumber.Location = new Point(63, 324);
            cCardNumber.Name = "cCardNumber";
            cCardNumber.Size = new Size(100, 29);
            cCardNumber.TabIndex = 5;
            // 
            // cBalance
            // 
            cBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cBalance.Location = new Point(63, 380);
            cBalance.Name = "cBalance";
            cBalance.Size = new Size(100, 29);
            cBalance.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(63, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 8;
            label2.Text = "Pin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(46, 132);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 9;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(51, 188);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 10;
            label4.Text = "CPR Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(63, 244);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 11;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(51, 300);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 12;
            label6.Text = "Card Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(63, 356);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 13;
            label7.Text = "Balance:";
            // 
            // CreateCustomerButton
            // 
            CreateCustomerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateCustomerButton.Location = new Point(28, 426);
            CreateCustomerButton.Name = "CreateCustomerButton";
            CreateCustomerButton.Size = new Size(169, 46);
            CreateCustomerButton.TabIndex = 14;
            CreateCustomerButton.Text = "Create Customer";
            CreateCustomerButton.UseVisualStyleBackColor = true;
            CreateCustomerButton.Click += CreateCustomerButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(12, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AddCustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(226, 497);
            Controls.Add(ExitButton);
            Controls.Add(CreateCustomerButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cBalance);
            Controls.Add(cCardNumber);
            Controls.Add(cEmail);
            Controls.Add(cCPRNumber);
            Controls.Add(cPhoneNumber);
            Controls.Add(cPin);
            Controls.Add(cUsername);
            Name = "AddCustomerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cUsername;
        private TextBox cPin;
        private TextBox cPhoneNumber;
        private TextBox cCPRNumber;
        private TextBox cEmail;
        private TextBox cCardNumber;
        private TextBox cBalance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button CreateCustomerButton;
        private Button ExitButton;
    }
}