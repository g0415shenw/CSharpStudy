using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrammarStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GrammarStudy.Tests
{
    [TestClass()]
    public class CCallBackTests
    {
        [TestMethod()]
        public void SetCallBackTest()
        {
            CCallBack cCallBack = new CCallBack();
            CCallBack.SetCallBack(cCallBack.m_DATACALLBACK);
            CCallBack.GetData();

        }
    }
}