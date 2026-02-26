

namespace LevenshteinDistanceClassLibrary
{
    /******************************************************************************
 * Файл: MeasureClass.cs
 * Описание: Класс для вычисления расстояния Левенштейна между двумя строками рекурсивным методом
 * и методом динамического программирования
 * 
 * Автор: Титова Мария
 * Дата создания: 21.02.2026
 * 
 * История изменений:
 *  1.0 (21.02.2026) - Первоначальная версия
 *  1.1 (22.02.2026) - Добавлена функция для метода динамического программирования
 *  1.2 (13.02.2026) - Обтимизирована функция для рекурсивного метода
 *
 * Использование: Класс предназначен для вычисления расстояния Левенштейна между двумя строками рекурсивным методом
 * и методом динамического программирования
 *****************************************************************************/
    public class LevenshteinDistance
    {
        // Глобальный кэш для хранения уже вычисленных результатов
        private static Dictionary<(string, string), int> cache = new Dictionary<(string, string), int>();
        //Объявление переменной для подсчета количества элементарных операций для рекурсивного метода
        private static int OperationRecursionCount = 0;
        private static int OperationDynamicCount = 0;
        // Рекурсивная функция для вычисления расстояния Левенштейна  

        /// <summary>
        /// Вывод количества элементарных операций для рекурсивного метода
        /// </summary>
        /// <returns>
        /// Количество элементарных операций для рекурсивного метода
        /// </returns>
        public static int GetOperationRecursionCount()
        {
            int tmp = OperationRecursionCount / 2;
            OperationRecursionCount = 0;
            return tmp;
        }

        public static int GetDistanseRecursion(string str1, string str2)
        {
            int res = CalculateDistanceRecursion(str1, str2);
            return res;
        }

        /// <summary>
        /// Вычисление расстояния Левенштейна между двумя строками рекурсивным методом
        /// </summary>
        /// <param name="str1">Первая строка</param>
        /// <param name="str2">Вторая строка</param>
        /// <returns>
        /// Расстояние Левенштейна между двумя строками
        /// </returns>
        public static int CalculateDistanceRecursion(string str1, string str2)
        {
            // Проверка кэша: если результат уже вычислен, возвращаем его
            if (cache.TryGetValue((str1, str2), out int result))
            {
                OperationRecursionCount += 7;
                return result;
            }

            // Базовый случай: если первая строка пустая
            if (str1.Length == 0)
            {
                OperationRecursionCount += 4;
                return str2.Length;
            }

            // Базовый случай: если вторая строка пустая
            if (str2.Length == 0)
            {

                OperationRecursionCount += 4;
                return str1.Length;
            }

            // Если последние символы строк совпадают
            if (str1[str1.Length - 1] == str2[str2.Length - 1])
            {
                result = CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1), str2.Substring(0, str2.Length - 1));
                OperationRecursionCount += 11;
            }
            else
            {
                // Если символы не совпадают, берем минимум из трех вариантов
                OperationRecursionCount += 11;
                result = 1 + Math.Min(
                   Math.Min(
                       CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1), str2),
                       CalculateDistanceRecursion(str1, str2.Substring(0, str2.Length - 1))),
                   CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1), str2.Substring(0, str2.Length - 1)));
            }
            OperationRecursionCount += 8;
            cache[(str1, str2)] = result;
            return result;
        }
        /// <summary>
        /// Возвращает количество элементарных операций для метода динамического пронраммирования
        /// </summary>
        /// <returns>
        /// Количество элементарных операций для метода динамического пронраммирования
        /// </returns>
        public static int GetOperationDynamicCount()
        {
            int tmp = OperationDynamicCount / 2;
            OperationDynamicCount = 0;
            return tmp;
        }

        /// <summary>
        /// Вычисление расстояния Левенштейна между двумя строками методом динамического программирования
        /// </summary>
        /// <param name="str1">Первая строка</param>
        /// <param name="str2">Вторая строка</param>
        /// <returns>
        /// Расстояние Левенштейна между двумя строками
        /// </returns>
        public static int CalculateDistanceDynamic(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            OperationDynamicCount += 4;

            // Создаем матрицу для хранения расстояний
            int[,] distance = new int[m + 1, n + 1];
            OperationDynamicCount += 5;

            // Инициализируем первую строку и столбец
            for (int i = 0; i <= m; i++)
            {
                distance[i, 0] = i;
                OperationDynamicCount += 4;
            }

            for (int j = 0; j <= n; j++)
            {
                distance[0, j] = j;
                OperationDynamicCount += 4;
            }
            // Заполняем остальную часть матрицы
            for (int i = 1; i <= m; i++)
            {
                OperationDynamicCount += 2;
                for (int j = 1; j <= n; j++)
                {
                    OperationDynamicCount += 2;
                    // Если символы совпадают
                    if (str1[i - 1] == str2[j - 1])
                    {
                        OperationDynamicCount += 5;
                        distance[i, j] = distance[i - 1, j - 1];
                        OperationDynamicCount += 6;
                    }
                    else
                    {
                        // Выбираем минимальное из трех возможных действий
                        distance[i, j] = 1 + Math.Min(
                            Math.Min(
                                distance[i - 1, j],    // Удаление
                                distance[i, j - 1]     // Вставка
                            ),
                            distance[i - 1, j - 1]     // Замена
                        );
                        OperationDynamicCount += 18;
                    }

                }
            }

            // Результат находится в правом нижнем углу матрицы
            OperationDynamicCount += 7;
            return distance[m, n];
        }
    }
}


