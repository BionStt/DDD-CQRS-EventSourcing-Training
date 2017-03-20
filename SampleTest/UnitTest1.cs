using DomainModel.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTest
{
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var match = new DomainModel.Business.Match("12345", "Home", "Visitors");
            match.Start()
                .StartPeriod()
                .Goal(TeamId.Home)
                .Goal(TeamId.Home)
                .EndPeriod()
                .StartPeriod()
                .Goal(TeamId.Visitors)
                .EndPeriod()
                .StartPeriod()
                .EndPeriod()
                .StartPeriod()
                .Goal(TeamId.Home)
                .EndPeriod()
                .Finish();
            Assert.AreEqual(new Score(3, 1), match.CurrentScore);
        }
    }
}
