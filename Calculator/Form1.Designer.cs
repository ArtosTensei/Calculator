namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.Label();
            this.queueRequestsText = new System.Windows.Forms.Label();
            this.queueResultsText = new System.Windows.Forms.Label();
            this.queueResults = new System.Windows.Forms.TextBox();
            this.queueRequests = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.timeText = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.buff = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(93, 329);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 300);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(93, 300);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(174, 300);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 271);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 23);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(93, 271);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 23);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(174, 271);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 23);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 242);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 23);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(93, 242);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 23);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(174, 242);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 23);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(253, 213);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(253, 242);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(253, 271);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(253, 300);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(253, 329);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 14;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(174, 32);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(63, 15);
            this.resultText.TabIndex = 18;
            this.resultText.Text = "Результат:";
            // 
            // queueRequestsText
            // 
            this.queueRequestsText.AutoSize = true;
            this.queueRequestsText.Location = new System.Drawing.Point(174, 76);
            this.queueRequestsText.Name = "queueRequestsText";
            this.queueRequestsText.Size = new System.Drawing.Size(99, 30);
            this.queueRequestsText.TabIndex = 19;
            this.queueRequestsText.Text = "Размер очереди \r\nзапросов:";
            // 
            // queueResultsText
            // 
            this.queueResultsText.AutoSize = true;
            this.queueResultsText.Location = new System.Drawing.Point(174, 135);
            this.queueResultsText.Name = "queueResultsText";
            this.queueResultsText.Size = new System.Drawing.Size(99, 30);
            this.queueResultsText.TabIndex = 20;
            this.queueResultsText.Text = "Размер очереди \r\nрезультатов:";
            // 
            // queueResults
            // 
            this.queueResults.Location = new System.Drawing.Point(174, 168);
            this.queueResults.Name = "queueResults";
            this.queueResults.ReadOnly = true;
            this.queueResults.Size = new System.Drawing.Size(154, 23);
            this.queueResults.TabIndex = 17;
            // 
            // queueRequests
            // 
            this.queueRequests.Location = new System.Drawing.Point(174, 109);
            this.queueRequests.Name = "queueRequests";
            this.queueRequests.ReadOnly = true;
            this.queueRequests.Size = new System.Drawing.Size(154, 23);
            this.queueRequests.TabIndex = 16;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(174, 50);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(154, 23);
            this.result.TabIndex = 15;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Location = new System.Drawing.Point(12, 150);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(63, 15);
            this.timeText.TabIndex = 22;
            this.timeText.Text = "Задержка:";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(12, 168);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 23);
            this.time.TabIndex = 23;
            this.time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // buff
            // 
            this.buff.AutoSize = true;
            this.buff.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buff.Location = new System.Drawing.Point(174, 53);
            this.buff.Name = "buff";
            this.buff.Size = new System.Drawing.Size(0, 15);
            this.buff.TabIndex = 24;
            this.buff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(174, 329);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 23);
            this.dot.TabIndex = 25;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(12, 329);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 23);
            this.sign.TabIndex = 26;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 364);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.buff);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.queueResultsText);
            this.Controls.Add(this.queueRequestsText);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.queueResults);
            this.Controls.Add(this.queueRequests);
            this.Controls.Add(this.result);
            this.Controls.Add(this.start);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button zero;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button start;
        private Label resultText;
        private Label queueRequestsText;
        private Label queueResultsText;
        private TextBox queueResults;
        private TextBox queueRequests;
        private TextBox result;
        private Label timeText;
        private TextBox time;
        private Label buff;
        private Button dot;
        private Button sign;
    }
}