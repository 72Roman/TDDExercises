using System;
using NUnit.Framework;
using Exercise1;
namespace Exersice1Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Greet_Bob_HelloBobReturned()
        {
            // arrange
            string name = "Bob";
            string expected = "Hello, Bob.";
            // act
            string actual = GreetingClass.Greet(name);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Greet_Null_HelloMyFriendReturned()
        {
            // arrange
            string expected = "Hello, my friend.";
            // act
            string actual = GreetingClass.Greet(null);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Greet_EmptyString_HelloMyFriendReturned()
        {
            // arrange
            string expected = "Hello, my friend.";
            // act
            string actual = GreetingClass.Greet("");
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Greet_UpperCaseName_UpperCaseResponseReturned()
        {
            // arrange
            string name = "JERRY";
            string expected = "HELLO JERRY!";
            // act
            string actual = GreetingClass.Greet(name);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsStringInUpperCase_UpperCaseString_TrueReturned()
        {
            // arrange
            string name = "JERRY";
            bool expected = true;
            // act
            bool actual = GreetingClass.IsStringInUpperCase(name);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsStringInUpperCase_Null_FalseReturned()
        {
            // arrange
            bool expected = false;
            // act
            bool actual = GreetingClass.IsStringInUpperCase(null);
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsStringInUpperCase_EmptyString_FalseReturned()
        {
            // arrange
            bool expected = false;
            // act
            bool actual = GreetingClass.IsStringInUpperCase("");
            // assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase("jerry")]
        [TestCase("12~++-")]
        [TestCase("Jerry")]
        public void IsStringInUpperCase_NoUpperCaseString_FalseReturned(string name)
        {
            bool expected = false;
            // act
            bool actual = GreetingClass.IsStringInUpperCase(name);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}