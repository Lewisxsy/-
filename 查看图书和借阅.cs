using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
	public partial class user2 : Form
	{
		public user2()
		{
			InitializeComponent();
			Table();
		}
		public void Table()
		{
			dataGridView1.Rows.Clear();//首先清空旧的数据
			Dao dao = new Dao();
			string sql = "select * from t_book";
			IDataReader dc = dao.read(sql);
			while (dc.Read())
			{
				dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
				dataGridView1.Columns[0].ReadOnly = true;
			}
			dc.Close();
			dao.DaoClose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());//库存
			if (number<1)
			{
				MessageBox.Show("库存不足，请联系管理员购入");
			}
			else
			{
				string sql = $"insert into t_lend([uid],bid,[datetime]) values('{Data.UID}','{id}',GETDATE()) update t_book set number = number-1 where id = '{id}'";
				Dao dao = new Dao();
				if (dao.Execute(sql)>1)//执行了两条
				{
					MessageBox.Show($"用户：{Data.UName}借出了图书{id}！");
					Table();
				}
			}
		}

        private void user2_Load(object sender, EventArgs e)
        {

        }
    }
}
