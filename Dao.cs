using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图书管理系统
{
	class Dao
	{
		SqlConnection sc;
		public SqlConnection connect()
		{
			//数据库连接字符串
			string str = @"Server=192.168.233.129;Database=BookDB;User ID=sa;Password=MSsql123;Trusted_Connection=False;";
			//创建数据库连接对象
			sc = new SqlConnection(str);
			//打开数据库
			sc.Open();
			//返回数据库连接对象
			return sc;
		}
		public SqlCommand command(string sql)
		{
			SqlCommand cmd = new SqlCommand(sql,connect());
			return cmd;
		}
		public int Execute(string sql)			//更新操作
		{
			return command(sql).ExecuteNonQuery();
		}
		public SqlDataReader read(string sql)	//读取操作
		{
			return command(sql).ExecuteReader();
		}
		public void DaoClose()
		{
			sc.Close();//关闭数据库连接
		}
	}
}
