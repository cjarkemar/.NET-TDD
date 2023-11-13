
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
    }
}