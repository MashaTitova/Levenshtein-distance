using LevenshteinDistanceClassLibrary;
using MeasureClassLibrary;
using System.Text;
namespace Lab_3
{
    public partial class LevenshteinDistance_Form : Form
    {
        private List<string[]> comparison_mass = new List<string[]>();
        private bool new_input = false;
        private int count = 0;

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
                if(RecursiveMethod_button.Text == "Рассчитать")
                {
                    LevenshteinDistanceRecursive_textBox.Text = Convert.ToString(LevenshteinDistance.CalculateDistance(FirstString_textBox.Text, SecondString_textBox.Text));
                    TimeRecursive_textBox.Text = Convert.ToString(PerformanceMeasurement.MeasureAlgorithm("Базовый алгоритм", () =>
                    {
                        LevenshteinDistance.CalculateDistance(FirstString_textBox.Text, SecondString_textBox.Text);
                    }).ElapsedMilliseconds);
                    OperationNumbersRecursion_textBox.Text = Convert.ToString(LevenshteinDistance.GetOperationCount());
                    comparison_mass.Add(["Рекурсивный", LevenshteinDistanceRecursive_textBox.Text, TimeRecursive_textBox.Text, OperationNumbersRecursion_textBox.Text,]);
                    new_input = true;
                    RecursiveMethod_button.Text = "Очистить";
                }
                else
                {
                    LevenshteinDistanceRecursive_textBox.Clear();
                    TimeRecursive_textBox.Clear();
                    OperationNumbersRecursion_textBox.Clear();
                    RecursiveMethod_button.Text = "Рассчитать";
                }
            }
        }
        public void Dynamic_Method(object sender, EventArgs e)
        {
            if (Check_Length())
            {
                if(DynamicProgramming_button.Text == "Рассчитать")
                {
                    (int dis, long operations) = LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text);
                    LevenshteinDistanceDynamic_textBox.Text = Convert.ToString(dis);
                    TimeDynamic_textBox.Text = Convert.ToString(PerformanceMeasurement.MeasureAlgorithm("Базовый алгоритм", () =>
                    {
                        LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text);
                    }).ElapsedMilliseconds);
                    OperationNumbersDymanic_textBox.Text = Convert.ToString(operations);
                    comparison_mass.Add(["Динам. программ.", LevenshteinDistanceDynamic_textBox.Text, TimeDynamic_textBox.Text, OperationNumbersDymanic_textBox.Text]);
                    new_input = true;
                    DynamicProgramming_button.Text = "Очистить";
                }
                else
                {
                    LevenshteinDistanceDynamic_textBox.Clear();
                    TimeDynamic_textBox.Clear();
                    OperationNumbersDymanic_textBox.Clear();
                    DynamicProgramming_button.Text = "Рассчитать";
                }
            }
        }

        public void Comparison(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            if (tmp.Name == "Show_button" && new_input)
            {
                // Проверяем, что список не пустой
                if (comparison_mass.Count > 0)
                {
                    // Проходим по всем элементам списка
                    for (int i = count; i < comparison_mass.Count; i++)
                    {
                        Comparison_dataGridView.Rows.Add(comparison_mass[i]);
                    }
                    count = comparison_mass.Count;
                }
                new_input = false;
            }
            if(tmp.Name == "ComparisonClear_button")
            {
                Comparison_dataGridView.Rows.Clear();
                count = 0;
                new_input = true;
            }
            
        }
        public void Clean_Input(object sender, EventArgs e)
        {
            FirstString_textBox.Clear();
            SecondString_textBox.Clear();
        }


    }
}
