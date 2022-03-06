using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

/// <summary>
/// Used to auto test checking if the values are correct 
/// checks for 6 
/// </summary>
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        //Miles to feet test
        [TestMethod]
        public void TestMilesToFeet()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 5280;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
        //Feet to meters test
        [TestMethod]
        public void TestFeetToMeters()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METERS;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 0.3048;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        //Meters to kelometers test
        [TestMethod]
        public void TestMeterToKelometer()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METERS;
            converter.ToUnit = DistanceConverter.KELOMETER;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 0.001;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        //Kelometers to miles test
        [TestMethod]
        public void TestKelometerToMiles()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.KELOMETER;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 0.62137119223733;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        //Millimeters to feet test
        [TestMethod]
        public void TestMillimeterToFeet()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILLIMETER;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 0.0032808398950131;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
        //Inches to millimeters
        [TestMethod]
        public void TestInchToMeters()
        {
            //Arrange

            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.INCH;
            converter.ToUnit = DistanceConverter.MILLIMETER;

            converter.FromDistance = 1.0;

            // Act

            converter.ConvertDistance();
            double expectedDistance = 25.4;

            // Assert

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
    }
