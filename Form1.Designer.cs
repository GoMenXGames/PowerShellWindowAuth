
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.TitleUser = new System.Windows.Forms.Label();
            this.TitlePassword = new System.Windows.Forms.Label();
            this.ButtonAuth = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.linkLabelLang = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleUser
            // 
            resources.ApplyResources(this.TitleUser, "TitleUser");
            this.TitleUser.Name = "TitleUser";
            this.TitleUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // TitlePassword
            // 
            resources.ApplyResources(this.TitlePassword, "TitlePassword");
            this.TitlePassword.Name = "TitlePassword";
            this.TitlePassword.Click += new System.EventHandler(this.TitlePassword_Click);
            // 
            // ButtonAuth
            // 
            resources.ApplyResources(this.ButtonAuth, "ButtonAuth");
            this.ButtonAuth.Name = "ButtonAuth";
            this.ButtonAuth.UseVisualStyleBackColor = true;
            this.ButtonAuth.Click += new System.EventHandler(this.button2_Click);
            this.ButtonAuth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // PasswordTextbox
            // 
            resources.ApplyResources(this.PasswordTextbox, "PasswordTextbox");
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.UseSystemPasswordChar = true;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            this.PasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // UserTextBox
            // 
            resources.ApplyResources(this.UserTextBox, "UserTextBox");
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // linkLabelLang
            // 
            resources.ApplyResources(this.linkLabelLang, "linkLabelLang");
            this.linkLabelLang.Name = "linkLabelLang";
            this.linkLabelLang.TabStop = true;
            this.linkLabelLang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLang_LinkClicked);
            // 
            // FormAuth
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.linkLabelLang);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.ButtonAuth);
            this.Controls.Add(this.TitlePassword);
            this.Controls.Add(this.TitleUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAuth";
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
        private System.Windows.Forms.LinkLabel linkLabelLang;
    }
}

