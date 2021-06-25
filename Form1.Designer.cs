
namespace PowerShellWindowAuth
{
    partial class FormAuth
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
            this.TitleUser = new System.Windows.Forms.Label();
            this.TitlePassword = new System.Windows.Forms.Label();
            this.ButtonAuth = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleUser
            // 
            this.TitleUser.AutoSize = true;
            this.TitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleUser.Location = new System.Drawing.Point(12, 9);
            this.TitleUser.Name = "TitleUser";
            this.TitleUser.Size = new System.Drawing.Size(197, 25);
            this.TitleUser.TabIndex = 0;
            this.TitleUser.Text = "Имя пользователя";
            this.TitleUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // TitlePassword
            // 
            this.TitlePassword.AutoSize = true;
            this.TitlePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitlePassword.Location = new System.Drawing.Point(12, 80);
            this.TitlePassword.Name = "TitlePassword";
            this.TitlePassword.Size = new System.Drawing.Size(86, 25);
            this.TitlePassword.TabIndex = 2;
            this.TitlePassword.Text = "Пароль";
            this.TitlePassword.Click += new System.EventHandler(this.TitlePassword_Click);
            // 
            // ButtonAuth
            // 
            this.ButtonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.ButtonAuth.Location = new System.Drawing.Point(74, 154);
            this.ButtonAuth.Name = "ButtonAuth";
            this.ButtonAuth.Size = new System.Drawing.Size(135, 47);
            this.ButtonAuth.TabIndex = 6;
            this.ButtonAuth.Text = "Войти";
            this.ButtonAuth.UseVisualStyleBackColor = true;
            this.ButtonAuth.Click += new System.EventHandler(this.button2_Click);
            this.ButtonAuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.PasswordTextbox.Location = new System.Drawing.Point(12, 108);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(257, 40);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            this.PasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.UserTextBox.Location = new System.Drawing.Point(12, 37);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(257, 40);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // FormAuth
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.ButtonAuth);
            this.Controls.Add(this.TitlePassword);
            this.Controls.Add(this.TitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleUser;
        private System.Windows.Forms.Label TitlePassword;
        private System.Windows.Forms.Button ButtonAuth;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UserTextBox;
    }
}

