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
            this.weekdayParsingGrupBoxControl1 = new Programming.View.EnumsControl.WeekdayParsingGrupBoxControl();
            this.enumirationsGrupBoxControl1 = new Programming.View.EnumsControl.EnumirationsGrupBoxControl();
            this.EnumsAndClassesTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.movieListboxControl1 = new Programming.View.ClassesControl.MovieListboxControl();
            this.rectanglesListboxControl1 = new Programming.View.ClassesControl.RectanglesListboxControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.RectanglesCollisionControl.RectanglesCollisionControl();
            this.seasonHandleGrupBoxControl1 = new Programming.View.EnumsControl.SeasonHandleGrupBoxControl();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsAndClassesTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.seasonHandleGrupBoxControl1);
            this.EnumsTabPage.Controls.Add(this.weekdayParsingGrupBoxControl1);
            this.EnumsTabPage.Controls.Add(this.enumirationsGrupBoxControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(855, 552);
            this.EnumsTabPage.TabIndex = 1;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingGrupBoxControl1
            // 
            this.weekdayParsingGrupBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.weekdayParsingGrupBoxControl1.Location = new System.Drawing.Point(6, 320);
            this.weekdayParsingGrupBoxControl1.Name = "weekdayParsingGrupBoxControl1";
            this.weekdayParsingGrupBoxControl1.Size = new System.Drawing.Size(460, 225);
            this.weekdayParsingGrupBoxControl1.TabIndex = 4;
            // 
            // enumirationsGrupBoxControl1
            // 
            this.enumirationsGrupBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumirationsGrupBoxControl1.Location = new System.Drawing.Point(6, 0);
            this.enumirationsGrupBoxControl1.Name = "enumirationsGrupBoxControl1";
            this.enumirationsGrupBoxControl1.Size = new System.Drawing.Size(843, 314);
            this.enumirationsGrupBoxControl1.TabIndex = 3;
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
            this.EnumsAndClassesTabControl.Size = new System.Drawing.Size(863, 585);
            this.EnumsAndClassesTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.movieListboxControl1);
            this.ClassesTabPage.Controls.Add(this.rectanglesListboxControl1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(881, 610);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // movieListboxControl1
            // 
            this.movieListboxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieListboxControl1.Location = new System.Drawing.Point(348, 7);
            this.movieListboxControl1.Name = "movieListboxControl1";
            this.movieListboxControl1.Size = new System.Drawing.Size(484, 567);
            this.movieListboxControl1.TabIndex = 3;
            // 
            // rectanglesListboxControl1
            // 
            this.rectanglesListboxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectanglesListboxControl1.Location = new System.Drawing.Point(6, 7);
            this.rectanglesListboxControl1.Name = "rectanglesListboxControl1";
            this.rectanglesListboxControl1.Size = new System.Drawing.Size(353, 554);
            this.rectanglesListboxControl1.TabIndex = 2;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesTabPage.Size = new System.Drawing.Size(881, 610);
            this.RectanglesTabPage.TabIndex = 3;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 4);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(873, 600);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // seasonHandleGrupBoxControl1
            // 
            this.seasonHandleGrupBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonHandleGrupBoxControl1.Location = new System.Drawing.Point(472, 320);
            this.seasonHandleGrupBoxControl1.Name = "seasonHandleGrupBoxControl1";
            this.seasonHandleGrupBoxControl1.Size = new System.Drawing.Size(377, 223);
            this.seasonHandleGrupBoxControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 585);
            this.Controls.Add(this.EnumsAndClassesTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsAndClassesTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage EnumsTabPage;
        private TabControl EnumsAndClassesTabControl;
        private TabPage ClassesTabPage;
        private TabPage RectanglesTabPage;
        private View.RectanglesCollisionControl.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.ClassesControl.RectanglesListboxControl rectanglesListboxControl1;
        private View.ClassesControl.MovieListboxControl movieListboxControl1;
        private View.EnumsControl.EnumirationsGrupBoxControl enumirationsGrupBoxControl1;
        private View.EnumsControl.WeekdayParsingGrupBoxControl weekdayParsingGrupBoxControl1;
        private View.EnumsControl.SeasonHandleGrupBoxControl seasonHandleGrupBoxControl1;
    }
}