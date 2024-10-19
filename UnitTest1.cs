using TimeCalculation;

namespace TimeCalculatorTests
{
    [TestClass]
    public class TimeCalculatorTests
    {
        [TestMethod]
        public void CalculateTime_WhenTotalSecondsIs3600_Returns1Hour()
        {
            // ϳ��������: ������������ ������� ������, �� ������� 3600 (1 ������)
            int totalSeconds = 3600;

            // ���������: ��������� ����� CalculateTime ��� ���������� �����, ������ �� ������
            var result = TimeCalculator.CalculateTime(totalSeconds);

            // ��������: ����������, �� ��������� ������� 1 ������, 0 ������, 0 ������
            Assert.AreEqual((1, 0, 0), result);
        }
    }
}
