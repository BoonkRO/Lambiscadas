using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lambiscadas.Clases
{
    public class DatabaseConnection
    {
        public static DataTable executeNonQueryDT(string s) => executeNonQueryDT(s, CommandType.Text, ConnectionString.Lambiscadas);
        public static int executeNonQueryInt(string s) => executeNonQueryInt(s, CommandType.Text, ConnectionString.Lambiscadas);
        public static int executeScalarInt(string s) => executeScalarInt(s, CommandType.Text, ConnectionString.Lambiscadas);
        public static DataTable executeNonQueryDT(String s, CommandType c, String strConex)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;
                    //cmd.Parameters.Add(param);

                    sql1.Open();
                    reader = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(reader);
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return dt;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static DataTable executeNonQueryDT(String s, CommandType c, String strConex, List<SqlParameter> lista)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            DataTable dt = new DataTable();
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader reader;

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;
                    cmd.CommandTimeout = 120;
                    foreach (SqlParameter sp in lista)
                    {
                        cmd.Parameters.Add(sp);
                    }
                    sql1.Open();
                    reader = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(reader);
                    cmd.Parameters.Clear();
                }
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return dt;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static int executeNonQueryInt(String s, CommandType c, String strConex)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            int res = -1;
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;

                    sql1.Open();
                    res = cmd.ExecuteNonQuery();
                }
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return res;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static object executeScalar(String s, CommandType c, String strConex, List<SqlParameter> lista)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            object res = null;
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;
                    foreach (SqlParameter sp in lista)
                    {
                        cmd.Parameters.Add(sp);
                    }

                    sql1.Open();
                    res = cmd.ExecuteScalar();
                }
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return res;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static object executeScalar(String s, CommandType c, String strConex)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            object res = null;
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;

                    sql1.Open();
                    res = cmd.ExecuteScalar();
                }
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return res;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static int executeScalarInt(String s, CommandType c, String strConex)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            object res = null;
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;

                    sql1.Open();
                    res = cmd.ExecuteScalar();
                }
                if (res != null && !Convert.IsDBNull(res) && !string.IsNullOrEmpty(res.ToString())) return Convert.ToInt32(res);
                else return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
            finally
            {
                sql1.Close();
            }
        }

        public static string executeScalarString(String s, CommandType c, String strConex)
        {
            SqlConnection sql1 = new SqlConnection(strConex);
            object res = null;
            try
            {
                if (!string.IsNullOrEmpty(s))
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = s;
                    cmd.CommandType = c;
                    cmd.Connection = sql1;

                    sql1.Open();
                    res = cmd.ExecuteScalar();
                }
                if (res != null && !Convert.IsDBNull(res) && !string.IsNullOrEmpty(res.ToString())) return res.ToString();
                else return string.Empty;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return string.Empty;
            }
            finally
            {
                sql1.Close();
            }
        }
    }
}