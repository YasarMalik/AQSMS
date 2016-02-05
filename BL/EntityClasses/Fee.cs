using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
 public   class Fee
    {
     private int sfid;
        private int sid;
        private int admno;
        private int classid;
        private string receiptno;
        private  string year;
        private string month;
        private int regfee;
        private int admfee;
        private int secfee;
        private int examsfee;
        private int sportsfee;
        private int tutionfee;
        private int collegefund;
        private int computerfee;
        private int transfee;
        private int latefee;
        private int misc;
        private int total;
        private int payed;
        private DateTime paydate;
        private int currarrs;
        private int prevarrs;

        public int SFID { get { return sfid; } set { sfid = value; } }
        public int SID { get { return sid; } set { sid = value; } }
        public int AdmNo { get { return admno; } set { admno = value; } }
        public int ClassID { get { return classid; } set { classid = value; } }
        public string RecptNo { get { return receiptno; } set { receiptno = value; } }
        public string Year { get { return year; } set { year = value; } }
        public string Month { get { return month; } set { month = value; } }
        public int RegFee { get { return regfee; } set { regfee = value; } }
        public int AdmFee { get { return admfee; } set { admfee = value; } }
        public int SecFee { get { return secfee; } set { secfee = value; } }
        public int ExamsFee { get { return examsfee; } set { examsfee = value; } }
        public int SportsFee { get { return sportsfee; } set { sportsfee = value; } }
        public int TutionFee { get { return tutionfee; } set { tutionfee = value; } }
        public int CollegeFund { get { return collegefund; } set { collegefund = value; } }
        public int CompFee { get { return computerfee; } set { computerfee = value; } }
        public int TransportFee { get { return transfee; } set { transfee = value; } }
        public int LateFee { get { return latefee; } set { latefee = value; } }
        public int Misc { get { return misc; } set { misc = value; } }
        public int Total { get { return total; } set { total = value; } }
        public int Payed { get { return payed; } set { payed = value; } }
        public DateTime PayDate { get { return paydate; } set { paydate = value; } }
        public int CurrArrears { get { return currarrs; } set { currarrs = value; } }
        public int PrevArrears { get { return prevarrs; } set { prevarrs = value; } }

    

     public DataTable TotrecpNos(int adno)
        {
            using (DbAccess db = new DbAccess())
            {
                DataTable dt = db.ExecuteDataTable("select COUNT(ReceiptNo) trecpno from StudentFee where AdmNo='" + adno + "'");
                //where UID='" + id + "'
                return dt;
            }

        }


     public DataTable GetMaxSFID(int admno) //Get Max Fee ID for Fee Table
        {
            DbAccess db = new DbAccess();
            SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                
           
            };
            return db.ExecuteSpDataTable("MAXSFID", ref prams);

        }

     public DataTable GetMaxRecpNo(int admno) //Max receipt Number
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                
           
            };
         return db.ExecuteSpDataTable("GetMaxReceiptIndex", ref prams);

     }
     public DataSet LoadFreshFee(int admno) // Fee for a fresh student
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                
           
            };
         return db.ExecuteSPDataSet("LoadFreshFee", ref prams);

     }

     public DataSet LoadOldFee(int admno) //Fee for old students
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                
           
            };
         return db.ExecuteSPDataSet("StudentFeeOld_Load", ref prams);

     }

     public DataSet LoadStudentFee(int admno)
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                           
            };

         return db.ExecuteSPDataSet("StudentFee_Load", ref prams);

     }

     public DataSet LoadStudentFeeByReceipt(string recpno)
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@ReceiptNo",SqlDbType.VarChar,20,recpno),
                           
            };

         return db.ExecuteSPDataSet("StudentFee_Receipt", ref prams);

     }



     public DataSet LoadStudentFeeByClass(int cls)
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={   
                                  
                db.CreateInParam("@ClassID",SqlDbType.Int ,4,cls),
                           
            };

         return db.ExecuteSPDataSet("StudentFeeByClass_Load", ref prams);

     }

     public bool Insert()
     {

         DbAccess db = new DbAccess();
         SqlParameter[] prams ={ 
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,AdmNo),
               db.CreateInParam("@RecptNo",SqlDbType.VarChar,20,RecptNo),
               db.CreateInParam("@Year",SqlDbType.VarChar,10,Year ),
               db.CreateInParam("@Month",SqlDbType.VarChar,10,Month),
               db.CreateInParam("@RegFee",SqlDbType.Int,4,RegFee),
               db.CreateInParam("@AdmFee",SqlDbType.Int,4,AdmFee),
               db.CreateInParam("@SecFee",SqlDbType.Int,4,SecFee),
               db.CreateInParam("@ExamsFee",SqlDbType.Int,4,ExamsFee),
               db.CreateInParam("@SportsFee",SqlDbType.Int,4,SportsFee),
               db.CreateInParam("@TutionFee",SqlDbType.Int,4,TutionFee),
               db.CreateInParam("@CollFund",SqlDbType.Int,4,CollegeFund),
               db.CreateInParam("@CompFee",SqlDbType.Int,4,CompFee),
                db.CreateInParam("@TransFee",SqlDbType.Int,4,TransportFee),
               db.CreateInParam("@LateFee",SqlDbType.Int,4,LateFee),
               db.CreateInParam("@Misc",SqlDbType.Int,4,Misc),
               db.CreateInParam("@Total",SqlDbType.Int,4,Total),
               db.CreateInParam("@Payed",SqlDbType.Int,4,Payed),
               db.CreateInParam("@PayDate",SqlDbType.DateTime,8,PayDate),
               db.CreateInParam("@CurrArrears",SqlDbType.Int,4,CurrArrears),
               db.CreateInParam("@PrevArrears",SqlDbType.Int,4,PrevArrears),
                                 };
         db.ExecuteStoredProcedure("StudentFee_Insert", ref prams);

         return true;
     }

     public bool Update()
     {
         DbAccess db = new DbAccess();

         SqlParameter[] prams ={     
               
               db.CreateInParam("@SFID",SqlDbType.Int,4,SFID),

               db.CreateInParam("@SID",SqlDbType.Int,4,SID),
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,AdmNo),
               db.CreateInParam("@ClassID",SqlDbType.Int,4,ClassID),
               db.CreateInParam("@RecptNo",SqlDbType.VarChar,20,RecptNo),
               db.CreateInParam("@Year",SqlDbType.VarChar,10,Year ),
               db.CreateInParam("@Month",SqlDbType.VarChar,10,Month),
               db.CreateInParam("@RegFee",SqlDbType.Int,4,RegFee),
               db.CreateInParam("@AdmFee",SqlDbType.Int,4,AdmFee),
               db.CreateInParam("@SecFee",SqlDbType.Int,4,SecFee),
               db.CreateInParam("@ExamsFee",SqlDbType.Int,4,ExamsFee),
               db.CreateInParam("@SportsFee",SqlDbType.Int,4,SportsFee),
               db.CreateInParam("@TutionFee",SqlDbType.Int,4,TutionFee),
               db.CreateInParam("@CollFund",SqlDbType.Int,4,CollegeFund),
               db.CreateInParam("@CompFee",SqlDbType.Int,4,CompFee),
               db.CreateInParam("@TransFee",SqlDbType.Int,4,TransportFee),
               db.CreateInParam("@LateFee",SqlDbType.Int,4,LateFee),
               db.CreateInParam("@Misc",SqlDbType.Int,4,Misc),
               db.CreateInParam("@Total",SqlDbType.Int,4,Total),
               db.CreateInParam("@Payed",SqlDbType.Int,4,Payed),
               db.CreateInParam("@PayDate",SqlDbType.DateTime,8,PayDate),
               db.CreateInParam("@CurrArrears",SqlDbType.Int,4,CurrArrears),
               db.CreateInParam("@PrevArrears",SqlDbType.Int,4,PrevArrears),
                         };
         db.ExecuteStoredProcedure("StudentFee_Update", ref prams);
         return true;
     }


     public bool UpdateArrears()
     {
         DbAccess db = new DbAccess();

         SqlParameter[] prams ={     
               
              
               db.CreateInParam("@AdmNo",SqlDbType.Int,4,AdmNo),
             
               db.CreateInParam("@Arrears",SqlDbType.Int,4,CurrArrears),
                         };
         db.ExecuteStoredProcedure("ArrearsUpdate", ref prams);
         return true;
     }




     public bool SetPayed(int sfid, int admno, int tot, int payed, string status)
     {

         DbAccess db = new DbAccess();
         SqlParameter[] prams ={ 
               db.CreateInParam("@SFID",SqlDbType.Int,4,sfid),
                db.CreateInParam("@AdmNo",SqlDbType.Int,4,admno),
                 db.CreateInParam("@Payed",SqlDbType.Int,4,payed),
                 db.CreateInParam("@Total",SqlDbType.Int,4,tot),
                    db.CreateInParam("@Status",SqlDbType.VarChar,30,status),
              // db.CreateInParam("@RecptNo",SqlDbType.VarChar,20,RecptNo),
 
                                 };
         db.ExecuteStoredProcedure("SetPayed", ref prams);

         return true;
     }


     public bool SetNotPayed(int sfid, int admno, int payed, int tot, string status)
     {

         DbAccess db = new DbAccess();
         SqlParameter[] prams ={ 
               db.CreateInParam("@SFID",SqlDbType.Int,4,sfid),
                db.CreateInParam("@AdmNo",SqlDbType.Int,4,admno),
                 db.CreateInParam("@Payed",SqlDbType.Int,4,payed),
                 db.CreateInParam("@Total",SqlDbType.Int,4,tot),
                    db.CreateInParam("@Status",SqlDbType.VarChar,30,status),
              // db.CreateInParam("@RecptNo",SqlDbType.VarChar,20,RecptNo),
 
                                 };
         db.ExecuteStoredProcedure("SetNotPayed", ref prams);

         return true;
     }

     public bool SetCanceled(int sfid,int admno,int payed,int tot,string status,int parrs)
     {

         DbAccess db = new DbAccess();
         SqlParameter[] prams ={ 
               db.CreateInParam("@SFID",SqlDbType.Int,4,sfid),
                db.CreateInParam("@AdmNo",SqlDbType.Int,4,admno),
                 db.CreateInParam("@Payed",SqlDbType.Int,4,payed),
                 db.CreateInParam("@Total",SqlDbType.Int,4,tot),
                 db.CreateInParam("@PrevArrears",SqlDbType.Int,4,parrs),
                    db.CreateInParam("@Status",SqlDbType.VarChar,30,status),
              // db.CreateInParam("@RecptNo",SqlDbType.VarChar,20,RecptNo),
 
                                 };
         db.ExecuteStoredProcedure("SetCanceled", ref prams);

         return true;
     }

     public DataTable TransactionStatus(int admno)
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={                
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                
           
            };
         return db.ExecuteSpDataTable("LastTransactionStatus", ref prams);

     }

     public DataSet LoadArrearsList()
     {
         DbAccess db = new DbAccess();
         return db.ExecuteSPDataSet("ArrearList");

     }

     public DataSet MonthlyFeeRem(int admno)
     {
         DbAccess db = new DbAccess();
         SqlParameter[] prams ={   
                                  
                db.CreateInParam("@AdmNo",SqlDbType.Int ,4,admno),
                           
            };

         return db.ExecuteSPDataSet("MonthlyFeeReminder", ref prams);

     }


    }
}
