namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.Equal(1, 1);

        [Fact]
        public void Test2() => Assert.NotEqual(1, 2);

        [Fact]
        public void CalculatePrice_area0_expect_500()
        {
            //Arrange
            PriceCalculator pc = new();
            int area = 0;
            int totalPrice = 0;
            //Act
            totalPrice += pc.CalculatePrice(area);
            //Assert
            Assert.Equal(500, totalPrice);
        }
    }
}