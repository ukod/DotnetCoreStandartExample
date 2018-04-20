using System;
using Xunit;
using logic;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedMessage = "Hello Kostya";
            var actualMessage = HelloWorld.GetMessage("Kostya");
            Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
