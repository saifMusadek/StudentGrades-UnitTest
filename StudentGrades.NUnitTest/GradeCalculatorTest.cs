namespace StudentGrades.NUnitTest
{
    public class GradeCalculatorTest
    {

        private GradeCalculator _gradeCalculator { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(91)]
        [TestCase(92)]
        [TestCase(93)]
        [TestCase(94)]
        [TestCase(99)]
        [TestCase(100)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        //Change the name from test one to the function of which the functionality we want to test
        {
            ////Assign for single test case
            //var percentage = 80;

            //Actd
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreEqual("A", grade);
            //Assert.Pass();
        }

        [TestCase(81)]
        [TestCase(82)]
        [TestCase(83)]
        [TestCase(84)]
        [TestCase(89)]
        [TestCase(77)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        //Change the name from test one to the function of which the functionality we want to test
        {
            ////Assign for single test case
            //var percentage = 80;

            //Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert
            Assert.AreNotEqual("A", grade);
            //Assert.Pass();
        }
    }
}