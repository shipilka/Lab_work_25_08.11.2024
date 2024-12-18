using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_work_25_08._11._2024
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            numericUpDownLength.DecimalPlaces = 2;
            numericUpDownWidth.DecimalPlaces = 2;
            numericUpDownLength.Minimum = 0;
            numericUpDownLength.Maximum = 100;
            numericUpDownWidth.Minimum = 0;
            numericUpDownWidth.Maximum = 100;
        }

        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year - DateOfBirthTimePicker.Value.Year;
            if (dateNow.Month < DateOfBirthTimePicker.Value.Month ||
               (dateNow.Month == DateOfBirthTimePicker.Value.Month && dateNow.Day < DateOfBirthTimePicker.Value.Day)) year--;
            AgeText.Text = year.ToString();
        }

        private void PriceTrackBar_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = PriceTrackBar.Value.ToString();

        }

        private void numericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            CalculateSquareAndPerimeter();
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            CalculateSquareAndPerimeter();
        }
        private void CalculateSquareAndPerimeter()
        {
                double length = (double)numericUpDownLength.Value;
                double width = (double)numericUpDownWidth.Value;

                double square = length * width;
                double perimeter = 2 * (length + width);

                SquareText.Text = $"Площадь: {square:F2}";
                PerimeterText.Text = $"Периметр: {perimeter:F2}";
            
        }
    }
}




