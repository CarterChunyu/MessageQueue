namespace 接收消息
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
            this.檢索消息 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.不間斷檢索消息 = new System.Windows.Forms.Button();
            this.檢索事務消息 = new System.Windows.Forms.Button();
            this.不間斷掃視事務消息 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 檢索消息
            // 
            this.檢索消息.Location = new System.Drawing.Point(62, 28);
            this.檢索消息.Name = "檢索消息";
            this.檢索消息.Size = new System.Drawing.Size(75, 23);
            this.檢索消息.TabIndex = 0;
            this.檢索消息.Text = "檢索消息";
            this.檢索消息.UseVisualStyleBackColor = true;
            this.檢索消息.Click += new System.EventHandler(this.檢索消息_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // 不間斷檢索消息
            // 
            this.不間斷檢索消息.Location = new System.Drawing.Point(62, 86);
            this.不間斷檢索消息.Name = "不間斷檢索消息";
            this.不間斷檢索消息.Size = new System.Drawing.Size(164, 23);
            this.不間斷檢索消息.TabIndex = 2;
            this.不間斷檢索消息.Text = "不間斷檢索消息";
            this.不間斷檢索消息.UseVisualStyleBackColor = true;
            this.不間斷檢索消息.Click += new System.EventHandler(this.不間斷檢索消息_Click);
            // 
            // 檢索事務消息
            // 
            this.檢索事務消息.DialogResult = System.Windows.Forms.DialogResult.No;
            this.檢索事務消息.Location = new System.Drawing.Point(62, 151);
            this.檢索事務消息.Name = "檢索事務消息";
            this.檢索事務消息.Size = new System.Drawing.Size(164, 23);
            this.檢索事務消息.TabIndex = 3;
            this.檢索事務消息.Text = "檢索事務消息";
            this.檢索事務消息.UseVisualStyleBackColor = true;
            this.檢索事務消息.Click += new System.EventHandler(this.檢索事務消息_Click);
            // 
            // 不間斷掃視事務消息
            // 
            this.不間斷掃視事務消息.DialogResult = System.Windows.Forms.DialogResult.No;
            this.不間斷掃視事務消息.Location = new System.Drawing.Point(62, 198);
            this.不間斷掃視事務消息.Name = "不間斷掃視事務消息";
            this.不間斷掃視事務消息.Size = new System.Drawing.Size(171, 23);
            this.不間斷掃視事務消息.TabIndex = 4;
            this.不間斷掃視事務消息.Text = "不間斷掃視事務消息";
            this.不間斷掃視事務消息.UseVisualStyleBackColor = true;
            this.不間斷掃視事務消息.Click += new System.EventHandler(this.不間斷掃視事務消息_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.不間斷掃視事務消息);
            this.Controls.Add(this.檢索事務消息);
            this.Controls.Add(this.不間斷檢索消息);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.檢索消息);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 檢索消息;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 不間斷檢索消息;
        private System.Windows.Forms.Button 檢索事務消息;
        private System.Windows.Forms.Button 不間斷掃視事務消息;
        private System.Windows.Forms.Button button1;
    }
}

