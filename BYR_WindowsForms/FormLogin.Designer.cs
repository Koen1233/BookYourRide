namespace BYR_WindowsForms
{
    partial class FormLogin
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
            buttonLogin = new Button();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            linkLabelCreateAccount = new LinkLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(193, 129);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 29);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(134, 66);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email: ";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(114, 99);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(193, 63);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(182, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(193, 96);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(182, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(193, 184);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(110, 20);
            linkLabelCreateAccount.TabIndex = 7;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Create Account";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(193, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Employee?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 272);
            Controls.Add(checkBox1);
            Controls.Add(linkLabelCreateAccount);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(buttonLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelCreateAccount;
        private CheckBox checkBox1;
    }
}
