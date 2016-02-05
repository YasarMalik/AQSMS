using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
 public   class EStudent
    {
        private int sid; //student id
        private int admno; //adminssion number
        private DateTime admdate; //admission date
        private string sname; //Student Name
        private DateTime dob; //Student Date of birth
        private string nationality; // Nationality
        private int classid;
        private string section;
        private string cname;
        private string prevschool;
        private string address;
        private string phone;
        private string fname; //Father Name
        private string fmobile; //Father Mobile Number
        private string mname; //Mother Name
        private string mmobile;// Mother Mobile Number
        private string guardian;
        private string fgaddress;
        private string wphone;
        private string email;
        private int scholarship;
        private string admstatus;
        private string remarks;
        private byte[] pic;


        public int SID { get { return sid; } set { sid = value; } }
        public int AdmNo { get { return admno; } set { admno = value; } }
        public DateTime AdmDate { get { return admdate; } set { admdate = value; } }
        public string SName { get { return sname; } set { sname = value; } }
        public DateTime DOB { get { return dob; } set { dob = value; } }
        public string Nationality { get { return nationality; } set { nationality = value; } }
        public int ClassID { get { return classid; } set { classid = value; } }
        public string Section { get { return section; } set { section = value; } }
        public string CName { get { return cname; } set { cname = value; } }
        public string PrevSchool { get { return prevschool; } set { prevschool = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string FName { get { return fname; } set { fname = value; } }
        public string FMobile { get { return fmobile; } set { fmobile = value; } }
        public string MName { get { return mname; } set { mname = value; } }
        public string MMobile { get { return mmobile; } set { mmobile = value; } }
        public string Guardian { get { return guardian; } set { guardian = value; } }
        public string FGAddress { get { return fgaddress; } set { fgaddress = value; } }
        public string WPhone { get { return wphone; } set { wphone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Scholarship { get { return scholarship; } set { scholarship = value; } }
        public string AdmStatus { get { return admstatus; } set { admstatus = value; } }
        public string Remarks { get { return remarks; } set { remarks = value; } }
        public byte[] PIC { get { return pic; } set { pic = value; } }


        public static bool AdmNoExists(int admno)//To check that admission number already exists or not
        {
            DbAccess db = new DbAccess();
            object c = db.ExecuteScalar("Select Count(*) from Student where AdmNo = '" + admno+ "'");

            if (Convert.ToInt32(c) == 0)
                return false;
            else
                return true;

        }

        public static int AdmNoExists2(int admno)
        {
            DbAccess db = new DbAccess();
            object c = db.ExecuteScalar("Select Count(*) from Student where AdmNo = '" + admno + "'");

            return (Convert.ToInt32(c));
             

        }


        public DataSet GetList() //Get list of all the students
        {
            DbAccess db = new DbAccess();
            return db.ExecuteSPDataSet("StudentList_List");
        }
    
        public bool Insert() 
        {

            DbAccess db = new DbAccess();
            SqlParameter[] prams ={ 
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,AdmNo),
               db.CreateInParam("@AdmDate",SqlDbType.Date,8,AdmDate),
               db.CreateInParam("@SName",SqlDbType.VarChar,50,SName ),
               db.CreateInParam("@DOB",SqlDbType.Date,8,DOB),
               db.CreateInParam("@Nationality",SqlDbType.VarChar,30,Nationality),
               db.CreateInParam("@ClassID",SqlDbType.Int,4,ClassID),
                   db.CreateInParam("@Section",SqlDbType.VarChar,10,Section),
               db.CreateInParam("@PrevSchool",SqlDbType.VarChar,300,PrevSchool),
               db.CreateInParam("@Address",SqlDbType.VarChar,300,Address),
               db.CreateInParam("@Phone",SqlDbType.VarChar,30,Phone),
               db.CreateInParam("@FName",SqlDbType.VarChar,50,FName),
               db.CreateInParam("@FMobile",SqlDbType.VarChar,30,FMobile),
               db.CreateInParam("@MName",SqlDbType.VarChar,50,MName),
               db.CreateInParam("@MMobile",SqlDbType.VarChar,30,MMobile),
               db.CreateInParam("@Guardian",SqlDbType.VarChar,50,Guardian),
               db.CreateInParam("@FGAddress",SqlDbType.VarChar,300,FGAddress),
               db.CreateInParam("@WPhone",SqlDbType.VarChar,30,WPhone),
               db.CreateInParam("@Email",SqlDbType.VarChar,30,Email),
               db.CreateInParam("@Scholarship",SqlDbType.VarChar,10,Scholarship),
               db.CreateInParam("@AdmStatus",SqlDbType.VarChar,100,AdmStatus),
               db.CreateInParam("@Remarks",SqlDbType.VarChar,300,Remarks),

               db.CreateInParam("@PIC",SqlDbType.Image,PIC.Length,PIC),

                                 };
            db.ExecuteStoredProcedure("Student_Insert", ref prams);

            return true;
        }

        public bool Update()
        {
            DbAccess db = new DbAccess();

            SqlParameter[] prams ={     
 db.CreateInParam("@SID",SqlDbType.Int,4,SID),
                db.CreateInParam("@AdmNo",SqlDbType.Int,4,AdmNo),
               db.CreateInParam("@AdmDate",SqlDbType.Date,8,AdmDate),
               db.CreateInParam("@SName",SqlDbType.VarChar,50,SName ),
               db.CreateInParam("@DOB",SqlDbType.Date,8,DOB),
               db.CreateInParam("@Nationality",SqlDbType.VarChar,30,Nationality),
               db.CreateInParam("@ClassID",SqlDbType.Int,4,ClassID),
                 db.CreateInParam("@Section",SqlDbType.VarChar,10,Section),
               db.CreateInParam("@PrevSchool",SqlDbType.VarChar,300,PrevSchool),
               db.CreateInParam("@Address",SqlDbType.VarChar,300,Address),
               db.CreateInParam("@Phone",SqlDbType.VarChar,30,Phone),
               db.CreateInParam("@FName",SqlDbType.VarChar,50,FName),
               db.CreateInParam("@FMobile",SqlDbType.VarChar,30,FMobile),
               db.CreateInParam("@MName",SqlDbType.VarChar,50,MName),
               db.CreateInParam("@MMobile",SqlDbType.VarChar,30,MMobile),
               db.CreateInParam("@Guardian",SqlDbType.VarChar,50,Guardian),
               db.CreateInParam("@FGAddress",SqlDbType.VarChar,300,FGAddress),
               db.CreateInParam("@WPhone",SqlDbType.VarChar,30,WPhone),
               db.CreateInParam("@Email",SqlDbType.VarChar,30,Email),
               db.CreateInParam("@Scholarship",SqlDbType.VarChar,10,Scholarship),
               db.CreateInParam("@AdmStatus",SqlDbType.VarChar,100,AdmStatus),
               db.CreateInParam("@Remarks",SqlDbType.VarChar,300,Remarks),

               db.CreateInParam("@PIC",SqlDbType.Image,PIC.Length,PIC),
                         };
            db.ExecuteStoredProcedure("Student_Update", ref prams);
            return true;
        }

        public DataSet GetListAdmNo(int admno)//get list by admission number
        {

            DbAccess db = new DbAccess();
            SqlParameter[] prams ={ 
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,admno),

                                 };
      return      db.ExecuteSPDataSet("StdListbyAdmNo", ref prams);
      
           
        }

        public DataSet LoadListClass(int clsid) //get list by classid
        {

            DbAccess db = new DbAccess();
            SqlParameter[] prams ={ 
               db.CreateInParam("@ClassID",SqlDbType.Int,4,clsid),

                                 };
            return db.ExecuteSPDataSet("StdListbyClass", ref prams);


        }

        public DataSet GetArrearsAdmNo(int admno)//get list by admission number
        {

            DbAccess db = new DbAccess();
            SqlParameter[] prams ={ 
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,admno),

                                 };
            return db.ExecuteSPDataSet("ArrearsbyAdmNo", ref prams);


        }

        public DataSet LoadArrearsClass(int clsid) //get list by classid
        {

            DbAccess db = new DbAccess();
            SqlParameter[] prams ={ 
               db.CreateInParam("@ClassID",SqlDbType.Int,4,clsid),

                                 };
            return db.ExecuteSPDataSet("ArrearstbyClass", ref prams);
        }

    }
}
