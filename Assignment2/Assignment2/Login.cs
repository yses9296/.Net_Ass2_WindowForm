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
        public static List<string> userList;

        StreamReader sr = new StreamReader("login.txt");

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            missingLabel.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (EmptyCheck())
            {
                missingLabel.Text = "";

                //Load all users into List structure
                List<string> uList = new List<string>();
                string[] readText = File.ReadAllLines("login.txt"); //Read all Lines from login.txt to array
                uList = readText.ToList(); //Convert array to List

                //Check the userName whether exist in login.txt
                bool check = checkUser(nameTextbox.Text, passwordTextBox.Text);

                if (check == true)
                {
                    //Set the variable to send
                    Login.userName = nameTextbox.Text;
                    Login.userList = uList;

                    sr.Close(); //Close the StreamReader

                    this.Hide(); //Close this Login form
                    TextEditor main = new TextEditor(); 

                    //Transfer user values to TextEditor form
                    TextEditor.userName = nameTextbox.Text;
                    TextEditor.userList = uList;

                    main.Show(); //Open the TextEditor Form
                }
                else
                {
                    //If userValue is not founded (Invalidation)
                    MessageBox.Show("Login Fail, Please check your name and password", "Login Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool checkUser<T>(T Uname, T Upassword)
        {
            //Initialize the position
            sr.BaseStream.Position = 0;
            while (!sr.EndOfStream)
            {
                //Read one line at a time and find the line which contains the userName
                string key = sr.ReadLine();
                bool checkId = key.Contains(nameTextbox.Text);

                if (checkId == true)
                {
                    //Split the line with ',' and get user Info values
                    string[] splits = key.Split(',');

                    string name = Convert.ToString(splits[0]);
                    string password = Convert.ToString(splits[1]);

                    return Uname.Equals(name) && Upassword.Equals(password);
                }
            }
            return false;
        }

        private bool EmptyCheck()
        {
            //If the user does not input anything in the field, the error message will be below the field with red color.
            if (String.IsNullOrEmpty(nameTextbox.Text) || String.IsNullOrEmpty(passwordTextBox.Text))
            {
                missingLabel.Text = "Please check your name and password";
                nameTextbox.Focus();
                return false;
            }
            return true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            sr.Close(); //Close the StreamReader

            this.Hide(); //Hide this login form

            NewUser create = new NewUser();
            create.Show(); //Open the NewUser form
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            sr.Close(); //Close the StreamReader
            Application.Exit(); //Application will be closed.
        }

        
    }
}
