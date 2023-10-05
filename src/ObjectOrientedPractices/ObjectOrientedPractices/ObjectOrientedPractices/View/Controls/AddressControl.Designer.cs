namespace ObjectOrientedPractices.View.Controls
{
    partial class AddressControl
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
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            ApartmentLabel = new Label();
            ValidationPostIndexLabel = new Label();
            ValidationCountryLabel = new Label();
            ValidationStreetLabel = new Label();
            ValidationBuildingLabel = new Label();
            ValidationCityLabel = new Label();
            ValidationApartmentLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            CityTextBox = new TextBox();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeliveryAddressLabel.Location = new Point(3, 0);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(128, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(3, 31);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(79, 20);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(3, 69);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(295, 69);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(3, 129);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(3, 188);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 5;
            BuildingLabel.Text = "Building:";
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(206, 188);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 6;
            ApartmentLabel.Text = "Apartment:";
            // 
            // ValidationPostIndexLabel
            // 
            ValidationPostIndexLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ValidationPostIndexLabel.AutoSize = true;
            ValidationPostIndexLabel.Location = new Point(206, 31);
            ValidationPostIndexLabel.Name = "ValidationPostIndexLabel";
            ValidationPostIndexLabel.Size = new Size(259, 20);
            ValidationPostIndexLabel.TabIndex = 7;
            ValidationPostIndexLabel.Text = "Post index must be a six digit number.";
            ValidationPostIndexLabel.Visible = false;
            // 
            // ValidationCountryLabel
            // 
            ValidationCountryLabel.AutoSize = true;
            ValidationCountryLabel.Location = new Point(3, 100);
            ValidationCountryLabel.Name = "ValidationCountryLabel";
            ValidationCountryLabel.Size = new Size(318, 20);
            ValidationCountryLabel.TabIndex = 8;
            ValidationCountryLabel.Text = "Country name must be from 0 to 50 characters.";
            ValidationCountryLabel.Visible = false;
            // 
            // ValidationStreetLabel
            // 
            ValidationStreetLabel.AutoSize = true;
            ValidationStreetLabel.Location = new Point(3, 160);
            ValidationStreetLabel.Name = "ValidationStreetLabel";
            ValidationStreetLabel.Size = new Size(314, 20);
            ValidationStreetLabel.TabIndex = 9;
            ValidationStreetLabel.Text = "Street name must be from 0 to 100 characters.";
            ValidationStreetLabel.Visible = false;
            // 
            // ValidationBuildingLabel
            // 
            ValidationBuildingLabel.AutoSize = true;
            ValidationBuildingLabel.Location = new Point(3, 219);
            ValidationBuildingLabel.Name = "ValidationBuildingLabel";
            ValidationBuildingLabel.Size = new Size(364, 20);
            ValidationBuildingLabel.TabIndex = 10;
            ValidationBuildingLabel.Text = "The building number must be from 0 to 10 characters.";
            ValidationBuildingLabel.Visible = false;
            // 
            // ValidationCityLabel
            // 
            ValidationCityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ValidationCityLabel.AutoSize = true;
            ValidationCityLabel.Location = new Point(295, 100);
            ValidationCityLabel.Name = "ValidationCityLabel";
            ValidationCityLabel.Size = new Size(292, 20);
            ValidationCityLabel.TabIndex = 11;
            ValidationCityLabel.Text = "City name must be from 0 to 50 characters.";
            ValidationCityLabel.Visible = false;
            // 
            // ValidationApartmentLabel
            // 
            ValidationApartmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ValidationApartmentLabel.AutoSize = true;
            ValidationApartmentLabel.Location = new Point(206, 219);
            ValidationApartmentLabel.Name = "ValidationApartmentLabel";
            ValidationApartmentLabel.Size = new Size(378, 20);
            ValidationApartmentLabel.TabIndex = 12;
            ValidationApartmentLabel.Text = "The apartment number must be from 0 to 10 characters.";
            ValidationApartmentLabel.Visible = false;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PostIndexTextBox.Enabled = false;
            PostIndexTextBox.Location = new Point(85, 27);
            PostIndexTextBox.Margin = new Padding(3, 4, 3, 4);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(114, 27);
            PostIndexTextBox.TabIndex = 13;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Enabled = false;
            CountryTextBox.Location = new Point(85, 65);
            CountryTextBox.Margin = new Padding(3, 4, 3, 4);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(190, 27);
            CountryTextBox.TabIndex = 14;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Enabled = false;
            CityTextBox.Location = new Point(337, 65);
            CityTextBox.Margin = new Padding(3, 4, 3, 4);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(190, 27);
            CityTextBox.TabIndex = 15;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Enabled = false;
            StreetTextBox.Location = new Point(85, 125);
            StreetTextBox.Margin = new Padding(3, 4, 3, 4);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(443, 27);
            StreetTextBox.TabIndex = 16;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Enabled = false;
            BuildingTextBox.Location = new Point(85, 184);
            BuildingTextBox.Margin = new Padding(3, 4, 3, 4);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(114, 27);
            BuildingTextBox.TabIndex = 17;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApartmentTextBox.Enabled = false;
            ApartmentTextBox.Location = new Point(289, 184);
            ApartmentTextBox.Margin = new Padding(3, 4, 3, 4);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(114, 27);
            ApartmentTextBox.TabIndex = 18;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(BuildingTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(ValidationApartmentLabel);
            Controls.Add(ValidationCityLabel);
            Controls.Add(ValidationBuildingLabel);
            Controls.Add(ValidationStreetLabel);
            Controls.Add(ValidationCountryLabel);
            Controls.Add(ValidationPostIndexLabel);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CityLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(563, 251);
            Name = "AddressControl";
            Size = new Size(563, 251);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private Label ApartmentLabel;
        private Label ValidationPostIndexLabel;
        private Label ValidationCountryLabel;
        private Label ValidationStreetLabel;
        private Label ValidationBuildingLabel;
        private Label ValidationCityLabel;
        private Label ValidationApartmentLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox CityTextBox;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
    }
}
