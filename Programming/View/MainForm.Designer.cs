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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
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
            this.EnumsAndClassesTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.DurationInMinutesLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.YearOfIssueTextBox = new System.Windows.Forms.TextBox();
            this.YearOfIssueLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.RectangelGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateYLabel = new System.Windows.Forms.Label();
            this.CoordinateXLabel = new System.Windows.Forms.Label();
            this.CoordinateYTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateXTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangelButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumirationGroupBox.SuspendLayout();
            this.EnumsAndClassesTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectangelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumirationGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(955, 379);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoSeasonButton);
            this.SeasonGroupBox.Location = new System.Drawing.Point(488, 240);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(458, 136);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(5, 53);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(159, 23);
            this.SeasonComboBox.TabIndex = 2;
            // 
            // GoSeasonButton
            // 
            this.GoSeasonButton.BackColor = System.Drawing.Color.LightGray;
            this.GoSeasonButton.Location = new System.Drawing.Point(169, 52);
            this.GoSeasonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoSeasonButton.Name = "GoSeasonButton";
            this.GoSeasonButton.Size = new System.Drawing.Size(81, 22);
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
            this.WeekdayGroupBox.Location = new System.Drawing.Point(10, 240);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(457, 136);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayMessageTextBox
            // 
            this.WeekdayMessageTextBox.Location = new System.Drawing.Point(8, 102);
            this.WeekdayMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayMessageTextBox.Name = "WeekdayMessageTextBox";
            this.WeekdayMessageTextBox.Size = new System.Drawing.Size(251, 23);
            this.WeekdayMessageTextBox.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(176, 52);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(82, 22);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(8, 53);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(163, 23);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeWeekdayLabel
            // 
            this.TypeWeekdayLabel.AutoSize = true;
            this.TypeWeekdayLabel.Location = new System.Drawing.Point(5, 34);
            this.TypeWeekdayLabel.Name = "TypeWeekdayLabel";
            this.TypeWeekdayLabel.Size = new System.Drawing.Size(128, 15);
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
            this.EnumirationGroupBox.Location = new System.Drawing.Point(7, 4);
            this.EnumirationGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationGroupBox.Name = "EnumirationGroupBox";
            this.EnumirationGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationGroupBox.Size = new System.Drawing.Size(940, 228);
            this.EnumirationGroupBox.TabIndex = 0;
            this.EnumirationGroupBox.TabStop = false;
            this.EnumirationGroupBox.Text = "Enumirations";
            // 
            // ValueLabel
            // 
            this.ValueLabel.Location = new System.Drawing.Point(351, 20);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(109, 19);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "Int value:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(351, 40);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(110, 23);
            this.ValueTextBox.TabIndex = 4;
            this.ValueTextBox.Text = "1";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(179, 24);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 15;
            this.ValueListBox.Location = new System.Drawing.Point(179, 40);
            this.ValueListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(169, 184);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumirationLabel
            // 
            this.EnumirationLabel.AutoSize = true;
            this.EnumirationLabel.Location = new System.Drawing.Point(5, 23);
            this.EnumirationLabel.Name = "EnumirationLabel";
            this.EnumirationLabel.Size = new System.Drawing.Size(123, 15);
            this.EnumirationLabel.TabIndex = 1;
            this.EnumirationLabel.Text = "Choose enumirations:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(5, 40);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(169, 184);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumsAndClassesTabControl
            // 
            this.EnumsAndClassesTabControl.AccessibleName = "";
            this.EnumsAndClassesTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumsAndClassesTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsAndClassesTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsAndClassesTabControl.Location = new System.Drawing.Point(0, 1);
            this.EnumsAndClassesTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsAndClassesTabControl.Name = "EnumsAndClassesTabControl";
            this.EnumsAndClassesTabControl.SelectedIndex = 0;
            this.EnumsAndClassesTabControl.Size = new System.Drawing.Size(963, 407);
            this.EnumsAndClassesTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MovieGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectangelGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(955, 379);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.DurationInMinutesTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationInMinutesLabel);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.FindMovieButton);
            this.MovieGroupBox.Controls.Add(this.YearOfIssueTextBox);
            this.MovieGroupBox.Controls.Add(this.YearOfIssueLabel);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieGroupBox.Controls.Add(this.TitleLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(460, 5);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(489, 371);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(163, 215);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(112, 23);
            this.DurationInMinutesTextBox.TabIndex = 11;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(163, 197);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(112, 15);
            this.DurationInMinutesLabel.TabIndex = 10;
            this.DurationInMinutesLabel.Text = "Duration in minutes";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(163, 127);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(112, 23);
            this.GenreTextBox.TabIndex = 9;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(163, 109);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(38, 15);
            this.GenreLabel.TabIndex = 8;
            this.GenreLabel.Text = "Genre";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(163, 302);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(112, 23);
            this.FindMovieButton.TabIndex = 7;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // YearOfIssueTextBox
            // 
            this.YearOfIssueTextBox.Location = new System.Drawing.Point(163, 171);
            this.YearOfIssueTextBox.Name = "YearOfIssueTextBox";
            this.YearOfIssueTextBox.Size = new System.Drawing.Size(112, 23);
            this.YearOfIssueTextBox.TabIndex = 6;
            this.YearOfIssueTextBox.TextChanged += new System.EventHandler(this.YearOfIssueTextBox_TextChanged);
            // 
            // YearOfIssueLabel
            // 
            this.YearOfIssueLabel.AutoSize = true;
            this.YearOfIssueLabel.Location = new System.Drawing.Point(163, 153);
            this.YearOfIssueLabel.Name = "YearOfIssueLabel";
            this.YearOfIssueLabel.Size = new System.Drawing.Size(72, 15);
            this.YearOfIssueLabel.TabIndex = 5;
            this.YearOfIssueLabel.Text = "Year of issue";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(163, 83);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(112, 23);
            this.RatingTextBox.TabIndex = 4;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(163, 65);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 15);
            this.RatingLabel.TabIndex = 3;
            this.RatingLabel.Text = "Rating";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(163, 39);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(112, 23);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(163, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(29, 15);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 15;
            this.MovieListBox.Items.AddRange(new object[] {
            "Movie1",
            "Movie2",
            "Movie3",
            "Movie4",
            "Movie5"});
            this.MovieListBox.Location = new System.Drawing.Point(6, 21);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(151, 304);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // RectangelGroupBox
            // 
            this.RectangelGroupBox.Controls.Add(this.IdLabel);
            this.RectangelGroupBox.Controls.Add(this.IdTextBox);
            this.RectangelGroupBox.Controls.Add(this.CoordinateYLabel);
            this.RectangelGroupBox.Controls.Add(this.CoordinateXLabel);
            this.RectangelGroupBox.Controls.Add(this.CoordinateYTextBox);
            this.RectangelGroupBox.Controls.Add(this.CoordinateXTextBox);
            this.RectangelGroupBox.Controls.Add(this.FindRectangelButton);
            this.RectangelGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangelGroupBox.Controls.Add(this.ColorLabel);
            this.RectangelGroupBox.Controls.Add(this.WidthTextBox);
            this.RectangelGroupBox.Controls.Add(this.WidthLabel);
            this.RectangelGroupBox.Controls.Add(this.LengthTextBox);
            this.RectangelGroupBox.Controls.Add(this.LengthLabel);
            this.RectangelGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectangelGroupBox.Location = new System.Drawing.Point(8, 5);
            this.RectangelGroupBox.Name = "RectangelGroupBox";
            this.RectangelGroupBox.Size = new System.Drawing.Size(446, 371);
            this.RectangelGroupBox.TabIndex = 0;
            this.RectangelGroupBox.TabStop = false;
            this.RectangelGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(165, 258);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(110, 23);
            this.IdTextBox.TabIndex = 12;
            // 
            // CoordinateYLabel
            // 
            this.CoordinateYLabel.AutoSize = true;
            this.CoordinateYLabel.Location = new System.Drawing.Point(165, 197);
            this.CoordinateYLabel.Name = "CoordinateYLabel";
            this.CoordinateYLabel.Size = new System.Drawing.Size(92, 15);
            this.CoordinateYLabel.TabIndex = 11;
            this.CoordinateYLabel.Text = "Coordinate by Y";
            // 
            // CoordinateXLabel
            // 
            this.CoordinateXLabel.AutoSize = true;
            this.CoordinateXLabel.Location = new System.Drawing.Point(165, 153);
            this.CoordinateXLabel.Name = "CoordinateXLabel";
            this.CoordinateXLabel.Size = new System.Drawing.Size(91, 15);
            this.CoordinateXLabel.TabIndex = 10;
            this.CoordinateXLabel.Text = "Coordinate by x";
            // 
            // CoordinateYTextBox
            // 
            this.CoordinateYTextBox.Location = new System.Drawing.Point(165, 215);
            this.CoordinateYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoordinateYTextBox.Name = "CoordinateYTextBox";
            this.CoordinateYTextBox.ReadOnly = true;
            this.CoordinateYTextBox.Size = new System.Drawing.Size(110, 23);
            this.CoordinateYTextBox.TabIndex = 9;
            // 
            // CoordinateXTextBox
            // 
            this.CoordinateXTextBox.Location = new System.Drawing.Point(165, 171);
            this.CoordinateXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoordinateXTextBox.Name = "CoordinateXTextBox";
            this.CoordinateXTextBox.ReadOnly = true;
            this.CoordinateXTextBox.Size = new System.Drawing.Size(112, 23);
            this.CoordinateXTextBox.TabIndex = 8;
            // 
            // FindRectangelButton
            // 
            this.FindRectangelButton.Location = new System.Drawing.Point(165, 302);
            this.FindRectangelButton.Name = "FindRectangelButton";
            this.FindRectangelButton.Size = new System.Drawing.Size(111, 23);
            this.FindRectangelButton.TabIndex = 7;
            this.FindRectangelButton.Text = "Find";
            this.FindRectangelButton.UseVisualStyleBackColor = true;
            this.FindRectangelButton.Click += new System.EventHandler(this.FindRectangelButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(165, 127);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(112, 23);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(165, 109);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(36, 15);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(165, 83);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(112, 23);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(165, 65);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(39, 15);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(165, 39);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(112, 23);
            this.LengthTextBox.TabIndex = 2;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(165, 21);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(44, 15);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle1",
            "Rectangle2",
            "Rectangle3",
            "Rectangle4",
            "Rectangle5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(8, 21);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(151, 304);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(165, 240);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(72, 15);
            this.IdLabel.TabIndex = 13;
            this.IdLabel.Text = "Rectangle id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 407);
            this.Controls.Add(this.EnumsAndClassesTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumirationGroupBox.ResumeLayout(false);
            this.EnumirationGroupBox.PerformLayout();
            this.EnumsAndClassesTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.RectangelGroupBox.ResumeLayout(false);
            this.RectangelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage EnumsTabPage;
        private GroupBox EnumirationGroupBox;
        private Label ValueLabel;
        private TextBox ValueTextBox;
        private Label ChooseValueLabel;
        private ListBox ValueListBox;
        private Label EnumirationLabel;
        private ListBox EnumsListBox;
        private TabControl EnumsAndClassesTabControl;
        private GroupBox WeekdayGroupBox;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label TypeWeekdayLabel;
        private GroupBox SeasonGroupBox;
        private Button GoSeasonButton;
        private MaskedTextBox WeekdayMessageTextBox;
        private ComboBox SeasonComboBox;
        private TabPage ClassesTabPage;
        private GroupBox MovieGroupBox;
        private Button FindMovieButton;
        private TextBox YearOfIssueTextBox;
        private Label YearOfIssueLabel;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private ListBox MovieListBox;
        private GroupBox RectangelGroupBox;
        private Button FindRectangelButton;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
        private TextBox DurationInMinutesTextBox;
        private Label DurationInMinutesLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Label CoordinateYLabel;
        private Label CoordinateXLabel;
        private TextBox CoordinateYTextBox;
        private TextBox CoordinateXTextBox;
        private TextBox IdTextBox;
        private Label IdLabel;
    }
}