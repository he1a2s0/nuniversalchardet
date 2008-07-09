namespace NUCD_Test
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.CharSetBox = new System.Windows.Forms.TextBox();
            this.PageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(12, 12);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(395, 21);
            this.UrlBox.TabIndex = 0;
            this.UrlBox.Text = "http://www.163.com";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(413, 12);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 1;
            this.Check.Text = "检测";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // CharSetBox
            // 
            this.CharSetBox.Location = new System.Drawing.Point(12, 51);
            this.CharSetBox.Name = "CharSetBox";
            this.CharSetBox.Size = new System.Drawing.Size(476, 21);
            this.CharSetBox.TabIndex = 2;
            // 
            // PageBox
            // 
            this.PageBox.Location = new System.Drawing.Point(12, 91);
            this.PageBox.Multiline = true;
            this.PageBox.Name = "PageBox";
            this.PageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PageBox.Size = new System.Drawing.Size(476, 266);
            this.PageBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 369);
            this.Controls.Add(this.PageBox);
            this.Controls.Add(this.CharSetBox);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.UrlBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox CharSetBox;
        private System.Windows.Forms.TextBox PageBox;
    }
}

