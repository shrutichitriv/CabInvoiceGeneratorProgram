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

        [Test]
        public void GivenMultipleRidesReturnAggregateFare()
        {
            //Arrange
            generateNormalFare = new CabInvoiceGen(RideType.NORMAL);
            double actual, expected = 375;  //215+160 = 375/-
            int time = 10; //10*1 =10
            double distance = 15;  //15*10=150
            Ride[] cabRides = new Ride[]
            {
                new Ride(10, 15), //160
                new Ride(15, 20)  //15*1+20*10=215
            };

            //Act
            actual = generateNormalFare.CalculateAgreegateFare(cabRides);
            //Assert
            Assert.AreEqual(actual, expected);
        }


    }
}