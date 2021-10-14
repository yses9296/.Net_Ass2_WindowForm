using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            bool isExist = checkUser(NameInput.Text);
            if (isExist == true)
            {
                if (!String.IsNullOrEmpty(value1) && !String.IsNullOrEmpty(value2) && !String.IsNullOrEmpty(value3) && !String.IsNullOrEmpty(value4) && !String.IsNullOrEmpty(value5) && !String.IsNullOrEmpty(value6))
                {
                    if (PWInput.Text == RePWInput.Text)
                    {
                        string newUser = string.Join(",", values);
                        using (StreamWriter sw = File.AppendText("login.txt"))
                        {
                            sw.WriteLine(newUser);
                            sw.Close();
                        }

                        if (MessageBox.Show("Is the Information correct?", "Check User Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Create New User Succeed!", "Success", MessageBoxButtons.OK);
                            this.Hide();

                            Login login = new Login();
                            login.Show();
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
                    string isUserName = splits[0];
                    string name = Convert.ToString(isUserName);
                    if (username.CompareTo(name) == 0)
                    {
                        sr.Close();
                        return false;
                    }
                    else
                    {
                        sr.Close();
                        return true;
                    }
                }
            }
            sr.Close();
            return true;
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void UserTypeInput_SelectedIndexChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
