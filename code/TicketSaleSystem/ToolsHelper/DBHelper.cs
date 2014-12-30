using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Text;

namespace ToolsHelper
{
    /// <summary>
    /// Author: Solan
    /// Date: 2014-12-26 22:59:13
    /// 数据访问基础类
    /// </summary>
    public class DBHelper
    {
        // 数据库连接字符串
        // 命名规则： DataType 的 value 值是下一节点中的起始字符串
        // <add key="DataType" value="Oracle" />
        // <add key="OracleConnectionString" value="Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.225)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=rhdb)));Persist Security Info=True;User ID=user_dss;Password=manager123;Unicode=True;Omit Oracle Connection Name=True" />
        // <add key="SQLServerConnectionString" value="Data Source=192.168.2.105;Initial Catalog=TicketSaleSystem;User ID=sa;Password=sa123;Integrated Security=False" />
        private static string connectionString;
        public static string ConntionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        public DBHelper(string strConnect, string dataType)
        {
            ConntionString = strConnect;
            DbType = dataType;
        }

        public DBHelper()
        {
            dbType = ConfigurationSettings.AppSettings["DataType"];
            connectionString = ConfigurationSettings.AppSettings[dbType + "ConnectionString"];
        }

        /// <summary>
        /// 数据库类型 
        /// </summary>
        private static string dbType;
        public static string DbType
        {
            get
            {
                if (dbType == string.Empty || dbType == null)
                {
                    return "Oracle";
                }
                else
                {
                    return dbType;
                }
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    dbType = value;
                }
                if (dbType == string.Empty || dbType == null)
                {
                    dbType = "Oracle";
                }
            }
        }

        #region 转换参数
        private static IDbDataParameter iDbPara(string ParaName, string DataType)
        {
            switch (DbType)
            {
                case "SqlServer":
                    return GetSqlPara(ParaName, DataType);
                case "Oracle":
                    return GetOraclePara(ParaName, DataType);
                case "Access":
                    return GetOleDbPara(ParaName, DataType);
                default:
                    return GetOraclePara(ParaName, DataType);
            }
        }

        private static SqlParameter GetSqlPara(string ParaName, string DataType)
        {
            switch (DataType)
            {
                case "Decimal":
                    return new SqlParameter(ParaName, SqlDbType.Decimal);
                case "Varchar":
                    return new SqlParameter(ParaName, SqlDbType.VarChar);
                case "DateTime":
                    return new SqlParameter(ParaName, SqlDbType.DateTime);
                case "Image":
                    return new SqlParameter(ParaName, SqlDbType.Image);
                case "Int":
                    return new SqlParameter(ParaName, SqlDbType.Int);
                case "Text":
                    return new SqlParameter(ParaName, SqlDbType.NText);
                default:
                    return new SqlParameter(ParaName, SqlDbType.VarChar);
            }
        }

        private static OracleParameter GetOraclePara(string ParaName, string DataType)
        {
            switch (DataType)
            {
                case "Decimal":
                    return new OracleParameter(ParaName, OracleType.Double);
                case "Varchar":
                    return new OracleParameter(ParaName, OracleType.VarChar);
                case "DateTime":
                    return new OracleParameter(ParaName, OracleType.DateTime);
                case "Image":
                    return new OracleParameter(ParaName, OracleType.BFile);
                case "Int":
                    return new OracleParameter(ParaName, OracleType.Int32);
                case "Text":
                    return new OracleParameter(ParaName, OracleType.LongVarChar);
                default:
                    return new OracleParameter(ParaName, OracleType.VarChar);
            }
        }

