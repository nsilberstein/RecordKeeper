using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using CPUFramework;
using RecordKeeperBizObjects;
using System.Data;
using NUnit.Framework;
using System.Data.SqlClient;

namespace RecordKeeperTest
{
    internal class DapperTest
    {
        int totalprez = 0;
        string connstring = "";
        int maxpreznum = 0;
        int maxprezid = 0;
        int prezwithexecorderid = 0;
        int maxpartyid = 0;

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
            dt = SQLUtility.GetDataTable(connstring, "select top 1 * from party order by partyid desc");
            maxpartyid = (int)dt.Rows[0]["PartyId"];

            
        }


        private List<BizPresident> LoadListPrez()
        {
            return BizPresident.GetAll();
        }
        private BizPresident LoadPrez(int Id)
        {
     
            BizPresident prez = BizPresident.Get(Id);
            return prez;
            
        }

        private BizPresident InsertNewPrez()
        {
            BizPresident prez = new BizPresident();
            prez.PartyId = maxpartyid;
            prez.FirstName = "Yonasan";
            prez.LastName = "Adams";
            prez.DateBorn = System.DateTime.Now.AddMonths(-420);
            prez.DateDied = System.DateTime.Now.AddMonths(24);
            prez.TermStart = System.DateTime.Now.Year;

            prez.Save();
            return prez;

        }

        private void SwapPrezFirstName(BizPresident prez)
        {
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            prez.LastName = firstname;
            prez.FirstName = lastname;
            prez.Save();
           
        }

        private int DeletePrez(int Id = 0)
        {
            BizPresident p;
            if(Id == 0)
            {
                p = this.InsertNewPrez();
            }
            else
            {
                p = this.LoadPrez(Id);
            }
         
            Id = p.PresidentId;
            p.Delete();
            return Id;
        }

        private void ChangePrezNum()
        {
            BizPresident prez = this.LoadPrez(maxprezid);
            prez.Num = prez.Num + 1;
            prez.Save();
            //DynamicParameters dp = new DynamicParameters(prez);
            //dp.Add("Message", "", direction: ParameterDirection.InputOutput);
            //dp.Add("return_value", "", direction: ParameterDirection.ReturnValue);
            //using (SqlConnection conn = GetConnection())
            //{
            //    conn.Execute("PresidentUpdate", dp, commandType: CommandType.StoredProcedure);
            //}
            //int ret = dp.Get<int>("return_value");
            //string msg = dp.Get<string>("Message");
            //if (ret == 1)
            //{
            //    throw new CPUException(msg);
            //}
        }




        [Test]
        public void TestLoadPrezList()
        {
            List<BizPresident> lst = this.LoadListPrez();
            Assert.IsTrue(lst.Count == totalprez);
            TestContext.WriteLine("num of prez " + lst.Count);
            Assert.IsTrue(lst.Count == totalprez);
        }

        [Test]
        public void TestLoadPrez()
        {
            BizPresident p = this.LoadPrez(maxprezid);
            TestContext.WriteLine(p.FullDescription());
            Assert.IsTrue(p.Num == maxpreznum);
        }

        [Test]
        public void TestLoadPrezByNum()
        {
            BizPresident p = BizPresident.Get("Num", maxpreznum);
            TestContext.WriteLine(p.FullDescription());
            Assert.IsTrue(p.PresidentId == maxprezid);
        }

        [Test]
        public void TestInsertNewPresident()
        {
            BizPresident p = this.InsertNewPrez();
            TestContext.WriteLine("Expected Prez Id > " + maxprezid + " Value = " + p.PresidentId);
            TestContext.WriteLine("Expected Num = " + (maxpreznum + 1) + " Value = " + p.Num);
            TestContext.WriteLine("Expected code not blank. Code = " + p.Code);
            Assert.IsTrue(p.Num == maxpreznum + 1 && p.PresidentId > maxprezid && string.IsNullOrEmpty(p.Code) == false);    
        }

        [Test]
        public void TestUpdatePrez()
        {
           BizPresident prez = this.LoadPrez(maxprezid);
            string lastname = prez.LastName;
            string firstname = prez.FirstName;
            this.SwapPrezFirstName(prez);
            prez = this.LoadPrez(maxprezid);
            TestContext.WriteLine("Original " + firstname + " " + lastname + " Current " + prez.FirstName + " " + prez.LastName);
            Assert.IsTrue(prez.LastName == firstname && prez.FirstName == lastname);
                     
        }
        [Test]
        public void TestDeletePrez()
        {
            int id = this.DeletePrez();
            BizPresident p = this.LoadPrez(id);
            Assert.IsTrue(p.PresidentId == 0);
        }

        [Test]
        public void TestDeletePrezWithExecOrder()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.DeletePrez(prezwithexecorderid));
            TestContext.WriteLine(ex?.FriendlyMessage);
        }

        [Test]
        public void TestChangePrezNum()
        {
            CPUException? ex = Assert.Throws<CPUException>(() => this.ChangePrezNum());
            TestContext.WriteLine(ex?.Message);
        }
        [Test]
        public void TestSearchPrez()
        {
            List<BizPresident> lst = BizPresident.Search("Bush");
            TestContext.WriteLine("List count = " + lst.Count.ToString());
            Assert.IsTrue(lst.Count == 2);
           
        }
    }
}
