namespace WindowsProcessControlTest
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRenew = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(183, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(97, 134);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(75, 23);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(98, 105);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(175, 110);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(24, 12);
            this.lbState.TabIndex = 5;
            this.lbState.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Process Name";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(17, 75);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(182, 22);
            this.tbId.TabIndex = 7;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Process ID ( only use for Process Kill )";
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(217, 134);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(46, 23);
            this.btnRenew.TabIndex = 10;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(269, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 136);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 167);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Contorl Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClear;
    }
}

