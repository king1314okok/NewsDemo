namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBtn = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.viewUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(65, 158);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(64, 89);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(47, 12);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "用户名:";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(64, 122);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(35, 12);
            this.pwdLabel.TabIndex = 2;
            this.pwdLabel.Text = "密码:";
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(122, 86);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 21);
            this.userText.TabIndex = 3;
            // 
            // pwdText
            // 
            this.pwdText.Location = new System.Drawing.Point(122, 119);
            this.pwdText.Name = "pwdText";
            this.pwdText.Size = new System.Drawing.Size(100, 21);
            this.pwdText.TabIndex = 4;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(146, 158);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(76, 23);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "注册";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "新闻管理系统";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::UI.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(9, 10);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(75, 70);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            // 
            // viewUserBtn
            // 
            this.viewUserBtn.Location = new System.Drawing.Point(66, 187);
            this.viewUserBtn.Name = "viewUserBtn";
            this.viewUserBtn.Size = new System.Drawing.Size(74, 23);
            this.viewUserBtn.TabIndex = 8;
            this.viewUserBtn.Text = "查看用户";
            this.viewUserBtn.UseVisualStyleBackColor = true;
            this.viewUserBtn.Click += new System.EventHandler(this.viewUserBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 219);
            this.Controls.Add(this.viewUserBtn);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button viewUserBtn;
    }
}

