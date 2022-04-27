namespace Calculator
{
    partial class frmCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.textIO = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonSquared = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumericValue);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumericValue);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumericValue);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 72);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumericValue);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(573, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumericValue);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(656, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 72);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumericValue);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(490, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 72);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumericValue);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(573, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 72);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumericValue);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(656, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 72);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumericValue);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(573, 464);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(77, 72);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumericValue);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Location = new System.Drawing.Point(490, 464);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(77, 72);
            this.buttonPlusMinus.TabIndex = 10;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Location = new System.Drawing.Point(656, 464);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(77, 72);
            this.buttonDecimal.TabIndex = 11;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            this.buttonDecimal.Click += new System.EventHandler(this.NumericValue);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(739, 152);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(77, 72);
            this.buttonDivide.TabIndex = 12;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.Operation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(739, 230);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(77, 72);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Operation);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(739, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 72);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Operation);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(739, 308);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(77, 72);
            this.buttonSubtract.TabIndex = 15;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.Operation);
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(739, 464);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(77, 72);
            this.buttonEvaluate.TabIndex = 16;
            this.buttonEvaluate.Text = "=";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // textIO
            // 
            this.textIO.Location = new System.Drawing.Point(472, 12);
            this.textIO.Multiline = true;
            this.textIO.Name = "textIO";
            this.textIO.Size = new System.Drawing.Size(344, 46);
            this.textIO.TabIndex = 17;
            this.textIO.Text = "0";
            this.textIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textIO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(739, 74);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(77, 72);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "⌫";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(573, 74);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(77, 72);
            this.buttonCE.TabIndex = 19;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(656, 74);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(77, 72);
            this.buttonC.TabIndex = 20;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonSquared
            // 
            this.buttonSquared.Location = new System.Drawing.Point(573, 152);
            this.buttonSquared.Name = "buttonSquared";
            this.buttonSquared.Size = new System.Drawing.Size(77, 72);
            this.buttonSquared.TabIndex = 21;
            this.buttonSquared.Text = "x^2";
            this.buttonSquared.UseVisualStyleBackColor = true;
            this.buttonSquared.Click += new System.EventHandler(this.buttonSquared_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Location = new System.Drawing.Point(656, 152);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(77, 72);
            this.buttonSquareRoot.TabIndex = 22;
            this.buttonSquareRoot.Text = "sqrt";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRoot_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonSquared);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textIO);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.Click += new System.EventHandler(this.Operation);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.TextBox textIO;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSquared;
        private System.Windows.Forms.Button buttonSquareRoot;
    }
}
