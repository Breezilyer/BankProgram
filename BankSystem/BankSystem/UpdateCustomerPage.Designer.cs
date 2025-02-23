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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(179, 9);
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
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(623, 21);
            label2.TabIndex = 1;
            label2.Text = "Please insert which Customer you want to update, by entering their CPR Number";
            // 
            // CPRNumber
            // 
            CPRNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPRNumber.Location = new Point(271, 99);
            CPRNumber.Name = "CPRNumber";
            CPRNumber.Size = new Size(103, 25);
            CPRNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(265, 75);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 3;
            label3.Text = "CPR number:";
            // 
            // Enter
            // 
            Enter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enter.Location = new Point(271, 130);
            Enter.Name = "Enter";
            Enter.Size = new Size(103, 32);
            Enter.TabIndex = 4;
            Enter.Text = "Enter";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // UpdateCustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(641, 170);
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
    }
}