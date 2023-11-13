
using FizzBuzz;


namespace FizzBuzzTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TalDelbartmed3()
        {
            //arrange
            int nummer = 9;

            //act
            string result = Kalkylator.FizzBuzzKalkyl(nummer);

            //assert

            Assert.That(result, Is.EqualTo("FIZZ"));
        }

        [Test]
        public void TalEjDelbartmed3()
        {
            //arrange
            int nummer = 7;

            //act

            string result = Kalkylator.FizzBuzzKalkyl(nummer);

            //assert
            Assert.That(result, Is.EqualTo("7"));



        }

        [Test]
        public void TalDelbartmed5()
        {
            //arrange
            int nummer = 10;

            //act

            string result = Kalkylator.FizzBuzzKalkyl(nummer);

            //assert
            Assert.That(result, Is.EqualTo("BUZZ"));



        }

        [Test]
        public void TalEjDelbartmed5()
        {
            //arrange
            int nummer = 11;

            //act

            string result = Kalkylator.FizzBuzzKalkyl(nummer);

            //assert
            Assert.That(result, Is.EqualTo("11"));

          

        }

        [Test]
        public void TalDelbartmed5Och3()
        {
            //arrange
            int nummer = 15;

            //act

            string result = Kalkylator.FizzBuzzKalkyl(nummer);

            //assert
            Assert.That(result, Is.EqualTo("FIZZBUZZ"));



        }

        [Test]
        public void TestFizzBuzzOutput()
        {
            // Arrange
            int testNumber = 15; 
            string expectedOutput = "FIZZBUZZ";

            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                FizzBuzz.Kalkylator.FizzBuzzOutput(testNumber);

                // Assert
                string actualOutput = sw.ToString().Trim(); 
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
}