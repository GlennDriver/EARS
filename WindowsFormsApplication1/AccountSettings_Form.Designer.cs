namespace EARS
{
    partial class AccountSettings_Form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.searchApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.AccountPermissionsBox = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleName = "menuStrip";
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchApplicantToolStripMenuItem,
            this.manageUserAccountsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(367, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // searchApplicantToolStripMenuItem
            // 
            this.searchApplicantToolStripMenuItem.Name = "searchApplicantToolStripMenuItem";
            this.searchApplicantToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.searchApplicantToolStripMenuItem.Text = "search applicant";
            this.searchApplicantToolStripMenuItem.Click += new System.EventHandler(this.searchApplicantToolStripMenuItem_Click);
            // 
            // manageUserAccountsToolStripMenuItem
            // 
            this.manageUserAccountsToolStripMenuItem.Name = "manageUserAccountsToolStripMenuItem";
            this.manageUserAccountsToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.manageUserAccountsToolStripMenuItem.Text = "manage user accounts";
            this.manageUserAccountsToolStripMenuItem.Click += new System.EventHandler(this.manageUserAccountsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(127, 28);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UserNameLabel.TabIndex = 13;
            this.UserNameLabel.Text = "label7";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(130, 55);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(187, 20);
            this.PassBox.TabIndex = 14;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(130, 82);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(187, 20);
            this.FirstNameBox.TabIndex = 15;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(130, 108);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(187, 20);
            this.LastNameBox.TabIndex = 16;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(130, 135);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(187, 20);
            this.EmailBox.TabIndex = 17;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(130, 161);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(187, 20);
            this.PhoneNumberBox.TabIndex = 18;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(16, 213);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(301, 23);
            this.SaveChanges.TabIndex = 19;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Account Permissions:";
            // 
            // AccountPermissionsBox
            // 
            this.AccountPermissionsBox.Location = new System.Drawing.Point(130, 187);
            this.AccountPermissionsBox.Name = "AccountPermissionsBox";
            this.AccountPermissionsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountPermissionsBox.Size = new System.Drawing.Size(187, 20);
            this.AccountPermissionsBox.TabIndex = 21;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AccountSettings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 311);
            this.Controls.Add(this.AccountPermissionsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Name = "AccountSettings_Form";
            this.Text = "EARS";
            this.Load += new System.EventHandler(this.AccountSettings_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserAccountsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox AccountPermissionsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}