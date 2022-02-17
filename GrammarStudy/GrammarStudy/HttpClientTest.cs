using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GrammarStudy
{
    public class HttpClientTest
    {
        HttpClient client = new HttpClient();

        public void TestGet()
        {
            //增加自定义head
            client.DefaultRequestHeaders.Add("token", "12345");
            var url = "http://127.0.0.1:8080/TestGet?count=99";

            var rsp = client.GetAsync(url).Result;
            LogHelp.logger.Info(rsp.StatusCode);
            LogHelp.logger.Info(rsp.Content.ReadAsStringAsync().Result);
        }

        public void TestPost()
        {
            //增加自定义head
            client.DefaultRequestHeaders.Add("token", "12345");
            var url = "http://127.0.0.1:8080/TestPost";

            HttpContent httpContent = new StringContent("8888888888888");
            var rsp = client.PostAsync(url,httpContent).Result;
            LogHelp.logger.Info(rsp.StatusCode);
            LogHelp.logger.Info(rsp.Content.ReadAsStringAsync().Result);
        }

    }
}
