namespace PhoneBook
{
    partial class UserDashboard
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
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnShowContacts = new FontAwesome.Sharp.IconButton();
            this.mainpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftPanel.Controls.Add(this.btnSettings);
            this.LeftPanel.Controls.Add(this.btnLogout);
            this.LeftPanel.Controls.Add(this.iconButton1);
            this.LeftPanel.Controls.Add(this.btnShowContacts);
            this.LeftPanel.Location = new System.Drawing.Point(1, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(238, 887);
            this.LeftPanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.btnSettings.IconColor = System.Drawing.Color.Black;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.Location = new System.Drawing.Point(4, 435);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(231, 57);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Manage Contacts";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(3, 761);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(231, 57);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Manage Contacts";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(4, 358);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(231, 57);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Manage Contacts";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnShowContacts
            // 
            this.btnShowContacts.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.btnShowContacts.IconColor = System.Drawing.Color.Black;
            this.btnShowContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowContacts.Location = new System.Drawing.Point(4, 278);
            this.btnShowContacts.Name = "btnShowContacts";
            this.btnShowContacts.Size = new System.Drawing.Size(231, 57);
            this.btnShowContacts.TabIndex = 0;
            this.btnShowContacts.Text = "Show All Contacts";
            this.btnShowContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowContacts.UseVisualStyleBackColor = true;
            this.btnShowContacts.Click += new System.EventHandler(this.btnShowContacts_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainpanel.Location = new System.Drawing.Point(242, 2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1481, 818);
            this.mainpanel.TabIndex = 1;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 826);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private FontAwesome.Sharp.IconButton btnShowContacts;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Panel mainpanel;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}