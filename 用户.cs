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
	public partial class user1 : Form
	{
		public user1()
		{
			InitializeComponent();
			label1.Text = $"欢迎{Data.UName}登录图书管理系统";
		}

		private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			user2 user2 = new user2();
			user2.ShowDialog();
		}

		private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			user3 user3 = new user3();
			user3.ShowDialog();
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
