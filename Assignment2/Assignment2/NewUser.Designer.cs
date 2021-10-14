
namespace Assignment2
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PWLabel = new System.Windows.Forms.Label();
            this.RePWLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PWInput = new System.Windows.Forms.TextBox();
            this.RePWInput = new System.Windows.Forms.TextBox();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.BirthDateInput = new System.Windows.Forms.DateTimePicker();
            this.UserTypeInput = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(274, 82);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(150, 25);
            this.createLabel.TabIndex = 0;
            this.createLabel.Text = "Create New User";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(93, 196);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(98, 25);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "UserName";
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Location = new System.Drawing.Point(93, 241);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(88, 25);
            this.PWLabel.TabIndex = 2;
            this.PWLabel.Text = "Password";
            // 
            // RePWLabel
            // 
            this.RePWLabel.AutoSize = true;
            this.RePWLabel.Location = new System.Drawing.Point(93, 285);
            this.RePWLabel.Name = "RePWLabel";
            this.RePWLabel.Size = new System.Drawing.Size(164, 25);
            this.RePWLabel.TabIndex = 3;
            this.RePWLabel.Text = "Re-enter Password";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(93, 337);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(100, 25);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(93, 380);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(99, 25);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last Name";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(93, 432);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(49, 25);
            this.BirthLabel.TabIndex = 6;
            this.BirthLabel.Text = "Birth";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(93, 485);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(89, 25);
            this.UserTypeLabel.TabIndex = 7;
            this.UserTypeLabel.Text = "UserType";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(274, 196);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(150, 31);
            this.NameInput.TabIndex = 8;
            // 
            // PWInput
            // 
            this.PWInput.Location = new System.Drawing.Point(274, 241);
            this.PWInput.Name = "PWInput";
            this.PWInput.Size = new System.Drawing.Size(150, 31);
            this.PWInput.TabIndex = 9;
            // 
            // RePWInput
            // 
            this.RePWInput.Location = new System.Drawing.Point(274, 285);
            this.RePWInput.Name = "RePWInput";
            this.RePWInput.Size = new System.Drawing.Size(150, 31);
            this.RePWInput.TabIndex = 10;
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(274, 337);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(150, 31);
            this.FirstNameInput.TabIndex = 11;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(274, 380);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(150, 31);
            this.LastNameInput.TabIndex = 12;
            // 
            // BirthDateInput
            // 
            this.BirthDateInput.CustomFormat = "dd-MM-yyyy";
            this.BirthDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDateInput.Location = new System.Drawing.Point(274, 432);
            this.BirthDateInput.Name = "BirthDateInput";
            this.BirthDateInput.Size = new System.Drawing.Size(238, 31);
            this.BirthDateInput.TabIndex = 13;
            // 
            // UserTypeInput
            // 
            this.UserTypeInput.FormattingEnabled = true;
            this.UserTypeInput.Items.AddRange(new object[] {
            "Edit",
            "View"});
            this.UserTypeInput.Location = new System.Drawing.Point(274, 485);
            this.UserTypeInput.Name = "UserTypeInput";
            this.UserTypeInput.Size = new System.Drawing.Size(182, 33);
            this.UserTypeInput.TabIndex = 14;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(138, 560);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(112, 34);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // CancleBtn
            // 
            this.CancleBtn.Location = new System.Drawing.Point(378, 560);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(112, 34);
            this.CancleBtn.TabIndex = 16;
            this.CancleBtn.Text = "Cancel";
            this.CancleBtn.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 658);
            this.Controls.Add(this.CancleBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.UserTypeInput);
            this.Controls.Add(this.BirthDateInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.RePWInput);
            this.Controls.Add(this.PWInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.UserTypeLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.RePWLabel);
            this.Controls.Add(this.PWLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.createLabel);
            this.Name = "NewUser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PWLabel;
        private System.Windows.Forms.Label RePWLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox PWInput;
        private System.Windows.Forms.TextBox RePWInput;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.DateTimePicker BirthDateInput;
        private System.Windows.Forms.ComboBox UserTypeInput;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button CancleBtn;
    }
}