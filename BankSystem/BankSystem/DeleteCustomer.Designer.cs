namespace BankSystem
{
    partial class DeleteCustomer
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
            DeleteButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(547, 21);
            label1.TabIndex = 0;
            label1.Text = "Please enter which Customer to delete, by entering their CPR NumbeR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 30);
            label2.TabIndex = 1;
            label2.Text = "Delete Customer";
            // 
            // CPRNumber
            // 
            CPRNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPRNumber.Location = new Point(226, 103);
            CPRNumber.Name = "CPRNumber";
            CPRNumber.Size = new Size(105, 29);
            CPRNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(226, 79);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 3;
            label3.Text = "CPR Number:";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(226, 138);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(105, 33);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Enter";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(12, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(573, 183);
            Controls.Add(ExitButton);
            Controls.Add(DeleteButton);
            Controls.Add(label3);
            Controls.Add(CPRNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CPRNumber;
        private Label label3;
        private Button DeleteButton;
        private Button ExitButton;
    }
}