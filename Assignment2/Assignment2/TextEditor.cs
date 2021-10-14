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
        static public string userName;
        private string fileName;
        bool modify;
        string currentFile;
        string currentOpenFile;

        //Font setting
        private int fontsize;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            modify = true;
            CheckType(userName);
            username.Text = "UserName: " + userName;
        }
        //Check userType - View or Edit
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
            StreamReader sr = new StreamReader("login.txt");
            sr.BaseStream.Position = 0;

            while (sr.EndOfStream == false)
            {
                string key = sr.ReadLine();

                bool Type = key.Contains(name);
                if (Type == true)
                {
                    string[] splits = key.Split(',');
                    string type = Convert.ToString(splits[2]);
                    return type;
                }
            }
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
            this.Close();
            Login restart = new Login();
            restart.Show();
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
            if (richTextBox.SelectionFont == null) return;
            if (richTextBox.SelectionFont.Bold)
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Regular);
            }
            else
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Bold);
            }
        }
        private void ItalicTool_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            if (richTextBox.SelectionFont.Italic)
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Regular);
            }
            else
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Italic);
            }
        }
        private void UnderLineTool_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            if (richTextBox.SelectionFont.Underline)
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Regular);
            }
            else
            {
                int thisSize = (int)richTextBox.SelectionFont.Size;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, thisSize, FontStyle.Underline);
            }
        }
        private void FontSizeTool_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont == null) return;
            fontsize = int.Parse(FontSizeTool.SelectedItem.ToString());
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, fontsize, richTextBox.SelectionFont.Bold ? FontStyle.Bold : FontStyle.Regular);
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
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.DefaultExt = "*.rtf";
                        saveFileDialog.Filter = "RTF Files|*.rtf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(saveFileDialog.FileName);
                            sw.WriteLine(richTextBox.Text);
                            sw.Close();

                            modify = false;
                            richTextBox.Clear();
                        }
                    }
                    else
                    {
                        StreamWriter sw = File.CreateText(fileName);
                        sw.WriteLine(richTextBox.Text);
                        sw.Close();

                        modify = true;
                    }
                }
            }
        }
        private void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open the file";
            openFileDialog.DefaultExt = "*.rtf";
            openFileDialog.Filter = "rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
            //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.FileName.Length > 0 && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                string openfileposition = openFileDialog.FileName;
                currentFile = openfileposition;
                currentOpenFile = openfileposition;

                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

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
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Save";
                saveFileDialog.FileName = "*.rtf";
                saveFileDialog.DefaultExt = "*.rtf";
                saveFileDialog.Filter = "RTF Files|*.rtf";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.AddExtension = true;

                richTextBox.SaveFile(currentOpenFile, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Save in " + fileName, "Save", MessageBoxButtons.OK);
            }
        }
        private void SaveAs()
        {
            SaveFileDialog saveAsFileDialog = new SaveFileDialog();
            saveAsFileDialog.Title = "Save AS";
            saveAsFileDialog.DefaultExt = "*.rtf";
            saveAsFileDialog.Filter = "RTF Files|*.rtf";
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK && saveAsFileDialog.FileName.Length > 0)
            {
                richTextBox.SaveFile(saveAsFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void about()
        {
            string type = getType(userName);
            string description = "UserName: " + userName + "\nUserType: " + type + "\nVersion:";
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
