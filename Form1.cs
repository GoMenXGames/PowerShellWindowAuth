using System;
using System.ComponentModel;
using System.Security;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Globalization;

namespace PowerShellWindowAuth
{
    
    public partial class FormAuth : Form
    {
        PowerShell ps = PowerShell.Create();
        Collection<PSObject> psDomain;
        Collection<PSObject> psScript;
        string domain;
        string lang;

        public void ErrorMessage(string message)
        {
            if (lang == "ru")
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        public FormAuth()
        {
            InitializeComponent();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
            button2_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TitleUser.Text != "Username")
            {
                lang = "ru";
            }
            else {
                lang = "en";
            }
            psDomain = ps.AddScript("get-addomain").Invoke();
            domain = psDomain[0].Properties["Name"].Value.ToString();
            ps.Commands.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TitlePassword_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string User = UserTextBox.Text; //Переносим данные из полей ввода в переменные
            string Pass = PasswordTextbox.Text;
            try
            {
                ps.AddScript("$UserName = \"" + domain + "\\" + User + "\""); //Переносим данные выше в Powershell
                ps.AddScript("$PlainPassword = \""+Pass+"\"");
                ps.AddScript("$SecurePassword = $PlainPassword | ConvertTo-SecureString -AsPlainText -Force"); //Преобразуем пароль в защишённые данные
                ps.AddScript("$Credentials = New-Object System.Management.Automation.PSCredential ` -ArgumentList $UserName, $SecurePassword").Invoke(); 
                //Создаём "объект" учётные данные с данными выше           
                string path = Environment.CurrentDirectory + "\\ADUserAndGroupManager.exe"; //Берём путь программы
                ps.AddScript("Start-Process -FilePath \"" + path + "\" -ArgumentList \"" + User + "\", \"" + lang + "\" -Credential $Credentials");
                //Запускаем процесс программы с данными Путь, Логин, Данные уч записи.
                if (!String.IsNullOrEmpty(User) && !String.IsNullOrEmpty(Pass))
                { //Проверка заполнености полей

                    psScript = ps.Invoke(); // Запуск всего скрипта ps 
                    
                    if (ps.HadErrors)
                    { //Проверяем его на ошибки 
                        int errorTrueDisplays = 0;
                        for (int i = 0; i < ps.Streams.Error.Count; i++)
                        {
                            string error = ps.Streams.Error[i].Exception.Message.ToString();
                            //MessageBox.Show(error + ", \n" + path, "Ошибка Powershell [" + i + "]", MessageBoxButtons.OK);
                            if (error == "Не удается выполнить команду из-за следующей ошибки: Неверно задано имя папки.")
                            {
                                if (lang == "ru")
                                {
                                    MessageBox.Show("Переустановите программу в другой папке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Reinstall the program in a different folder. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                errorTrueDisplays++;
                            }
                            else
                            if (error == "This command cannot be executed due to the error: The directory name is invalid.")
                            {
                                if (lang == "ru")
                                {
                                    MessageBox.Show("Переустановите программу в другой папке.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Reinstall the program in a different folder. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                errorTrueDisplays++;
                            }
                            else
                            if (error == "Не удается выполнить команду из-за следующей ошибки: Неверное имя пользователя или пароль.")
                            {
                                if (lang == "ru")
                                {
                                    ErrorMessage("Ошибка: Неверный логин или пароль.");
                                }
                                else
                                {
                                    ErrorMessage("Error: Invalid username or password.");
                                }
                                errorTrueDisplays++;
                            }
                            else
                            if (error == "This command cannot be run due to the error: Logon failure: unknown user name or bad password.")
                            {
                                if (lang == "ru")
                                {
                                    ErrorMessage("Ошибка: Неверный логин или пароль.");
                                }
                                else
                                {
                                    ErrorMessage("Error: Invalid username or password.");
                                }
                                errorTrueDisplays++;
                            }
                        }
                        if (errorTrueDisplays == 0)
                        {
                            if (lang == "ru")
                            {
                                ErrorMessage("Попробуйте переустановить данную программу, в соответствии с инструкцией.");
                            }
                            else
                            {
                                ErrorMessage("Try reinstalling the program according to the instructions.");
                            }
                        }
                        ps.Streams.Error.Clear();
                        ps.Commands.Clear();
                    }
                    else
                    {
                        ps.Streams.Error.Clear();
                        ps.Commands.Clear();
                        Application.Exit(); //Закрываем программу для авторизации 
                    }
                }

            }
            catch 
            {
                if (lang == "ru")
                {
                    ErrorMessage("Ошибка: Неизветная ошибка.");
                }
                else
                {
                    ErrorMessage("Error: Unknown error.");
                }
                
            }
            if (String.IsNullOrEmpty(User) || String.IsNullOrEmpty(Pass)) 
            {
                if (lang == "ru")
                {
                    ErrorMessage("Ошибка: Заполните поля!");
                }
                else
                {
                    ErrorMessage("Error: Fill in the fields!");
                }
                
            }
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelLang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelLang.Text == "ru")
            {


                linkLabelLang.Text = "en";
            }
            else
            {
                linkLabelLang.Text = "ru";

            }
            lang = linkLabelLang.Text;
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAuth));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                if (c.Name == "$this.Text")
                {
                    resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                }
            }
            if (lang == "ru")
            {
                this.Text = "Авторизация";
            }
            else
            {
                this.Text = "Authorization";
            }
        }
    }
}

