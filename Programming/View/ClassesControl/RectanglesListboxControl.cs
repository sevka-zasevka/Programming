using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.ClassesControl
{
    /// <summary>
    /// Предоставляет методы для заполнения ListBox и TextBox.
    /// </summary>
    public partial class RectanglesListboxControl : UserControl
    {
        /// <summary>
        /// Массив из пяти элементов класса <see cref="Rectangle">.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];
        /// <summary>
        /// Объект класса <see cref="Rectangle">.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();
        private Random _random = new Random();

        public RectanglesListboxControl()
        {
            InitializeComponent();

            /// <summary>
            /// Экземпляр класса <see cref="Rectangle">.
            /// </summary>
            Rectangle exampleRectangle = new Rectangle();

            /// <summary>
            /// Цикл для заполнения массива объектями класса <see cref="Rectangle">.
            /// </summary>
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(_random.Next(1, 100), _random.Next(1, 100), Enum.GetName(typeof(Colors), _random.Next(1, 7)), _random.Next(1, 100), _random.Next(1, 100));
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesClassesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            LengthClassesTextBox.Text = _currentRectangle.Length.ToString();
            WidthClassesTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            CoordinateXTextBox.Text = _currentRectangle.Centre.X.ToString();
            CoordinateYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            IdClassesTextBox.Text = _currentRectangle.Id.ToString();
            if (_currentRectangle != _rectangles[value])
            {
                _rectangles[value] = _currentRectangle;
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newLength = (int)Convert.ToInt64(LengthClassesTextBox.Text);
                _currentRectangle.Length = newLength;
                LengthClassesTextBox.BackColor = AppColors.White;
            }
            catch
            {
                LengthClassesTextBox.BackColor = AppColors.Lightpink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newWidth = (int)Convert.ToInt64(WidthClassesTextBox.Text);
                _currentRectangle.Width = newWidth;
                WidthClassesTextBox.BackColor = AppColors.White;
            }
            catch
            {
                WidthClassesTextBox.BackColor = AppColors.Lightpink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newColor = Convert.ToString(ColorTextBox.Text);
            _currentRectangle.Color = newColor;
        }

        /// <summary>
        /// Метод для отыскания прямоугольника с максимальной шириной из массива.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Возращает индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidth = 0;
            int indexMaxWidth = -1;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        private void FindRectangelButton_Click(object sender, EventArgs e)
        {
            RectanglesClassesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
