namespace BYRWindowsForms
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
            buttonTryLogin = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // buttonTryLogin
            // 
            buttonTryLogin.Location = new Point(195, 191);
            buttonTryLogin.Name = "buttonTryLogin";
            buttonTryLogin.Size = new Size(94, 29);
            buttonTryLogin.TabIndex = 0;
            buttonTryLogin.Text = "Login";
            buttonTryLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(176, 76);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(176, 134);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(176, 53);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email:";
            labelEmail.Click += this.label1_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(176, 111);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 251);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonTryLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTryLogin;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label labelEmail;
        private Label labelPassword;
    }
}
