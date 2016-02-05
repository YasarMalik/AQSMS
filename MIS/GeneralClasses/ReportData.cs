using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Data;
using BL;
using MIS.Reports;

namespace MIS
{
  public  class ReportData
    {

      //public static ReportClass GetBundleCourseWise(string year, string semester, string code)
      //{
      //    using (DbAccess db = new DbAccess())
      //    {
      //        SqlParameter[] prams ={                   
      //              db.CreateInParam("@CourseCode",SqlDbType.VarChar ,10,code),
      //              db.CreateInParam("@Year",SqlDbType.VarChar ,10,year),
      //              db.CreateInParam("@Semester",SqlDbType.VarChar ,10,semester)
     
      //          };
      //        DataSet ds = db.ExecuteSPDataSet("CourseWiseBundle_List", ref prams);
      //        rptBundlesbyCourse rpt = new rptBundlesbyCourse();
      //         ds.Tables[0].TableName = "CourseWiseBundle_List";
      //        rpt.SetDataSource(ds.Tables[0]);
      //        return rpt;
      //    }
      //}
      //public static ReportClass GetAllBundleCourseWiseExaminer(string year, string semester, string code)
      //{
      //    using (DbAccess db = new DbAccess())
      //    {
      //        SqlParameter[] prams ={                   
      //              db.CreateInParam("@CourseCode",SqlDbType.VarChar ,10,code),
      //              db.CreateInParam("@Year",SqlDbType.VarChar ,10,year),
      //              db.CreateInParam("@Semester",SqlDbType.VarChar ,10,semester)
     
      //          };
      //        DataSet ds = db.ExecuteSPDataSet("BundlebyCourseWithExaminer", ref prams);

      //        BundlebyCoursewithExaminer rpt = new BundlebyCoursewithExaminer();
      //        ds.Tables[0].TableName = "BundlebyCourseWithExaminer";
      //        rpt.SetDataSource(ds.Tables[0]);
      //        return rpt;
      //    }
      //}
      //public static ReportClass GetAllBundleCourseWiseHall(string year, string semester, string code)
      //{
      //    using (DbAccess db = new DbAccess())
      //    {
      //        SqlParameter[] prams ={                   
      //              db.CreateInParam("@CourseCode",SqlDbType.VarChar ,10,code),
      //              db.CreateInParam("@Year",SqlDbType.VarChar ,10,year),
      //              db.CreateInParam("@Semester",SqlDbType.VarChar ,10,semester)
     
      //          };
      //        DataSet ds = db.ExecuteSPDataSet("BundleByCourseWithHall", ref prams);

      //        rptBundlebyCoursewithHall rpt = new rptBundlebyCoursewithHall();
      //        ds.Tables[0].TableName = "BundleByCourseWithHall";
      //        rpt.SetDataSource(ds.Tables[0]);
      //        return rpt;
      //    }
      //}

      //public static ReportClass GetBundleCenterWise(string year, string semester, string code)
      //{
      //    using (DbAccess db = new DbAccess())
      //    {
      //        SqlParameter[] prams ={                   
      //              db.CreateInParam("@CenterCode",SqlDbType.VarChar ,10,code),
      //              db.CreateInParam("@Year",SqlDbType.VarChar ,10,year),
      //              db.CreateInParam("@Semester",SqlDbType.VarChar ,10,semester)
                    
      //          };
      //        DataSet ds = db.ExecuteSPDataSet("CenterWiseBundle_List", ref prams);
      //        rptBundleByCenter rpt = new rptBundleByCenter();
      //        ds.Tables[0].TableName = "CenterWiseBundle_List";
      //        rpt.SetDataSource(ds.Tables[0]);
      //        return rpt;
      //    }
      //}

      //public static ReportClass GetBundlebyAllCenters(string year, string semester)
      //{
      //    using (DbAccess db = new DbAccess())
      //    {
      //        SqlParameter[] prams ={                   
                   
      //              db.CreateInParam("@Year",SqlDbType.VarChar ,10,year),
      //              db.CreateInParam("@Semester",SqlDbType.VarChar ,10,semester)
                 
      //          };
      //        DataSet ds = db.ExecuteSPDataSet("Bundle_List", ref prams);
      //        rptBundlesByAllCenters rpt = new rptBundlesByAllCenters();
      //         ds.Tables[0].TableName = "Bundle_List";
      //        rpt.SetDataSource(ds.Tables[0]);
      //        return rpt;
      //    }
      //}
      
    }
}
