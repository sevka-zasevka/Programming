namespace Programming.View.EnumsControl
{
    partial class SeasonHandleGrupBoxControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoSeasonButton = new System.Windows.Forms.Button();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.GoSeasonButton);
            this.SeasonGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(367, 134);
            this.SeasonGroupBox.TabIndex = 3;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SeasonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Fall"});
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 71);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(196, 28);
            this.SeasonComboBox.TabIndex = 2;
            // 
            // GoSeasonButton
            // 
            this.GoSeasonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoSeasonButton.BackColor = System.Drawing.Color.LightGray;
            this.GoSeasonButton.Location = new System.Drawing.Point(208, 69);
            this.GoSeasonButton.Name = "GoSeasonButton";
            this.GoSeasonButton.Size = new System.Drawing.Size(97, 30);
            this.GoSeasonButton.TabIndex = 1;
            this.GoSeasonButton.Text = "Go!";
            this.GoSeasonButton.UseVisualStyleBackColor = false;
            this.GoSeasonButton.Click += new System.EventHandler(this.GoSeasonButton_Click);
            // 
            // SeasonHandleGrupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonHandleGrupBoxControl";
            this.Size = new System.Drawing.Size(373, 140);
            this.SeasonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SeasonGroupBox;
        private ComboBox SeasonComboBox;
        private Button GoSeasonButton;
    }
}
