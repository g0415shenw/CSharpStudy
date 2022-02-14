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
    public class JsonToClassTests
    {
        [TestMethod()]
        public void TestJsonToClassTest()
        {
            JsonToClass jsonToClass = new JsonToClass();
            jsonToClass.TestJsonToClass();
        }
    }
}