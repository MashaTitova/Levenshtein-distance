using LevenshteinDistanceClassLibrary;
using MeasureClassLibrary;
/******************************************************************************
 * Файл: Form1.cs
 * Описание: Класс для вывода расстояния Левенштейна между двумя строками двумя методами 
 * с использованием графического интерфейса
 * 
 * Автор: Титова Мария
 * Дата создания: 21.02.2026
 * 
 * История изменений:
 *  1.0 (21.02.2026) - Первоначальная версия
 *  1.1 (22.02.2026) - Добавлены функции для вывода сравнения методов 
 *  1.2 (23.02.2026) - Добавлены функции для визуализации прогресии 
 *
 * Использование: Класс предназначен для вывода расстояния Левенштейна между двумя строками двумя методами
 * с использование графического интерфейса
 *****************************************************************************/

namespace Lab_3
{
    public partial class LevenshteinDistance_Form : Form
    {
        //Список для проведенных вычислений
        private List<string[]> comparison_mass = new List<string[]>();
        //Флаг, показывающий наличие новых данных
        private bool new_input = false;
        //Количество данных, занесенных в таблицу
        private int count = 0;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public LevenshteinDistance_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка допустимой длины введенных строк
        /// </summary>
        ///<returns>
        ///True если обе стороки нужной длины
        ///False если хотя бы одна строка введена неверно
        ///</returns>
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

        /// <summary>
        /// Вычисление расстояния Левенштейна рекурсивным методом
        /// </summary>
        public void Recursive_Method(object sender, EventArgs e)
        {
            if (Check_Length())
            {   
                if(RecursiveMethod_button.Text == "Рассчитать")
                {
                    //Вывод расстояния Левенштейна
                    LevenshteinDistanceRecursive_textBox.Text = Convert.ToString(LevenshteinDistance.GetDistanseRecursion(FirstString_textBox.Text, SecondString_textBox.Text));
                    //Вывод времени выполнения алгоритма
                    TimeRecursive_textBox.Text = Convert.ToString(PerformanceMeasurement.MeasureAlgorithm(() =>
                    {
                        LevenshteinDistance.GetDistanseRecursion(FirstString_textBox.Text, SecondString_textBox.Text);
                    }).Elapsed.TotalMilliseconds * 1000) + " мкс";
                    //Вывод количества элементарных операций
                    OperationNumbersRecursion_textBox.Text = Convert.ToString(LevenshteinDistance.GetOperationRecursionCount());
                    //Добавление данных в список
                    comparison_mass.Add(["Рекурсивный", LevenshteinDistanceRecursive_textBox.Text, TimeRecursive_textBox.Text, OperationNumbersRecursion_textBox.Text,]);
                    new_input = true;
                    RecursiveMethod_button.Text = "Очистить";
                }
                else
                {
                    //Очистка полей
                    LevenshteinDistanceRecursive_textBox.Clear();
                    TimeRecursive_textBox.Clear();
                    OperationNumbersRecursion_textBox.Clear();
                    RecursiveMethod_button.Text = "Рассчитать";
                }
            }
        }
        /// <summary>
        /// Вычисление расстояния Левенштейна методом динамического программирования
        /// </summary>
        public void Dynamic_Method(object sender, EventArgs e)
        {
            if (Check_Length())
            {
                if(DynamicProgramming_button.Text == "Рассчитать")
                {
                    //Вывод расстояния Левенштейна
                    LevenshteinDistanceDynamic_textBox.Text = Convert.ToString(LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text));
                    //Вывод времени выполнения алгоритма
                    TimeDynamic_textBox.Text = Convert.ToString(
                        PerformanceMeasurement.MeasureAlgorithm(() =>
                        {
                            LevenshteinDistance.CalculateDistanceDynamic(FirstString_textBox.Text, SecondString_textBox.Text);
                        }).Elapsed.TotalMilliseconds * 1000) + "мкс";
                    //Вывод количества элементарных операций
                    OperationNumbersDymanic_textBox.Text = Convert.ToString(LevenshteinDistance.GetOperationDynamicCount());
                    //Добавление данных в список
                    comparison_mass.Add(["Динам. программ.", LevenshteinDistanceDynamic_textBox.Text, TimeDynamic_textBox.Text, OperationNumbersDymanic_textBox.Text]);
                    new_input = true;
                    DynamicProgramming_button.Text = "Очистить";
                }
                else
                {
                    //Очистка полей
                    LevenshteinDistanceDynamic_textBox.Clear();
                    TimeDynamic_textBox.Clear();
                    OperationNumbersDymanic_textBox.Clear();
                    DynamicProgramming_button.Text = "Рассчитать";
                }
            }
        }

