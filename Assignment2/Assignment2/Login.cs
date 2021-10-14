using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login : Form
    {
        public static string userName;
        StreamReader sr = new StreamReader("login.txt");
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                bool check = checkUser(nameTextbox.Text, passwordTextBox.Text);

                if (check == true)
                {
                    Login.userName = nameTextbox.Text;

                    sr.Close();

                    this.Hide();
                    TextEditor main = new TextEditor();
                    TextEditor.userName = nameTextbox.Text;

                    main.Show();
                }
                else
                {
                    MessageBox.Show("Login Fail, Please check your name and password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool checkUser<T>(T Uname, T Upassword)
        {
            sr.BaseStream.Position = 0;
            while (!sr.EndOfStream)
            {
                string key = sr.ReadLine();
                bool checkId = key.Contains(nameTextbox.Text);

                if (checkId == true)
                {
                    LinkedList<string> userValue = new LinkedList<string>();
                    string[] splits = key.Split(','); // Convert to List or else...

                    string isUserName = splits[0];
                    string isUserPassword = splits[1];

                    string name = Convert.ToString(isUserName);
                    string password = Convert.ToString(isUserPassword);

                    return Uname.Equals(name) && Upassword.Equals(password);
                }
            }
            return false;
        }

        private bool EmptyCheck()
        {
            if (String.IsNullOrEmpty(nameTextbox.Text))
            {
                MessageBox.Show("Please check your name", "Login Error");
                nameTextbox.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Please check your password", "Login Error");
                passwordTextBox.Focus();
                return false;
            }
            return true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            sr.Close();
            this.Hide();
            NewUser create = new NewUser();
            create.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            sr.Close();
            Application.Exit();
        }
    }
}
