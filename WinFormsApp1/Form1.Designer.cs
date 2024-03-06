namespace WinFormsApp1
{
    partial class Form1
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
            btnSumbit = new Button();
            txtUserName = new TextBox();
            lblUserName = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(405, 254);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(75, 39);
            btnSumbit.TabIndex = 0;
            btnSumbit.Text = "Login";
            btnSumbit.UseVisualStyleBackColor = true;
            btnSumbit.Click += btnSumbit_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(259, 115);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(253, 31);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(146, 115);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "User Name";
            lblUserName.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 186);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(259, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 31);
            txtPassword.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(btnSumbit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumbit;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label label1;
        private TextBox txtPassword;
    }
}