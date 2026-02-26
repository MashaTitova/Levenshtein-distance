using System.Diagnostics;
/******************************************************************************
 * Файл: MeasureClass.cs
 * Описание: Класс для измерения времени выполнения алгоритма
 * 
 * Автор: Титова Мария
 * Дата создания: 23.02.2026
 * 
 * История изменений:
 *  1.0 (23.02.2026) - Первоначальная версия
 *
 * Использование: Класс предназначен для измерения времени выполнения алгоритма
 *****************************************************************************/
namespace MeasureClassLibrary
{
    public static class PerformanceMeasurement
    {
        /// <summary>
        /// Измерение времени выполнения алгоритма
        /// </summary>
        ///<returns>
        ///Время работы алгоритма
        ///</returns>
        public static Stopwatch MeasureAlgorithm(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();

            // Запускаем секундомер
            stopwatch.Start();

            // Выполняем действие
            action();

            // Останавливаем секундомер
            stopwatch.Stop();

            return stopwatch;
        }
    }
}
