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

        [Fact]
        public void PrintDecimal(){
            decimal s = 3/6;

            s.ShouldBeSameAs(0.300000);
        }

    }
}