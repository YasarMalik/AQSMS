using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BL
{

  public class EUser
  {

      private int userid;
      private string username;
      private string password;
      private int roleid; //user roll form roll table
      private string department;
      private string designation;
      private string cnic;
      public int UserID { get {return userid ;} set { userid=value;} }
      public string UserName  { get { return username; } set { username = value; } }
      public string Password { get { return password; } set { password = value; } }
      public int RoleID { get { return roleid ; } set { roleid = value; } }
      public string Department { get { return department; } set { department = value; } }
      public string Designation { get { return designation; } set { designation = value; } }
      public string CNIC { get { return cnic; } set { cnic = value; } }

      public bool Insert()
      {

          DbAccess db = new DbAccess();


          SqlParameter[] prams ={ 
               db.CreateInParam("@UserName",SqlDbType.VarChar,50,UserName),
               db.CreateInParam("@Password",SqlDbType.VarChar,20,Password),
                db.CreateInParam("@RoleID",SqlDbType.Int,4,RoleID),
                 db.CreateInParam("@Section",SqlDbType.VarChar,30,Department),
                   db.CreateInParam("@Designation",SqlDbType.VarChar,30,Designation),
                     db.CreateInParam("@CNIC",SqlDbType.VarChar,15,CNIC),
              
             
            };
          db.ExecuteStoredProcedure("User_Insert", ref prams);

          return true;
      }

      public bool Update()
      {
          DbAccess db = new DbAccess();

          SqlParameter[] prams ={            
      db.CreateInParam("@UID",SqlDbType.Int,4,UserID),
              db.CreateInParam("@UserName",SqlDbType.VarChar,50,UserName),
               db.CreateInParam("@Password",SqlDbType.VarChar,20,Password),
                db.CreateInParam("@RoleID",SqlDbType.Int,4,RoleID),
                 db.CreateInParam("@Section",SqlDbType.VarChar,30,Department),
                   db.CreateInParam("@Designation",SqlDbType.VarChar,30,Designation),
                     db.CreateInParam("@CNIC",SqlDbType.VarChar,15,CNIC),
               
            };
          db.ExecuteStoredProcedure("User_Update", ref prams);
          return true;
      }
      public DataTable GetRoles() // Get all the user's roll from roll Table
      {
          using (DbAccess db = new DbAccess())
          {
              DataTable dt = db.ExecuteDataTable("select * from Role");
              return dt;
          }

      }
      public DataSet GetListSpecific(string uname,string pwd,int roleid)
      {
          DbAccess db = new DbAccess();
          SqlParameter[] prams ={                
                db.CreateInParam("@UserName",SqlDbType.VarChar ,50,uname),
                db.CreateInParam("@Password",SqlDbType.VarChar,20,pwd ),
                db.CreateInParam("@RoleID",SqlDbType.Int,4,roleid),
           
            };
          return db.ExecuteSPDataSet("CheckLogin", ref prams);

      }
      public bool ChangePwd(int uid,string pwd)
      {
          DbAccess db = new DbAccess();

          SqlParameter[] prams ={                
               db.CreateInParam("@UID",SqlDbType.Int,4,uid),
              db.CreateInParam("@Password",SqlDbType.VarChar,10,pwd),
                             
            };
          db.ExecuteStoredProcedure("User_ChangePwd", ref prams);
          return true;
      }

      public DataTable GetRole()
      {
          using (DbAccess db = new DbAccess())
          {
              DataTable dt = db.ExecuteDataTable("select * from Role");
              return dt;
          }

      }

      public DataSet GetList()
      {
          DbAccess db = new DbAccess();
          return db.ExecuteSPDataSet("AllUsers_List");
      }

    }
}
