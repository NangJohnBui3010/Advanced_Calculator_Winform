
namespace AdvancedCalc
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
            this.txtbx = new System.Windows.Forms.TextBox();
            this.so1 = new System.Windows.Forms.Button();
            this.so4 = new System.Windows.Forms.Button();
            this.so7 = new System.Windows.Forms.Button();
            this.negate = new System.Windows.Forms.Button();
            this.so0 = new System.Windows.Forms.Button();
            this.so8 = new System.Windows.Forms.Button();
            this.so5 = new System.Windows.Forms.Button();
            this.so2 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.so9 = new System.Windows.Forms.Button();
            this.so6 = new System.Windows.Forms.Button();
            this.so3 = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.sol = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.luythua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblequa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx
            // 
            this.txtbx.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx.Location = new System.Drawing.Point(28, 52);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(748, 51);
            this.txtbx.TabIndex = 0;
            this.txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // so1
            // 
            this.so1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so1.Location = new System.Drawing.Point(28, 256);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(132, 53);
            this.so1.TabIndex = 1;
            this.so1.Text = "1";
            this.so1.UseVisualStyleBackColor = true;
            this.so1.Click += new System.EventHandler(this.so1_Click);
            // 
            // so4
            // 
            this.so4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so4.Location = new System.Drawing.Point(28, 183);
            this.so4.Name = "so4";
            this.so4.Size = new System.Drawing.Size(132, 53);
            this.so4.TabIndex = 2;
            this.so4.Text = "4";
            this.so4.UseVisualStyleBackColor = true;
            this.so4.Click += new System.EventHandler(this.so4_Click);
            // 
            // so7
            // 
            this.so7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so7.Location = new System.Drawing.Point(28, 110);
            this.so7.Name = "so7";
            this.so7.Size = new System.Drawing.Size(132, 53);
            this.so7.TabIndex = 3;
            this.so7.Text = "7";
            this.so7.UseVisualStyleBackColor = true;
            this.so7.Click += new System.EventHandler(this.so7_Click);
            // 
            // negate
            // 
            this.negate.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.negate.Location = new System.Drawing.Point(28, 327);
            this.negate.Name = "negate";
            this.negate.Size = new System.Drawing.Size(132, 53);
            this.negate.TabIndex = 4;
            this.negate.Text = "+/-";
            this.negate.UseVisualStyleBackColor = true;
            // 
            // so0
            // 
            this.so0.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so0.Location = new System.Drawing.Point(187, 327);
            this.so0.Name = "so0";
            this.so0.Size = new System.Drawing.Size(132, 53);
            this.so0.TabIndex = 8;
            this.so0.Text = "0";
            this.so0.UseVisualStyleBackColor = true;
            this.so0.Click += new System.EventHandler(this.so0_Click);
            // 
            // so8
            // 
            this.so8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so8.Location = new System.Drawing.Point(187, 109);
            this.so8.Name = "so8";
            this.so8.Size = new System.Drawing.Size(132, 53);
            this.so8.TabIndex = 7;
            this.so8.Text = "8";
            this.so8.UseVisualStyleBackColor = true;
            this.so8.Click += new System.EventHandler(this.so8_Click);
            // 
            // so5
            // 
            this.so5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so5.Location = new System.Drawing.Point(187, 183);
            this.so5.Name = "so5";
            this.so5.Size = new System.Drawing.Size(132, 53);
            this.so5.TabIndex = 6;
            this.so5.Text = "5";
            this.so5.UseVisualStyleBackColor = true;
            this.so5.Click += new System.EventHandler(this.so5_Click);
            // 
            // so2
            // 
            this.so2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so2.Location = new System.Drawing.Point(187, 256);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(132, 53);
            this.so2.TabIndex = 5;
            this.so2.Text = "2";
            this.so2.UseVisualStyleBackColor = true;
            this.so2.Click += new System.EventHandler(this.so2_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del.Location = new System.Drawing.Point(647, 110);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(132, 53);
            this.del.TabIndex = 12;
            this.del.Text = "<--";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // so9
            // 
            this.so9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so9.Location = new System.Drawing.Point(346, 110);
            this.so9.Name = "so9";
            this.so9.Size = new System.Drawing.Size(132, 53);
            this.so9.TabIndex = 11;
            this.so9.Text = "9";
            this.so9.UseVisualStyleBackColor = true;
            this.so9.Click += new System.EventHandler(this.so9_Click);
            // 
            // so6
            // 
            this.so6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so6.Location = new System.Drawing.Point(346, 183);
            this.so6.Name = "so6";
            this.so6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.so6.Size = new System.Drawing.Size(132, 53);
            this.so6.TabIndex = 10;
            this.so6.Text = "6";
            this.so6.UseVisualStyleBackColor = true;
            this.so6.Click += new System.EventHandler(this.so6_Click);
            // 
            // so3
            // 
            this.so3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so3.Location = new System.Drawing.Point(346, 256);
            this.so3.Name = "so3";
            this.so3.Size = new System.Drawing.Size(132, 53);
            this.so3.TabIndex = 9;
            this.so3.Text = "3";
            this.so3.UseVisualStyleBackColor = true;
            this.so3.Click += new System.EventHandler(this.so3_Click);
            // 
            // ac
            // 
            this.ac.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ac.Location = new System.Drawing.Point(647, 183);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(132, 53);
            this.ac.TabIndex = 16;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(509, 183);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(132, 53);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(509, 256);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(132, 53);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(509, 327);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(132, 53);
            this.divide.TabIndex = 13;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(509, 110);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(132, 53);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // sol
            // 
            this.sol.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sol.Location = new System.Drawing.Point(647, 327);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(132, 53);
            this.sol.TabIndex = 18;
            this.sol.Text = "=";
            this.sol.UseVisualStyleBackColor = true;
            this.sol.Click += new System.EventHandler(this.sol_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(346, 327);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(132, 53);
            this.dot.TabIndex = 19;
            this.dot.Text = ".";
            this.dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans.Location = new System.Drawing.Point(647, 256);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(132, 53);
            this.ans.TabIndex = 20;
            this.ans.Text = "ANS";
            this.ans.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(621, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 31);
            this.lbl.TabIndex = 21;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(509, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 22;
            this.button1.Text = "x!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(187, 399);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(132, 51);
            this.div.TabIndex = 24;
            this.div.Text = "div";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mod.Location = new System.Drawing.Point(28, 399);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(132, 51);
            this.mod.TabIndex = 25;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(647, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 51);
            this.button5.TabIndex = 26;
            this.button5.Text = "sqrt(x)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(28, 472);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 51);
            this.button6.TabIndex = 27;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(187, 472);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 51);
            this.button8.TabIndex = 29;
            this.button8.Text = "x^2";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // luythua
            // 
            this.luythua.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luythua.Location = new System.Drawing.Point(346, 399);
            this.luythua.Name = "luythua";
            this.luythua.Size = new System.Drawing.Size(132, 51);
            this.luythua.TabIndex = 31;
            this.luythua.Text = "^";
            this.luythua.UseVisualStyleBackColor = true;
            this.luythua.Click += new System.EventHandler(this.luythua_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(346, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 33;
            this.button2.Text = "EquaSol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblequa
            // 
            this.lblequa.AutoSize = true;
            this.lblequa.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblequa.Location = new System.Drawing.Point(28, 3);
            this.lblequa.Name = "lblequa";
            this.lblequa.Size = new System.Drawing.Size(0, 45);
            this.lblequa.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(813, 594);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 593);
            this.Controls.Add(this.lblequa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.luythua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.del);
            this.Controls.Add(this.so9);
            this.Controls.Add(this.so6);
            this.Controls.Add(this.so3);
            this.Controls.Add(this.so0);
            this.Controls.Add(this.so8);
            this.Controls.Add(this.so5);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.negate);
            this.Controls.Add(this.so7);
            this.Controls.Add(this.so4);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.txtbx);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.Button so1;
        private System.Windows.Forms.Button so4;
        private System.Windows.Forms.Button so7;
        private System.Windows.Forms.Button negate;
        private System.Windows.Forms.Button so0;
        private System.Windows.Forms.Button so8;
        private System.Windows.Forms.Button so5;
        private System.Windows.Forms.Button so2;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button so9;
        private System.Windows.Forms.Button so6;
        private System.Windows.Forms.Button so3;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button sol;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button luythua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblequa;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

