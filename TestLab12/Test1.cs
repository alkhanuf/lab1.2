using lab12;

namespace TestLab12
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TEST1()
        {
            string[] grades = new string[] { "5", "4", "3", "2", "5", "4", "3" };
            int[] res = Logic.CountGrades(grades);

            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(2, res[2]);
            Assert.AreEqual(1, res[3]);
        }

        [TestMethod]
        public void TEST2()
        {
            string[] grades = new string[] { "5", "5", "5", "5" };
            int[] res = Logic.CountGrades(grades);

            Assert.AreEqual(4, res[0]);
            Assert.AreEqual(0, res[1]);
            Assert.AreEqual(0, res[2]);
            Assert.AreEqual(0, res[3]);
        }


        [TestMethod]
        public void TEST3()
        {
            string[] grades = new string[] { };
            int[] res = Logic.CountGrades(grades);

            Assert.AreEqual(0, res[0]);
            Assert.AreEqual(0, res[1]);
            Assert.AreEqual(0, res[2]);
            Assert.AreEqual(0, res[3]);
        }

        [TestMethod]
        public void TEST4()
        {
            string[] grades = new string[] { "5", "5", "4", "4", "6" ,"3", "3", "2", "2" };
            int[] res = Logic.CountGrades(grades);

            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(2, res[2]);
            Assert.AreEqual(2, res[3]);
        }

        
    }
}
