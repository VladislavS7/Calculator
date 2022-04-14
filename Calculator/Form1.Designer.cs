
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_Expression = new System.Windows.Forms.TextBox();
            this.text_Resualt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.btn_CloseArc = new System.Windows.Forms.Button();
            this.btn_OpenArc = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_plus_minus = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_M = new System.Windows.Forms.Button();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // text_Expression
            // 
            this.text_Expression.Location = new System.Drawing.Point(147, 32);
            this.text_Expression.Name = "text_Expression";
            this.text_Expression.ReadOnly = true;
            this.text_Expression.Size = new System.Drawing.Size(228, 22);
            this.text_Expression.TabIndex = 1;
            // 
            // text_Resualt
            // 
            this.text_Resualt.Location = new System.Drawing.Point(147, 74);
            this.text_Resualt.Name = "text_Resualt";
            this.text_Resualt.ReadOnly = true;
            this.text_Resualt.Size = new System.Drawing.Size(228, 22);
            this.text_Resualt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_C);
            this.groupBox1.Controls.Add(this.btn_Backspace);
            this.groupBox1.Controls.Add(this.btn_CloseArc);
            this.groupBox1.Controls.Add(this.btn_OpenArc);
            this.groupBox1.Location = new System.Drawing.Point(30, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_C.ForeColor = System.Drawing.Color.Red;
            this.btn_C.Location = new System.Drawing.Point(274, 21);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(65, 48);
            this.btn_C.TabIndex = 24;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Backspace.ForeColor = System.Drawing.Color.Red;
            this.btn_Backspace.Location = new System.Drawing.Point(175, 21);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(93, 48);
            this.btn_Backspace.TabIndex = 2;
            this.btn_Backspace.Text = "Backspace";
            this.btn_Backspace.UseVisualStyleBackColor = true;
            this.btn_Backspace.Click += new System.EventHandler(this.btn_Backspace_Click);
            // 
            // btn_CloseArc
            // 
            this.btn_CloseArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CloseArc.Location = new System.Drawing.Point(69, 21);
            this.btn_CloseArc.Name = "btn_CloseArc";
            this.btn_CloseArc.Size = new System.Drawing.Size(49, 48);
            this.btn_CloseArc.TabIndex = 1;
            this.btn_CloseArc.Text = ")";
            this.btn_CloseArc.UseVisualStyleBackColor = true;
            this.btn_CloseArc.Click += new System.EventHandler(this.btn_CloseArc_Click);
            // 
            // btn_OpenArc
            // 
            this.btn_OpenArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OpenArc.Location = new System.Drawing.Point(14, 21);
            this.btn_OpenArc.Name = "btn_OpenArc";
            this.btn_OpenArc.Size = new System.Drawing.Size(49, 48);
            this.btn_OpenArc.TabIndex = 0;
            this.btn_OpenArc.Text = "(";
            this.btn_OpenArc.UseVisualStyleBackColor = true;
            this.btn_OpenArc.Click += new System.EventHandler(this.btn_OpenArc_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1.Location = new System.Drawing.Point(30, 214);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 48);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_2.Location = new System.Drawing.Point(85, 214);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 48);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_3.Location = new System.Drawing.Point(140, 214);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 48);
            this.btn_3.TabIndex = 6;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_div.ForeColor = System.Drawing.Color.Red;
            this.btn_div.Location = new System.Drawing.Point(195, 214);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(49, 48);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_4.Location = new System.Drawing.Point(30, 268);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 48);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5.Location = new System.Drawing.Point(85, 268);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 48);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_6.Location = new System.Drawing.Point(140, 268);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 48);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_mul.ForeColor = System.Drawing.Color.Red;
            this.btn_mul.Location = new System.Drawing.Point(195, 268);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(49, 48);
            this.btn_mul.TabIndex = 11;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_7.Location = new System.Drawing.Point(30, 322);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 48);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8.Location = new System.Drawing.Point(85, 322);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 48);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_9.Location = new System.Drawing.Point(140, 322);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 48);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sub.ForeColor = System.Drawing.Color.Red;
            this.btn_sub.Location = new System.Drawing.Point(195, 322);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(49, 48);
            this.btn_sub.TabIndex = 15;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_plus_minus
            // 
            this.btn_plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus_minus.Location = new System.Drawing.Point(30, 376);
            this.btn_plus_minus.Name = "btn_plus_minus";
            this.btn_plus_minus.Size = new System.Drawing.Size(49, 48);
            this.btn_plus_minus.TabIndex = 16;
            this.btn_plus_minus.Text = "+/-";
            this.btn_plus_minus.UseVisualStyleBackColor = true;
            this.btn_plus_minus.Click += new System.EventHandler(this.btn_plus_minus_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_0.Location = new System.Drawing.Point(85, 376);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(49, 48);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_mod.ForeColor = System.Drawing.Color.Red;
            this.btn_mod.Location = new System.Drawing.Point(140, 376);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(49, 48);
            this.btn_mod.TabIndex = 18;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.ForeColor = System.Drawing.Color.Red;
            this.btn_plus.Location = new System.Drawing.Point(195, 376);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(49, 48);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_M
            // 
            this.btn_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_M.ForeColor = System.Drawing.Color.Blue;
            this.btn_M.Location = new System.Drawing.Point(310, 268);
            this.btn_M.Name = "btn_M";
            this.btn_M.Size = new System.Drawing.Size(65, 48);
            this.btn_M.TabIndex = 21;
            this.btn_M.Text = "M+";
            this.btn_M.UseVisualStyleBackColor = true;
            this.btn_M.Click += new System.EventHandler(this.btn_M_Click);
            // 
            // btn_MC
            // 
            this.btn_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MC.ForeColor = System.Drawing.Color.Blue;
            this.btn_MC.Location = new System.Drawing.Point(310, 322);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(65, 48);
            this.btn_MC.TabIndex = 22;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.btn_MC_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_equal.ForeColor = System.Drawing.Color.Red;
            this.btn_equal.Location = new System.Drawing.Point(310, 372);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(65, 48);
            this.btn_equal.TabIndex = 23;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MR.ForeColor = System.Drawing.Color.Blue;
            this.btn_MR.Location = new System.Drawing.Point(310, 214);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(65, 48);
            this.btn_MR.TabIndex = 20;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.btn_MR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 455);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.btn_M);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_plus_minus);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text_Resualt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Expression);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Expression;
        private System.Windows.Forms.TextBox text_Resualt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_CloseArc;
        private System.Windows.Forms.Button btn_OpenArc;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_plus_minus;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_MR;
    }
}

