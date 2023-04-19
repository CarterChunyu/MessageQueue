namespace 傳送消息
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.產生隊列 = new System.Windows.Forms.Button();
            this.產生交易性隊列 = new System.Windows.Forms.Button();
            this.傳送消息 = new System.Windows.Forms.Button();
            this.傳送交易性消息 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 產生隊列
            // 
            this.產生隊列.Location = new System.Drawing.Point(45, 25);
            this.產生隊列.Name = "產生隊列";
            this.產生隊列.Size = new System.Drawing.Size(75, 23);
            this.產生隊列.TabIndex = 0;
            this.產生隊列.Text = "產生隊列";
            this.產生隊列.UseVisualStyleBackColor = true;
            this.產生隊列.Click += new System.EventHandler(this.產生隊列_Click);
            // 
            // 產生交易性隊列
            // 
            this.產生交易性隊列.Location = new System.Drawing.Point(45, 71);
            this.產生交易性隊列.Name = "產生交易性隊列";
            this.產生交易性隊列.Size = new System.Drawing.Size(132, 23);
            this.產生交易性隊列.TabIndex = 1;
            this.產生交易性隊列.Text = "產生交易性隊列";
            this.產生交易性隊列.UseVisualStyleBackColor = true;
            this.產生交易性隊列.Click += new System.EventHandler(this.產生交易性隊列_Click);
            // 
            // 傳送消息
            // 
            this.傳送消息.Location = new System.Drawing.Point(45, 113);
            this.傳送消息.Name = "傳送消息";
            this.傳送消息.Size = new System.Drawing.Size(75, 23);
            this.傳送消息.TabIndex = 2;
            this.傳送消息.Text = "傳送消息";
            this.傳送消息.UseVisualStyleBackColor = true;
            this.傳送消息.Click += new System.EventHandler(this.傳送消息_Click);
            // 
            // 傳送交易性消息
            // 
            this.傳送交易性消息.Location = new System.Drawing.Point(45, 154);
            this.傳送交易性消息.Name = "傳送交易性消息";
            this.傳送交易性消息.Size = new System.Drawing.Size(132, 27);
            this.傳送交易性消息.TabIndex = 3;
            this.傳送交易性消息.Text = "傳送交易性消息";
            this.傳送交易性消息.UseVisualStyleBackColor = true;
            this.傳送交易性消息.Click += new System.EventHandler(this.傳送交易性消息_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.傳送交易性消息);
            this.Controls.Add(this.傳送消息);
            this.Controls.Add(this.產生交易性隊列);
            this.Controls.Add(this.產生隊列);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 產生隊列;
        private System.Windows.Forms.Button 產生交易性隊列;
        private System.Windows.Forms.Button 傳送消息;
        private System.Windows.Forms.Button 傳送交易性消息;
        private System.Windows.Forms.Label label1;
    }
}

