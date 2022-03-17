using System;
using Xunit;
using Lab_02Unit__Testing; 

namespace TestBank
{
    public class UnitTest1
    {
        [Fact]
        public void CanWithdraw()
        {
            Assert.Equal(" PLEASE COLLECT YOUR CASH", Class1.atmBank());
           
        }
    }
}
