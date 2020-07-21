namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewmemberBox = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMember = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewmemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(239, 54);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(21, 122);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(361, 43);
            this.teamNameValue.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamNameLabel.Location = new System.Drawing.Point(14, 81);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTeamMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamMemberButton.Location = new System.Drawing.Point(21, 305);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(361, 58);
            this.addTeamMemberButton.TabIndex = 19;
            this.addTeamMemberButton.Text = "ADD MEMBER";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(21, 230);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(361, 45);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 189);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(164, 38);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team";
            // 
            // addNewmemberBox
            // 
            this.addNewmemberBox.Controls.Add(this.createMemberButton);
            this.addNewmemberBox.Controls.Add(this.cellphoneValue);
            this.addNewmemberBox.Controls.Add(this.cellphoneLabel);
            this.addNewmemberBox.Controls.Add(this.emailValue);
            this.addNewmemberBox.Controls.Add(this.emailLabel);
            this.addNewmemberBox.Controls.Add(this.lastNameValue);
            this.addNewmemberBox.Controls.Add(this.lastNameLabel);
            this.addNewmemberBox.Controls.Add(this.firstNameValue);
            this.addNewmemberBox.Controls.Add(this.firstNameLabel);
            this.addNewmemberBox.Location = new System.Drawing.Point(21, 385);
            this.addNewmemberBox.Name = "addNewmemberBox";
            this.addNewmemberBox.Size = new System.Drawing.Size(361, 350);
            this.addNewmemberBox.TabIndex = 20;
            this.addNewmemberBox.TabStop = false;
            this.addNewmemberBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(183, 63);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(163, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 66);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 38);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(183, 117);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(163, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 120);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(147, 38);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(183, 171);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(163, 43);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailLabel.Location = new System.Drawing.Point(6, 174);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(182, 38);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "EmailAddress";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(183, 225);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(163, 43);
            this.cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cellphoneLabel.Location = new System.Drawing.Point(15, 228);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(142, 38);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createMemberButton.Location = new System.Drawing.Point(22, 274);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(324, 58);
            this.createMemberButton.TabIndex = 21;
            this.createMemberButton.Text = "CREATE MEMBER";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 37;
            this.teamMembersListbox.Location = new System.Drawing.Point(434, 122);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(304, 298);
            this.teamMembersListbox.TabIndex = 21;
            // 
            // deleteSelectedMember
            // 
            this.deleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.deleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMember.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteSelectedMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteSelectedMember.Location = new System.Drawing.Point(744, 247);
            this.deleteSelectedMember.Name = "deleteSelectedMember";
            this.deleteSelectedMember.Size = new System.Drawing.Size(180, 69);
            this.deleteSelectedMember.TabIndex = 22;
            this.deleteSelectedMember.Text = "DELETE";
            this.deleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTeamButton.Location = new System.Drawing.Point(608, 659);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(355, 76);
            this.createTeamButton.TabIndex = 23;
            this.createTeamButton.Text = "CREATE TEAM";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 747);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMember);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.addNewmemberBox);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewmemberBox.ResumeLayout(false);
            this.addNewmemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewmemberBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button deleteSelectedMember;
        private System.Windows.Forms.Button createTeamButton;
    }
}