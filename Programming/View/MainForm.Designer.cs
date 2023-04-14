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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.IdClassesLabel = new System.Windows.Forms.Label();
            this.IdClassesTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateYLabel = new System.Windows.Forms.Label();
            this.CoordinateXLabel = new System.Windows.Forms.Label();
            this.CoordinateYTextBox = new System.Windows.Forms.TextBox();
            this.CoordinateXTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangelButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthClassesTextBox = new System.Windows.Forms.TextBox();
            this.WidthClassesLabel = new System.Windows.Forms.Label();
            this.LengthClassesTextBox = new System.Windows.Forms.TextBox();
            this.LengthClassesLabel = new System.Windows.Forms.Label();
            this.RectanglesClassesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLable = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLable = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumirationGroupBox.SuspendLayout();
            this.EnumsAndClassesTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectangelGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumirationGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(912, 572);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoSeasonButton);
            this.SeasonGroupBox.Location = new System.Drawing.Point(472, 320);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(432, 237);
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
            this.GoSeasonButton.Size = new System.Drawing.Size(93, 29);
            this.GoSeasonButton.TabIndex = 1;
            this.GoSeasonButton.Text = "Go!";
            this.GoSeasonButton.UseVisualStyleBackColor = false;
            this.GoSeasonButton.Click += new System.EventHandler(this.GoSeasonButton_Click);
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayGroupBox.Controls.Add(this.WeekdayMessageTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeWeekdayLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(11, 320);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(454, 237);
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
            this.EnumirationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumirationGroupBox.Controls.Add(this.ValueLabel);
            this.EnumirationGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumirationGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumirationGroupBox.Controls.Add(this.ValueListBox);
            this.EnumirationGroupBox.Controls.Add(this.EnumirationLabel);
            this.EnumirationGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumirationGroupBox.Location = new System.Drawing.Point(8, 5);
            this.EnumirationGroupBox.Name = "EnumirationGroupBox";
            this.EnumirationGroupBox.Size = new System.Drawing.Size(896, 304);
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
            this.ValueTextBox.Location = new System.Drawing.Point(401, 53);
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
            this.ValueListBox.Location = new System.Drawing.Point(205, 53);
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
            this.EnumsListBox.Location = new System.Drawing.Point(6, 53);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(193, 244);
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
            this.EnumsAndClassesTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsAndClassesTabControl.Location = new System.Drawing.Point(0, 1);
            this.EnumsAndClassesTabControl.Name = "EnumsAndClassesTabControl";
            this.EnumsAndClassesTabControl.SelectedIndex = 0;
            this.EnumsAndClassesTabControl.Size = new System.Drawing.Size(920, 605);
            this.EnumsAndClassesTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MovieGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectangelGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(912, 572);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.MovieGroupBox.Location = new System.Drawing.Point(443, 7);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieGroupBox.Size = new System.Drawing.Size(459, 549);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(186, 287);
            this.DurationInMinutesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(127, 27);
            this.DurationInMinutesTextBox.TabIndex = 11;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(186, 263);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(139, 20);
            this.DurationInMinutesLabel.TabIndex = 10;
            this.DurationInMinutesLabel.Text = "Duration in minutes";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(186, 169);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(127, 27);
            this.GenreTextBox.TabIndex = 9;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(186, 145);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 20);
            this.GenreLabel.TabIndex = 8;
            this.GenreLabel.Text = "Genre";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(186, 403);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(128, 31);
            this.FindMovieButton.TabIndex = 7;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // YearOfIssueTextBox
            // 
            this.YearOfIssueTextBox.Location = new System.Drawing.Point(186, 228);
            this.YearOfIssueTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearOfIssueTextBox.Name = "YearOfIssueTextBox";
            this.YearOfIssueTextBox.Size = new System.Drawing.Size(127, 27);
            this.YearOfIssueTextBox.TabIndex = 6;
            this.YearOfIssueTextBox.TextChanged += new System.EventHandler(this.YearOfIssueTextBox_TextChanged);
            // 
            // YearOfIssueLabel
            // 
            this.YearOfIssueLabel.AutoSize = true;
            this.YearOfIssueLabel.Location = new System.Drawing.Point(186, 204);
            this.YearOfIssueLabel.Name = "YearOfIssueLabel";
            this.YearOfIssueLabel.Size = new System.Drawing.Size(91, 20);
            this.YearOfIssueLabel.TabIndex = 5;
            this.YearOfIssueLabel.Text = "Year of issue";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(186, 111);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(127, 27);
            this.RatingTextBox.TabIndex = 4;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(186, 87);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(52, 20);
            this.RatingLabel.TabIndex = 3;
            this.RatingLabel.Text = "Rating";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(186, 52);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(127, 27);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(186, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 20;
            this.MovieListBox.Items.AddRange(new object[] {
            "Movie1",
            "Movie2",
            "Movie3",
            "Movie4",
            "Movie5"});
            this.MovieListBox.Location = new System.Drawing.Point(7, 28);
            this.MovieListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(172, 404);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // RectangelGroupBox
            // 
            this.RectangelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangelGroupBox.Controls.Add(this.IdClassesLabel);
            this.RectangelGroupBox.Controls.Add(this.IdClassesTextBox);
            this.RectangelGroupBox.Controls.Add(this.CoordinateYLabel);
            this.RectangelGroupBox.Controls.Add(this.CoordinateXLabel);
            this.RectangelGroupBox.Controls.Add(this.CoordinateYTextBox);
            this.RectangelGroupBox.Controls.Add(this.CoordinateXTextBox);
            this.RectangelGroupBox.Controls.Add(this.FindRectangelButton);
            this.RectangelGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangelGroupBox.Controls.Add(this.ColorLabel);
            this.RectangelGroupBox.Controls.Add(this.WidthClassesTextBox);
            this.RectangelGroupBox.Controls.Add(this.WidthClassesLabel);
            this.RectangelGroupBox.Controls.Add(this.LengthClassesTextBox);
            this.RectangelGroupBox.Controls.Add(this.LengthClassesLabel);
            this.RectangelGroupBox.Controls.Add(this.RectanglesClassesListBox);
            this.RectangelGroupBox.Location = new System.Drawing.Point(9, 7);
            this.RectangelGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangelGroupBox.Name = "RectangelGroupBox";
            this.RectangelGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangelGroupBox.Size = new System.Drawing.Size(426, 549);
            this.RectangelGroupBox.TabIndex = 0;
            this.RectangelGroupBox.TabStop = false;
            this.RectangelGroupBox.Text = "Rectangles";
            // 
            // IdClassesLabel
            // 
            this.IdClassesLabel.AutoSize = true;
            this.IdClassesLabel.Location = new System.Drawing.Point(189, 320);
            this.IdClassesLabel.Name = "IdClassesLabel";
            this.IdClassesLabel.Size = new System.Drawing.Size(92, 20);
            this.IdClassesLabel.TabIndex = 13;
            this.IdClassesLabel.Text = "Rectangle id";
            // 
            // IdClassesTextBox
            // 
            this.IdClassesTextBox.Location = new System.Drawing.Point(189, 344);
            this.IdClassesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdClassesTextBox.Name = "IdClassesTextBox";
            this.IdClassesTextBox.ReadOnly = true;
            this.IdClassesTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdClassesTextBox.TabIndex = 12;
            // 
            // CoordinateYLabel
            // 
            this.CoordinateYLabel.AutoSize = true;
            this.CoordinateYLabel.Location = new System.Drawing.Point(189, 263);
            this.CoordinateYLabel.Name = "CoordinateYLabel";
            this.CoordinateYLabel.Size = new System.Drawing.Size(115, 20);
            this.CoordinateYLabel.TabIndex = 11;
            this.CoordinateYLabel.Text = "Coordinate by Y";
            // 
            // CoordinateXLabel
            // 
            this.CoordinateXLabel.AutoSize = true;
            this.CoordinateXLabel.Location = new System.Drawing.Point(189, 204);
            this.CoordinateXLabel.Name = "CoordinateXLabel";
            this.CoordinateXLabel.Size = new System.Drawing.Size(114, 20);
            this.CoordinateXLabel.TabIndex = 10;
            this.CoordinateXLabel.Text = "Coordinate by x";
            // 
            // CoordinateYTextBox
            // 
            this.CoordinateYTextBox.Location = new System.Drawing.Point(189, 287);
            this.CoordinateYTextBox.Name = "CoordinateYTextBox";
            this.CoordinateYTextBox.ReadOnly = true;
            this.CoordinateYTextBox.Size = new System.Drawing.Size(125, 27);
            this.CoordinateYTextBox.TabIndex = 9;
            // 
            // CoordinateXTextBox
            // 
            this.CoordinateXTextBox.Location = new System.Drawing.Point(189, 228);
            this.CoordinateXTextBox.Name = "CoordinateXTextBox";
            this.CoordinateXTextBox.ReadOnly = true;
            this.CoordinateXTextBox.Size = new System.Drawing.Size(127, 27);
            this.CoordinateXTextBox.TabIndex = 8;
            // 
            // FindRectangelButton
            // 
            this.FindRectangelButton.Location = new System.Drawing.Point(189, 403);
            this.FindRectangelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FindRectangelButton.Name = "FindRectangelButton";
            this.FindRectangelButton.Size = new System.Drawing.Size(127, 31);
            this.FindRectangelButton.TabIndex = 7;
            this.FindRectangelButton.Text = "Find";
            this.FindRectangelButton.UseVisualStyleBackColor = true;
            this.FindRectangelButton.Click += new System.EventHandler(this.FindRectangelButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(189, 169);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(127, 27);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(189, 145);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 20);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WidthClassesTextBox
            // 
            this.WidthClassesTextBox.Location = new System.Drawing.Point(189, 111);
            this.WidthClassesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WidthClassesTextBox.Name = "WidthClassesTextBox";
            this.WidthClassesTextBox.Size = new System.Drawing.Size(127, 27);
            this.WidthClassesTextBox.TabIndex = 4;
            this.WidthClassesTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthClassesLabel
            // 
            this.WidthClassesLabel.AutoSize = true;
            this.WidthClassesLabel.Location = new System.Drawing.Point(189, 87);
            this.WidthClassesLabel.Name = "WidthClassesLabel";
            this.WidthClassesLabel.Size = new System.Drawing.Size(49, 20);
            this.WidthClassesLabel.TabIndex = 3;
            this.WidthClassesLabel.Text = "Width";
            // 
            // LengthClassesTextBox
            // 
            this.LengthClassesTextBox.Location = new System.Drawing.Point(189, 52);
            this.LengthClassesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LengthClassesTextBox.Name = "LengthClassesTextBox";
            this.LengthClassesTextBox.Size = new System.Drawing.Size(127, 27);
            this.LengthClassesTextBox.TabIndex = 2;
            this.LengthClassesTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthClassesLabel
            // 
            this.LengthClassesLabel.AutoSize = true;
            this.LengthClassesLabel.Location = new System.Drawing.Point(189, 28);
            this.LengthClassesLabel.Name = "LengthClassesLabel";
            this.LengthClassesLabel.Size = new System.Drawing.Size(54, 20);
            this.LengthClassesLabel.TabIndex = 1;
            this.LengthClassesLabel.Text = "Length";
            // 
            // RectanglesClassesListBox
            // 
            this.RectanglesClassesListBox.FormattingEnabled = true;
            this.RectanglesClassesListBox.ItemHeight = 20;
            this.RectanglesClassesListBox.Items.AddRange(new object[] {
            "Rectangle1",
            "Rectangle2",
            "Rectangle3",
            "Rectangle4",
            "Rectangle5"});
            this.RectanglesClassesListBox.Location = new System.Drawing.Point(9, 28);
            this.RectanglesClassesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesClassesListBox.Name = "RectanglesClassesListBox";
            this.RectanglesClassesListBox.Size = new System.Drawing.Size(172, 404);
            this.RectanglesClassesListBox.TabIndex = 0;
            this.RectanglesClassesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesTabPage.Controls.Add(this.RectanglePanel);
            this.RectanglesTabPage.Controls.Add(this.HeightLabel);
            this.RectanglesTabPage.Controls.Add(this.WidthLable);
            this.RectanglesTabPage.Controls.Add(this.YLabel);
            this.RectanglesTabPage.Controls.Add(this.XLabel);
            this.RectanglesTabPage.Controls.Add(this.HeightTextBox);
            this.RectanglesTabPage.Controls.Add(this.WidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.YTextBox);
            this.RectanglesTabPage.Controls.Add(this.XTextBox);
            this.RectanglesTabPage.Controls.Add(this.IdTextBox);
            this.RectanglesTabPage.Controls.Add(this.IdLable);
            this.RectanglesTabPage.Controls.Add(this.AddRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesListBox);
            this.RectanglesTabPage.Controls.Add(this.RectanglesLabel);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Size = new System.Drawing.Size(912, 572);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglePanel.AutoSize = true;
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(299, 35);
            this.RectanglePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(599, 518);
            this.RectanglePanel.TabIndex = 15;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(5, 520);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(57, 20);
            this.HeightLabel.TabIndex = 14;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLable
            // 
            this.WidthLable.AutoSize = true;
            this.WidthLable.Location = new System.Drawing.Point(10, 481);
            this.WidthLable.Name = "WidthLable";
            this.WidthLable.Size = new System.Drawing.Size(52, 20);
            this.WidthLable.TabIndex = 13;
            this.WidthLable.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(39, 443);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(20, 20);
            this.YLabel.TabIndex = 12;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(39, 404);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(21, 20);
            this.XLabel.TabIndex = 11;
            this.XLabel.Text = "X:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(65, 516);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(114, 27);
            this.HeightTextBox.TabIndex = 10;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(65, 477);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(114, 27);
            this.WidthTextBox.TabIndex = 9;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged_1);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(65, 439);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(114, 27);
            this.YTextBox.TabIndex = 8;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(65, 400);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(114, 27);
            this.XTextBox.TabIndex = 7;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(65, 361);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(114, 27);
            this.IdTextBox.TabIndex = 6;
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(35, 365);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(25, 20);
            this.IdLable.TabIndex = 5;
            this.IdLable.Text = "Id:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(10, 288);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(29, 33);
            this.AddRectangleButton.TabIndex = 4;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(46, 288);
            this.DeleteRectangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(29, 33);
            this.DeleteRectangleButton.TabIndex = 3;
            this.DeleteRectangleButton.UseVisualStyleBackColor = false;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(10, 325);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 2;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(10, 35);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(282, 244);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged_1);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(8, 8);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(81, 20);
            this.RectanglesLabel.TabIndex = 0;
            this.RectanglesLabel.Text = "Rectangles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 605);
            this.Controls.Add(this.EnumsAndClassesTabControl);
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
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
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
        private TextBox WidthClassesTextBox;
        private Label WidthClassesLabel;
        private TextBox LengthClassesTextBox;
        private Label LengthClassesLabel;
        private ListBox RectanglesClassesListBox;
        private TextBox DurationInMinutesTextBox;
        private Label DurationInMinutesLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Label CoordinateYLabel;
        private Label CoordinateXLabel;
        private TextBox CoordinateYTextBox;
        private TextBox CoordinateXTextBox;
        private TextBox IdClassesTextBox;
        private Label IdClassesLabel;
        private TabPage RectanglesTabPage;
        private Label HeightLabel;
        private Label WidthLable;
        private Label YLabel;
        private Label XLabel;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox YTextBox;
        private TextBox XTextBox;
        private TextBox IdTextBox;
        private Label IdLable;
        private Button AddRectangleButton;
        private Button DeleteRectangleButton;
        private Label SelectedRectangleLabel;
        private ListBox RectanglesListBox;
        private Label RectanglesLabel;
        private Panel RectanglePanel;
    }
}