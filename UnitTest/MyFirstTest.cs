using System;
using Xunit;
using Shouldly;
namespace UnitTest
{
    public class MyFirstTest
    {
        [Fact]
        public void PassingTest()
        {
            var actual = (2 * 2);
            actual.ShouldBe(4);
        }
    }
}
