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

        [TestMethod()]
        public void GetMsg_typeTest()
        {
            string json = @"{""data"":{ ""carry_che"":"""",""ctn_id"":""EGHU9748850"",""ctn_operator"":""EMC"",""ctn_size"":""45GP"",""ctn_status"":70,""datetime"":""2022/01/21 09:56:51"",""from_pos"":{ ""mColumn"":5,""mLocation"":""1A"",""mQual"":89,""mRow2"":82,""mTier"":4},""ld_che"":""RT05"",""move_kind"":""LOAD"",""to_pos"":{ ""mColumn"":12,""mLocation"":""EMCKC7"",""mQual"":86,""mRow2"":66,""mTier"":20},""wi_dispatchtime"":1642729204},""msg_type"":""DESEL""}";
            if(false == JsonToClass.GetMsg_type(json,out var type))
            {
                LogHelp.logger.Error("JsonToClass.GetMsg_type");
                return;
            }
        }
    }
}