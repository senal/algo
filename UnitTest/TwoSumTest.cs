using System;
using Shouldly;
using Xunit;
namespace UnitTest
{
    public class TwoSumTest
    {

        [Fact]
        public void SampleTest(){

            var sum = 2 + 2;
            sum.ShouldBe(4);
        }

    }
}