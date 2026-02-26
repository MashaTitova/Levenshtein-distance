using LevenshteinDistanceClassLibrary;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateDistanceRecursion_FirstStringIsEmpty_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "";
            string str2 = "Привет";

            // Act
            int result = LevenshteinDistance.CalculateDistanceRecursion(str1, str2);

            // Assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void CalculateDistanceRecursion_SecondStringIsEmpty_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "2534";
            string str2 = "";

            // Act
            int result = LevenshteinDistance.CalculateDistanceRecursion(str1, str2);

            // Assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void CalculateDistanceRecursion_SameString_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "Матрица кратчайших расстояний";
            string str2 = "Матрица кратчайших расстояний";

            // Act
            int result = LevenshteinDistance.CalculateDistanceRecursion(str1, str2);

            // Assert
            Assert.Equal(0, result);

        }
        [Fact]
        public void CalculateDistanceRecursion_TypicalExample_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "МАТЕМАТИКА";
            string str2 = "ФИЗИКА";

            // Act
            int result = LevenshteinDistance.CalculateDistanceRecursion(str1, str2);

            // Assert
            Assert.Equal(7, result);

        }
        [Fact]
        public void CalculateDistanceDynamic_SecondStringIsEmpty_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "2534";
            string str2 = "";

            // Act
            int result = LevenshteinDistance.CalculateDistanceDynamic(str1, str2);

            // Assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void CCalculateDistanceDynamic_SameString_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "Матрица кратчайших расстояний";
            string str2 = "Матрица кратчайших расстояний";

            // Act
            int result = LevenshteinDistance.CalculateDistanceDynamic(str1, str2);

            // Assert
            Assert.Equal(0, result);

        }
        [Fact]
        public void CalculateDistanceDynamic_TypicalExample_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "МАТЕМАТИКА";
            string str2 = "ФИЗИКА";

            // Act
            int result = LevenshteinDistance.CalculateDistanceDynamic(str1, str2);

            // Assert
            Assert.Equal(7, result);

        }
        [Fact]
        public void CalculateDistanceDynamic_FirstStringIsEmpty_ReturnsCorrectDistance()
        {
            // Arrange
            string str1 = "";
            string str2 = "Привет";

            // Act
            int result = LevenshteinDistance.CalculateDistanceDynamic(str1, str2);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