        private static OleDbParameter GetOleDbPara(string ParaName, string DataType)
        {
            switch (DataType)
            {
                case "Decimal":
                    return new OleDbParameter(ParaName, OleDbType.Decimal);
                case "Varchar":
                    return new OleDbParameter(ParaName, OleDbType.VarChar);
                case "DateTime":
                    return new OleDbParameter(ParaName, OleDbType.DBTimeStamp);
                case "Image":
                    return new OleDbParameter(ParaName, OleDbType.Binary);
                case "Int":
                    return new OleDbParameter(ParaName, OleDbType.Integer);
                case "Text":
                    return new OleDbParameter(ParaName, OleDbType.LongVarChar);
                default:
                    return new OleDbParameter(ParaName, OleDbType.VarChar);
            }
        }

        #endregion

        #region 创建 Connection 和 Command

        private IDbConnection GetConnection()
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlConnection(ConntionString);
                case "Oracle":
                    return new OracleConnection(ConntionString);
                case "Access":
                    return new OleDbConnection(ConntionString);
                default:
                    return new SqlConnection(ConntionString);
            }
        }

        private static IDbCommand GetCommand(string Sql, IDbConnection iConn)
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlCommand(Sql, (SqlConnection)iConn);
                case "Oracle":
                    return new OracleCommand(Sql, (OracleConnection)iConn);
                case "Access":
                    return new OleDbCommand(Sql, (OleDbConnection)iConn);
                default:
                    return new SqlCommand(Sql, (SqlConnection)iConn);
            }
        }

        private static IDbCommand GetCommand()
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlCommand();
                case "Oracle":
                    return new OracleCommand();
                case "Access":
                    return new OleDbCommand();
                default:
                    return new SqlCommand();
            }
        }

        private static IDataAdapter GetAdapater(string Sql, IDbConnection iConn)
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlDataAdapter(Sql, (SqlConnection)iConn);

                case "Oracle":
                    return new OracleDataAdapter(Sql, (OracleConnection)iConn);

                case "Access":
                    return new OleDbDataAdapter(Sql, (OleDbConnection)iConn);

                default:
                    return new SqlDataAdapter(Sql, (SqlConnection)iConn); ;
            }

        }

        private static IDataAdapter GetAdapater()
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlDataAdapter();
                case "Oracle":
                    return new OracleDataAdapter();
                case "Access":
                    return new OleDbDataAdapter();
                default:
                    return new SqlDataAdapter();
            }
        }

        private static IDataAdapter GetAdapater(IDbCommand iCmd)
        {
            switch (DbType)
            {
                case "SqlServer":
                    return new SqlDataAdapter((SqlCommand)iCmd);
                case "Oracle":
                    return new OracleDataAdapter((OracleCommand)iCmd);
                case "Access":
                    return new OleDbDataAdapter((OleDbCommand)iCmd);
                default:
                    return new SqlDataAdapter((SqlCommand)iCmd);
            }
        }
        #endregion

        #region  执行简单SQL语句
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSql(string SqlString)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(SqlString, iConn))
                {
                    iConn.Open();
                    try
                    {

                        int rows = iCmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>        
        public void ExecuteSqlTran(ArrayList SQLStringList)
        {
            ExecuteSqlTran(SQLStringList, -1);
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>
        /// <param name="EffectCounts">预计影响行数</param>
        public void ExecuteSqlTran(ArrayList SQLStringList, int EffectCounts)
        {
            int counts = 0;
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                using (IDbCommand iCmd = GetCommand())
                {
                    iCmd.Connection = iConn;
                    using (IDbTransaction iDbTran = iConn.BeginTransaction())
                    {
                        iCmd.Transaction = iDbTran;
                        try
                        {
                            for (int n = 0; n < SQLStringList.Count; n++)
                            {
                                string strsql = SQLStringList[n].ToString();
                                if (strsql.Trim().Length > 1)
                                {
                                    iCmd.CommandText = strsql;
                                    counts += iCmd.ExecuteNonQuery();
                                }
                            }
                            if (EffectCounts != -1 && EffectCounts != counts)
                            {
                                iDbTran.Rollback();
                            }
                            else
                            {
                                iDbTran.Commit();
                            }
                        }
                        catch (System.Exception E)
                        {
                            iDbTran.Rollback();
                            throw new Exception(E.Message);
                        }
                        finally
                        {
                            if (iConn.State != ConnectionState.Closed)
                            {
                                iConn.Close();
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSql(string SqlString, string content)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(SqlString, iConn))
                {
                    IDataParameter myParameter = iDbPara("@content", "Text");
                    myParameter.Value = content;
                    iCmd.Parameters.Add(myParameter);
                    iConn.Open();
                    try
                    {

                        int rows = iCmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSqlInsertImg(string SqlString, byte[] fs)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(SqlString, iConn))
                {
                    IDataParameter myParameter = iDbPara("@content", "Image");
                    myParameter.Value = fs;
                    iCmd.Parameters.Add(myParameter);
                    iConn.Open();
                    try
                    {
                        int rows = iCmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string SqlString)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(SqlString, iConn))
                {
                    iConn.Open();
                    try
                    {
                        object obj = iCmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回IDataAdapter
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>IDataAdapter</returns>
        public IDataAdapter ExecuteReader(string strSQL)
        {
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                try
                {
                    IDataAdapter iAdapter = GetAdapater(strSQL, iConn);
                    return iAdapter;
                }
                catch (System.Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    if (iConn.State != ConnectionState.Closed)
                    {
                        iConn.Close();
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string sqlString)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(sqlString, iConn))
                {
                    DataSet ds = new DataSet();
                    iConn.Open();
                    try
                    {
                        IDataAdapter iAdapter = GetAdapater(sqlString, iConn);
                        iAdapter.Fill(ds);
                        return ds;
                    }
                    catch (System.Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="sqlString">查询语句</param>
        /// <param name="tableName">要填充的表名</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string sqlString, string tableName)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(sqlString, iConn))
                {
                    iConn.Open();
                    try
                    {
                        DataSet dataSet = new DataSet();
                        IDataAdapter iAdapter = GetAdapater(sqlString, iConn);
                        iAdapter.Fill(dataSet);
                        if (dataSet.Tables != null && dataSet.Tables.Count > 0)
                            dataSet.Tables[0].TableName = tableName;
                        return dataSet;
                    }
                    catch (System.Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行SQL语句 返回存储过程
        /// </summary>
        /// <param name="sqlString">Sql语句</param>
        /// <param name="dataSet">要填充的DataSet</param>
        /// <param name="startIndex">开始记录</param>
        /// <param name="pageSize">页面记录大小</param>
        /// <param name="tableName">表名称</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string sqlString, DataSet dataSet, int startIndex, int pageSize, string tableName)
        {
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                try
                {
                    IDataAdapter iAdapter = GetAdapater(sqlString, iConn);

                    ((OleDbDataAdapter)iAdapter).Fill(dataSet, startIndex, pageSize, tableName);

                    return dataSet;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (iConn.State != ConnectionState.Closed)
                    {
                        iConn.Close();
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，向XML文件写入数据
        /// </summary>
        /// <param name="sqlString">查询语句</param>
        /// <param name="xmlPath">XML文件路径</param>
        public void WriteToXml(string sqlString, string xmlPath)
        {
            Query(sqlString).WriteXml(xmlPath);
        }
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="SqlString">查询语句</param>
        /// <returns>DataTable </returns>
        public DataTable ExecuteQuery(string sqlString)
        {
            using (IDbConnection iConn = GetConnection())
            {
                IDbCommand iCmd  =  GetCommand(sqlString,iConn);
                iCmd.CommandTimeout = 60000;
                using (DataSet ds = new DataSet())
                {
                    try
                    {
                        IDataAdapter iAdapter = GetAdapater(sqlString, iConn);
                        iAdapter.Fill(ds);
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                    return ds.Tables[0];
                }
            }
        }
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="SqlString">查询语句</param>
        /// <returns>DataTable </returns>
        public DataTable ExecuteQuery(string SqlString, string Proc)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(SqlString, iConn))
                {
                    iCmd.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    try
                    {
                        IDataAdapter iDataAdapter = GetAdapater(SqlString, iConn);
                        iDataAdapter.Fill(ds);
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                    return ds.Tables[0];
                }


            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Sql"></param>
        /// <returns></returns>
        public DataView ExeceuteDataView(string Sql)
        {
            using (IDbConnection iConn = GetConnection())
            {
                using (IDbCommand iCmd = GetCommand(Sql, iConn))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        IDataAdapter iDataAdapter = GetAdapater(Sql, iConn);
                        iDataAdapter.Fill(ds);
                        return ds.Tables[0].DefaultView;
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        #endregion

        #region 执行带参数的SQL语句
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteSql(string SQLString, params IDataParameter[] iParms)
        {
            using (IDbConnection iConn = GetConnection())
            {
                IDbCommand iCmd = GetCommand();
                {
                    try
                    {
                        PrepareCommand(out iCmd, iConn, null, SQLString, iParms);
                        int rows = iCmd.ExecuteNonQuery();
                        iCmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Exception E)
                    {
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        iCmd.Dispose();
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                using (IDbTransaction iTrans = iConn.BeginTransaction())
                {
                    IDbCommand iCmd = GetCommand();
                    try
                    {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            IDataParameter[] iParms = (IDataParameter[])myDE.Value;
                            PrepareCommand(out iCmd, iConn, iTrans, cmdText, iParms);
                            int val = iCmd.ExecuteNonQuery();
                            iCmd.Parameters.Clear();
                        }
                        iTrans.Commit();
                    }
                    catch
                    {
                        iTrans.Rollback();
                        throw;
                    }
                    finally
                    {
                        iCmd.Dispose();
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }

                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString, params IDataParameter[] iParms)
        {
            using (IDbConnection iConn = GetConnection())
            {
                IDbCommand iCmd = GetCommand();
                {
                    try
                    {
                        PrepareCommand(out iCmd, iConn, null, SQLString, iParms);
                        object obj = iCmd.ExecuteScalar();
                        iCmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        iCmd.Dispose();
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回IDataReader
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns> IDataReader </returns>
        public IDataReader ExecuteReader(string SQLString, params IDataParameter[] iParms)
        {
            using (IDbConnection iConn = GetConnection())
            {
                IDbCommand iCmd = GetCommand();
                {
                    try
                    {
                        PrepareCommand(out iCmd, iConn, null, SQLString, iParms);
                        IDataReader iReader = iCmd.ExecuteReader();
                        iCmd.Parameters.Clear();
                        return iReader;
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                    finally
                    {
                        iCmd.Dispose();
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string sqlString, params IDataParameter[] iParms)
        {
            using (IDbConnection iConn = GetConnection())
            {
                IDbCommand iCmd = GetCommand();
                {
                    PrepareCommand(out iCmd, iConn, null, sqlString, iParms);
                    try
                    {
                        IDataAdapter iAdapter = GetAdapater(sqlString, iConn);
                        DataSet ds = new DataSet();
                        iAdapter.Fill(ds);
                        iCmd.Parameters.Clear();
                        return ds;
                    }
                    catch (System.Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        iCmd.Dispose();
                        if (iConn.State != ConnectionState.Closed)
                        {
                            iConn.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 初始化Command
        /// </summary>
        /// <param name="iCmd"></param>
        /// <param name="iConn"></param>
        /// <param name="iTrans"></param>
        /// <param name="cmdText"></param>
        /// <param name="iParms"></param>
        private static void PrepareCommand(out IDbCommand iCmd, IDbConnection iConn, IDbTransaction iTrans, string cmdText, IDataParameter[] iParms)
        {
            if (iConn.State != ConnectionState.Open)
                iConn.Open();
            iCmd = GetCommand();
            iCmd.Connection = iConn;
            iCmd.CommandText = cmdText;
            if (iTrans != null)
                iCmd.Transaction = iTrans;
            iCmd.CommandType = CommandType.Text;//cmdType;
            if (iParms != null)
            {
                foreach (IDataParameter parm in iParms)
                    iCmd.Parameters.Add(parm);
            }
        }
        #endregion

        #region 存储过程操作
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>IDataReader</returns>
        public IDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                using (IDbCommand iDBCmd = BuildQueryCommand(iConn, storedProcName, parameters))
                {
                    return iDBCmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (IDbConnection iConn = GetConnection())
            {
                DataSet dataSet = new DataSet();
                iConn.Open();
                IDataAdapter iDA = GetAdapater();
                iDA = GetAdapater(BuildQueryCommand(iConn, storedProcName, parameters));
                switch (DbType)
                {
                    case "SqlServer":
                        ((SqlDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    case "Oracle":
                        ((OracleDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    case "Access":
                        ((OleDbDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    default:
                        ((SqlDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                }
                if (iConn.State != ConnectionState.Closed)
                {
                    iConn.Close();
                }
                return dataSet;
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <param name="startIndex">开始记录索引</param>
        /// <param name="pageSize">页面记录大小</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, int startIndex, int pageSize, string tableName)
        {

            using (IDbConnection iConn = GetConnection())
            {
                DataSet dataSet = new DataSet();
                iConn.Open();
                IDataAdapter iDA = GetAdapater();
                iDA = GetAdapater(BuildQueryCommand(iConn, storedProcName, parameters));
                switch (DbType)
                {
                    case "SqlServer":
                        ((SqlDataAdapter)iDA).Fill(dataSet, startIndex, pageSize, tableName);
                        break;
                    case "Oracle":
                        ((OracleDataAdapter)iDA).Fill(dataSet, startIndex, pageSize, tableName);
                        break;
                    case "Access":
                        ((OleDbDataAdapter)iDA).Fill(dataSet, startIndex, pageSize, tableName);
                        break;
                    default:
                        ((SqlDataAdapter)iDA).Fill(dataSet, startIndex, pageSize, tableName);
                        break;
                }
                if (iConn.State != ConnectionState.Closed)
                {
                    iConn.Close();
                }
                return dataSet;
            }
        }
        /// <summary>
        /// 执行存储过程 填充已经存在的DataSet数据集 
        /// </summary>
        /// <param name="storeProcName">存储过程名称</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="dataSet">要填充的数据集</param>
        /// <param name="tablename">要填充的表名</param>
        /// <returns></returns>
        public DataSet RunProcedure(string storeProcName, IDataParameter[] parameters, DataSet dataSet, string tableName)
        {
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                IDataAdapter iDA = GetAdapater();
                iDA = GetAdapater(BuildQueryCommand(iConn, storeProcName, parameters));
                switch (DbType)
                {
                    case "SqlServer":
                        ((SqlDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    case "Oracle":
                        ((OracleDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    case "Access":
                        ((OleDbDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                    default:
                        ((SqlDataAdapter)iDA).Fill(dataSet, tableName);
                        break;
                }
                if (iConn.State != ConnectionState.Closed)
                {
                    iConn.Close();
                }
                return dataSet;
            }
        }
        /// <summary>
        /// 执行存储过程并返回受影响的行数
        /// </summary>
        /// <param name="storedProcName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int RunProcedureNoQuery(string storedProcName, IDataParameter[] parameters)
        {
            int result = 0;
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                using (IDbCommand scmd = BuildQueryCommand(iConn, storedProcName, parameters))
                {
                    result = scmd.ExecuteNonQuery();
                }
                if (iConn.State != ConnectionState.Closed)
                {
                    iConn.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// 执行存储过程并返回结果集中的第一行第一列，忽略其他行或列
        /// </summary>
        /// <param name="storeProcName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string RunProcedureExecuteScalar(string storeProcName, IDataParameter[] parameters)
        {
            string result = string.Empty;
            using (IDbConnection iConn = GetConnection())
            {
                iConn.Open();
                using (IDbCommand scmd = BuildQueryCommand(iConn, storeProcName, parameters))
                {
                    object obj = scmd.ExecuteScalar();
                    if (obj == null)
                        result = null;
                    else
                        result = obj.ToString();
                }
                if (iConn.State != ConnectionState.Closed)
                {
                    iConn.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static IDbCommand BuildQueryCommand(IDbConnection iConn, string storedProcName, IDataParameter[] parameters)
        {
            using (IDbCommand iCmd = GetCommand(storedProcName, iConn))
            {
                iCmd.CommandType = CommandType.StoredProcedure;
                if (parameters == null)
                {
                    switch (DbType)
                    {
                        case "SqlServer":
                            return (SqlCommand)iCmd;
                        case "Oracle":
                            return (OracleCommand)iCmd;
                        case "Access":
                            return (OleDbCommand)iCmd;
                        default:
                            return (SqlCommand)iCmd;
                    }
                }
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (i == parameters.Length - 1)
                    {
                        switch (DbType)
                        {
                            case "SqlServer":
                                iCmd.Parameters.Add(parameters[i]);
                                break;
                            case "Oracle":
                                ((OracleParameter)parameters[i]).OracleType = OracleType.Cursor;
                                ((OracleParameter)parameters[i]).Direction = ParameterDirection.Output;
                                iCmd.Parameters.Add((OracleParameter)parameters[i]);
                                break;
                            case "Access":
                                iCmd.Parameters.Add(parameters[i]);
                                break;
                            default:
                                iCmd.Parameters.Add(parameters[i]);
                                break;
                        }
                    }
                    else
                    {
                        iCmd.Parameters.Add(parameters[i]);
                    }
                }
                return iCmd;
            }
        }
        /// <summary>
        /// 执行存储过程，返回影响的行数        
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (IDbConnection iConn = GetConnection())
            {
                int result;
                iConn.Open();
                using (IDbCommand sqlCmd = BuildIntCommand(iConn, storedProcName, parameters))
                {
                    rowsAffected = sqlCmd.ExecuteNonQuery();
                    switch (DbType)
                    {
                        case "SqlServer":
                            result = (int)((((SqlCommand)sqlCmd).Parameters["ReturnValue"]).Value);
                            break;
                        case "Oracle":
                            result = (int)((((OracleCommand)sqlCmd).Parameters["ReturnValue"]).Value);
                            break;
                        case "Access":
                            result = (int)((((OleDbCommand)sqlCmd).Parameters["ReturnValue"]).Value);
                            break;
                        default:
                            result = (int)((((SqlCommand)sqlCmd).Parameters["ReturnValue"]).Value);
                            break;
                    }
                    if (iConn.State != ConnectionState.Closed)
                    {
                        iConn.Close();
                    }
                    return result;
                }
            }
        }
        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)    
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private static IDbCommand BuildIntCommand(IDbConnection iConn, string storedProcName, IDataParameter[] parameters)
        {
            IDbCommand iDbCmd = BuildQueryCommand(iConn, storedProcName, parameters);
            iDbCmd.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return iDbCmd;
        }
        #endregion

        public bool BlukImport(DataTable dt)
        {
            if (dt != null)
                return BlukImport(dt.Rows.Count, dt);
            else
                return false;
        }

        public bool BlukImport(int BatchSize, DataTable dt)
        {
            bool flag = true;
            try
            {
                SqlBulkCopy bulk = new SqlBulkCopy(connectionString);
                bulk.DestinationTableName = dt.TableName; // "test2"
                bulk.WriteToServer(dt);
                bulk.Close();
            }
            catch (Exception ex) 
            {
                flag = false;
            }
            return flag;
        }
    }
}
