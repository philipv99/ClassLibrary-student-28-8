using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_student_28_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary_student_28_8.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod()]
        public void HashCodeTester()
        {
            Teacher Ttest = new Teacher(1, "mand", 1, GenderEnum.Male);
            Student Stest = new Student(1, "mand", 1, GenderEnum.Male);

            Assert.AreNotEqual(Ttest.GetHashCode(), Stest.GetHashCode());
        }

        [TestMethod()]
        public void ConstructorTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male, "1C", "4B");
            Assert.IsNotNull(Ttest);
        }

        [TestMethod()]
        public void ClassesTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male, "1C", "4B");
            Assert.AreEqual(Ttest.Classes.Count, 2);
            Assert.AreEqual(Ttest.Classes[0], "1C");
        }

            [TestMethod()]
        public void ToStringTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male);
            string Expected = "#1: Mr.mand, Teahcer";
            Assert.AreEqual(Expected, Ttest.ToString());
        }

        [TestMethod()]
        public void ValidNameTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male);
            Ttest.ValidName();

            Teacher nulltest = new Teacher(1, null, 100, GenderEnum.Male);
            Assert.ThrowsException<ArgumentNullException>(() => nulltest.ValidName());

            Teacher noNametest = new Teacher(1, "", 100, GenderEnum.Male);
            Assert.ThrowsException<ArgumentException>(() => noNametest.ValidName());
        }

        [TestMethod()]
        public void ValidSalaryTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male);
            Ttest.ValidSalary();

            Teacher lesstest = new Teacher(1, "mand", -1, GenderEnum.Male);
            Assert.ThrowsException<ArgumentException>(() => lesstest.ValidSalary());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male);
            Teacher OneWrong = new Teacher(1, "mand", 0, GenderEnum.Male);
            Teacher otherWrong = new Teacher(1, "", 10, GenderEnum.Male);

            Ttest.Validate();

            Assert.ThrowsException<ArgumentException>(() => OneWrong.Validate());
            Assert.ThrowsException<ArgumentException>(() => OneWrong.Validate());
        }

        [TestMethod()]
        public void GenderTestMale()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Male);

            Assert.AreEqual(Ttest.Gender, GenderEnum.Male);
        }

        [TestMethod()]
        public void GenderTestFeMale()
        {
            Teacher Ttest = new Teacher(1, "mand", 100, GenderEnum.Female);

            Assert.AreEqual(Ttest.Gender, GenderEnum.Female);
        }
    }
}