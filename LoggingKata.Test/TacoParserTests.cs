using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("33.59453,-86.694742,Taco Bell Birmingham...", -86.694742)]
        [InlineData("33.49763, -86.875722, Taco Bell Birmingham...", -86.875722)]
        [InlineData("33.470013, -86.816966, Taco Bell Birmingham...", -86.816966)]
        [InlineData("34.8831, -84.293899, Taco Bell Blue Ridg...", -84.293899)]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {

            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);


        }


          //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("33.59453,-86.694742,Taco Bell Birmingham...", 33.59453)]
        [InlineData("33.49763, -86.875722, Taco Bell Birmingham...", 33.49763)]
        [InlineData("33.470013, -86.816966, Taco Bell Birmingham...", 33.470013)]
        [InlineData("34.8831, -84.293899, Taco Bell Blue Ridg...", 34.8831)]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected) 
        {

            var tester = new TacoParser();


            var actual =tester.Parse(line).Location.Latitude;


            Assert.Equal(expected , actual);



        }




    }
}
