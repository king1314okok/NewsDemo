namespace UI
{
    partial class NewsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pageNumLabel = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.newsAddBtn = new System.Windows.Forms.Button();
            this.flushBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pageNumLabel);
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(33, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(423, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pageNumLabel
            // 
            this.pageNumLabel.AutoSize = true;
            this.pageNumLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pageNumLabel.Location = new System.Drawing.Point(361, 170);
            this.pageNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageNumLabel.Name = "pageNumLabel";
            this.pageNumLabel.Size = new System.Drawing.Size(55, 15);
            this.pageNumLabel.TabIndex = 1;
            this.pageNumLabel.Text = "label1";
            this.pageNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(27, 145);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(87, 15);
            this.linkLabel5.TabIndex = 0;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel1";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(27, 118);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(87, 15);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel1";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(27, 89);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(87, 15);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel1";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(27, 60);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 15);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel1";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(27, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Location = new System.Drawing.Point(377, 222);
            this.nextPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(79, 30);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "下一页";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(289, 221);
            this.previousPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(83, 31);
            this.previousPageBtn.TabIndex = 2;
            this.previousPageBtn.Text = "上一页";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            this.previousPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // newsAddBtn
            // 
            this.newsAddBtn.Location = new System.Drawing.Point(188, 222);
            this.newsAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newsAddBtn.Name = "newsAddBtn";
            this.newsAddBtn.Size = new System.Drawing.Size(96, 31);
            this.newsAddBtn.TabIndex = 3;
            this.newsAddBtn.Text = "添加新闻";
            this.newsAddBtn.UseVisualStyleBackColor = true;
            this.newsAddBtn.Click += new System.EventHandler(this.newsAddBtn_Click);
            // 
            // flushBtn
            // 
            this.flushBtn.Location = new System.Drawing.Point(123, 222);
            this.flushBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flushBtn.Name = "flushBtn";
            this.flushBtn.Size = new System.Drawing.Size(60, 31);
            this.flushBtn.TabIndex = 4;
            this.flushBtn.Text = "刷新";
            this.flushBtn.UseVisualStyleBackColor = true;
            this.flushBtn.Click += new System.EventHandler(this.flushBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(33, 222);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(84, 31);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "查找新闻";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(181, 26);
            this.helpMenuItem.Text = "帮助";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // NewsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 268);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.flushBtn);
            this.Controls.Add(this.newsAddBtn);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewsPage";
            this.Text = "新闻";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewsPage_FormClosed);
            this.Load += new System.EventHandler(this.NewsView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button previousPageBtn;
        private System.Windows.Forms.Button newsAddBtn;
        private System.Windows.Forms.Button flushBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label pageNumLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    }
}