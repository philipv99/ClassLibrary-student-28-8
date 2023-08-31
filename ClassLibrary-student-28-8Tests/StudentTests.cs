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
    public class StudentTests
    {
        [TestMethod()]
        public void StudentTest()
        {
            Student TestStudent = new Student(1, "morten", 1, GenderEnum.Male);

            Assert.IsNotNull(TestStudent);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Student TestStudent = new Student(1, "morten", 1, GenderEnum.Male);
            string Expect = "#1: morten, 1. semester student";
            Assert.AreEqual(Expect, TestStudent.ToString());
        }

        [TestMethod()]
        public void ValidSemesterTest()
        {
            Student TestStudent = new Student(1, "morten", 1, GenderEnum.Male);
            Student TestStudentSemesterFail = new Student(1, "morten", 0, GenderEnum.Male);

            TestStudent.ValidSemester();

            Assert.ThrowsException<ArgumentException>(() => TestStudentSemesterFail.ValidSemester());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Student TestStudent = new Student(1, "morten", 1, GenderEnum.Male);
            Student TestStudentOneFail = new Student(1, "", 1, GenderEnum.Male);
            Student TestStudentOtherFail = new Student(1, "morten", -1, GenderEnum.Male);

            TestStudent.Validate();

            Assert.ThrowsException<ArgumentException>(() => TestStudentOneFail.Validate());
            Assert.ThrowsException<ArgumentException>(() => TestStudentOtherFail.Validate());
        }
    }
}

