using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrammarStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarStudy.Tests
{
    [TestClass()]
    public class HttpClientTestTests
    {
        [TestMethod()]
        public void TestGetTest()
        {
            HttpClientTest httpClientTest = new HttpClientTest();
            httpClientTest.TestGet();
        }

        [TestMethod()]
        public void TestPostTest()
        {
            HttpClientTest httpClientTest = new HttpClientTest();
            httpClientTest.TestPost();
        }
    }
}