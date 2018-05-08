using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Good_Maths()
        {
            Assert.Equal(2, 1 + 1);
        }

        [Fact]
        public void Bad_Math()
        {
            Assert.Equal(2, 1 * 1);
        }
    }
}
