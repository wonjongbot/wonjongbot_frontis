namespace WindowsFormsApp1
{
    partial class Summation
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lwrbndTXT = new System.Windows.Forms.TextBox();
            this.uprbndTXT = new System.Windows.Forms.TextBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.Operator = new System.Windows.Forms.Label();
            this.operatorSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Bound";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upper Bound";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lwrbndTXT
            // 
            this.lwrbndTXT.Location = new System.Drawing.Point(114, 42);
            this.lwrbndTXT.Name = "lwrbndTXT";
            this.lwrbndTXT.Size = new System.Drawing.Size(100, 21);
            this.lwrbndTXT.TabIndex = 2;
            this.lwrbndTXT.TextChanged += new System.EventHandler(this.lwrbndTXT_TextChanged);
            // 
            // uprbndTXT
            // 
            this.uprbndTXT.Location = new System.Drawing.Point(114, 78);
            this.uprbndTXT.Name = "uprbndTXT";
            this.uprbndTXT.Size = new System.Drawing.Size(100, 21);
            this.uprbndTXT.TabIndex = 3;
            this.uprbndTXT.TextChanged += new System.EventHandler(this.uprbndTXT_TextChanged);
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(139, 183);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(75, 23);
            this.Calculatebtn.TabIndex = 4;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(114, 144);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(100, 21);
            this.resulttxt.TabIndex = 5;
            this.resulttxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(28, 149);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 12);
            this.result.TabIndex = 6;
            this.result.Text = "Result";
            // 
            // Operator
            // 
            this.Operator.AutoSize = true;
            this.Operator.Location = new System.Drawing.Point(28, 115);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(53, 12);
            this.Operator.TabIndex = 7;
            this.Operator.Text = "Operator";
            this.Operator.Click += new System.EventHandler(this.label3_Click);
            // 
            // operatorSelection
            // 
            this.operatorSelection.FormattingEnabled = true;
            this.operatorSelection.Items.AddRange(new object[] {
            "Sigma"});
            this.operatorSelection.Location = new System.Drawing.Point(114, 112);
            this.operatorSelection.Name = "operatorSelection";
            this.operatorSelection.Size = new System.Drawing.Size(100, 20);
            this.operatorSelection.TabIndex = 9;
            // 
            // Summation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 217);
            this.Controls.Add(this.operatorSelection);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.uprbndTXT);
            this.Controls.Add(this.lwrbndTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Summation";
            this.Text = "Summation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lwrbndTXT;
        private System.Windows.Forms.TextBox uprbndTXT;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label Operator;
        private System.Windows.Forms.ComboBox operatorSelection;
    }
}

