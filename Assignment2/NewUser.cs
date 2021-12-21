using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string[] values = new string[6];
            values[0] = Convert.ToString(NameInput.Text);
            values[1] = Convert.ToString(PWInput.Text);
            values[2] = Convert.ToString(UserTypeInput.Text);
            values[3] = Convert.ToString(FirstNameInput.Text);
            values[4] = Convert.ToString(LastNameInput.Text);
            values[5] = Convert.ToString(BirthDateInput.Text);

            string value1 = values[0].ToString();
            string value2 = values[1].ToString();
            string value3 = values[2].ToString();
            string value4 = values[3].ToString();
            string value5 = values[4].ToString();
            string value6 = values[5].ToString();

            bool isUserExist = checkUser(NameInput.Text);

            //UserName is available
            if (isUserExist == true) 
            {
                //All required fields are filled out.
                if (!String.IsNullOrEmpty(value1) && !String.IsNullOrEmpty(value2) && !String.IsNullOrEmpty(value3) && !String.IsNullOrEmpty(value4) && !String.IsNullOrEmpty(value5) && !String.IsNullOrEmpty(value6)) 
                {
                    //Password and re-password match
                    if (PWInput.Text == RePWInput.Text) 
                    {
                        DialogResult answer = MessageBox.Show("Is the Information correct?", "Check User Information", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            MessageBox.Show("Create New User Succeed!", "Success", MessageBoxButtons.OK);
                            
                            string newUser = string.Join(",", values); //Convert array to String to save new user
                            using (StreamWriter sw = File.AppendText("login.txt"))
                            {
                                sw.WriteLine(newUser); //Append new user info into login.txt
                                sw.Close(); //Close StreamWriter
                            }

                            this.Hide(); //Close New User Form

                            Login login = new Login();
                            login.Show();//Open the Login Form
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match, Please check your password!", "Error - Password Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Required fields must be filled in.", "Error - Missing Required field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User Name already exists!", "Error - Invalid User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkUser(string username)
        {
            StreamReader sr = new StreamReader("login.txt");
            sr.BaseStream.Position = 0;
            while (!sr.EndOfStream)
            {
                string key = sr.ReadLine();
                bool checkId = key.Contains(username);

                if (checkId == true) 
                {
                    string[] splits = key.Split(',');
                    string name = Convert.ToString(splits[0]);
                    if (username.CompareTo(name) == 0) //UserName already Exist, username is invalid
                    {
                        sr.Close(); //Close StreamReader
                        return false;
                    }
                    else //New user's UserName is vaild
                    {
                        sr.Close(); //Close StreamReader
                        return true;
                    }
                }
            }
            sr.Close();
            return true;
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Close New User Form

            Login login = new Login();
            login.Show(); //Open the Login Form
        }

        private void UserTypeInput_SelectedIndexChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //User cannot write in comboBox, only can select
        }
    }
}
