using System;
using System.Data;
using System.Configuration;

using System.Data.SqlClient;

namespace BL
{
    public enum TransactionStates
    {
        UnInit = 0,
        Running = 1,
        Committed = 2,
        RollBacked = 3,
        Ended = 4
    }
   public  class DbAccess:IDisposable 
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dap;
        private String connectionString;
        private DataSet currDataSet;
        private DataTable currDataTable;
        private Boolean m_disposed = false;
        private SqlTransaction m_transaction;
        private TransactionStates m_trans_state = TransactionStates.UnInit;

        public String ConnectionString
        {
            get { return ConnectionString; }
            set { connectionString = value; }
        }



        #region Constructor
        public DbAccess()
        {
            string strCon = ConfigurationManager.ConnectionStrings["AQSMS"].ConnectionString;
            conn = new SqlConnection(strCon);


            // conn = new SqlConnection("Data Source =YASAR-PC; Initial Catalog = BASRDB; Integrated Security = True;"); // for local system

            //  conn = new SqlConnection(@"Server=172.16.230.100\SQLEXPRESS;Database=BASRDB;User ID=sa;Password=sql123;"); // for networked system
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;

        }
       

        #endregion
        private SqlConnection GetConnection(string connString)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }

        #region Public Methods
        public DataSet ExecuteDataSet(string query, string tableName, DataSet ds)
        {
            SqlConnection con;
            using (con = GetConnection(connectionString))
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                dap = new SqlDataAdapter(cmd);

                dap.Fill(ds);
                return ds;

            }
        }
        public DataSet ExecuteDataSet(string query, string tableName)
        {
            DataSet ds = new DataSet();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            dap = new SqlDataAdapter(cmd);

            dap.Fill(ds, tableName);

            currDataSet = ds;

            return ds;
        }

        public int ExecuteNonQuery(string query)
        {
            //'cmd = New SqlClient.SqlCommand(NonQuery, conn)
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            int returnValue = cmd.ExecuteNonQuery();
            return returnValue;
        }
        //--------------------------------------------------------
        public DataTable ExecuteDataTable(String Query)
        {
            try
            {
                DataTable dt = new DataTable();
                dap = new SqlDataAdapter(Query, conn);
                dap.Fill(dt);
                currDataTable = dt;
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //--------------------------------------------------------
        public SqlDataReader ExecuteReader(String Query)
        {
            SqlDataReader dr;
            //'cmd = New SqlClient.SqlCommand(Query, conn)
            //'cmd.Connection = conn
            cmd.Parameters.Clear();
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            return dr;

        }
        //--------------------------------------------------------
        public SqlDataReader ExecuteReaderSP(String spName)
        {
            SqlDataReader dr;
            //'cmd = New SqlClient.SqlCommand(Query, conn)
            //'cmd.Connection = conn
            cmd.Parameters.Clear();
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            return dr;
        }
        //-----------------------------------------------------------------
        public SqlDataReader ExecuteReaderSP(String spName, ref  SqlParameter[] prams)
        {

            SqlDataReader dr;
            //'cmd = New SqlClient.SqlCommand(Query, conn)
            //'cmd.Connection = conn
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            for (int i = 0; i < prams.Length; i++)
            {
                cmd.Parameters.Add(prams[i]);
            }
            dr = cmd.ExecuteReader();
            return dr;

        }
        //------------------------------------------------------------------
        public SqlParameter CreateInParam(String paramName, System.Data.SqlDbType paramType, int paramSize, Object paramValue)
        {
            SqlParameter param1 = new SqlParameter(paramName, paramType, paramSize);
            param1.Direction = ParameterDirection.Input;
            param1.Value = paramValue;
            return param1;
        }
        //------------------------------------------------------------------
        public SqlParameter CreateOutParam(String paramName, System.Data.SqlDbType paramType, int paramSize)
        {
            SqlParameter param1 = new SqlParameter(paramName, paramType, paramSize);
            param1.Direction = ParameterDirection.Output;
            return param1;
        }
        //------------------------------------------------------------------
        public int ExecuteStoredProcedure(String spName, ref SqlParameter[] prams)
        {
            // 'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            cmd.Parameters.Clear();
            for (int i = 0; i < prams.Length; i++)
            {
                cmd.Parameters.Add(prams[i]);
            }

            int retVal = cmd.ExecuteNonQuery();
            return retVal;

        }
        //----------------------------------------------------------------------
        public int ExecuteStoredProcedure(String spName)
        {
            //    'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            cmd.Parameters.Clear();
            int retVal = cmd.ExecuteNonQuery();
            return retVal;
        }
        //----------------------------------------------------------------------
        public DataSet ExecuteSPDataSet(String spName, ref SqlParameter[] prams)
        {

            DataSet retVal = new DataSet();
            //'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            cmd.Parameters.Clear();

            for (int i = 0; i < prams.Length; i++)
            {
                cmd.Parameters.Add(prams[i]);
            }
            dap = new SqlDataAdapter(cmd);
            dap.Fill(retVal);
            currDataSet = retVal;
            return retVal;
        }
        //----------------------------------------------------------------------
        public DataSet ExecuteSPDataSet(String spName)
        {
            DataSet retVal = new DataSet();
            //'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            dap = new SqlDataAdapter(cmd);
            dap.Fill(retVal);
            currDataSet = retVal;
            return retVal;
        }
        //-------------------------------------
        public DataTable ExecuteSpDataTable(String spName)
        {
            DataTable retVal = new DataTable();
            //'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            dap = new SqlDataAdapter(cmd);
            dap.Fill(retVal);
            currDataTable = retVal;
            return retVal;

        }
        //------------------------------------
        public DataTable ExecuteSpDataTable(String spName, ref SqlParameter[] prams)
        {
            DataTable retVal = new DataTable();
            //'cmd = New SqlClient.SqlCommand(spName, conn)
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;
            cmd.Parameters.Clear();

            for (int i = 0; i < prams.Length; i++)
            {
                cmd.Parameters.Add(prams[i]);
            }
            dap = new SqlDataAdapter(cmd);
            dap.Fill(retVal);
            currDataTable = retVal;
            return retVal;
        }
        //------------------------------------
        public Object ExecuteScalar(String query) // returns single value ie sum, count id etc
        {
            Object retVal;
            //' cmd = New SqlClient.SqlCommand(query, conn)
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            retVal = cmd.ExecuteScalar();
            return retVal;
        }
        //--------------------------------------
        public int Update()
        {
            return dap.Update(currDataSet);
        }
        public int Update(string table)
        {
            SqlCommandBuilder comBuilder = new SqlCommandBuilder(dap);
            return dap.Update(currDataSet, table);
        }

        //---------------------------------------
        public Boolean BeginTransaction()
        {
            if (m_trans_state != TransactionStates.Running)
            {
                m_transaction = conn.BeginTransaction();
                cmd.Transaction = m_transaction;
                m_trans_state = TransactionStates.Running;
                return true;
            }
            else
            {
                throw new Exception("Cannot begin multiple transactions.ie Another transaction already in progress");
            }
            //return false;
        }

        //---------------------------------------------
        public Boolean Commit()
        {
            if (m_trans_state != TransactionStates.UnInit)
            {
                m_transaction.Commit();
                m_trans_state = TransactionStates.Committed;
                //'cmd.Transaction = Nothing
                return true;
            }
            else
            {
                throw new Exception("No transaction is in progress.Begin a transaction first to commit it.");
            }
            //return false;
        }

        //----------------------------------------------
        public Boolean RollBack()
        {
            //'If (m_trans_state = TransactionStates.Running) Then
            //'    m_transaction.Rollback()
            //'    m_trans_state = TransactionStates.RollBacked
            //'    cmd.Transaction = Nothing
            //'    Return True
            //'Else
            //'    Throw New Exception("No transaction is in progress.Begin a transaction first to Rollback it.")
            //'End If
            //'Return False
            if (cmd.Transaction != null)
            {
                m_transaction.Rollback();
                m_trans_state = TransactionStates.RollBacked;
                cmd.Transaction = null;
                return true;
            }
            else
                throw new Exception("No transaction is in progress.Begin a transaction first to Rollback it.");
        }
        //--------------------------------------------------
        public void EndTransaction()
        {
            m_trans_state = TransactionStates.Ended;
            cmd.Transaction = null;
        }

        #endregion


        #region Private Member Functions
        protected void Dispose(Boolean disposing)
        {
            if (disposing)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            // Free unmanaged resources
            m_disposed = true;

        }
        #endregion

        #region Destructor
        protected void Finalize()
        {
            Dispose(false);
        }
        #endregion
        #region IDisposable Members

        public void Dispose()
        {
            if (!m_disposed)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        #endregion

    }
}
