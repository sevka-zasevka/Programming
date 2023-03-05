namespace Programming
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
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoSeasonButton = new System.Windows.Forms.Button();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayMessageTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeWeekdayLabel = new System.Windows.Forms.Label();
            this.EnumirationGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumirationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.Enums.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumirationGroupBox.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonGroupBox);
            this.Enums.Controls.Add(this.WeekdayGroupBox);
            this.Enums.Controls.Add(this.EnumirationGroupBox);
            this.Enums.Location = new System.Drawing.Point(4, 29);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1088, 509);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoSeasonButton);
            this.SeasonGroupBox.Location = new System.Drawing.Point(558, 320);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(524, 181);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Fall"});
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 71);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(181, 28);
            this.SeasonComboBox.TabIndex = 2;
            // 
            // GoSeasonButton
            // 
            this.GoSeasonButton.BackColor = System.Drawing.Color.LightGray;
            this.GoSeasonButton.Location = new System.Drawing.Point(193, 69);
            this.GoSeasonButton.Name = "GoSeasonButton";
            this.GoSeasonButton.Size = new System.Drawing.Size(93, 30);
            this.GoSeasonButton.TabIndex = 1;
            this.GoSeasonButton.Text = "Go!";
            this.GoSeasonButton.UseVisualStyleBackColor = false;
            this.GoSeasonButton.Click += new System.EventHandler(this.GoSeasonButton_Click);
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.WeekdayMessageTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeWeekdayLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(12, 320);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(522, 181);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayMessageTextBox
            // 
            this.WeekdayMessageTextBox.Location = new System.Drawing.Point(9, 136);
            this.WeekdayMessageTextBox.Name = "WeekdayMessageTextBox";
            this.WeekdayMessageTextBox.Size = new System.Drawing.Size(286, 27);
            this.WeekdayMessageTextBox.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(201, 69);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(94, 29);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(9, 71);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(186, 27);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeWeekdayLabel
            // 
            this.TypeWeekdayLabel.AutoSize = true;
            this.TypeWeekdayLabel.Location = new System.Drawing.Point(6, 45);
            this.TypeWeekdayLabel.Name = "TypeWeekdayLabel";
            this.TypeWeekdayLabel.Size = new System.Drawing.Size(162, 20);
            this.TypeWeekdayLabel.TabIndex = 0;
            this.TypeWeekdayLabel.Text = "Type value for parsing: ";
            // 
            // EnumirationGroupBox
            // 
            this.EnumirationGroupBox.Controls.Add(this.ValueLabel);
            this.EnumirationGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumirationGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumirationGroupBox.Controls.Add(this.ValueListBox);
            this.EnumirationGroupBox.Controls.Add(this.EnumirationLabel);
            this.EnumirationGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumirationGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumirationGroupBox.Name = "EnumirationGroupBox";
            this.EnumirationGroupBox.Size = new System.Drawing.Size(1074, 304);
            this.EnumirationGroupBox.TabIndex = 0;
            this.EnumirationGroupBox.TabStop = false;
            this.EnumirationGroupBox.Text = "Enumirations";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(401, 27);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(125, 25);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "Int value:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(401, 54);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(125, 27);
            this.ValueTextBox.TabIndex = 4;
            this.ValueTextBox.Text = "1";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(205, 32);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(100, 20);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 20;
            this.ValueListBox.Location = new System.Drawing.Point(205, 54);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(193, 244);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumirationLabel
            // 
            this.EnumirationLabel.AutoSize = true;
            this.EnumirationLabel.Location = new System.Drawing.Point(6, 31);
            this.EnumirationLabel.Name = "EnumirationLabel";
            this.EnumirationLabel.Size = new System.Drawing.Size(151, 20);
            this.EnumirationLabel.TabIndex = 1;
            this.EnumirationLabel.Text = "Choose enumirations:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 54);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(193, 244);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.Enums);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(1096, 542);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 542);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Enums.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumirationGroupBox.ResumeLayout(false);
            this.EnumirationGroupBox.PerformLayout();
            this.EnumsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage Enums;
        private GroupBox EnumirationGroupBox;
        private Label ValueLabel;
        private TextBox ValueTextBox;
        private Label ChooseValueLabel;
        private ListBox ValueListBox;
        private Label EnumirationLabel;
        private ListBox EnumsListBox;
        private TabControl EnumsTabControl;
        private GroupBox WeekdayGroupBox;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label TypeWeekdayLabel;
        private GroupBox SeasonGroupBox;
        private Button GoSeasonButton;
        private MaskedTextBox WeekdayMessageTextBox;
        private ComboBox SeasonComboBox;
    }
}