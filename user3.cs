﻿using System;
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
	public partial class user3 : Form
	{
		public user3()
		{
			InitializeComponent();
			Table();
		}
		public void Table()
		{
			dataGridView1.Rows.Clear();//首先清空旧的数据
			Dao dao = new Dao();
			string sql = $"select [no],[bid],[name],[datetime] from t_lend left join t_book on t_book.id=t_lend.bid where uid='{Data.UID}'";
			IDataReader dc = dao.read(sql);
			while (dc.Read())
			{
				dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
			}
			dc.Close();
			dao.DaoClose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			string sql = $"delete from t_lend where [no] = {no};update t_book set number = number+1 where id = '{id}'";
			Dao dao = new Dao();
			if (dao.Execute(sql)>1)
			{
				MessageBox.Show("归还成功！");
				Table();
			}
		}

        private void user3_Load(object sender, EventArgs e)
        {

        }
    }
}
