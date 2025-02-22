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
            CreateCustomerButton.Location = new Point(168, 86);
            CreateCustomerButton.Name = "CreateCustomerButton";
            CreateCustomerButton.Size = new Size(145, 31);
            CreateCustomerButton.TabIndex = 1;
            CreateCustomerButton.Text = "Create Customer";
            CreateCustomerButton.UseVisualStyleBackColor = true;
            CreateCustomerButton.Click += CreateCustomerButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(492, 168);
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
    }
}