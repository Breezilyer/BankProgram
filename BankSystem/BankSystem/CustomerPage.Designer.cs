namespace BankSystem
{
    partial class CustomerPage
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
            WelcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            Balance = new Label();
            WithdrawButton = new Button();
            DepositButton = new Button();
            WithdrawBox = new TextBox();
            DepositBox = new TextBox();
            ExitButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = SystemColors.ButtonFace;
            WelcomeLabel.Location = new Point(12, 51);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(72, 30);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 41);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.BackColor = Color.White;
            Balance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Balance.ForeColor = Color.LimeGreen;
            Balance.Location = new Point(15, 132);
            Balance.Name = "Balance";
            Balance.Size = new Size(34, 25);
            Balance.TabIndex = 3;
            Balance.Text = "0$";
            // 
            // WithdrawButton
            // 
            WithdrawButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WithdrawButton.Location = new Point(12, 193);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(94, 30);
            WithdrawButton.TabIndex = 4;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // DepositButton
            // 
            DepositButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepositButton.Location = new Point(112, 193);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(94, 30);
            DepositButton.TabIndex = 5;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawBox
            // 
            WithdrawBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithdrawBox.Location = new Point(12, 229);
            WithdrawBox.Name = "WithdrawBox";
            WithdrawBox.Size = new Size(94, 29);
            WithdrawBox.TabIndex = 6;
            // 
            // DepositBox
            // 
            DepositBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositBox.Location = new Point(112, 229);
            DepositBox.Name = "DepositBox";
            DepositBox.Size = new Size(94, 29);
            DepositBox.TabIndex = 7;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(8, 13);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 22;
            label1.Text = "Balance:";
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(223, 270);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(DepositBox);
            Controls.Add(WithdrawBox);
            Controls.Add(DepositButton);
            Controls.Add(WithdrawButton);
            Controls.Add(Balance);
            Controls.Add(pictureBox1);
            Controls.Add(WelcomeLabel);
            Name = "CustomerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private PictureBox pictureBox1;
        private Label Balance;
        private Button WithdrawButton;
        private Button DepositButton;
        private TextBox WithdrawBox;
        private TextBox DepositBox;
        private Button ExitButton;
        private Label label1;
    }
}