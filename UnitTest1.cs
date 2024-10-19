using TimeCalculation;

namespace TimeCalculatorTests
{
    [TestClass]
    public class TimeCalculatorTests
    {
        [TestMethod]
        public void CalculateTime_WhenTotalSecondsIs3600_Returns1Hour()
        {
            // Підготовка: встановлюємо кількість секунд, що дорівнює 3600 (1 година)
            int totalSeconds = 3600;

            // Виконання: викликаємо метод CalculateTime для обчислення годин, хвилин та секунд
            var result = TimeCalculator.CalculateTime(totalSeconds);

            // Перевірка: перевіряємо, що результат відповідає 1 година, 0 хвилин, 0 секунд
            Assert.AreEqual((1, 0, 0), result);
        }
    }
}
