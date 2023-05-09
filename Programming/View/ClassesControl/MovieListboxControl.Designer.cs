namespace Programming.View.ClassesControl
{
    partial class MovieListboxControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.MovieGroupBox.Location = new System.Drawing.Point(3, 4);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieGroupBox.Size = new System.Drawing.Size(345, 462);
            this.MovieGroupBox.TabIndex = 2;
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
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(186, 264);
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
            this.GenreLabel.Location = new System.Drawing.Point(186, 146);
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
            this.YearOfIssueLabel.Location = new System.Drawing.Point(186, 205);
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
            this.RatingLabel.Location = new System.Drawing.Point(186, 88);
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
            this.TitleLabel.Location = new System.Drawing.Point(186, 29);
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
            // MovieListboxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MovieListboxControl";
            this.Size = new System.Drawing.Size(351, 470);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MovieGroupBox;
        private TextBox DurationInMinutesTextBox;
        private Label DurationInMinutesLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Button FindMovieButton;
        private TextBox YearOfIssueTextBox;
        private Label YearOfIssueLabel;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private ListBox MovieListBox;
    }
}
