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
        public static List<string> userList;

        private string fileName;
        bool modify;
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
            
            username.Text = "UserName: " + userName;
            CheckType(userName);
        }

        //Check userType - View or Edit (Additional function to identify the userType easily)
        public void CheckType(string user)
        {
            string type = getType(userName);
            if (type == "Edit")
            {
                richTextBox.ReadOnly = false;
                UserType.Text = "UserType: " + type;
            }
            else if (type == "View")
            {
                richTextBox.ReadOnly = true;
                UserType.Text = "UserType: " + type;
            }
            else
            {
                MessageBox.Show("User Type is not founded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox.ReadOnly = true;
                UserType.Text = "UserType: none";
            }
        }
        public string getType(string name)
        {
            string Utype = "";
            StreamReader sr = new StreamReader("login.txt"); //Load the login.txt and find the userType using userName
            sr.BaseStream.Position = 0; //Initialize the location and scan the file text.
            while (sr.EndOfStream == false)
            {
                string key = sr.ReadLine(); //Read one line at a time.

                bool Type = key.Contains(name); //Verify the line(string key) contains userName
                if (Type == true)
                {
                    string[] splits = key.Split(',');
                    string type = Convert.ToString(splits[2]);
                    return type;
                }
            }

            sr.Close();
            return Utype;
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
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save all users back to “login.txt”, when a user logs out of the text editor
            using (StreamWriter sw = new StreamWriter("login2.txt")) 
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
            Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
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
            Save();
        }
        private void SaveAsTool_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        //toolStrip1.2 - Font Style Editor
        private void BoldTool_Click(object sender, EventArgs e)
        {
            //if selectionfont has different sizes and styles for each other then, it will be a null pointer.
            if (richTextBox.SelectionFont == null) return;

            //Set the font format to overlap. i.e. if the Bold and the Underline are applied together, 2 * 5 corresponds to case 10 and break.
            int number = 1;
            number = richTextBox.SelectionFont.Bold ? 1 : 2;
            number *= richTextBox.SelectionFont.Italic ? 3 : 1;
            number *= richTextBox.SelectionFont.Underline ? 5 : 1;

            switch (number)
            {
                case 1:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular); break;
                case 2:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold); break;
                case 3:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic); break;
                case 5:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline); break;
                case 6:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;
                case 10:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;
                case 15:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | FontStyle.Underline); break;
                case 30:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
            }
        }
        private void ItalicTool_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return; //Null pointer

            //Duplicate font format, different format with Bold one, preventing the conflicts and confusion.
            int number = 1;
            number = richTextBox.SelectionFont.Italic ? 1 : 4;
            number *= richTextBox.SelectionFont.Underline ? 7 : 1;
            number *= richTextBox.SelectionFont.Bold ? 8 : 1;

            switch (number)
            {
                case 1:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Regular); break;
                case 4:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic); break;
                case 7:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline); break;
                case 8:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold); break;
                case 28:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline | FontStyle.Italic); break;
                case 32:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic); break;
                case 56:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Underline); break;
                case 224:
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline); break;
            }
        }
        private void UnderLineTool_Click(object sender, EventArgs e)
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

        private void FontSizeTool_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return; //Null pointer

            //new font size value in combobox convert into int type
            Font currentFont = richTextBox.SelectionFont;
            fontsize = int.Parse(FontSizeTool.SelectedItem.ToString());

            //Set new Font size maintaining the Font Style
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, fontsize, currentFont.Style);
        }
        private void AboutTool_Click(object sender, EventArgs e)
        {
            about();
        }

        //toolStrip2 - Cut, Copy, Paste Function (Separate) - 2
        private void CutTool_Click(object sender, EventArgs e)
        {
            Cut();
        }
        private void CopyTool_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void PasteTool_Click(object sender, EventArgs e)
        {
            Paste();
        }

        //Functions - New, Open, Save, Save As
        private void New()
        {
            fileName = "noname.txt";
            //Before clean the richtextbox, check whethether save the file. 
            FileProcessBeforeClose();
        }
        private void FileProcessBeforeClose()
        {
            if (modify == true)
            {
                DialogResult answer = MessageBox.Show("Do you want to save before?", "Save", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (fileName == "noname.txt")
                    {
                        //Save richtextbox into RTF file
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.DefaultExt = "*.rtf";
                        saveFileDialog.Filter = "RTF Files|*.rtf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                            sw.WriteLine(richTextBox.Text);
                            sw.Close();
                            //set the modify to 'false' to save it to overwrite. (Save)
                            modify = false;
                            richTextBox.Clear();
                        }
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(richTextBox.Text);
                        sw.Close();

                        //set the modify to 'true' to save it to overwrite. (Save As) 
                        modify = true;
                    }
                }
                else
                {
                    richTextBox.Clear();
                    modify = true;
                }
            }
            else
            {
                richTextBox.Clear();
                modify = true;
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
                //Load file using OpenFileDialog.
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);

                fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                modify = false;
            }
        }
        private void Save()
        {
            if (modify == true)
            {
                SaveAs();
            }
            else if (modify == false && currentFile != null)
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

                //set the modify to 'false' to save it to overwrite. (Save)
                modify = false; 
            }
        }
        private void SaveAs()
        {
            //setting the SaveFileDialog variables (RTF file type)
            SaveFileDialog saveAsFileDialog = new SaveFileDialog();

            saveAsFileDialog.Title = "Save AS";
            saveAsFileDialog.DefaultExt = "*.rtf";
            saveAsFileDialog.Filter = "RTF Files|*.rtf";
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK && saveAsFileDialog.FileName.Length > 0)
            {
                //Save RichTextFile into RTF file.
                richTextBox.SaveFile(saveAsFileDialog.FileName, RichTextBoxStreamType.RichText);
                //set the modify to 'false' to save it to overwrite. (Save)
                modify = false; 
            }
        }
        private void about()
        {
            string type = getType(userName);
            string thisVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            string description = "UserName: " + userName + "\nUserType: " + type + "\nVersion: " + thisVersion;
            MessageBox.Show(description, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Functions - Cut, Copy, Paste
        private void Cut()
        {
            //Clipboard.SetDataObject(richTextBox.SelectedText, true);
            //richTextBox.SelectedText.Remove(0);
            if (richTextBox.SelectedText != "")
            {
                richTextBox.Cut();
            }
        }
        private void Copy()
        {
            if (richTextBox.SelectionLength > 0)
                Clipboard.SetDataObject(richTextBox.SelectedText, true);
        }
        private void Paste()
        {
            IDataObject ido = Clipboard.GetDataObject();
            if (ido.GetDataPresent(typeof(string))) //Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true
            {
                richTextBox.Paste();
                //richTextBox.Text = (string)ido.GetData(typeof(string));
            }
        }

    }
}
