using NUnit.Framework;
using RecordKeeperBizObjects;
using System.Data;
using CPUFramework;
using Dapper;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    public class Tests
    {
        int totalprez = 0;
        string connstring = "";
        int maxpreznum = 0;
        int maxprezid = 0;
        int prezwithexecorderid = 0;

        [SetUp]
        public void Setup()
        {
           connstring = DataUtility.SetConnectionString("nsilberstein.database.windows.net,1433", "RecordKeeperDB", "nsilbersteinadmin", "CPU123!@#");
           DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from president");
           totalprez = (int)dt.Rows[0]["total"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.PresidentId, p.Num from president p order by p.Num desc");
            maxpreznum = (int)dt.Rows[0]["Num"];
            maxprezid = (int)dt.Rows[0]["PresidentId"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.PresidentId, p.Num from president p join ExecutiveOrder e on e.PresidentId = p.PresidentId order by p.Num desc");
            prezwithexecorderid = (int)dt.Rows[0]["PresidentId"];
        }

        //[Test]
        //public void TestPresidentList()
        //{
        //    DataTable dt = DataService.GetPresidentList();
        //    TestContext.WriteLine("Num presidents " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == totalprez);


        //    Assert.Pass();
        //}
        //[Test]
        //public void TestPartyList()
        //{
        //    DataTable dt = DataService.GetPartyList();
        //    TestContext.WriteLine("Num Parties " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == 7);
           
        //}
        //[Test]
        //public void TestUSGovSummary()
        //{
        //    DataTable dt = DataService.GetUSGovRecordSummary();
        //    TestContext.WriteLine("Num records for summary " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == 3);
        
        //}
        //[Test]
        //public void TestLoadPresidentDapper()
        //{
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        BizPresident prez = conn.QueryFirstOrDefault<BizPresident>("select top 1 * from president order by num");
        //        TestContext.WriteLine(prez.FullDescription());
        //    }
        //}

        //[Test]
        //public void TestLoadPresident()
        //{
        //    BizPresident prez = BizPresident.Get(maxprezid);
        //    TestContext.WriteLine("Prez FullDescription = " + prez.FullDescription());
        //    Assert.IsTrue(prez.Num == maxpreznum);
        //}

        //[Test]
        //public void TestNewPresident()
        //{
        //    BizPresident prez = new BizPresident();
        //    prez.FirstName = "Yonasan";
        //    prez.LastName = "Adams";
        //    prez.DateBorn = System.DateTime.Now.AddMonths(-420);
        //    prez.DateDied = System.DateTime.Now.AddMonths(24);
        //    prez.TermStart = System.DateTime.Now.Year;
        //    prez.Save();
        //    TestContext.WriteLine("New president num = " + prez.Num.ToString() + " should be " + (maxpreznum + 1));
        //    Assert.IsTrue(prez.Num == maxpreznum + 1);
        //}

        //[Test]
        //public void TestChangePresidentNumber()
        //{
        //    BizPresident prez = BizPresident.Get(maxprezid);
        //    prez.Num = prez.Num + 1;
        //    Assert.Throws<CPUException>(() => prez.Save(), "You cannot change a president's number");
        //    TestContext.WriteLine(prez.FullDescription());
        //}

        //[Test]
        //public void TestDeletePresidentWithExecutiveOrder()
        //{
        //    BizPresident prez = BizPresident.Get(prezwithexecorderid);
        //    Assert.Throws<CPUException>(() => prez.Delete());
        //}
    }
}