namespace Programming.View.EnumsControl
{
    partial class WeekdayParsingGrupBoxControl
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
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayMessageTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekdayGroupBox.Controls.Add(this.WeekdayMessageTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.TypeWeekdayLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(310, 188);
            this.WeekdayGroupBox.TabIndex = 2;
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
            // WeekdayParsingGrupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayGroupBox);
            this.Name = "WeekdayParsingGrupBoxControl";
            this.Size = new System.Drawing.Size(316, 194);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox WeekdayGroupBox;
        private MaskedTextBox WeekdayMessageTextBox;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label TypeWeekdayLabel;
    }
}
