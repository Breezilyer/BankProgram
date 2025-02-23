namespace BankSystem
{
    partial class AdminPanel
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
            CreateCustomerButton = new Button();
            ExitButton = new Button();
            ReadCustomerButton = new Button();
            DeleteCustomerButton = new Button();
            UpdateCustomerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // CreateCustomerButton
            // 
            CreateCustomerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateCustomerButton.ForeColor = SystemColors.ControlText;
            CreateCustomerButton.Location = new Point(77, 63);
            CreateCustomerButton.Name = "CreateCustomerButton";
            CreateCustomerButton.Size = new Size(145, 31);
            CreateCustomerButton.TabIndex = 1;
            CreateCustomerButton.Text = "Create Customer";
            CreateCustomerButton.UseVisualStyleBackColor = true;
            CreateCustomerButton.Click += CreateCustomerButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(12, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(41, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReadCustomerButton
            // 
            ReadCustomerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadCustomerButton.ForeColor = SystemColors.ControlText;
            ReadCustomerButton.Location = new Point(77, 100);
            ReadCustomerButton.Name = "ReadCustomerButton";
            ReadCustomerButton.Size = new Size(145, 31);
            ReadCustomerButton.TabIndex = 3;
            ReadCustomerButton.Text = "Read Customers";
            ReadCustomerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCustomerButton.ForeColor = SystemColors.ControlText;
            DeleteCustomerButton.Location = new Point(264, 100);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(145, 31);
            DeleteCustomerButton.TabIndex = 4;
            DeleteCustomerButton.Text = "Delete Customer";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomerButton
            // 
            UpdateCustomerButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateCustomerButton.ForeColor = SystemColors.ControlText;
            UpdateCustomerButton.Location = new Point(264, 63);
            UpdateCustomerButton.Name = "UpdateCustomerButton";
            UpdateCustomerButton.Size = new Size(145, 31);
            UpdateCustomerButton.TabIndex = 5;
            UpdateCustomerButton.Text = "Update Customer";
            UpdateCustomerButton.UseVisualStyleBackColor = true;
            UpdateCustomerButton.Click += UpdateCustomerButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(492, 168);
            Controls.Add(UpdateCustomerButton);
            Controls.Add(DeleteCustomerButton);
            Controls.Add(ReadCustomerButton);
            Controls.Add(ExitButton);
            Controls.Add(CreateCustomerButton);
            Controls.Add(label1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateCustomerButton;
        private Button ExitButton;
        private Button ReadCustomerButton;
        private Button DeleteCustomerButton;
        private Button UpdateCustomerButton;
    }
}