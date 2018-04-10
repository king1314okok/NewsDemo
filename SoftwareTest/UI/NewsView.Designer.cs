namespace UI
{
    partial class NewsView
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.delNewsBtn = new System.Windows.Forms.Button();
            this.editorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.Location = new System.Drawing.Point(136, 33);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(103, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentTextBox.Enabled = false;
            this.contentTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentTextBox.Location = new System.Drawing.Point(71, 92);
            this.contentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(569, 162);
            this.contentTextBox.TabIndex = 2;
            this.contentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(111, 258);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(345, 192);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // delNewsBtn
            // 
            this.delNewsBtn.Location = new System.Drawing.Point(581, 414);
            this.delNewsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delNewsBtn.Name = "delNewsBtn";
            this.delNewsBtn.Size = new System.Drawing.Size(97, 36);
            this.delNewsBtn.TabIndex = 4;
            this.delNewsBtn.Text = "删除新闻";
            this.delNewsBtn.UseVisualStyleBackColor = true;
            this.delNewsBtn.Click += new System.EventHandler(this.delNewsBtn_Click);
            // 
            // editorLabel
            // 
            this.editorLabel.AutoSize = true;
            this.editorLabel.Location = new System.Drawing.Point(415, 78);
            this.editorLabel.Name = "editorLabel";
            this.editorLabel.Size = new System.Drawing.Size(41, 12);
            this.editorLabel.TabIndex = 5;
            this.editorLabel.Text = "label1";
            // 
            // NewsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.editorLabel);
            this.Controls.Add(this.delNewsBtn);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "新闻标题";
            this.Load += new System.EventHandler(this.NewsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button delNewsBtn;
        private System.Windows.Forms.Label editorLabel;
    }
}