using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Кр_Пз_
{
    public partial class Form1 : Form
    {
        private List<PointData> points = new List<PointData>();
        public Form1()
        {
            InitializeComponent();
            comboBoxColor.Items.Add("Red");
            comboBoxColor.Items.Add("Green");
            comboBoxColor.Items.Add("Blue");
            comboBoxColor.Items.Add("Yellow");
        }
        private void AddPoint(double x, double y, Color color)
        {
            points.Add(new PointData { X = x, Y = y, Color = color });
        }

        private void DisplayPoints(List<PointData> pointList)
        {
            richTextBoxDisplay.Clear();

            foreach (var point in pointList)
            {
                richTextBoxDisplay.AppendText($"X: {point.X}, Y: {point.Y}, Color: {point.Color}\n");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            Color color = Color.FromName(comboBoxColor.SelectedItem.ToString());

            AddPoint(x, y, color);
            DisplayPoints(points);

            textBoxX.Clear();
            textBoxY.Clear();

        }
        private List<PointData> SortPointsByColor(bool ascending)
        {
            if (ascending)
            {
                return points.OrderBy(p => p.Color.ToArgb()).ToList();
            }
            else
            {
                return points.OrderByDescending(p => p.Color.ToArgb()).ToList();
            }
        }
        private List<PointData> FindUniquePointsInCircle(double centerX, double centerY, double radius)
        {
            return points
                .Where(p => Math.Pow(p.X - centerX, 2) + Math.Pow(p.Y - centerY, 2) <= Math.Pow(radius, 2))
                .OrderByDescending(p => p.Y)
                .ToList();
        }

        private Dictionary<Color, List<PointData>> CreateColorPointTable()
        {
            var colorPointTable = points
                .GroupBy(p => p.Color)
                .ToDictionary(g => g.Key, g => g.ToList());

            return colorPointTable;
        }

        private void DisplaySortedPointsForm(List<PointData> sortedPoints)
        {
            Form sortedPointsForm = new Form();
            sortedPointsForm.Text = "Відсортовані точки за кольором";
            sortedPointsForm.Size = new Size(400, 300);

            DataGridView dgvSortedPoints = new DataGridView();
            dgvSortedPoints.Dock = DockStyle.Fill;
            sortedPointsForm.Controls.Add(dgvSortedPoints);

            dgvSortedPoints.AutoGenerateColumns = true;
            dgvSortedPoints.DataSource = sortedPoints;

            sortedPointsForm.ShowDialog();
        }
        private void DisplayUniquePointsForm(List<PointData> uniquePoints)
        {

            Form uniquePointsForm = new Form();
            uniquePointsForm.Text = "Унікальні точки у колі";
            uniquePointsForm.Size = new Size(400, 300);

            DataGridView dgvUniquePoints = new DataGridView();
            dgvUniquePoints.Dock = DockStyle.Fill;
            uniquePointsForm.Controls.Add(dgvUniquePoints);


            dgvUniquePoints.AutoGenerateColumns = true;
            dgvUniquePoints.DataSource = uniquePoints;


            uniquePointsForm.ShowDialog();
        }
        private void DisplayColorPointTableForm(Dictionary<Color, List<PointData>> colorPointTable)
        {

            Form colorPointTableForm = new Form();
            colorPointTableForm.Text = "Таблиця кольорів та точок";
            colorPointTableForm.Size = new Size(400, 300);


            DataGridView dgvColorPointTable = new DataGridView();
            dgvColorPointTable.Dock = DockStyle.Fill;
            colorPointTableForm.Controls.Add(dgvColorPointTable);


            dgvColorPointTable.AutoGenerateColumns = true;


            dgvColorPointTable.DataSource = colorPointTable.SelectMany(kvp => kvp.Value.Select(pd => new { Колір = kvp.Key, X = pd.X, Y = pd.Y })).ToList();


            colorPointTableForm.ShowDialog();
        }


        private void SortPointsA_Click(object sender, EventArgs e)
        {
            var sortedPoints = SortPointsByColor(true);
            DisplaySortedPointsForm(sortedPoints);
        }

        private void SortPointsD_Click(object sender, EventArgs e)
        {
            var sortedPoints = SortPointsByColor(false);
            DisplaySortedPointsForm(sortedPoints);
        }

        private void FindUniqePoints_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCenterX.Text, out double centerX) &&
double.TryParse(textBoxCenterY.Text, out double centerY) &&
double.TryParse(textBoxRadius.Text, out double radius))
            {
                var uniquePoints = FindUniquePointsInCircle(centerX, centerY, radius);
                DisplayUniquePointsForm(uniquePoints);
            }
            else
            {
                MessageBox.Show("Введіть коректні значення для центру та радіусу кола.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createTable_Click(object sender, EventArgs e)
        {
            var colorPointTable = CreateColorPointTable();
            DisplayColorPointTableForm(colorPointTable);
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {

                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            double x = double.Parse(parts[0]);
                            double y = double.Parse(parts[1]);
                            Color color = Color.FromName(parts[2]);
                            AddPoint(x, y, color);
                        }
                    }

                    DisplayPoints(points);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка читання файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var point in points)
                        {
                            writer.WriteLine($"{point.X},{point.Y},{point.Color.Name}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка запису до файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
