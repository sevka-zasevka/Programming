namespace ObjectOrientedPractices.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            PercentDiscountLabel = new Label();
            CategoryComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            CategoryLabel = new Label();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PercentDiscountLabel.Location = new Point(12, 9);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(132, 20);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(90, 41);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(194, 28);
            CategoryComboBox.TabIndex = 1;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(90, 86);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 2;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(190, 86);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 41);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 4;
            CategoryLabel.Text = "Category:";
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 125);
            Controls.Add(CategoryLabel);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(PercentDiscountLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(314, 172);
            MinimumSize = new Size(314, 172);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private ComboBox CategoryComboBox;
        private Button OkButton;
        private Button CancelButton;
        private Label CategoryLabel;
    }
}