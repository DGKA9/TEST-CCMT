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
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnSumbit
            // 
            btnSumbit.Location = new Point(207, 197);
            btnSumbit.Margin = new Padding(2, 2, 2, 2);
            btnSumbit.Name = "btnSumbit";
            btnSumbit.Size = new Size(60, 31);
            btnSumbit.TabIndex = 0;
            btnSumbit.Text = "Login";
            btnSumbit.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(207, 92);
            txtUserName.Margin = new Padding(2, 2, 2, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(203, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(117, 92);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(82, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "User Name";
            lblUserName.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 149);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(207, 149);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(316, 197);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            Controls.Add(btnSumbit);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btnClose;
    }
}