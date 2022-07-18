using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GrammarStudy
{
    public class CCallBack
    {
        public const string RelativeDir = @"D:\work\code\study\github\CPlusStudy\build\callback\Debug\callbakc.dll";

        public delegate void DATACALLBACK(IntPtr pData1, int lenth1,
            IntPtr pData2, int lenth2,
            IntPtr pData3, int lenth3);

        [DllImport(RelativeDir)]
        public static extern int SetCallBack(DATACALLBACK dATACALLBACK);

        [DllImport(RelativeDir)]
        public static extern int GetData();

        public DATACALLBACK m_DATACALLBACK = new DATACALLBACK(callback);
        public static void callback(IntPtr pData1, int lenth1,
            IntPtr pData2, int lenth2,
            IntPtr pData3, int lenth3)
        {
            byte[] bBuf1 = new byte[lenth1];
            Marshal.Copy(pData1, bBuf1, 0, lenth1);
            var sData = System.Text.Encoding.UTF8.GetString(bBuf1);


            byte[] bBuf2 = new byte[lenth2];
            Marshal.Copy(pData2, bBuf2, 0, lenth2);
            var sData1 = System.Text.Encoding.UTF8.GetString(bBuf2);

            byte[] bBuf3 = new byte[lenth3];
            Marshal.Copy(pData3, bBuf3, 0, lenth3);
            var sData2 = System.Text.Encoding.UTF8.GetString(bBuf3);

            LogHelp.logger.Info(sData);
            LogHelp.logger.Info(sData1);
            LogHelp.logger.Info(sData2);
        }
    }
    
}
