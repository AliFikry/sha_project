namespace ProjectCalulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(4, 90);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(66, 38);
            this.buttonC.TabIndex = 0;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(76, 90);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(138, 38);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.TabStop = false;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(220, 90);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(66, 38);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(220, 134);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(66, 38);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.TabStop = false;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button09
            // 
            this.button09.Location = new System.Drawing.Point(148, 134);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(66, 38);
            this.button09.TabIndex = 6;
            this.button09.TabStop = false;
            this.button09.Text = "9";
            this.button09.UseVisualStyleBackColor = true;
            this.button09.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button08
            // 
            this.button08.Location = new System.Drawing.Point(76, 134);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(66, 38);
            this.button08.TabIndex = 5;
            this.button08.TabStop = false;
            this.button08.Text = "8";
            this.button08.UseVisualStyleBackColor = true;
            this.button08.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button07
            // 
            this.button07.Location = new System.Drawing.Point(4, 134);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(66, 38);
            this.button07.TabIndex = 4;
            this.button07.TabStop = false;
            this.button07.Text = "7";
            this.button07.UseVisualStyleBackColor = true;
            this.button07.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 38);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(148, 178);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(66, 38);
            this.button06.TabIndex = 10;
            this.button06.TabStop = false;
            this.button06.Text = "6";
            this.button06.UseVisualStyleBackColor = true;
            this.button06.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(76, 178);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(66, 38);
            this.button05.TabIndex = 9;
            this.button05.TabStop = false;
            this.button05.Text = "5";
            this.button05.UseVisualStyleBackColor = true;
            this.button05.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(4, 178);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(66, 38);
            this.button04.TabIndex = 8;
            this.button04.TabStop = false;
            this.button04.Text = "4";
            this.button04.UseVisualStyleBackColor = true;
            this.button04.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(220, 222);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(66, 38);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(148, 222);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(66, 38);
            this.button03.TabIndex = 14;
            this.button03.TabStop = false;
            this.button03.Text = "3";
            this.button03.UseVisualStyleBackColor = true;
            this.button03.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(76, 222);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(66, 38);
            this.button02.TabIndex = 13;
            this.button02.TabStop = false;
            this.button02.Text = "2";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 38);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(148, 266);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(138, 38);
            this.btnResult.TabIndex = 19;
            this.btnResult.TabStop = false;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(76, 266);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(66, 38);
            this.button0.TabIndex = 17;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(4, 266);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(66, 38);
            this.buttonPoint.TabIndex = 16;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(4, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(282, 42);
            this.lblResult.TabIndex = 20;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 326);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button03);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button06);
            this.Controls.Add(this.button05);
            this.Controls.Add(this.button04);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button09);
            this.Controls.Add(this.button08);
            this.Controls.Add(this.button07);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Label lblResult;
    }
}

