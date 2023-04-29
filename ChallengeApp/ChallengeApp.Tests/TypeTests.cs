namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void TestNumericInt()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act


            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TestNumericFloat()
        {
            //arrange
            float out1 = 1.3f;
            float out2 = 2.7f;

            //act


            //assert
            Assert.AreNotEqual(out1, out2);
        }

            [Test]
        public void TestString()
        {
            //arrange
            var employee1 = GetUser("Adam");
            var employee2 = GetUser("Tomasz");

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
    
}
