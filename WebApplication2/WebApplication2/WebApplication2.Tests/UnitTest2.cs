using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using service;
using data;
using Moq;


namespace WebApplication2.Tests
{
    [TestClass]
    public class UnitTest2
    {
        //private ITesto _TestService;
        private ITesto _TestService;
        private Mock<IReposity> _Ireposity;
        [TestMethod]
        public void TestMethod1()
        {
            int score = 0;
            int level = 0;
            
            string input = "{<ds!s>}";
            int value = _TestService.ADD(input, score, level);
            Assert.AreEqual(value,1);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int current = 0;
            int len = 0;
           
            string input = "<dsadsa>p";
            int value = _TestService.Garbage(input, current,len) ;
            Assert.AreEqual(value, 8);

        }

        [TestInitialize]
        public void Initialize()
        {
            _Ireposity = new Mock<IReposity>();
            _TestService = new TestService (_Ireposity.Object);
            _Ireposity.Setup(x =>x.Add(It.IsAny<string>(),It.IsAny<int>(),It.IsAny<int>())).Returns(1);
            _Ireposity.Setup(x => x.Garbage(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>())).Returns(8);

        }
     }
}
