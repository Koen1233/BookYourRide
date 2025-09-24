namespace BYR_WindowsForms
{
    partial class FormRegistration
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
            textBoxFirstName = new TextBox();
            textBoxRepeatEmail = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRepeatPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonCreateAccount = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(111, 58);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(228, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxRepeatEmail
            // 
            textBoxRepeatEmail.Location = new Point(111, 226);
            textBoxRepeatEmail.Name = "textBoxRepeatEmail";
            textBoxRepeatEmail.Size = new Size(228, 27);
            textBoxRepeatEmail.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(111, 169);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(228, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(111, 115);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(228, 27);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(111, 279);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(228, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxRepeatPassword
            // 
            textBoxRepeatPassword.Location = new Point(111, 335);
            textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            textBoxRepeatPassword.PasswordChar = '*';
            textBoxRepeatPassword.Size = new Size(228, 27);
            textBoxRepeatPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 92);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 203);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Repeat Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 256);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 312);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 11;
            label6.Text = "Repeat Password";
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Location = new Point(145, 382);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(161, 29);
            buttonCreateAccount.TabIndex = 12;
            buttonCreateAccount.Text = "Create account";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 491);
            Controls.Add(buttonCreateAccount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRepeatPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxRepeatEmail);
            Controls.Add(textBoxFirstName);
            Name = "FormRegistration";
            Text = "FormRegistration";
            Load += FormRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxRepeatEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonCreateAccount;
    }
}