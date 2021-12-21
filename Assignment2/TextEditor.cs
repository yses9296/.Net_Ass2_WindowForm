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
    public partial class TextEditor : Form
    {
        //get userName and userList form login.cs
        static public string userName;
        static public string userType;
        public static List<string> userList;

        private string fileName;
        bool modify;
        bool UserTypeValid;
        string currentFile;

        //Font setting
        private int fontsize;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            //modify is to check whether it is already existed file or not.
            //if modify is 'true' then should create new file (Save as). else, can overwirte it (Save)
            modify = true;
            
            username.Text = "UserName: " + userName; //Show the name of the currently logged user

            //Check userType - View or Edit (Additional function to identify the userType easily)
            if (userType == "Edit")
            {
                richTextBox.ReadOnly = false;
                UserTypeValid = true;
                UserType.Text = "UserType: " + userType;
            }
            else if (userType == "View")
            {
                richTextBox.ReadOnly = true;
                UserTypeValid = false;
                UserType.Text = "UserType: " + userType;
            }
            else
            {
                MessageBox.Show("User Type is not founded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox.ReadOnly = true;
                UserType.Text = "UserType: none";
            }
        }

        //MenuStrip - File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Save();
            }
            else
            {
                MessageBox.Show("You cannot Save the file \nYour UserType is " + userType, "Acceess Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                SaveAs();
            }
            else
            {
                MessageBox.Show("You cannot Save As the file \nYour UserType is " + userType, "Acceess Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save all users back to “login.txt”, when a user logs out of the text editor
            using (StreamWriter sw = new StreamWriter("login.txt")) 
            {
                for(int i = 0; i < userList.Count; i++)
                {
                    sw.WriteLine(userList[i]); //Overwrite the userlist.
                }
                sw.Close(); // Close the StreamWriter
            }
            
            this.Close(); //Close the TextEditor form

            Login restart = new Login();
            restart.Show(); //Open the Login form
        }

        //MenuStrip - Edit
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Cut();
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Copy();
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Paste();
            }
        }

        //MenuStrip - Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about();
        }

        //toolStrip1.1 - New, Open, Save, SaveAS
        private void NewTool_Click(object sender, EventArgs e)
        {
            New();
        }
        private void OpenTool_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void SaveTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Save();
            }
            else
            {
                MessageBox.Show("You cannot Save the file \nYour UserType is "+userType, "Acceess Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }
        private void SaveAsTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                SaveAs();
            }
            else
            {
                MessageBox.Show("You cannot Save As the file \nYour UserType is " + userType, "Acceess Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //toolStrip1.2 - Font Style Editor
        private void BoldTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                //if selectionfont has different sizes and styles for each other then, it will be a null pointer.
                if (richTextBox.SelectionFont == null) return;

                //Set the font format to overlap. i.e. if the Bold and the Underline are applied together, 2 * 5 corresponds to case 10 and break.
                int number = 1;
                number = richTextBox.SelectionFont.Bold ? 1 : 2;
                number *= richTextBox.SelectionFont.Italic ? 3 : 1;
                number *= richTextBox.SelectionFont.Underline ? 4 : 1;

                switch (number)
                {
                    case 1:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular); break;
                    case 2:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold); break;
                    case 3:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic); break;
                    case 4:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline); break;
                    case 6:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;
                    case 8:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;
                    case 12:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;
                    case 24:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
                }
            }
        }
        private void ItalicTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                if (richTextBox.SelectionFont == null) return; //Null pointer

                //Duplicate font format, different format with Bold one, preventing the conflicts and confusion.
                int number = 1;
                number = richTextBox.SelectionFont.Italic ? 1 : 5;
                number *= richTextBox.SelectionFont.Underline ? 7 : 1;
                number *= richTextBox.SelectionFont.Bold ? 8 : 1;

                switch (number)
                {
                    case 1:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular); break;
                    case 5:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic); break;
                    case 7:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline); break;
                    case 8:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold); break;
                    case 35:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline | FontStyle.Italic); break;
                    case 40:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;
                    case 56:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;
                    case 280:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
                }
            }
        }
        private void UnderLineTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                if (richTextBox.SelectionFont == null) return; //Null pointer

                //Duplicate font format
                int number = 1;
                number = richTextBox.SelectionFont.Underline ? 1 : 9;
                number *= richTextBox.SelectionFont.Bold ? 11 : 1;
                number *= richTextBox.SelectionFont.Italic ? 12 : 1;

                switch (number)
                {
                    case 1:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular); break;
                    case 9:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline); break;
                    case 11:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold); break;
                    case 12:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic); break;
                    case 99:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;
                    case 108:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;
                    case 132:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | FontStyle.Bold); break;
                    case 1188:
                        richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
                }
            }
        }

        private void FontSizeTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                if (richTextBox.SelectionFont == null) return; //Null pointer

                //new font size value in combobox convert into int type
                Font currentFont = richTextBox.SelectionFont;
                fontsize = int.Parse(FontSizeTool.SelectedItem.ToString());

                //Set new Font size maintaining the Font Style
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, fontsize, currentFont.Style);
            }
        }
        private void AboutTool_Click(object sender, EventArgs e)
        {
            about();
        }

        //toolStrip2 - Cut, Copy, Paste Function (Separate) - 2
        private void CutTool_Click(object sender, EventArgs e)
        {
            if(UserTypeValid == true)
            {
                Cut();
            }
        }
        private void CopyTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Copy();
            }
        }
        private void PasteTool_Click(object sender, EventArgs e)
        {
            if (UserTypeValid == true)
            {
                Paste();
            }
        }

        //Functions - New, Open, Save, Save As
        private void New()
        {
            fileName = "noname";
            //Before clean the richtextbox, check whethether save the file. 
            FileProcessBeforeClose();
        }
        private void FileProcessBeforeClose()
        {
            if (modify == true && UserTypeValid == true)
            {
                DialogResult answer = MessageBox.Show("Do you want to save before?", "Save", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (fileName == "noname")
                    {
                        //Save richtextbox into RTF file
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.DefaultExt = "*.rtf";
                        saveFileDialog.Filter = "RTF Files|*.rtf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                            sw.WriteLine(richTextBox.Text);
                            sw.Close(); //Close the StreamWriter

                            modify = false; //set the modify to 'false' to save it to overwrite. (Save)
                            richTextBox.Clear(); //Clean the RichTextBox
                        }
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(richTextBox.Text);
                        sw.Close(); //Close the StreamWriter

                        modify = true; //set the modify to 'true' to save it to overwrite. (Save As) 
                    }
                }
                else
                {
                    richTextBox.Clear(); //Clean the RichTextBox
                    modify = true; //set the modify to 'true' to save it to overwrite. (Save As) 
                }
            }
            else
            {
                richTextBox.Clear(); //Clean the RichTextBox
                modify = true; //set the modify to 'true' to save it to overwrite. (Save As) 
            }
        }
        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open the file";
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0 && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                string openfileposition = openFileDialog.FileName;
                currentFile = openfileposition;

                try 
                {
                    richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText); //Load file using OpenFileDialog (with saved RichText Style)
                }
                catch(System.ArgumentException e)
                {
                    richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText); //Catch the ArgumentException which file format is not valid, instead RichText 
                }

                fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                modify = false; //set the modify to 'false' to save it to overwrite. (Save)
            }
        }
        private void Save()
        {
            if (modify == true && UserTypeValid == true)
            {
                SaveAs();
            }
            else if (modify == false && UserTypeValid == true && currentFile != null)
            {
                //setting the SaveFileDialog variables (RTF file type)
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Save";
                saveFileDialog.FileName = "*.rtf";
                saveFileDialog.DefaultExt = "*.rtf";
                saveFileDialog.Filter = "RTF Files|*.rtf";

                //SaveFileDialog can overwrite this text to existed file (after Open the file).
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.AddExtension = true;

                richTextBox.SaveFile(currentFile, RichTextBoxStreamType.RichText);
                MessageBox.Show("Save in " + fileName, "Save", MessageBoxButtons.OK);

                modify = false; //set the modify to 'false' to save it to overwrite. (Save)
            }
            else if (UserTypeValid == false) //Restricted access View - UserType
            {
                MessageBox.Show("You cannot Save the file \nYour UserType is " + userType, "Acceess Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void SaveAs()
        {
            //setting the SaveFileDialog variables (RTF file type)
            SaveFileDialog saveAsFileDialog = new SaveFileDialog();

            saveAsFileDialog.Title = "Save As";
            saveAsFileDialog.DefaultExt = "*.rtf";
            saveAsFileDialog.Filter = "RTF Files|*.rtf";

            if (saveAsFileDialog.ShowDialog() == DialogResult.OK && saveAsFileDialog.FileName.Length > 0)
            {   
                richTextBox.SaveFile(saveAsFileDialog.FileName, RichTextBoxStreamType.RichText); //Save RichTextFile into RTF file.
                modify = false; //set the modify to 'false' to save it to overwrite. (Save)
            }
        }
        private void about()
        {
            string type = userType;
            string thisVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            string description = "UserName: " + userName + "\nUserType: " + type + "\nVersion: " + thisVersion;
            MessageBox.Show(description, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Functions - Cut, Copy, Paste
        private void Cut()
        {
            if (richTextBox.SelectedText != "")
                richTextBox.Cut();
            
        }
        private void Copy()
        {
            if (richTextBox.SelectionLength > 0)
                Clipboard.SetDataObject(richTextBox.SelectedText, true);
        }
        private void Paste()
        {
            IDataObject ido = Clipboard.GetDataObject();

            if (ido.GetDataPresent(typeof(string))) 
                richTextBox.Paste();
            
        }

    }
}
