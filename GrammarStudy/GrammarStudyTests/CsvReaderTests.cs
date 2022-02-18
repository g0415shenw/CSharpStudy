using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrammarStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GrammarStudy.Tests
{
    [TestClass()]
    public class CsvReaderTests
    {
        [TestMethod()]
        public void readCSVTest()
        {

            // 调用方法
            string FilePath_3 = "zuobiao.CSV";  // csv文件地址
            DataTable data = new DataTable();
            CsvReader.readCSV(FilePath_3, out data); // 调用函数

            // 遍历table 中的所有数据
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    object obj = data.Rows[i][j]; //i行j列的值 
                    Console.WriteLine("mulRea11= {0}", obj);
                }

            }
        }
    }
}