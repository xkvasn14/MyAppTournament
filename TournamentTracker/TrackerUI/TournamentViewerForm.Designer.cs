namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(231, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentName.Location = new System.Drawing.Point(249, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(165, 54);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundLabel.Location = new System.Drawing.Point(23, 121);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(97, 38);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(126, 118);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(187, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(126, 181);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(217, 42);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(30, 232);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(283, 187);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneName.Location = new System.Drawing.Point(364, 222);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(172, 38);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(331, 280);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(423, 280);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 43);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(423, 465);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 43);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(331, 465);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoName.Location = new System.Drawing.Point(364, 407);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(174, 38);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team Two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versusLabel.Location = new System.Drawing.Point(397, 353);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(87, 38);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "- VS -";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.scoreButton.Location = new System.Drawing.Point(555, 332);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(118, 78);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "SCORE";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 531);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

