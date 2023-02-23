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
            this.groupBoxSeason = new System.Windows.Forms.GroupBox();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.buttonGoSeason = new System.Windows.Forms.Button();
            this.groupBoxWeekday = new System.Windows.Forms.GroupBox();
            this.textBoxWeekdayMessage = new System.Windows.Forms.MaskedTextBox();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxWeekday = new System.Windows.Forms.TextBox();
            this.labelTypeweekday = new System.Windows.Forms.Label();
            this.groupBoxEnumiration = new System.Windows.Forms.GroupBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelChooseValue = new System.Windows.Forms.Label();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.labelEnumiration = new System.Windows.Forms.Label();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.tabControlEnums = new System.Windows.Forms.TabControl();
            this.Enums.SuspendLayout();
            this.groupBoxSeason.SuspendLayout();
            this.groupBoxWeekday.SuspendLayout();
            this.groupBoxEnumiration.SuspendLayout();
            this.tabControlEnums.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.groupBoxSeason);
            this.Enums.Controls.Add(this.groupBoxWeekday);
            this.Enums.Controls.Add(this.groupBoxEnumiration);
            this.Enums.Location = new System.Drawing.Point(4, 29);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1088, 509);
            this.Enums.TabIndex = 1;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeason
            // 
            this.groupBoxSeason.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSeason.Controls.Add(this.comboBoxSeason);
            this.groupBoxSeason.Controls.Add(this.buttonGoSeason);
            this.groupBoxSeason.Location = new System.Drawing.Point(558, 320);
            this.groupBoxSeason.Name = "groupBoxSeason";
            this.groupBoxSeason.Size = new System.Drawing.Size(524, 181);
            this.groupBoxSeason.TabIndex = 2;
            this.groupBoxSeason.TabStop = false;
            this.groupBoxSeason.Text = "Season Handle";
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Fall"});
            this.comboBoxSeason.Location = new System.Drawing.Point(6, 71);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(181, 28);
            this.comboBoxSeason.TabIndex = 2;
            // 
            // buttonGoSeason
            // 
            this.buttonGoSeason.BackColor = System.Drawing.Color.LightGray;
            this.buttonGoSeason.Location = new System.Drawing.Point(193, 69);
            this.buttonGoSeason.Name = "buttonGoSeason";
            this.buttonGoSeason.Size = new System.Drawing.Size(93, 30);
            this.buttonGoSeason.TabIndex = 1;
            this.buttonGoSeason.Text = "Go!";
            this.buttonGoSeason.UseVisualStyleBackColor = false;
            this.buttonGoSeason.Click += new System.EventHandler(this.buttonGoSeason_Click);
            // 
            // groupBoxWeekday
            // 
            this.groupBoxWeekday.Controls.Add(this.textBoxWeekdayMessage);
            this.groupBoxWeekday.Controls.Add(this.buttonParse);
            this.groupBoxWeekday.Controls.Add(this.textBoxWeekday);
            this.groupBoxWeekday.Controls.Add(this.labelTypeweekday);
            this.groupBoxWeekday.Location = new System.Drawing.Point(12, 320);
            this.groupBoxWeekday.Name = "groupBoxWeekday";
            this.groupBoxWeekday.Size = new System.Drawing.Size(522, 181);
            this.groupBoxWeekday.TabIndex = 1;
            this.groupBoxWeekday.TabStop = false;
            this.groupBoxWeekday.Text = "Weekday Parsing";
            // 
            // textBoxWeekdayMessage
            // 
            this.textBoxWeekdayMessage.Location = new System.Drawing.Point(9, 136);
            this.textBoxWeekdayMessage.Name = "textBoxWeekdayMessage";
            this.textBoxWeekdayMessage.Size = new System.Drawing.Size(286, 27);
            this.textBoxWeekdayMessage.TabIndex = 3;
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(201, 69);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(94, 29);
            this.buttonParse.TabIndex = 2;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // textBoxWeekday
            // 
            this.textBoxWeekday.Location = new System.Drawing.Point(9, 71);
            this.textBoxWeekday.Name = "textBoxWeekday";
            this.textBoxWeekday.Size = new System.Drawing.Size(186, 27);
            this.textBoxWeekday.TabIndex = 1;
            // 
            // labelTypeweekday
            // 
            this.labelTypeweekday.AutoSize = true;
            this.labelTypeweekday.Location = new System.Drawing.Point(6, 45);
            this.labelTypeweekday.Name = "labelTypeweekday";
            this.labelTypeweekday.Size = new System.Drawing.Size(162, 20);
            this.labelTypeweekday.TabIndex = 0;
            this.labelTypeweekday.Text = "Type value for parsing: ";
            // 
            // groupBoxEnumiration
            // 
            this.groupBoxEnumiration.Controls.Add(this.labelValue);
            this.groupBoxEnumiration.Controls.Add(this.textBoxValue);
            this.groupBoxEnumiration.Controls.Add(this.labelChooseValue);
            this.groupBoxEnumiration.Controls.Add(this.listBoxValue);
            this.groupBoxEnumiration.Controls.Add(this.labelEnumiration);
            this.groupBoxEnumiration.Controls.Add(this.listBoxEnums);
            this.groupBoxEnumiration.Location = new System.Drawing.Point(8, 6);
            this.groupBoxEnumiration.Name = "groupBoxEnumiration";
            this.groupBoxEnumiration.Size = new System.Drawing.Size(1074, 304);
            this.groupBoxEnumiration.TabIndex = 0;
            this.groupBoxEnumiration.TabStop = false;
            this.groupBoxEnumiration.Text = "Enumirations";
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(401, 27);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(125, 25);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "Int value:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(401, 54);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Text = "1";
            // 
            // labelChooseValue
            // 
            this.labelChooseValue.AutoSize = true;
            this.labelChooseValue.Location = new System.Drawing.Point(205, 32);
            this.labelChooseValue.Name = "labelChooseValue";
            this.labelChooseValue.Size = new System.Drawing.Size(100, 20);
            this.labelChooseValue.TabIndex = 3;
            this.labelChooseValue.Text = "Choose value:";
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 20;
            this.listBoxValue.Location = new System.Drawing.Point(205, 54);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(193, 244);
            this.listBoxValue.TabIndex = 2;
            this.listBoxValue.SelectedIndexChanged += new System.EventHandler(this.listBoxValue_SelectedIndexChanged);
            // 
            // labelEnumiration
            // 
            this.labelEnumiration.AutoSize = true;
            this.labelEnumiration.Location = new System.Drawing.Point(6, 31);
            this.labelEnumiration.Name = "labelEnumiration";
            this.labelEnumiration.Size = new System.Drawing.Size(151, 20);
            this.labelEnumiration.TabIndex = 1;
            this.labelEnumiration.Text = "Choose enumirations:";
            // 
            // listBoxEnums
            // 
            this.listBoxEnums.FormattingEnabled = true;
            this.listBoxEnums.ItemHeight = 20;
            this.listBoxEnums.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.listBoxEnums.Location = new System.Drawing.Point(6, 54);
            this.listBoxEnums.Name = "listBoxEnums";
            this.listBoxEnums.Size = new System.Drawing.Size(193, 244);
            this.listBoxEnums.TabIndex = 0;
            this.listBoxEnums.SelectedIndexChanged += new System.EventHandler(this.listBoxEnums_SelectedIndexChanged);
            // 
            // tabControlEnums
            // 
            this.tabControlEnums.Controls.Add(this.Enums);
            this.tabControlEnums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEnums.Location = new System.Drawing.Point(0, 0);
            this.tabControlEnums.Name = "tabControlEnums";
            this.tabControlEnums.SelectedIndex = 0;
            this.tabControlEnums.Size = new System.Drawing.Size(1096, 542);
            this.tabControlEnums.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 542);
            this.Controls.Add(this.tabControlEnums);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Enums.ResumeLayout(false);
            this.groupBoxSeason.ResumeLayout(false);
            this.groupBoxWeekday.ResumeLayout(false);
            this.groupBoxWeekday.PerformLayout();
            this.groupBoxEnumiration.ResumeLayout(false);
            this.groupBoxEnumiration.PerformLayout();
            this.tabControlEnums.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage Enums;
        private GroupBox groupBoxEnumiration;
        private Label labelValue;
        private TextBox textBoxValue;
        private Label labelChooseValue;
        private ListBox listBoxValue;
        private Label labelEnumiration;
        private ListBox listBoxEnums;
        private TabControl tabControlEnums;
        private GroupBox groupBoxWeekday;
        private Button buttonParse;
        private TextBox textBoxWeekday;
        private Label labelTypeweekday;
        private GroupBox groupBoxSeason;
        private Button buttonGoSeason;
        private MaskedTextBox textBoxWeekdayMessage;
        private ComboBox comboBoxSeason;
    }
}