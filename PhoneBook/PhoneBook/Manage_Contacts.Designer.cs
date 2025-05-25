namespace PhoneBook
{
    partial class Manage_Contacts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Addpanel = new System.Windows.Forms.Panel();
            this.PhoneList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.adderss = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnAddPhone = new FontAwesome.Sharp.IconButton();
            this.btnUpload = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveContact = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Addpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // Addpanel
            // 
            this.Addpanel.BackColor = System.Drawing.Color.Black;
            this.Addpanel.Controls.Add(this.PhoneList);
            this.Addpanel.Controls.Add(this.adderss);
            this.Addpanel.Controls.Add(this.txtAddress);
            this.Addpanel.Controls.Add(this.btnEdit);
            this.Addpanel.Controls.Add(this.btnAddPhone);
            this.Addpanel.Controls.Add(this.btnUpload);
            this.Addpanel.Controls.Add(this.label1);
            this.Addpanel.Controls.Add(this.picProfile);
            this.Addpanel.Controls.Add(this.comboType);
            this.Addpanel.Controls.Add(this.comboGroup);
            this.Addpanel.Controls.Add(this.label16);
            this.Addpanel.Controls.Add(this.label2);
            this.Addpanel.Controls.Add(this.txtName);
            this.Addpanel.Controls.Add(this.btnSaveContact);
            this.Addpanel.Controls.Add(this.label13);
            this.Addpanel.Controls.Add(this.txtPhone);
            this.Addpanel.Controls.Add(this.label12);
            this.Addpanel.Controls.Add(this.label11);
            this.Addpanel.Controls.Add(this.label4);
            this.Addpanel.Controls.Add(this.label10);
            this.Addpanel.Controls.Add(this.label6);
            this.Addpanel.Controls.Add(this.label3);
            this.Addpanel.Controls.Add(this.txtEmail);
            this.Addpanel.ForeColor = System.Drawing.Color.White;
            this.Addpanel.Location = new System.Drawing.Point(12, 12);
            this.Addpanel.Name = "Addpanel";
            this.Addpanel.Size = new System.Drawing.Size(1469, 334);
            this.Addpanel.TabIndex = 88;
            this.Addpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Addpanel_Paint);
            // 
            // PhoneList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.PhoneList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PhoneList.BackgroundColor = System.Drawing.Color.Silver;
            this.PhoneList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhoneList.ColumnHeadersHeight = 30;
            this.PhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PhoneList.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhoneList.GridColor = System.Drawing.Color.White;
            this.PhoneList.Location = new System.Drawing.Point(695, 10);
            this.PhoneList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneList.Name = "PhoneList";
            this.PhoneList.RowHeadersVisible = false;
            this.PhoneList.RowHeadersWidth = 51;
            this.PhoneList.RowTemplate.Height = 40;
            this.PhoneList.Size = new System.Drawing.Size(757, 259);
            this.PhoneList.TabIndex = 90;
            this.PhoneList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.PhoneList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.PhoneList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhoneList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhoneList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhoneList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhoneList.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.PhoneList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.PhoneList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.PhoneList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PhoneList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PhoneList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhoneList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhoneList.ThemeStyle.HeaderStyle.Height = 30;
            this.PhoneList.ThemeStyle.ReadOnly = false;
            this.PhoneList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.PhoneList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhoneList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PhoneList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.PhoneList.ThemeStyle.RowsStyle.Height = 40;
            this.PhoneList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.PhoneList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PhoneList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhoneLIst_CellContentClick);
            // 
            // adderss
            // 
            this.adderss.AutoSize = true;
            this.adderss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adderss.ForeColor = System.Drawing.Color.White;
            this.adderss.Location = new System.Drawing.Point(20, 89);
            this.adderss.Name = "adderss";
            this.adderss.Size = new System.Drawing.Size(78, 23);
            this.adderss.TabIndex = 78;
            this.adderss.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.SlateGray;
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(19, 116);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(151, 37);
            this.txtAddress.TabIndex = 77;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(419, 235);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(191, 42);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnAddPhone.FlatAppearance.BorderSize = 0;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPhone.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddPhone.IconColor = System.Drawing.Color.Black;
            this.btnAddPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPhone.Location = new System.Drawing.Point(1275, 273);
            this.btnAddPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(191, 47);
            this.btnAddPhone.TabIndex = 75;
            this.btnAddPhone.Text = "Add Phone";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpload.IconColor = System.Drawing.Color.Black;
            this.btnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpload.Location = new System.Drawing.Point(19, 204);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(110, 31);
            this.btnUpload.TabIndex = 74;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Upload Profile Photo";
            // 
            // picProfile
            // 
            this.picProfile.ImageRotate = 0F;
            this.picProfile.Location = new System.Drawing.Point(252, 179);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(128, 141);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 72;
            this.picProfile.TabStop = false;
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.Transparent;
            this.comboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboType.ItemHeight = 30;
            this.comboType.Items.AddRange(new object[] {
            "Personal",
            "Work",
            "Temporary"});
            this.comboType.Location = new System.Drawing.Point(540, 49);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(140, 36);
            this.comboType.TabIndex = 71;
            // 
            // comboGroup
            // 
            this.comboGroup.BackColor = System.Drawing.Color.Transparent;
            this.comboGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboGroup.ItemHeight = 30;
            this.comboGroup.Items.AddRange(new object[] {
            "Friend",
            "Family",
            "Work"});
            this.comboGroup.Location = new System.Drawing.Point(194, 117);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(140, 36);
            this.comboGroup.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 28);
            this.label16.TabIndex = 4;
            this.label16.Text = "Name";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.SlateGray;
            this.txtName.BorderRadius = 8;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(14, 47);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(151, 37);
            this.txtName.TabIndex = 59;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.Blue;
            this.btnSaveContact.FlatAppearance.BorderSize = 0;
            this.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveContact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveContact.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveContact.IconColor = System.Drawing.Color.Black;
            this.btnSaveContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveContact.Location = new System.Drawing.Point(419, 179);
            this.btnSaveContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(191, 42);
            this.btnSaveContact.TabIndex = 16;
            this.btnSaveContact.Text = "Save Contact";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(536, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Type";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.Black;
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(365, 51);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(151, 37);
            this.txtPhone.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(190, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(371, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(185, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(190, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(366, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(185, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.SlateGray;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(189, 47);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(151, 37);
            this.txtEmail.TabIndex = 60;
            // 
            // ContactList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ContactList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ContactList.BackgroundColor = System.Drawing.Color.DimGray;
            this.ContactList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ContactList.ColumnHeadersHeight = 30;
            this.ContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ContactList.DefaultCellStyle = dataGridViewCellStyle6;
            this.ContactList.GridColor = System.Drawing.Color.White;
            this.ContactList.Location = new System.Drawing.Point(12, 363);
            this.ContactList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactList.Name = "ContactList";
            this.ContactList.RowHeadersVisible = false;
            this.ContactList.RowHeadersWidth = 51;
            this.ContactList.RowTemplate.Height = 40;
            this.ContactList.Size = new System.Drawing.Size(1469, 394);
            this.ContactList.TabIndex = 89;
            this.ContactList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.ContactList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.ContactList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ContactList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ContactList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ContactList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ContactList.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.ContactList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ContactList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ContactList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ContactList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ContactList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ContactList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ContactList.ThemeStyle.HeaderStyle.Height = 30;
            this.ContactList.ThemeStyle.ReadOnly = false;
            this.ContactList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.ContactList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ContactList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ContactList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ContactList.ThemeStyle.RowsStyle.Height = 40;
            this.ContactList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.ContactList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactList_CellContentClick);
            // 
            // Manage_Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 768);
            this.Controls.Add(this.ContactList);
            this.Controls.Add(this.Addpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Contacts";
            this.Text = "Manage_Contacts";
            this.Addpanel.ResumeLayout(false);
            this.Addpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Addpanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private FontAwesome.Sharp.IconButton btnSaveContact;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2ComboBox comboGroup;
        private FontAwesome.Sharp.IconButton btnUpload;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picProfile;
        private Guna.UI2.WinForms.Guna2ComboBox comboType;
        private FontAwesome.Sharp.IconButton btnAddPhone;
        private Guna.UI2.WinForms.Guna2DataGridView ContactList;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label adderss;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2DataGridView PhoneList;
    }
}