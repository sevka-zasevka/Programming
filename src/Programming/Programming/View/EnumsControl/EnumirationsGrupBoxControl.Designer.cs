namespace Programming.View.EnumsControl
{
    partial class EnumirationsGrupBoxControl
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
            this.EnumirationGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumirationLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumirationGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.EnumirationGroupBox.Location = new System.Drawing.Point(0, 3);
            this.EnumirationGroupBox.Name = "EnumirationGroupBox";
            this.EnumirationGroupBox.Size = new System.Drawing.Size(674, 312);
            this.EnumirationGroupBox.TabIndex = 1;
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
            // EnumirationsGrupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumirationGroupBox);
            this.Name = "EnumirationsGrupBoxControl";
            this.Size = new System.Drawing.Size(677, 318);
            this.EnumirationGroupBox.ResumeLayout(false);
            this.EnumirationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox EnumirationGroupBox;
        private Label ValueLabel;
        private TextBox ValueTextBox;
        private Label ChooseValueLabel;
        private ListBox ValueListBox;
        private Label EnumirationLabel;
        private ListBox EnumsListBox;
    }
}
