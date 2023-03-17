using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FishTank.Tests
{
    [TestClass()]
    public class FishTest
    {

        const int FishType = 1;
        const string FishName = "Test Fish";
        [TestMethod()]
        public void feedTest()
        {
            FishTank.Tank tank = new FishTank.Tank();
            try
            {
                int fishTypeFalse = 2;
                tank.addFish(1, fishTypeFalse, FishName);

                Assert.AreEqual(FishType, fishTypeFalse, "Fish Type are not same");
            }
            finally
            {
            }
        }

        [TestMethod()]
        public void saveFishTest()
        {
            Assert.Fail();
        }
    }
}
