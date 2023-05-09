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
            this.SeasonHandleGrupBoxControl = new Programming.View.EnumsControl.SeasonHandleGrupBoxControl();
            this.WeekdayParsingGrupBoxControl = new Programming.View.EnumsControl.WeekdayParsingGrupBoxControl();
            this.EnumirationsGrupBoxControl = new Programming.View.EnumsControl.EnumirationsGrupBoxControl();
            this.EnumsAndClassesTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.movieListboxControl1 = new Programming.View.ClassesControl.MovieListboxControl();
            this.rectanglesListboxControl1 = new Programming.View.ClassesControl.RectanglesListboxControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.RectanglesCollisionControl.RectanglesCollisionControl();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsAndClassesTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGrupBoxControl);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGrupBoxControl);
            this.EnumsTabPage.Controls.Add(this.EnumirationsGrupBoxControl);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(841, 586);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGrupBoxControl
            // 
            this.SeasonHandleGrupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGrupBoxControl.Location = new System.Drawing.Point(472, 320);
            this.SeasonHandleGrupBoxControl.Name = "SeasonHandleGrupBoxControl";
            this.SeasonHandleGrupBoxControl.Size = new System.Drawing.Size(363, 257);
            this.SeasonHandleGrupBoxControl.TabIndex = 5;
            // 
            // WeekdayParsingGrupBoxControl
            // 
            this.WeekdayParsingGrupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingGrupBoxControl.Location = new System.Drawing.Point(6, 320);
            this.WeekdayParsingGrupBoxControl.Name = "WeekdayParsingGrupBoxControl";
            this.WeekdayParsingGrupBoxControl.Size = new System.Drawing.Size(460, 257);
            this.WeekdayParsingGrupBoxControl.TabIndex = 4;
            // 
            // EnumirationsGrupBoxControl
            // 
            this.EnumirationsGrupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumirationsGrupBoxControl.Location = new System.Drawing.Point(6, 0);
            this.EnumirationsGrupBoxControl.Name = "EnumirationsGrupBoxControl";
            this.EnumirationsGrupBoxControl.Size = new System.Drawing.Size(829, 318);
            this.EnumirationsGrupBoxControl.TabIndex = 3;
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
            this.EnumsAndClassesTabControl.Size = new System.Drawing.Size(908, 602);
            this.EnumsAndClassesTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(841, 586);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.movieListboxControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rectanglesListboxControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // movieListboxControl1
            // 
            this.movieListboxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieListboxControl1.Location = new System.Drawing.Point(420, 3);
            this.movieListboxControl1.Name = "movieListboxControl1";
            this.movieListboxControl1.Size = new System.Drawing.Size(412, 574);
            this.movieListboxControl1.TabIndex = 0;
            // 
            // rectanglesListboxControl1
            // 
            this.rectanglesListboxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesListboxControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesListboxControl1.Name = "rectanglesListboxControl1";
            this.rectanglesListboxControl1.Size = new System.Drawing.Size(411, 574);
            this.rectanglesListboxControl1.TabIndex = 1;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Size = new System.Drawing.Size(900, 569);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, 4);
            this.RectanglesCollisionControl.MinimumSize = new System.Drawing.Size(901, 585);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(901, 585);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 602);
            this.Controls.Add(this.EnumsAndClassesTabControl);
            this.MinimumSize = new System.Drawing.Size(734, 649);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsAndClassesTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage EnumsTabPage;
        private TabControl EnumsAndClassesTabControl;
        private TabPage ClassesTabPage;
        private TabPage RectanglesTabPage;
        private View.RectanglesCollisionControl.RectanglesCollisionControl RectanglesCollisionControl;
        private View.EnumsControl.EnumirationsGrupBoxControl EnumirationsGrupBoxControl;
        private View.EnumsControl.WeekdayParsingGrupBoxControl WeekdayParsingGrupBoxControl;
        private View.EnumsControl.SeasonHandleGrupBoxControl SeasonHandleGrupBoxControl;
        private TableLayoutPanel tableLayoutPanel1;
        private View.ClassesControl.MovieListboxControl movieListboxControl1;
        private View.ClassesControl.RectanglesListboxControl rectanglesListboxControl1;
    }
}