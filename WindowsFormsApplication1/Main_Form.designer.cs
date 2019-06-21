namespace EARS
{
    partial class Main_Form
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
            this.searchApplicants = new System.Windows.Forms.Button();
            this.manageUserAccounts = new System.Windows.Forms.Button();
            this.accountSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchApplicants
            // 
            this.searchApplicants.AccessibleName = "btnSearchApplicant";
            this.searchApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchApplicants.Location = new System.Drawing.Point(98, 80);
            this.searchApplicants.Name = "searchApplicants";
            this.searchApplicants.Size = new System.Drawing.Size(160, 36);
            this.searchApplicants.TabIndex = 0;
            this.searchApplicants.Text = "search applicant";
            this.searchApplicants.UseVisualStyleBackColor = true;
            this.searchApplicants.Click += new System.EventHandler(this.searchApplicants_Click);
            // 
            // manageUserAccounts
            // 
            this.manageUserAccounts.AccessibleName = "btnManageUserAccounts";
            this.manageUserAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserAccounts.Location = new System.Drawing.Point(98, 122);
            this.manageUserAccounts.Name = "manageUserAccounts";
            this.manageUserAccounts.Size = new System.Drawing.Size(160, 34);
            this.manageUserAccounts.TabIndex = 1;
            this.manageUserAccounts.Text = "manage user accounts";
            this.manageUserAccounts.UseVisualStyleBackColor = true;
            this.manageUserAccounts.Click += new System.EventHandler(this.manageUserAccounts_Click);
            // 
            // accountSettings
            // 
            this.accountSettings.AccessibleName = "btnAccountSettings";
            this.accountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettings.Location = new System.Drawing.Point(98, 162);
            this.accountSettings.Name = "accountSettings";
            this.accountSettings.Size = new System.Drawing.Size(160, 37);
            this.accountSettings.TabIndex = 2;
            this.accountSettings.Text = "account settings";
            this.accountSettings.UseVisualStyleBackColor = true;
            this.accountSettings.Click += new System.EventHandler(this.accountSettings_Click);
            // 
            // Main_Form
            // 
            this.AccessibleName = "frmMain";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 311);
            this.Controls.Add(this.accountSettings);
            this.Controls.Add(this.manageUserAccounts);
            this.Controls.Add(this.searchApplicants);
            this.Name = "Main_Form";
            this.Text = "EARS";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchApplicants;
        private System.Windows.Forms.Button manageUserAccounts;
        private System.Windows.Forms.Button accountSettings;
    }
}