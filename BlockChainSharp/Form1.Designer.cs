namespace BlockChainSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mineButton = new System.Windows.Forms.Button();
            this.mainingLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mineButton
            // 
            this.mineButton.Location = new System.Drawing.Point(6, 103);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(65, 23);
            this.mineButton.TabIndex = 0;
            this.mineButton.Text = "Mine";
            this.mineButton.UseVisualStyleBackColor = true;
            this.mineButton.Click += new System.EventHandler(this.MineButton_Click);
            // 
            // mainingLabel
            // 
            this.mainingLabel.AutoSize = true;
            this.mainingLabel.Location = new System.Drawing.Point(3, 87);
            this.mainingLabel.Name = "mainingLabel";
            this.mainingLabel.Size = new System.Drawing.Size(71, 13);
            this.mainingLabel.TabIndex = 1;
            this.mainingLabel.Text = "Mining Status";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(3, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(62, 6);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(62, 35);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(3, 38);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(179, 4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(179, 33);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 284);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.mainingLabel);
            this.Controls.Add(this.mineButton);
            this.Name = "Form1";
            this.Text = "Mine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button mineButton;
        private System.Windows.Forms.Label mainingLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button signUpButton;
    }
}

