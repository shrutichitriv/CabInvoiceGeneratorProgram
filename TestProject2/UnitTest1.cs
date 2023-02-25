using CabInvoice;

namespace TestProject1
{
    public class CabInvoiceGenUnitTest
    {
        public CabInvoiceGen generateNormalFare;
        public void Setup()
        {
            generateNormalFare = new CabInvoiceGen(RideType.NORMAL);
        }
        [Test]
        public void GivenProperDistanceAndTimeShouldResturnFare()
        {
            //Arrange
            generateNormalFare = new CabInvoiceGen(RideType.NORMAL);
            double expected = 160;
            int time = 10;
            double distance = 15;
            //Act
            double actual = generateNormalFare.CalculateFare(time, distance);
            //Assert
            Assert.AreEqual(actual, expected);
        }

    }
}