        /// <summary>
        /// Заполнение таблицы с результатами работы методов нахождения расстояния Левенштейна
        /// </summary>
        public void Comparison(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            //Если нажата нужная кнопка и были добавлены записи
            if (tmp.Name == "Show_button" && new_input)
            {
                // Проверяем, что список не пустой
                if (comparison_mass.Count > 0)
                {
                    // Проходим по всем элементам списка
                    for (int i = count; i < comparison_mass.Count; i++)
                    {
                        //Заполнение строки таблицы
                        Comparison_dataGridView.Rows.Add(comparison_mass[i]);
                    }
                    //Количество уже занесенных в таблицу данных
                    count = comparison_mass.Count;
                }
                new_input = false;
            }
            if(tmp.Name == "ComparisonClear_button")
            {
                //Очистка таблицы при нажатии нужной кнопки
                Comparison_dataGridView.Rows.Clear();
                count = 0;
                new_input = true;
            }
            
        }

        /// <summary>
        /// Очистка полей ввода
        /// </summary>
        public void Clean_Input(object sender, EventArgs e)
        {
            
            FirstString_textBox.Clear();
            SecondString_textBox.Clear();
        }

        /// <summary>
        /// Вызов всплывающих окн со справками для пользователя
        /// </summary>
        public void Information(object sender, EventArgs e)
        {
            var tmp = (Button)sender;
            if (tmp.Name == "Inf_button")
            {
                MessageBox.Show("Вычисление расстояния Левенштейна между двумя строками. \n" +
                    "Расстояние Левенштейна — это минимальное количество операций вставки, удаления и замены одного символа на другой," +
                    " необходимых для превращения одной строки в другую. \n" +
                    "Введите строки в соответствующие поля. \n" +
                    "Длина строк не должна превышать 100 символов. \n" +
                    "Вы можете очистить поля, нажав на кнопку рядом с полями для ввода.");
            }
            if (tmp.Name == "InfRecursive_button")
            {
                MessageBox.Show("Вычисление расстояния Левенштейна рекурсивным методом. \n" +
                    "Для получения результата нажмите на кнопку 'Рассчитать'. \n" +
                    "Вы сможете увидеть расстояние Левенштейна, время выполнение алгоритма и количество элементарных операций алгоритма\n" +
                    "Вы можете очистить поля, повторно нажав на кнопку. ");
            }
            if (tmp.Name == "InfDynamicProgramming_button")
            {
                MessageBox.Show("Вычисление расстояния Левенштейна методом динамического программирования. \n" +
                    "Для получения результата нажмите на кнопку 'Рассчитать'. \n" +
                    "Вы сможете увидеть расстояние Левенштейна, время выполнение алгоритма и количество элементарных операций алгоритма.\n" +
                    "Вы можете очистить поля, повторно нажав на кнопку. ");
            }
            if (tmp.Name == "InfComparison_button")
            {
                MessageBox.Show("В таблице представлены результаты вычисления расстояния Левенштейна между двумя строками:" +
                    " рекурсивным методом и методом динамического программирования.  \n" +
                    "Для обновления таблицы нажмите на кнопку 'Обновить'. \n" +
                    "Вы сможете сравнить такие показатели как" +
                    " расстояние Левенштейна, время выполнение алгоритма и количество элементарных операций алгоритма.\n" +
                    "Вы можете очистить таблицу, нажав на кнопку 'Очистить'. ");
            }

        }

    }
}
