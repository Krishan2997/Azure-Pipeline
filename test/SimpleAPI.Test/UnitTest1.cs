using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValueController controller =new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue =controller.Get(1);
            Assert.Equal("Krishan Agarwal", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
