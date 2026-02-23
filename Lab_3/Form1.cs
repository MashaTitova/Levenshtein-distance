using LevenshteinDistanceClassLibrary;
using MeasureClassLibrary;
using System.Text;
namespace Lab_3
{
    public partial class LevenshteinDistance_Form : Form
    {
        private List<string[]> comparison_mass = new List<string[]>();

        public LevenshteinDistance_Form()
        {
            InitializeComponent();
        }
        public bool Check_Length()
        {
            if (FirstString_textBox.Text.Length > 100)
            {
                MessageBox.Show("Строка 1 должна быть не длиннее 100 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (SecondString_textBox.Text.Length > 100)
                {
                    MessageBox.Show("Строка 2 должна быть не длиннее 100 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        public void Recursive_Method(object sender, EventArgs e)
        {
            if (Check_Length())
            {
                LevenshteinDistanceRecursive_textBox.Text = Convert.ToString(LevenshteinDistance.CalculateDistance(FirstString_textBox.Text, SecondString_textBox.Text));
                TimeRecursive_textBox.Text = Convert.ToString(PerformanceMeasurement.MeasureAlgorithm("Базовый алгоритм", () =>
                {
                    LevenshteinDistance.CalculateDistance(FirstString_textBox.Text, SecondString_textBox.Text);
                }).ElapsedMilliseconds);
                OperationNumbersRecursion_textBox.Text = Convert.ToString(LevenshteinDistance.GetOperationCount());
                comparison_mass.Add(["Рекурсивный", LevenshteinDistanceRecursive_textBox.Text, TimeRecursive_textBox.Text, OperationNumbersRecursion_textBox.Text,]);
            }
        }
        public void Dynamic_Method(object sender, EventArgs e)
        {
            if (Check_Length())
            {
                (int dis, int operations) = LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text);
                LevenshteinDistanceDynamic_textBox.Text = Convert.ToString(dis);
                TimeDynamic_textBox.Text = Convert.ToString(PerformanceMeasurement.MeasureAlgorithm("Базовый алгоритм", () =>
                {
                    LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text);
                }).ElapsedMilliseconds);
                OperationNumbersDymanic_textBox.Text = Convert.ToString(operations);
                comparison_mass.Add(["Динам. программ.", LevenshteinDistanceDynamic_textBox.Text, TimeDynamic_textBox.Text, OperationNumbersDymanic_textBox.Text]);
            }
        }

        public void Comparison(object sender, EventArgs e)
        {

            // Проверяем, что список не пустой
            if (comparison_mass.Count > 0)
            {
                // Проходим по всем элементам списка
                for (int i = 0; i < comparison_mass.Count; i++)
                {
                    dataGridView1.Rows.Add(comparison_mass[i]);
                }
            }
        }

    }
}
