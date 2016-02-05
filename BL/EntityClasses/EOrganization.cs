using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
  public  class EOrganization
  {
      public bool Update(string names,string cont,string dycont,string phone,string email,string add)
      {
          DbAccess db = new DbAccess();

          SqlParameter[] prams ={                
               
              db.CreateInParam("@Name",SqlDbType.VarChar,100,names),
               db.CreateInParam("@Controller",SqlDbType.VarChar,50,cont),
               db.CreateInParam("@DyController",SqlDbType.VarChar,200,dycont),
               db.CreateInParam("@Phone",SqlDbType.VarChar,200,phone),
               db.CreateInParam("@Email",SqlDbType.VarChar,200,email),
               db.CreateInParam("@Address",SqlDbType.VarChar,200,add),
               
            };
          db.ExecuteStoredProcedure("Org_Update", ref prams);
          return true;
      }
      public DataTable GetList()
      {
          DbAccess db = new DbAccess();
          return db.ExecuteDataTable("Org_List");
      }
    }
}
