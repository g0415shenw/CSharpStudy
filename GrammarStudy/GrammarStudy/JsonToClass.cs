using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarStudy
{
    public class From_pos
    {
        public int mColumn { get; set; }
        public string mLocation { get; set; }
        public int mQual { get; set; }
        public int mRow2 { get; set; }
        public int mTier { get; set; }
    }

    public class To_pos
    {
        public int mColumn { get; set; }
        public string mLocation { get; set; }
        public int mQual { get; set; }
        public int mRow2 { get; set; }
        public int mTier { get; set; }
    }

    public class Data
    {
        public string carry_che { get; set; }
        public string ctn_id { get; set; }
        public string ctn_operator { get; set; }
        public string ctn_size { get; set; }
        public int ctn_status { get; set; }
        public string datetime { get; set; }
        public From_pos from_pos { get; set; }
        public string ld_che { get; set; }
        public string move_kind { get; set; }
        public To_pos to_pos { get; set; }
        public int wi_dispatchtime { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public string msg_type { get; set; }
    }


    public class JsonToClass
    {
        public void TestJsonToClass()
        {
            string json = @"{""data"":{ ""carry_che"":"""",""ctn_id"":""EGHU9748850"",""ctn_operator"":""EMC"",""ctn_size"":""45GP"",""ctn_status"":70,""datetime"":""2022/01/21 09:56:51"",""from_pos"":{ ""mColumn"":5,""mLocation"":""1A"",""mQual"":89,""mRow2"":82,""mTier"":4},""ld_che"":""RT05"",""move_kind"":""LOAD"",""to_pos"":{ ""mColumn"":12,""mLocation"":""EMCKC7"",""mQual"":86,""mRow2"":66,""mTier"":20},""wi_dispatchtime"":1642729204},""msg_type"":""DESEL""}";
            Root student = JsonConvert.DeserializeObject<Root>(json);

            var json2 = JsonConvert.SerializeObject(student);

            Console.WriteLine(json2);
        }

        public static bool GetMsg_type(string input, out string msg_type)
        {
            msg_type = "";
            try
            {
                var rootNode = JsonConvert.DeserializeXmlNode(input,"root");
                if (null == rootNode)
                {
                    return false;
                }
                var msgTypeNode = rootNode.SelectSingleNode("/root/msg_type");
                if (null == msgTypeNode)
                {
                    return false;
                }
                msg_type = msgTypeNode.InnerText;
            }
            catch (Exception ex)
            {
                LogHelp.logger.Info("GetMsg_type ex={0} input={1}", ex.Message, input);
                return false;
            }

            return true;
        }
    }
}
