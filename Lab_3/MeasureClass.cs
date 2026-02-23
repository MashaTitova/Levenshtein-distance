
using System.Diagnostics;
namespace MeasureClassLibrary
{
    public static class PerformanceMeasurement
    {
        public static Stopwatch MeasureAlgorithm(string algorithmName, Action action)
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
