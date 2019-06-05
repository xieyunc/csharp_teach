using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo_SqlEdit
{
    class MsSql
    {
        private SqlConnection sqlConn;

        public MsSql()
        {
            sqlConn = new SqlConnection();
            ConnDbSrv();
        }

        public int InsertData(string xh,string xm,string xb,string nj,string xy,string zy,string bj,string dh,out string sError)
        {
            string sqlStr;

            sqlStr = string.Format("insert into Table_Xsxx(学号,姓名,性别,年级,学院,专业,班级,电话) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",xh,xm,xb,nj,xy,zy,bj,dh);

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;
            try
            {
                int iResult = cmd.ExecuteNonQuery();
                sError = "";
                return iResult;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return 0;
                //throw;
            }
        }

        public int UpdateData(string xh, string xm, string xb, string nj, string xy, string zy, string bj, string dh, out string sError)
        {
            string sqlStr;

            sqlStr = string.Format("update Table_Xsxx set 姓名='{1}',性别='{2}',年级='{3}',学院='{4}',专业='{5}',班级='{6}',电话='{7}' where 学号='{0}'", xh, xm, xb, nj, xy, zy, bj, dh);

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;
            try
            {
                int iResult = cmd.ExecuteNonQuery();
                sError = "";
                return iResult;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return 0;
                //throw;
            }
        }

        public int DeleteData(string xh, out string sError)
        {
            string sqlStr;

            sqlStr = string.Format("delete from Table_Xsxx where 学号='{0}'", xh);

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;
            try
            {
                int iResult = cmd.ExecuteNonQuery();
                sError = "";
                return iResult;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return 0;
                //throw;
            }
        }

        public bool LocateXsInfo(string xh,out string xm,out string xb,out string nj,out string xy,out string zy,out string bj,out string dh,out string sError)
        {
            string sqlStr;
            xm = "";
            xb = "";
            xy = "";
            nj = "";
            zy = "";
            bj = "";
            dh = "";
            sError = "";

            sqlStr = string.Format("select * from Table_Xsxx where 学号='{0}'", xh);

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlStr;
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    //xh = sdr["学号"].ToString();
                    xm = sdr["姓名"].ToString();
                    xb = sdr["性别"].ToString();
                    nj = sdr["年级"].ToString();
                    xy = sdr["学院"].ToString();
                    zy = sdr["专业"].ToString();
                    bj = sdr["班级"].ToString();
                    dh = sdr["电话"].ToString();
                }
                return (xm != "");
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
                //throw;
            }
        }

        public bool ConnDbSrv()
        {
            sqlConn.Close();
            sqlConn.ConnectionString = "server=(local)\\sqlexpress;database=xscj_db;uid=xscjgl_sa;pwd=abcd@1234;";
            try 
	        {	        
                sqlConn.Open();
                return sqlConn.State == System.Data.ConnectionState.Open;
	        }
	        catch (Exception)
	        {
                return false;		
		        //throw;
	        }
        }
        //~MsSql()
        //{
        //    if (sqlConn!=null)
        //        sqlConn.Dispose();
        //}
    }
}
