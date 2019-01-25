namespace calculatorsimple
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bsquare = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bcube = new System.Windows.Forms.Button();
            this.badsub = new System.Windows.Forms.Button();
            this.bexp = new System.Windows.Forms.Button();
            this.bpow = new System.Windows.Forms.Button();
            this.bMOD = new System.Windows.Forms.Button();
            this.bper = new System.Windows.Forms.Button();
            this.bac = new System.Windows.Forms.Button();
            this.bPi = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bsin = new System.Windows.Forms.Button();
            this.blog = new System.Windows.Forms.Button();
            this.bfac = new System.Windows.Forms.Button();
            this.bncr = new System.Windows.Forms.Button();
            this.bradian = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bhistory = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.textBox1.Location = new System.Drawing.Point(58, 27);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.VisibleChanged += new System.EventHandler(this.textBox1_VisibleChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(58, 80);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 23);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(163, 80);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 23);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(363, 80);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 23);
            this.n4.TabIndex = 5;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(257, 80);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(75, 23);
            this.n3.TabIndex = 6;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            this.n3.MouseHover += new System.EventHandler(this.n3_MouseHover);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(58, 109);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(75, 23);
            this.n5.TabIndex = 7;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(163, 109);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(75, 23);
            this.n6.TabIndex = 8;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(257, 109);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 23);
            this.n7.TabIndex = 9;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(363, 109);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(75, 23);
            this.n8.TabIndex = 10;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(58, 134);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(75, 23);
            this.n9.TabIndex = 11;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(163, 138);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(75, 23);
            this.n0.TabIndex = 12;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // bequal
            // 
            this.bequal.Location = new System.Drawing.Point(363, 163);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(75, 23);
            this.bequal.TabIndex = 13;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(257, 134);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 14;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(163, 163);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 23);
            this.bdiv.TabIndex = 17;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(257, 163);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 23);
            this.bdot.TabIndex = 18;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(58, 192);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(75, 23);
            this.bc.TabIndex = 19;
            this.bc.Text = "c";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bsquare
            // 
            this.bsquare.Location = new System.Drawing.Point(163, 192);
            this.bsquare.Name = "bsquare";
            this.bsquare.Size = new System.Drawing.Size(75, 23);
            this.bsquare.TabIndex = 20;
            this.bsquare.Text = "x2";
            this.bsquare.UseVisualStyleBackColor = true;
            this.bsquare.Click += new System.EventHandler(this.bsquare_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // bcube
            // 
            this.bcube.Location = new System.Drawing.Point(257, 192);
            this.bcube.Name = "bcube";
            this.bcube.Size = new System.Drawing.Size(75, 23);
            this.bcube.TabIndex = 22;
            this.bcube.Text = "x3";
            this.bcube.UseVisualStyleBackColor = true;
            this.bcube.Click += new System.EventHandler(this.bcube_Click);
            // 
            // badsub
            // 
            this.badsub.Location = new System.Drawing.Point(363, 192);
            this.badsub.Name = "badsub";
            this.badsub.Size = new System.Drawing.Size(75, 23);
            this.badsub.TabIndex = 23;
            this.badsub.Text = " +/- ";
            this.badsub.UseVisualStyleBackColor = true;
            this.badsub.Click += new System.EventHandler(this.badsub_Click);
            // 
            // bexp
            // 
            this.bexp.Location = new System.Drawing.Point(58, 221);
            this.bexp.Name = "bexp";
            this.bexp.Size = new System.Drawing.Size(75, 23);
            this.bexp.TabIndex = 24;
            this.bexp.Text = " 1/x";
            this.bexp.UseVisualStyleBackColor = true;
            this.bexp.Click += new System.EventHandler(this.bexp_Click);
            // 
            // bpow
            // 
            this.bpow.Location = new System.Drawing.Point(163, 221);
            this.bpow.Name = "bpow";
            this.bpow.Size = new System.Drawing.Size(75, 23);
            this.bpow.TabIndex = 25;
            this.bpow.Text = " x^y";
            this.bpow.UseVisualStyleBackColor = true;
            this.bpow.Click += new System.EventHandler(this.bpow_Click);
            // 
            // bMOD
            // 
            this.bMOD.Location = new System.Drawing.Point(257, 221);
            this.bMOD.Name = "bMOD";
            this.bMOD.Size = new System.Drawing.Size(75, 23);
            this.bMOD.TabIndex = 26;
            this.bMOD.Text = "%";
            this.bMOD.UseVisualStyleBackColor = true;
            this.bMOD.Click += new System.EventHandler(this.bMOD_Click);
            // 
            // bper
            // 
            this.bper.Location = new System.Drawing.Point(363, 221);
            this.bper.Name = "bper";
            this.bper.Size = new System.Drawing.Size(75, 23);
            this.bper.TabIndex = 27;
            this.bper.Text = "nPr";
            this.bper.UseVisualStyleBackColor = true;
            this.bper.Click += new System.EventHandler(this.bper_Click);
            // 
            // bac
            // 
            this.bac.Location = new System.Drawing.Point(58, 250);
            this.bac.Name = "bac";
            this.bac.Size = new System.Drawing.Size(75, 23);
            this.bac.TabIndex = 28;
            this.bac.Text = "Ac";
            this.bac.UseVisualStyleBackColor = true;
            this.bac.Click += new System.EventHandler(this.bac_Click);
            // 
            // bPi
            // 
            this.bPi.Location = new System.Drawing.Point(163, 250);
            this.bPi.Name = "bPi";
            this.bPi.Size = new System.Drawing.Size(75, 23);
            this.bPi.TabIndex = 29;
            this.bPi.Text = "Pi";
            this.bPi.UseVisualStyleBackColor = true;
            this.bPi.Click += new System.EventHandler(this.bPi_Click);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(257, 250);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(75, 23);
            this.bCE.TabIndex = 30;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bsin
            // 
            this.bsin.Location = new System.Drawing.Point(363, 250);
            this.bsin.Name = "bsin";
            this.bsin.Size = new System.Drawing.Size(75, 23);
            this.bsin.TabIndex = 31;
            this.bsin.Text = "log";
            this.bsin.UseVisualStyleBackColor = true;
            this.bsin.Click += new System.EventHandler(this.bsin_Click);
            // 
            // blog
            // 
            this.blog.Location = new System.Drawing.Point(58, 279);
            this.blog.Name = "blog";
            this.blog.Size = new System.Drawing.Size(75, 23);
            this.blog.TabIndex = 32;
            this.blog.Text = "log10";
            this.blog.UseVisualStyleBackColor = true;
            this.blog.Click += new System.EventHandler(this.blog_Click);
            // 
            // bfac
            // 
            this.bfac.Location = new System.Drawing.Point(163, 279);
            this.bfac.Name = "bfac";
            this.bfac.Size = new System.Drawing.Size(75, 23);
            this.bfac.TabIndex = 33;
            this.bfac.Text = "x!";
            this.bfac.UseVisualStyleBackColor = true;
            this.bfac.Click += new System.EventHandler(this.bfac_Click);
            // 
            // bncr
            // 
            this.bncr.Location = new System.Drawing.Point(257, 279);
            this.bncr.Name = "bncr";
            this.bncr.Size = new System.Drawing.Size(75, 23);
            this.bncr.TabIndex = 34;
            this.bncr.Text = "nCr";
            this.bncr.UseVisualStyleBackColor = true;
            this.bncr.Click += new System.EventHandler(this.bncr_Click);
            // 
            // bradian
            // 
            this.bradian.Location = new System.Drawing.Point(363, 279);
            this.bradian.Name = "bradian";
            this.bradian.Size = new System.Drawing.Size(75, 23);
            this.bradian.TabIndex = 35;
            this.bradian.Text = "radian";
            this.bradian.UseVisualStyleBackColor = true;
            this.bradian.Click += new System.EventHandler(this.bradian_Click);
            // 
            // bhistory
            // 
            this.bhistory.Location = new System.Drawing.Point(58, 323);
            this.bhistory.Name = "bhistory";
            this.bhistory.Size = new System.Drawing.Size(75, 23);
            this.bhistory.TabIndex = 36;
            this.bhistory.Text = "Clear History";
            this.bhistory.UseVisualStyleBackColor = true;
            this.bhistory.Click += new System.EventHandler(this.bhistory_Click);
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(487, 80);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(196, 264);
            this.History.TabIndex = 37;
            this.History.SelectedIndexChanged += new System.EventHandler(this.History_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.History);
            this.Controls.Add(this.bhistory);
            this.Controls.Add(this.bradian);
            this.Controls.Add(this.bncr);
            this.Controls.Add(this.bfac);
            this.Controls.Add(this.blog);
            this.Controls.Add(this.bsin);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bPi);
            this.Controls.Add(this.bac);
            this.Controls.Add(this.bper);
            this.Controls.Add(this.bMOD);
            this.Controls.Add(this.bpow);
            this.Controls.Add(this.bexp);
            this.Controls.Add(this.badsub);
            this.Controls.Add(this.bcube);
            this.Controls.Add(this.bsquare);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bsquare;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bcube;
        private System.Windows.Forms.Button badsub;
        private System.Windows.Forms.Button bexp;
        private System.Windows.Forms.Button bpow;
        private System.Windows.Forms.Button bMOD;
        private System.Windows.Forms.Button bper;
        private System.Windows.Forms.Button bac;
        private System.Windows.Forms.Button bPi;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bsin;
        private System.Windows.Forms.Button blog;
        private System.Windows.Forms.Button bfac;
        private System.Windows.Forms.Button bncr;
        private System.Windows.Forms.Button bradian;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.Button bhistory;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

