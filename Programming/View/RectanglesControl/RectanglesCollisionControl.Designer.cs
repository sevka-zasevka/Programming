namespace Programming.View.RectanglesCollisionControl
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
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
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglePanel.AutoSize = true;
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(314, 42);
            this.RectanglePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(553, 501);
            this.RectanglePanel.TabIndex = 31;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(20, 526);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(57, 20);
            this.HeightLabel.TabIndex = 30;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLable
            // 
            this.WidthLable.AutoSize = true;
            this.WidthLable.Location = new System.Drawing.Point(25, 487);
            this.WidthLable.Name = "WidthLable";
            this.WidthLable.Size = new System.Drawing.Size(52, 20);
            this.WidthLable.TabIndex = 29;
            this.WidthLable.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(54, 449);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(20, 20);
            this.YLabel.TabIndex = 28;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(54, 410);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(21, 20);
            this.XLabel.TabIndex = 27;
            this.XLabel.Text = "X:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(80, 522);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(114, 27);
            this.HeightTextBox.TabIndex = 26;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(80, 483);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(114, 27);
            this.WidthTextBox.TabIndex = 25;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(80, 445);
            this.YTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(114, 27);
            this.YTextBox.TabIndex = 24;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(80, 406);
            this.XTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(114, 27);
            this.XTextBox.TabIndex = 23;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(80, 367);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(114, 27);
            this.IdTextBox.TabIndex = 22;
            // 
            // IdLable
            // 
            this.IdLable.AutoSize = true;
            this.IdLable.Location = new System.Drawing.Point(50, 371);
            this.IdLable.Name = "IdLable";
            this.IdLable.Size = new System.Drawing.Size(25, 20);
            this.IdLable.TabIndex = 21;
            this.IdLable.Text = "Id:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(25, 294);
            this.AddRectangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(29, 33);
            this.AddRectangleButton.TabIndex = 20;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(61, 294);
            this.DeleteRectangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(29, 33);
            this.DeleteRectangleButton.TabIndex = 19;
            this.DeleteRectangleButton.UseVisualStyleBackColor = false;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(25, 331);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 18;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.FormattingEnabled = true;
            this.RectanglesPanelListBox.ItemHeight = 20;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(25, 41);
            this.RectanglesPanelListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(282, 244);
            this.RectanglesPanelListBox.TabIndex = 17;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(25, 17);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(81, 20);
            this.RectanglesLabel.TabIndex = 16;
            this.RectanglesLabel.Text = "Rectangles";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglePanel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLable);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLable);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.DeleteRectangleButton);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectanglesPanelListBox);
            this.Controls.Add(this.RectanglesLabel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(888, 571);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel RectanglePanel;
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
        private ListBox RectanglesPanelListBox;
        private Label RectanglesLabel;
    }
}
