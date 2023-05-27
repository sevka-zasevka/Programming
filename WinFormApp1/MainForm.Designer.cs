namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.ValidationDurationLabel = new System.Windows.Forms.Label();
            this.ValidationRateLabel = new System.Windows.Forms.Label();
            this.ValidationYearLabel = new System.Windows.Forms.Label();
            this.ValidationTitleLable = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DurationLable = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(12, 12);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(350, 344);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionGroupBox.Controls.Add(this.ValidationDurationLabel);
            this.DescriptionGroupBox.Controls.Add(this.ValidationRateLabel);
            this.DescriptionGroupBox.Controls.Add(this.ValidationYearLabel);
            this.DescriptionGroupBox.Controls.Add(this.ValidationTitleLable);
            this.DescriptionGroupBox.Controls.Add(this.GenreComboBox);
            this.DescriptionGroupBox.Controls.Add(this.DurationTextBox);
            this.DescriptionGroupBox.Controls.Add(this.RateTextBox);
            this.DescriptionGroupBox.Controls.Add(this.ReleaseTextBox);
            this.DescriptionGroupBox.Controls.Add(this.TitleTextBox);
            this.DescriptionGroupBox.Controls.Add(this.DurationLable);
            this.DescriptionGroupBox.Controls.Add(this.RateLabel);
            this.DescriptionGroupBox.Controls.Add(this.GenreLabel);
            this.DescriptionGroupBox.Controls.Add(this.YearLabel);
            this.DescriptionGroupBox.Controls.Add(this.TitleLabel);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(368, 3);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(395, 302);
            this.DescriptionGroupBox.TabIndex = 1;
            this.DescriptionGroupBox.TabStop = false;
            this.DescriptionGroupBox.Text = "Description";
            // 
            // ValidationDurationLabel
            // 
            this.ValidationDurationLabel.AutoSize = true;
            this.ValidationDurationLabel.Location = new System.Drawing.Point(80, 266);
            this.ValidationDurationLabel.Name = "ValidationDurationLabel";
            this.ValidationDurationLabel.Size = new System.Drawing.Size(270, 20);
            this.ValidationDurationLabel.TabIndex = 14;
            this.ValidationDurationLabel.Text = "Only a positive value, no more than 300";
            this.ValidationDurationLabel.Visible = false;
            // 
            // ValidationRateLabel
            // 
            this.ValidationRateLabel.AutoSize = true;
            this.ValidationRateLabel.Location = new System.Drawing.Point(80, 213);
            this.ValidationRateLabel.Name = "ValidationRateLabel";
            this.ValidationRateLabel.Size = new System.Drawing.Size(250, 20);
            this.ValidationRateLabel.TabIndex = 13;
            this.ValidationRateLabel.Text = "Only positive value, no more than 10";
            this.ValidationRateLabel.Visible = false;
            // 
            // ValidationYearLabel
            // 
            this.ValidationYearLabel.AutoSize = true;
            this.ValidationYearLabel.Location = new System.Drawing.Point(80, 106);
            this.ValidationYearLabel.Name = "ValidationYearLabel";
            this.ValidationYearLabel.Size = new System.Drawing.Size(134, 20);
            this.ValidationYearLabel.TabIndex = 11;
            this.ValidationYearLabel.Text = "Only positive value";
            this.ValidationYearLabel.Visible = false;
            // 
            // ValidationTitleLable
            // 
            this.ValidationTitleLable.AutoSize = true;
            this.ValidationTitleLable.Location = new System.Drawing.Point(80, 53);
            this.ValidationTitleLable.Name = "ValidationTitleLable";
            this.ValidationTitleLable.Size = new System.Drawing.Size(138, 20);
            this.ValidationTitleLable.TabIndex = 10;
            this.ValidationTitleLable.Text = "Only 100 characters";
            this.ValidationTitleLable.Visible = false;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(80, 129);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(151, 28);
            this.GenreComboBox.TabIndex = 9;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DurationTextBox.Location = new System.Drawing.Point(80, 236);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.ReadOnly = true;
            this.DurationTextBox.Size = new System.Drawing.Size(151, 27);
            this.DurationTextBox.TabIndex = 8;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // RateTextBox
            // 
            this.RateTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RateTextBox.Location = new System.Drawing.Point(80, 183);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.ReadOnly = true;
            this.RateTextBox.Size = new System.Drawing.Size(151, 27);
            this.RateTextBox.TabIndex = 7;
            this.RateTextBox.TextChanged += new System.EventHandler(this.RateTextBox_TextChanged);
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReleaseTextBox.Location = new System.Drawing.Point(80, 76);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.ReadOnly = true;
            this.ReleaseTextBox.Size = new System.Drawing.Size(151, 27);
            this.ReleaseTextBox.TabIndex = 6;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.ReleaseTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleTextBox.Location = new System.Drawing.Point(80, 23);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(303, 27);
            this.TitleTextBox.TabIndex = 5;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // DurationLable
            // 
            this.DurationLable.AutoSize = true;
            this.DurationLable.Location = new System.Drawing.Point(4, 239);
            this.DurationLable.Name = "DurationLable";
            this.DurationLable.Size = new System.Drawing.Size(70, 20);
            this.DurationLable.TabIndex = 4;
            this.DurationLable.Text = "Duration:";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(32, 186);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(42, 20);
            this.RateLabel.TabIndex = 3;
            this.RateLabel.Text = "Rate:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(23, 132);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(14, 79);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(60, 20);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Reliaze:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(33, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(12, 369);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(61, 64);
            this.AddButton.TabIndex = 2;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(148, 369);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(63, 65);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeButton.BackgroundImage")));
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Location = new System.Drawing.Point(79, 369);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(63, 65);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApplyButton.BackgroundImage")));
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(368, 311);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(59, 68);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 445);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.MoviesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(636, 326);
            this.Name = "MainForm";
            this.Text = "MovieApp";
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox MoviesListBox;
        private GroupBox DescriptionGroupBox;
        private ComboBox GenreComboBox;
        private TextBox DurationTextBox;
        private TextBox RateTextBox;
        private TextBox ReleaseTextBox;
        private TextBox TitleTextBox;
        private Label DurationLable;
        private Label RateLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label TitleLabel;
        private Button AddButton;
        private Button DeleteButton;
        private Button ChangeButton;
        private Button ApplyButton;
        private Label ValidationDurationLabel;
        private Label ValidationRateLabel;
        private Label ValidationYearLabel;
        private Label ValidationTitleLable;
    }
}