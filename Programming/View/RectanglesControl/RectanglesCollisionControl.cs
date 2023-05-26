using Programming.Model.Class;
using Rectangle = Programming.Model.Class.Rectangle;

namespace Programming.View.RectanglesCollisionControl
{
    /// <summary>
    /// Предоставляет методы для создания объектов и вывода их на панель.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Rectangle">.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        /// <summary>
        /// Экземпляр объекта класса <see cref="Rectangle">.
        /// </summary>
        private Rectangle _currentRectangleList = new Rectangle();
        /// <summary>
        /// Список панелей.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Экземпляр класса <see cref="Random"/>.
        /// </summary>
        private Random _random = new Random();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            int panelWidth = Convert.ToInt32(RectanglePanel.Size.Width);
            int panelHeight = Convert.ToInt32(RectanglePanel.Size.Height);
            var rectangle = new Rectangle(_random.Next(1, 100), _random.Next(1, 100), Enum.GetName(typeof(Colors), _random.Next(1, 7)), _random.Next(5, panelWidth - 5), _random.Next(5, panelHeight - 5));
            _rectanglesList.Add(rectangle);
            RectanglesPanelListBox.Items.Add(LineToOutput(rectangle));
            var panel = new Panel();
            int x = rectangle.Centre.X - rectangle.Width / 2;
            int y = rectangle.Centre.Y - rectangle.Length / 2;
            panel.Location = new Point(x, y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Length;
            panel.BackColor = AppColors.Blue;
            _rectanglePanels.Add(panel);
            IsPanelCollision(_rectanglesList);
            RectanglePanel.Controls.Add(panel);
        }

        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value != -1)
            {
                RectanglesPanelListBox.Items.RemoveAt(value);
                _rectanglesList.RemoveAt(value);
                _rectanglePanels.RemoveAt(value);
                RectanglePanel.Controls.RemoveAt(value);
            }
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value != -1)
            {
                _currentRectangleList = _rectanglesList[value];
                if (IdTextBox.Text == "" || _currentRectangleList.Id != Convert.ToInt64(IdTextBox.Text))
                {
                    HeightTextBox.Text = _currentRectangleList.Length.ToString();
                    WidthTextBox.Text = _currentRectangleList.Width.ToString();
                    XTextBox.Text = _currentRectangleList.Centre.X.ToString();
                    YTextBox.Text = _currentRectangleList.Centre.Y.ToString();
                    IdTextBox.Text = _currentRectangleList.Id.ToString();
                }
            }
            else
            {
                HeightTextBox.Clear();
                WidthTextBox.Clear();
                XTextBox.Clear();
                YTextBox.Clear();
                IdTextBox.Clear();
            }
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value == -1)
            {
                XTextBox.BackColor = AppColors.White;
            }
            else
            {
                try
                {
                    int newX = (int)Convert.ToInt64(XTextBox.Text);
                    if (newX != _currentRectangleList.Centre.X)
                    {
                        _currentRectangleList.Centre.X = newX;
                        XTextBox.BackColor = AppColors.White;
                        int currentSelection = XTextBox.SelectionStart;
                        RectanglesPanelListBox.Items[value] = LineToOutput(_currentRectangleList);
                        XTextBox.Focus();
                        XTextBox.SelectionStart = currentSelection;
                        int x = _currentRectangleList.Centre.X - _currentRectangleList.Width / 2;
                        int y = _currentRectangleList.Centre.Y - _currentRectangleList.Length / 2;
                        _rectanglePanels[value].Location = new Point(x, y);
                        IsPanelCollision(_rectanglesList);
                    }
                }
                catch
                {
                    XTextBox.BackColor = AppColors.Lightpink;
                }
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value == -1)
            {
                YTextBox.BackColor = AppColors.White;
            }
            else
            {
                try
                {
                    int newY = (int)Convert.ToInt64(YTextBox.Text);
                    if (newY != _currentRectangleList.Centre.Y)
                    {
                        _currentRectangleList.Centre.Y = newY;
                        YTextBox.BackColor = AppColors.White;
                        int currentSelection = YTextBox.SelectionStart;
                        RectanglesPanelListBox.Items[value] = LineToOutput(_currentRectangleList);
                        YTextBox.Focus();
                        YTextBox.SelectionStart = currentSelection;
                        int x = _currentRectangleList.Centre.X - _currentRectangleList.Width / 2;
                        int y = _currentRectangleList.Centre.Y - _currentRectangleList.Length / 2;
                        _rectanglePanels[value].Location = new Point(x, y);
                        IsPanelCollision(_rectanglesList);
                    }
                }
                catch
                {
                    YTextBox.BackColor = AppColors.Lightpink;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value == -1)
            {
                WidthTextBox.BackColor = AppColors.White;
            }
            else
            {
                try
                {
                    int newW = (int)Convert.ToInt64(WidthTextBox.Text);
                    if (newW != _currentRectangleList.Width)
                    {
                        _currentRectangleList.Width = newW;
                        WidthTextBox.BackColor = AppColors.White;
                        int currentSelection = WidthTextBox.SelectionStart;
                        RectanglesPanelListBox.Items[value] = LineToOutput(_currentRectangleList);
                        WidthTextBox.Focus();
                        WidthTextBox.SelectionStart = currentSelection;
                        _rectanglePanels[value].Width = _currentRectangleList.Width;
                        IsPanelCollision(_rectanglesList);
                    }
                }
                catch
                {
                    WidthTextBox.BackColor = AppColors.Lightpink;
                }
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = RectanglesPanelListBox.SelectedIndex;
            if (value == -1)
            {
                HeightTextBox.BackColor = AppColors.White;
            }
            else
            {
                try
                {
                    int newH = (int)Convert.ToInt64(HeightTextBox.Text);
                    if (newH != _currentRectangleList.Length)
                    {
                        _currentRectangleList.Length = newH;
                        HeightTextBox.BackColor = AppColors.White;
                        int currentSelection = HeightTextBox.SelectionStart;
                        RectanglesPanelListBox.Items[value] = LineToOutput(_currentRectangleList);
                        HeightTextBox.Focus();
                        HeightTextBox.SelectionStart = currentSelection;
                        _rectanglePanels[value].Height = _currentRectangleList.Length;
                        IsPanelCollision(_rectanglesList);
                    }
                }
                catch
                {
                    HeightTextBox.BackColor = AppColors.Lightpink;
                }
            }
        }

        /// <summary>
        /// Метод для создания строки со значениями прямоугольника.
        /// </summary>
        /// <param name="rectangle">Объект класса <see cref="Rectangle">, по значениям полей которого надо сохдать строку.</param>
        /// <returns>Строка со значениями прямоугольника.</returns>
        private string LineToOutput(Rectangle rectangle)
        {
            string id = Convert.ToString(rectangle.Id);
            string x = Convert.ToString(rectangle.Centre.X);
            string y = Convert.ToString(rectangle.Centre.Y);
            string w = Convert.ToString(rectangle.Width);
            string l = Convert.ToString(rectangle.Length);
            string line = id + ":(X=" + x + ";Y=" + y + ";W=" + w + ";L=" + l + ")";
            return line;
        }

        /// <summary>
        /// Метод для поиска и перекрашивания панелей пересекающихся прямоугольников.
        /// </summary>
        /// <param name="rectangleList">Список прямоугольников.</param>
        private void IsPanelCollision(List<Rectangle> rectangleList)
        {
            int value = rectangleList.Count;
            for (int i = 0; i < value; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.Blue;
            }

            for (int i = 0; i < value; i++)
            {
                for (int j = i; j < value; j++)
                {
                    if (i != j)
                    {
                        if (CollisionManager.IsCollision(rectangleList[j], rectangleList[i]))
                        {
                            _rectanglePanels[j].BackColor = AppColors.Lightpink;
                            _rectanglePanels[i].BackColor = AppColors.Lightpink;
                        }
                    }
                }
            }
        }

    }
}
