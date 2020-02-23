using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XunitPractice.HandleContext;

namespace XunitPractice
{
    public class TestCaseSample: IClassFixture<HandlingFixture>
    {
        HandlingFixture handlingFixture;

        public TestCaseSample(HandlingFixture handlingFixture)
        {
            this.handlingFixture = handlingFixture;
        }

        [Theory]
        [Trait("Sample", "TEST_1234")]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void TestNumberIsOdd(int number)
        {
            Assert.True(IsOdd(number));
        }

        [Theory]
        [Trait("Sample","TEST_5678")]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 15)]
        public void TestSum(int num1, int num2, int sum)
        {
            Assert.Equal(num1 + num2, sum);
        }

        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
