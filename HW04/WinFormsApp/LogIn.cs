using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context;

namespace WinFormsApp
{
    public partial class LogIn : Form
    {
        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public LogIn()
        {
            InitializeComponent();
        }

        private bool CheckLogin(string login)
        {
            using (var context = new EmployeeDbContext())
            {
                return context.Users.Any(u => u.Login == login);
            }
        }

        private bool AuthUser(string login, string password)
        {
            using (var context = new EmployeeDbContext())
            {
                return context.Users.Any(u => u.Login == login && u.Password == password);
            }
        }

        private bool ValidateInputs(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowError("Fields cannot be empty");
                return false;
            }
            return true;
        }
        private void AddUser(string login, string password)
        {
            using (var context = new EmployeeDbContext())
            {
                var newUser = new Model.User { Login = login, Password = password };
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (!ValidateInputs(login, password))
            {
                return;
            }

            if (!CheckLogin(login))
            {
                DialogResult res = MessageBox.Show("User doesn't exist. Would you like to create a new account?", "Information", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    AddUser(login, password);
                    ShowInfo("Account successfully created");
                }
            }
            else if (!AuthUser(login, password))
            {
                ShowError("Incorrect password");
            }
            else
            {
                ShowInfo("Login successful");
                Hide();

                Manager form = new Manager();
                form.Show();
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (!ValidateInputs(login, password))
            {
                return;
            }
            if (CheckLogin(login))
            {
                ShowError("This login is already in use");
            }
            else
            {
                AddUser(login, password);
                ShowInfo("Account successfully created");
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
