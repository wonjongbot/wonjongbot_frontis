namespace Calculator
{
    partial class Calculator
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
            this.textdisp = new System.Windows.Forms.TextBox();
            this.indicator = new System.Windows.Forms.Label();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.bntrcprc = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btntan = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btnmins = new System.Windows.Forms.Button();
            this.btnpls = new System.Windows.Forms.Button();
            this.btnent = new System.Windows.Forms.Button();
            this.btnsin = new System.Windows.Forms.Button();
            this.btnexp = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnneg = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.btnpi = new System.Windows.Forms.Button();
            this.modulo_pressed = new System.Windows.Forms.Button();
            this.checker = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textdisp
            // 
            this.textdisp.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textdisp.Location = new System.Drawing.Point(12, 12);
            this.textdisp.Name = "textdisp";
            this.textdisp.Size = new System.Drawing.Size(460, 63);
            this.textdisp.TabIndex = 1;
            this.textdisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textdisp.TextChanged += new System.EventHandler(this.textdisp_TextChanged);
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.BackColor = System.Drawing.SystemColors.Window;
            this.indicator.Location = new System.Drawing.Point(29, 22);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(0, 12);
            this.indicator.TabIndex = 2;
            // 
            // btnsqrt
            // 
            this.btnsqrt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsqrt.Location = new System.Drawing.Point(15, 151);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(109, 62);
            this.btnsqrt.TabIndex = 69;
            this.btnsqrt.Text = "√";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.singleoperation);
            // 
            // bntrcprc
            // 
            this.bntrcprc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bntrcprc.Location = new System.Drawing.Point(130, 151);
            this.bntrcprc.Name = "bntrcprc";
            this.bntrcprc.Size = new System.Drawing.Size(109, 62);
            this.bntrcprc.TabIndex = 68;
            this.bntrcprc.Text = "^-1";
            this.bntrcprc.UseVisualStyleBackColor = true;
            this.bntrcprc.Click += new System.EventHandler(this.singleoperation);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn0.Location = new System.Drawing.Point(15, 491);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(109, 67);
            this.btn0.TabIndex = 62;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn7.Location = new System.Drawing.Point(15, 423);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(109, 62);
            this.btn7.TabIndex = 52;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn8.Location = new System.Drawing.Point(130, 423);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(109, 62);
            this.btn8.TabIndex = 53;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn9.Location = new System.Drawing.Point(245, 423);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(109, 62);
            this.btn9.TabIndex = 54;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn6.Location = new System.Drawing.Point(245, 355);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(109, 62);
            this.btn6.TabIndex = 50;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn5.Location = new System.Drawing.Point(130, 355);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(109, 62);
            this.btn5.TabIndex = 49;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn4.Location = new System.Drawing.Point(15, 355);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(109, 62);
            this.btn4.TabIndex = 48;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn1.Location = new System.Drawing.Point(15, 287);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(109, 62);
            this.btn1.TabIndex = 44;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn2.Location = new System.Drawing.Point(130, 287);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(109, 62);
            this.btn2.TabIndex = 45;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_pressed);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn3.Location = new System.Drawing.Point(245, 287);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 62);
            this.btn3.TabIndex = 46;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_pressed);
            // 
            // s
            // 
            this.s.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.s.Location = new System.Drawing.Point(360, 83);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(109, 62);
            this.s.TabIndex = 66;
            this.s.Text = "c";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btncos
            // 
            this.btncos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncos.Location = new System.Drawing.Point(130, 219);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(109, 62);
            this.btncos.TabIndex = 57;
            this.btncos.Text = "cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.singleoperation);
            // 
            // btntan
            // 
            this.btntan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btntan.Location = new System.Drawing.Point(245, 219);
            this.btntan.Name = "btntan";
            this.btntan.Size = new System.Drawing.Size(109, 62);
            this.btntan.TabIndex = 58;
            this.btntan.Text = "tan";
            this.btntan.UseVisualStyleBackColor = true;
            this.btntan.Click += new System.EventHandler(this.singleoperation);
            // 
            // btndiv
            // 
            this.btndiv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btndiv.Location = new System.Drawing.Point(360, 151);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(109, 62);
            this.btndiv.TabIndex = 51;
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.arithmetic);
            // 
            // btntimes
            // 
            this.btntimes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btntimes.Location = new System.Drawing.Point(360, 219);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(109, 62);
            this.btntimes.TabIndex = 55;
            this.btntimes.Text = "×";
            this.btntimes.UseVisualStyleBackColor = true;
            this.btntimes.Click += new System.EventHandler(this.arithmetic);
            // 
            // btnmins
            // 
            this.btnmins.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnmins.Location = new System.Drawing.Point(360, 287);
            this.btnmins.Name = "btnmins";
            this.btnmins.Size = new System.Drawing.Size(109, 62);
            this.btnmins.TabIndex = 59;
            this.btnmins.Text = "-";
            this.btnmins.UseVisualStyleBackColor = true;
            this.btnmins.Click += new System.EventHandler(this.arithmetic);
            // 
            // btnpls
            // 
            this.btnpls.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnpls.Location = new System.Drawing.Point(360, 355);
            this.btnpls.Name = "btnpls";
            this.btnpls.Size = new System.Drawing.Size(109, 62);
            this.btnpls.TabIndex = 61;
            this.btnpls.Text = "+";
            this.btnpls.UseVisualStyleBackColor = true;
            this.btnpls.Click += new System.EventHandler(this.arithmetic);
            // 
            // btnent
            // 
            this.btnent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnent.Location = new System.Drawing.Point(360, 423);
            this.btnent.Name = "btnent";
            this.btnent.Size = new System.Drawing.Size(109, 135);
            this.btnent.TabIndex = 65;
            this.btnent.Text = "enter";
            this.btnent.UseVisualStyleBackColor = true;
            this.btnent.Click += new System.EventHandler(this.enter_pressed);
            // 
            // btnsin
            // 
            this.btnsin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnsin.Location = new System.Drawing.Point(15, 219);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(109, 62);
            this.btnsin.TabIndex = 56;
            this.btnsin.Text = "sin";
            this.btnsin.UseVisualStyleBackColor = true;
            this.btnsin.Click += new System.EventHandler(this.singleoperation);
            // 
            // btnexp
            // 
            this.btnexp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnexp.Location = new System.Drawing.Point(245, 151);
            this.btnexp.Name = "btnexp";
            this.btnexp.Size = new System.Drawing.Size(109, 62);
            this.btnexp.TabIndex = 47;
            this.btnexp.Text = "^";
            this.btnexp.UseVisualStyleBackColor = true;
            this.btnexp.Click += new System.EventHandler(this.arithmetic);
            // 
            // btndot
            // 
            this.btndot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btndot.Location = new System.Drawing.Point(245, 491);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(109, 67);
            this.btndot.TabIndex = 63;
            this.btndot.Text = ".";
            this.btndot.UseCompatibleTextRendering = true;
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.button_pressed);
            // 
            // btnneg
            // 
            this.btnneg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnneg.Location = new System.Drawing.Point(130, 493);
            this.btnneg.Name = "btnneg";
            this.btnneg.Size = new System.Drawing.Size(109, 62);
            this.btnneg.TabIndex = 64;
            this.btnneg.Text = "(-)";
            this.btnneg.UseVisualStyleBackColor = true;
            this.btnneg.Click += new System.EventHandler(this.negative_pressed);
            // 
            // button33
            // 
            this.button33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button33.Location = new System.Drawing.Point(15, 83);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(109, 62);
            this.button33.TabIndex = 60;
            this.button33.Text = "ln";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.singleoperation);
            // 
            // btnpi
            // 
            this.btnpi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnpi.Location = new System.Drawing.Point(245, 83);
            this.btnpi.Name = "btnpi";
            this.btnpi.Size = new System.Drawing.Size(109, 62);
            this.btnpi.TabIndex = 67;
            this.btnpi.Text = "π";
            this.btnpi.UseVisualStyleBackColor = true;
            this.btnpi.Click += new System.EventHandler(this.pi_pressed);
            // 
            // modulo_pressed
            // 
            this.modulo_pressed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modulo_pressed.Location = new System.Drawing.Point(130, 83);
            this.modulo_pressed.Name = "modulo_pressed";
            this.modulo_pressed.Size = new System.Drawing.Size(109, 62);
            this.modulo_pressed.TabIndex = 70;
            this.modulo_pressed.Text = "%";
            this.modulo_pressed.UseVisualStyleBackColor = true;
            this.modulo_pressed.Click += new System.EventHandler(this.arithmetic);
            // 
            // checker
            // 
            this.checker.AutoSize = true;
            this.checker.Location = new System.Drawing.Point(13, 63);
            this.checker.Name = "checker";
            this.checker.Size = new System.Drawing.Size(38, 12);
            this.checker.TabIndex = 71;
            this.checker.Text = "label1";
            this.checker.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 543);
            this.dataGridView1.TabIndex = 72;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checker);
            this.Controls.Add(this.modulo_pressed);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.bntrcprc);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.s);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btntan);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnmins);
            this.Controls.Add(this.btnpls);
            this.Controls.Add(this.btnent);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.btnexp);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnneg);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.btnpi);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.textdisp);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textdisp;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button bntrcprc;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btntan;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btnmins;
        private System.Windows.Forms.Button btnpls;
        private System.Windows.Forms.Button btnent;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btnexp;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnneg;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button btnpi;
        private System.Windows.Forms.Button modulo_pressed;
        private System.Windows.Forms.Label checker;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

