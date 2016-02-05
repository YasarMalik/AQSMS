using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
  public  class EClass
  {
      private int cid;
      private string cname;
      private string desc;

      public int CID { get { return cid; } set { cid = value; } }
      public string CName { get { return cname; } set { cname = value; } }
      public string Desc { get { return desc; } set { desc = value; } }

      public DataTable GetClasses()
      {
          using (DbAccess db = new DbAccess())
          {
              DataTable dt = db.ExecuteDataTable("select * from Class");
              return dt;
          }

      }


      public bool Insert()
      {

          DbAccess db = new DbAccess();


          SqlParameter[] prams ={ 
               db.CreateInParam("@CName",SqlDbType.VarChar,50,CName),
               db.CreateInParam("@Desc",SqlDbType.VarChar,20,Desc),
                
             
            };
          db.ExecuteStoredProcedure("Class_Insert", ref prams);

          return true;
      }

      public bool Update()
      {
          DbAccess db = new DbAccess();

          SqlParameter[] prams ={            
                db.CreateInParam("@CID",SqlDbType.Int,4,CID),
                db.CreateInParam("@CName",SqlDbType.VarChar,50,CName),
               db.CreateInParam("@Desc",SqlDbType.VarChar,20,Desc),
                
            };
          db.ExecuteStoredProcedure("Class_Update", ref prams);
          return true;
      }



    }
}
