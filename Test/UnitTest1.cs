using System;
using System.IO;
using TestMVC.Models;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Apple apple = new Apple();
            Assert.Equal("Apple", apple._message);
        }

        [Fact]
        public void Test2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Apple apple = new Apple();
                apple.Quantity = 0;
                Assert.Equal("Apple", sw.ToString());
            }
        }
    }
}
