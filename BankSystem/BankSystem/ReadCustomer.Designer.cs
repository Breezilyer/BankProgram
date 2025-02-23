namespace BankSystem
{
    partial class ReadCustomer
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
            EnterButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 0;
            label1.Text = "Get Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(530, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter the CPR Number of which Customer you want to get data from";
            // 
            // CPRNumber
            // 
            CPRNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPRNumber.Location = new Point(212, 86);
            CPRNumber.Name = "CPRNumber";
            CPRNumber.Size = new Size(106, 29);
            CPRNumber.TabIndex = 2;
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterButton.Location = new Point(212, 121);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(106, 29);
            EnterButton.TabIndex = 3;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(12, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReadCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(550, 163);
            Controls.Add(ExitButton);
            Controls.Add(EnterButton);
            Controls.Add(CPRNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReadCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReadCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CPRNumber;
        private Button EnterButton;
        private Button ExitButton;
    }
}