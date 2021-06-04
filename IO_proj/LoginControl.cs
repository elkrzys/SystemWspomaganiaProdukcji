using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ProductionManagementSystem.Security;
using ProductionManagementSystem.DataAccess;
using IO_proj;

namespace ProductionManagementSystem
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        //januszex:papaj2137 -> test creds

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            CredentialManager manager = new CredentialManager();

            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            int userId;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                DisplayErrorMessage("Wpisz login i hasło");
                return;
            }

            StatusCode resultCode = manager.Login(login, password, out userId);

            switch (resultCode)
            {
                case StatusCode.WrongCredentials:
                    DisplayErrorMessage("Zły login i/lub hasło.");
                    break;
                case StatusCode.UnkonownError:
                    DisplayErrorMessage("Nieznany błąd.");
                    break;
                case StatusCode.Ok:
                    MainForm main = new MainForm(DBManager.Instance.GetUserById(userId));
                    main.Show();
                    TableLayoutPanel tlp = Parent as TableLayoutPanel;
                    LoginForm form = tlp.Parent as LoginForm;
                    form.Hide();
                    break;
                    
            }
        }
        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
