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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && textBox2.Text != "")
			{
				Login();
			}
			else
			{
				MessageBox.Show("用户名或密码为空！");
			}
		}
		//登录方法，验证是否允许登录，允许返回真
		public void Login()
		{
			if (RadioButton_User.Checked == true)
			{
				Dao dao = new Dao();
                //几种书写方式
                string sql = "select * from t_user where id='" + textBox1.Text + " 'and psw ='" + textBox2.Text + "'";
                //string sql2 = String.Format("select * from t_user where id='{0}' and psw = '{1}'", textBox1.Text, textBox2);
                //string sql = $"select * from t_user where id = '{textBox1.Text}' and psw= '{textBox2.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
				if (dc.Read())
				{
					Data.UID = dc["id"].ToString();
					Data.UName = dc["name"].ToString();
					MessageBox.Show("登录成功");
					user1 user = new user1();
					this.Hide();
					user.ShowDialog();
				}
				else
				{
					MessageBox.Show("登录失败");
				}
				dao.DaoClose();
				//MessageBox.Show(dc[0].ToString(),dc["name"].ToString());
			}
			//管理员
			if (RadioButton_Admin.Checked == true)
			{
				Dao dao = new Dao();
				string sql = $"select * from t_admin where id = '{textBox1.Text}' and psw= '{textBox2.Text}'";
				IDataReader dc = dao.read(sql);
				if (dc.Read())
				{
					MessageBox.Show("登录成功");
					admin1 user = new admin1();
					this.Hide();
					user.ShowDialog();
				}
				else
				{
					MessageBox.Show("登录失败");
				}
				dao.DaoClose();
			}
		}

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
