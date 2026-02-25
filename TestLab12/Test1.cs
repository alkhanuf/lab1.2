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
            Grades res = Logic.CountGrades(grades);

            Assert.AreEqual(2, res.countFive);
            Assert.AreEqual(2, res.countFour);
            Assert.AreEqual(2, res.countThree);
            Assert.AreEqual(1, res.countTwo);
        }

        [TestMethod]
        public void TEST2()
        {
            string[] grades = new string[] { "5", "5", "5", "5" };
            Grades res = Logic.CountGrades(grades);

            Assert.AreEqual(4, res.countFive);
            Assert.AreEqual(0, res.countFour);
            Assert.AreEqual(0, res.countThree);
            Assert.AreEqual(0, res.countTwo);
        }


        [TestMethod]
        public void TEST3()
        {
            string[] grades = new string[] { };
            Grades res = Logic.CountGrades(grades);

            Assert.AreEqual(0, res.countFive);
            Assert.AreEqual(0, res.countFour);
            Assert.AreEqual(0, res.countThree);
            Assert.AreEqual(0, res.countTwo);
        }

        [TestMethod]
        public void TEST4()
        {
            string[] grades = new string[] { "5", "5", "4", "4", "6" ,"3", "3", "2", "2" };
            Grades res = Logic.CountGrades(grades);

            Assert.AreEqual(2, res.countFive);
            Assert.AreEqual(2, res.countFour);
            Assert.AreEqual(2, res.countThree);
            Assert.AreEqual(2, res.countTwo);
        }

        
    }
}
