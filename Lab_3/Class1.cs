
namespace LevenshteinDistanceClassLibrary
{
    public class LevenshteinDistance
    {
        private static int OperationRecursionCount = 0;
        // Рекурсивная функция для вычисления расстояния Левенштейна
        public static int CalculateDistance(string str1, string str2)
        {
            OperationRecursionCount = 0;
            return CalculateDistanceRecursion(str1, str2);
            
        }
        public static int GetOperationCount()
        {
            return OperationRecursionCount;
        }
        public static int CalculateDistanceRecursion(string str1, string str2)
        {
            // Базовый случай: если одна из строк пустая
            OperationRecursionCount += 3;
            if (str1.Length == 0)
            {
                return str2.Length;
            }
                
            if (str2.Length == 0)
            {
                return str1.Length;
            }             
            // Если последние символы совпадают
            if (str1[str1.Length - 1] == str2[str2.Length - 1])
            {
                OperationRecursionCount += 20;
                return CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1),
                                           str2.Substring(0, str2.Length - 1));
            }

            else
            {
                // Иначе берём минимум из трёх вариантов
                OperationRecursionCount += 19;
                return 1 + Math.Min(
                    Math.Min(
                        CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1), str2),
                        CalculateDistanceRecursion(str1, str2.Substring(0, str2.Length - 1))),
                        CalculateDistanceRecursion(str1.Substring(0, str1.Length - 1), str2.Substring(0, str2.Length - 1)));
            }
            


        }
        public static (int dis, int operations) CalculateDistanceDynamic(string str1, string str2)
        {
            int operations = 0;
            int m = str1.Length;
            int n = str2.Length;
            operations += 2;

            // Создаем матрицу для хранения расстояний
            int[,] distance = new int[m + 1, n + 1];
            operations += 5;

            // Инициализируем первую строку и столбец
            for (int i = 0; i <= m; i++)
            {
                distance[i, 0] = i;
                operations += 4;
            }

            for (int j = 0; j <= n; j++)
            {
                distance[0, j] = j;
                operations += 4;
            }
            // Заполняем остальную часть матрицы
            for (int i = 1; i <= m; i++)
            {
                operations += 2;
                for (int j = 1; j <= n; j++)
                {
                    operations += 2;
                    // Если символы совпадают
                    if (str1[i - 1] == str2[j - 1])
                    {
                        operations += 5;
                        distance[i, j] = distance[i - 1, j - 1];
                        operations += 6;
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
                        operations += 18;
                    }

                }
            }

            // Результат находится в правом нижнем углу матрицы
            return (distance[m, n], operations);
        }
    }
}


