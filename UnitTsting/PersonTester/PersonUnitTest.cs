using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTsting;

namespace PersonTester
{
    [TestClass]
    public class PersonUnitTest
    {
        [TestMethod]
        public void TestSum()
        {
            //Arrange
            int num1 = 5;
            int num2 = 7;
            int expected = 12;

            //Act
            int actual = num1 + num2;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCanVote()
        {
            //Arrange
            int age = 5;
            bool expected = false;

            //Act
            Person p = new Person("Kabelo", "Tlhape", age);
            bool actual = p.CanVote();
            //Assert
            Assert.AreEqual(expected, actual);
            //Assert.IsTrue(expected.Equals(actual));
        }
        [TestMethod]
        public void TestLength()
        {
            //Arrange
            string name = "Kabelo";
            int expected = 6;

            //Act
            Person p = new Person(name, "Smit", 12);
            int actual = p.StringLength(name);

            //Assert
            Assert.IsTrue(expected == actual);

        }
    }
}
