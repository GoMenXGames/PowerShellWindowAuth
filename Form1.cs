using System;
using System.ComponentModel;
using System.Security;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace PowerShellWindowAuth
{
    
    public partial class FormAuth : Form
    {
        PowerShell ps = PowerShell.Create();
        Collection<PSObject> psDomain;

        public void ErrorMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            psDomain = ps.AddScript("get-addomain").Invoke();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TitlePassword_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string User = UserTextBox.Text;
            string Pass = PasswordTextbox.Text;
            try
            {
                Console.WriteLine(User + ", " + Pass);
                SecureString theSecureString = new NetworkCredential("", Pass).SecurePassword;
                if (!String.IsNullOrEmpty(User) || !String.IsNullOrEmpty(Pass)) { 
                    var app = Process.Start(@"PowerShellAutomation.exe", "", User, theSecureString, psDomain[0].Properties["Name"].Value.ToString()); 
                    Application.Exit();
                }
                
            }
            catch (Win32Exception)
            {
                ErrorMessage("Ошибка: Неверный логин или пароль \n Иначе другая ошибка");
            }
            catch
            {
                ErrorMessage("Ошибка: Неизветная ошибка.");
            }
            if (String.IsNullOrEmpty(User) || String.IsNullOrEmpty(Pass)) 
            {
                ErrorMessage("Ошибка: Заполните поля!");
            }
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

