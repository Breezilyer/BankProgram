namespace BankSystem
{
    partial class UpdateCustomerPage
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
            label2 = new Label();
            CPRNumber = new TextBox();
            label3 = new Label();
            Enter = new Button();
            Username = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            PINCode = new TextBox();
            PhoneNumber = new TextBox();
            UpdateCPRNumber = new TextBox();
            Email = new TextBox();
            CardNumber = new TextBox();
            Balance = new TextBox();
            UsernameButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 30);
            label1.TabIndex = 0;
            label1.Text = "Update a specific Customer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(99, 39);
            label2.Name = "label2";
            label2.Size = new Size(623, 21);
            label2.TabIndex = 1;
            label2.Text = "Please insert which Customer you want to update, by entering their CPR Number";
            // 
            // CPRNumber
            // 
            CPRNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPRNumber.Location = new Point(375, 106);
            CPRNumber.Name = "CPRNumber";
            CPRNumber.Size = new Size(103, 25);
            CPRNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(375, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 3;
            label3.Text = "CPR Number:";
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enter.Location = new Point(375, 137);
            Enter.Name = "Enter";
            Enter.Size = new Size(103, 32);
            Enter.TabIndex = 4;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F);
            Username.Location = new Point(12, 210);
            Username.Name = "Username";
            Username.Size = new Size(91, 29);
            Username.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(118, 186);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 7;
            label5.Text = "PIN Code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(218, 186);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 8;
            label6.Text = "Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(366, 186);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 9;
            label7.Text = "CPR Number:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(493, 186);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 10;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(605, 186);
            label9.Name = "label9";
            label9.Size = new Size(117, 21);
            label9.TabIndex = 11;
            label9.Text = "Card Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(737, 186);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 12;
            label10.Text = "Balance:";
            // 
            // PINCode
            // 
            PINCode.Font = new Font("Segoe UI", 12F);
            PINCode.Location = new Point(118, 210);
            PINCode.Name = "PINCode";
            PINCode.Size = new Size(85, 29);
            PINCode.TabIndex = 13;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Font = new Font("Segoe UI", 12F);
            PhoneNumber.Location = new Point(218, 210);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(131, 29);
            PhoneNumber.TabIndex = 14;
            // 
            // UpdateCPRNumber
            // 
            UpdateCPRNumber.Font = new Font("Segoe UI", 12F);
            UpdateCPRNumber.Location = new Point(366, 210);
            UpdateCPRNumber.Name = "UpdateCPRNumber";
            UpdateCPRNumber.Size = new Size(112, 29);
            UpdateCPRNumber.TabIndex = 15;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(493, 210);
            Email.Name = "Email";
            Email.Size = new Size(100, 29);
            Email.TabIndex = 16;
            // 
            // CardNumber
            // 
            CardNumber.Font = new Font("Segoe UI", 12F);
            CardNumber.Location = new Point(605, 210);
            CardNumber.Name = "CardNumber";
            CardNumber.Size = new Size(117, 29);
            CardNumber.TabIndex = 17;
            // 
            // Balance
            // 
            Balance.Font = new Font("Segoe UI", 12F);
            Balance.Location = new Point(737, 210);
            Balance.Name = "Balance";
            Balance.Size = new Size(100, 29);
            Balance.TabIndex = 18;
            // 
            // UsernameButton
            // 
            UsernameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameButton.Location = new Point(375, 273);
            UsernameButton.Name = "UsernameButton";
            UsernameButton.Size = new Size(91, 29);
            UsernameButton.TabIndex = 19;
            UsernameButton.Text = "Enter";
            UsernameButton.UseVisualStyleBackColor = true;
            UsernameButton.Click += UsernameButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(12, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UpdateCustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(861, 350);
            Controls.Add(ExitButton);
            Controls.Add(UsernameButton);
            Controls.Add(Balance);
            Controls.Add(CardNumber);
            Controls.Add(Email);
            Controls.Add(UpdateCPRNumber);
            Controls.Add(PhoneNumber);
            Controls.Add(PINCode);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Username);
            Controls.Add(Enter);
            Controls.Add(label3);
            Controls.Add(CPRNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateCustomerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update a Customer on this Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CPRNumber;
        private Label label3;
        private Button Enter;
        private TextBox Username;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox PINCode;
        private TextBox PhoneNumber;
        private TextBox UpdateCPRNumber;
        private TextBox Email;
        private TextBox CardNumber;
        private TextBox Balance;
        private Button UsernameButton;
        private Button ExitButton;
    }
}