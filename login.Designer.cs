
namespace 图书管理系统
{
	partial class login
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RadioButton_User = new System.Windows.Forms.RadioButton();
            this.RadioButton_Admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(295, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登录图书管理系统";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(301, 183);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(45, 15);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "账户:";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(302, 251);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(45, 15);
            this.label_pwd.TabIndex = 1;
            this.label_pwd.Text = "密码:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(353, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 25);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RadioButton_User
            // 
            this.RadioButton_User.AutoSize = true;
            this.RadioButton_User.Checked = true;
            this.RadioButton_User.Location = new System.Drawing.Point(305, 287);
            this.RadioButton_User.Name = "RadioButton_User";
            this.RadioButton_User.Size = new System.Drawing.Size(58, 19);
            this.RadioButton_User.TabIndex = 4;
            this.RadioButton_User.TabStop = true;
            this.RadioButton_User.Text = "用户";
            this.RadioButton_User.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Admin
            // 
            this.RadioButton_Admin.AutoSize = true;
            this.RadioButton_Admin.Location = new System.Drawing.Point(475, 287);
            this.RadioButton_Admin.Name = "RadioButton_Admin";
            this.RadioButton_Admin.Size = new System.Drawing.Size(73, 19);
            this.RadioButton_Admin.TabIndex = 4;
            this.RadioButton_Admin.TabStop = true;
            this.RadioButton_Admin.Text = "管理员";
            this.RadioButton_Admin.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 472);
            this.Controls.Add(this.RadioButton_Admin);
            this.Controls.Add(this.RadioButton_User);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.Label label_pwd;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton RadioButton_User;
		private System.Windows.Forms.RadioButton RadioButton_Admin;
	}
}

