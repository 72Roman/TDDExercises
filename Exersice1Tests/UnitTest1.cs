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
            string actual = "Hello, Bob.";
            // act
            string result = GreetingClass.Greet(name);
            // assert
            Assert.AreEqual(actual, result);
        }
    }
}