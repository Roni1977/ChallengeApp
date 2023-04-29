namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployyeResultToCorrectResoult()
        {
            //arrange
            var employee = new Employee("Lena", "dasfqwer", 32);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(3);
            employee.AddScore(-4);
            var employee1 = new Employee("Roman", "dasfqwer", 21);
            employee1.AddScore(5);
            employee1.AddScore(15);
            employee1.AddScore(5);
            employee1.AddScore(22);
            var employee2 = new Employee("Marek", "dasfqwer", 44);
            employee2.AddScore(45);
            employee2.AddScore(1);
            employee2.AddScore(5);
            employee2.AddScore(-20);
            
            //act
            var result = employee.Result;
            var result1 = employee1.Result;
            var result2 = employee2.Result;

            //assert
            Assert.AreEqual(10, employee.Result);
            Assert.AreEqual(47, employee1.Result);
            Assert.AreEqual(31, employee2.Result);
        }
    }
}