using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestIntroduction
{
    /// <summary>
    /// CollectionAssertSample 的摘要描述
    /// </summary>
    [TestClass]
    public class CollectionAssertSample
    {
        public CollectionAssertSample()
        {
            //
            // TODO:  在此加入建構函式的程式碼
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合
        ///的相關資訊與功能的測試內容。
        ///</summary>
        //public TestContext TestContext
        //{
        //	get
        //	{
        //		return testContextInstance;
        //	}
        //	set
        //	{
        //		testContextInstance = value;
        //	}
        //}

        #region 其他測試屬性

        //
        // 您可以使用下列其他屬性撰寫您的測試:
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //

        #endregion 其他測試屬性      

        [TestMethod()]
        public void 分頁取值_3筆一組_取Cost總和_結果為6_15_24_21()
        {
            //arrange 
            //準備好資料清單
            var DateList = new List<DateList>
            {
                {new DateList { Id = 1,  Cost = 1,  Revenue= 11, SellPrice=21 } },
                {new DateList { Id = 2,  Cost = 2,  Revenue= 12, SellPrice=22 } },
                {new DateList { Id = 3,  Cost = 3,  Revenue= 13, SellPrice=23 } },
                {new DateList { Id = 4,  Cost = 4,  Revenue= 14, SellPrice=24 } },
                {new DateList { Id = 5,  Cost = 5,  Revenue= 15, SellPrice=25 } },
                {new DateList { Id = 6,  Cost = 6,  Revenue= 16, SellPrice=26 } },
                {new DateList { Id = 7,  Cost = 7,  Revenue= 17, SellPrice=27 } },
                {new DateList { Id = 8,  Cost = 8,  Revenue= 18, SellPrice=28 } },
                {new DateList { Id = 9,  Cost = 9,  Revenue= 19, SellPrice=29 } },
                {new DateList { Id = 10, Cost = 10, Revenue= 20, SellPrice=30 } },
                {new DateList { Id = 11, Cost = 11, Revenue= 21, SellPrice=31 } },
            };

            //act 
            //經過計算取得一組數字:6, 15, 24, 21
            //calculate(上面準備的list,N筆一組,取哪一欄位)
            List<int> actual = calculate(DateList, 3, "Cost");

            //assert 
            List<int> expected = new List<int> { 6, 15, 24, 21 };
            //做比較
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void 分頁取值_4筆一組_取Revenue總和_結果為_50_66_60()
        {
            //arrange 
            var DateList = new List<DateList>
            {
                {new DateList { Id = 1,  Cost = 1,  Revenue= 11, SellPrice=21 } },
                {new DateList { Id = 2,  Cost = 2,  Revenue= 12, SellPrice=22 } },
                {new DateList { Id = 3,  Cost = 3,  Revenue= 13, SellPrice=23 } },
                {new DateList { Id = 4,  Cost = 4,  Revenue= 14, SellPrice=24 } },
                {new DateList { Id = 5,  Cost = 5,  Revenue= 15, SellPrice=25 } },
                {new DateList { Id = 6,  Cost = 6,  Revenue= 16, SellPrice=26 } },
                {new DateList { Id = 7,  Cost = 7,  Revenue= 17, SellPrice=27 } },
                {new DateList { Id = 8,  Cost = 8,  Revenue= 18, SellPrice=28 } },
                {new DateList { Id = 9,  Cost = 9,  Revenue= 19, SellPrice=29 } },
                {new DateList { Id = 10, Cost = 10, Revenue= 20, SellPrice=30 } },
                {new DateList { Id = 11, Cost = 11, Revenue= 21, SellPrice=31 } },
            };

            //act 
            //經過計算取得一組數字:50, 66, 60
            //calculate(上面準備的list,N筆一組,取哪一欄位)
            List<int> actual = calculate(DateList, 4, "Revenue");

            //assert  
            List<int> expected = new List<int> { 50, 66, 60 };
            //做比較
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}