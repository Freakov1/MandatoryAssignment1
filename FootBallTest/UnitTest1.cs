using MandatoryAssignment;

namespace FootBallTest
{
    [TestClass]
    public class UnitTest1
    {
        FootballPlayer player = new FootballPlayer { ID = 1, Name = "Simon", Age = 29, ShirtNumber = 88 };

        [TestMethod]
        public void TestValidateName()
        {
            
            player.ValidateName();
            player.Name = "S";
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateName());
        }

        [TestMethod]
        public void TestValidateAge()
        {

            player.ValidateAge();
            player.Age = 0;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateAge());
        }

        [TestMethod]
        public void TestValidateShirt()
        {

            player.ValidateShirt();
            player.ShirtNumber = 100;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player.ValidateShirt());
        }
    }
}