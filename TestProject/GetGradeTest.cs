using TubesKPL;

namespace TestProject
{
    [TestClass]
    public sealed class GetGradeTest
    {
        [TestMethod]
        public void TestGetGradeA()
        {
            Assert.AreEqual("A", TubesKPL.Attempt.GetGradeByScore(81));
        }
        [TestMethod]
        public void TestGetGradeAB()
        {
            Assert.AreEqual("AB", TubesKPL.Attempt.GetGradeByScore(71));
        }
        [TestMethod]
        public void TestGetGradeB()
        {
            Assert.AreEqual("B", TubesKPL.Attempt.GetGradeByScore(66));
        }
        [TestMethod]
        public void TestGetGradeBC()
        {
            Assert.AreEqual("BC", TubesKPL.Attempt.GetGradeByScore(61));
        }
        [TestMethod]
        public void TestGetGradeC()
        {
            Assert.AreEqual("C", TubesKPL.Attempt.GetGradeByScore(51));
        }
        [TestMethod]
        public void TestGetGradeD()
        {
            Assert.AreEqual("D", TubesKPL.Attempt.GetGradeByScore(41));
        }
        [TestMethod]
        public void TestGetGradeE()
        {
            Assert.AreEqual("E", TubesKPL.Attempt.GetGradeByScore(0));
        }
    }
}
