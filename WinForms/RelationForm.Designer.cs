using System.ComponentModel;

namespace WinForms
{
    partial class RelationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.z2Label = new System.Windows.Forms.Label();
            this.y2Label = new System.Windows.Forms.Label();
            this.l1z2Numeric = new System.Windows.Forms.NumericUpDown();
            this.l1y2Numeric = new System.Windows.Forms.NumericUpDown();
            this.l1x2Numeric = new System.Windows.Forms.NumericUpDown();
            this.x2Label = new System.Windows.Forms.Label();
            this.z1Label = new System.Windows.Forms.Label();
            this.y1Label = new System.Windows.Forms.Label();
            this.l1z1Numeric = new System.Windows.Forms.NumericUpDown();
            this.l1y1Numeric = new System.Windows.Forms.NumericUpDown();
            this.l1x1Numeric = new System.Windows.Forms.NumericUpDown();
            this.x1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.point1Btn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l2z2Numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.l2y2Numeric = new System.Windows.Forms.NumericUpDown();
            this.l2x2Numeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l2z1Numeric = new System.Windows.Forms.NumericUpDown();
            this.l2y1Numeric = new System.Windows.Forms.NumericUpDown();
            this.l2x1Numeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.l1z2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1y2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1x2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1z1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1y1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1x1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2z2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2y2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2x2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2z1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2y1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2x1Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "LINE 1";
            // 
            // z2Label
            // 
            this.z2Label.Location = new System.Drawing.Point(379, 102);
            this.z2Label.Name = "z2Label";
            this.z2Label.Size = new System.Drawing.Size(32, 27);
            this.z2Label.TabIndex = 29;
            this.z2Label.Text = "Z";
            // 
            // y2Label
            // 
            this.y2Label.Location = new System.Drawing.Point(323, 102);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(32, 27);
            this.y2Label.TabIndex = 28;
            this.y2Label.Text = "Y";
            // 
            // l1z2Numeric
            // 
            this.l1z2Numeric.Location = new System.Drawing.Point(361, 132);
            this.l1z2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1z2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1z2Numeric.Name = "l1z2Numeric";
            this.l1z2Numeric.Size = new System.Drawing.Size(57, 22);
            this.l1z2Numeric.TabIndex = 27;
            this.l1z2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l1y2Numeric
            // 
            this.l1y2Numeric.Location = new System.Drawing.Point(300, 132);
            this.l1y2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1y2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1y2Numeric.Name = "l1y2Numeric";
            this.l1y2Numeric.Size = new System.Drawing.Size(55, 22);
            this.l1y2Numeric.TabIndex = 26;
            this.l1y2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l1x2Numeric
            // 
            this.l1x2Numeric.Location = new System.Drawing.Point(237, 132);
            this.l1x2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1x2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1x2Numeric.Name = "l1x2Numeric";
            this.l1x2Numeric.Size = new System.Drawing.Size(55, 22);
            this.l1x2Numeric.TabIndex = 25;
            this.l1x2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // x2Label
            // 
            this.x2Label.Location = new System.Drawing.Point(260, 102);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(32, 27);
            this.x2Label.TabIndex = 24;
            this.x2Label.Text = "X";
            // 
            // z1Label
            // 
            this.z1Label.Location = new System.Drawing.Point(171, 102);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(32, 27);
            this.z1Label.TabIndex = 23;
            this.z1Label.Text = "Z";
            // 
            // y1Label
            // 
            this.y1Label.Location = new System.Drawing.Point(113, 102);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(32, 27);
            this.y1Label.TabIndex = 22;
            this.y1Label.Text = "Y";
            // 
            // l1z1Numeric
            // 
            this.l1z1Numeric.Location = new System.Drawing.Point(162, 132);
            this.l1z1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1z1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1z1Numeric.Name = "l1z1Numeric";
            this.l1z1Numeric.Size = new System.Drawing.Size(56, 22);
            this.l1z1Numeric.TabIndex = 21;
            this.l1z1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l1y1Numeric
            // 
            this.l1y1Numeric.Location = new System.Drawing.Point(103, 132);
            this.l1y1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1y1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1y1Numeric.Name = "l1y1Numeric";
            this.l1y1Numeric.Size = new System.Drawing.Size(53, 22);
            this.l1y1Numeric.TabIndex = 20;
            this.l1y1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l1x1Numeric
            // 
            this.l1x1Numeric.Location = new System.Drawing.Point(42, 132);
            this.l1x1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l1x1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l1x1Numeric.Name = "l1x1Numeric";
            this.l1x1Numeric.Size = new System.Drawing.Size(55, 22);
            this.l1x1Numeric.TabIndex = 19;
            this.l1x1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // x1Label
            // 
            this.x1Label.Location = new System.Drawing.Point(52, 102);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(32, 27);
            this.x1Label.TabIndex = 18;
            this.x1Label.Text = "X";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(300, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Point2";
            // 
            // point1Btn
            // 
            this.point1Btn.Location = new System.Drawing.Point(90, 75);
            this.point1Btn.Name = "point1Btn";
            this.point1Btn.Size = new System.Drawing.Size(55, 27);
            this.point1Btn.TabIndex = 16;
            this.point1Btn.Text = "Point1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "LINE 2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(379, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Z";
            // 
            // l2z2Numeric
            // 
            this.l2z2Numeric.Location = new System.Drawing.Point(361, 293);
            this.l2z2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2z2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2z2Numeric.Name = "l2z2Numeric";
            this.l2z2Numeric.Size = new System.Drawing.Size(57, 22);
            this.l2z2Numeric.TabIndex = 42;
            this.l2z2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(323, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 27);
            this.label5.TabIndex = 43;
            this.label5.Text = "Y";
            // 
            // l2y2Numeric
            // 
            this.l2y2Numeric.Location = new System.Drawing.Point(300, 293);
            this.l2y2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2y2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2y2Numeric.Name = "l2y2Numeric";
            this.l2y2Numeric.Size = new System.Drawing.Size(55, 22);
            this.l2y2Numeric.TabIndex = 41;
            this.l2y2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l2x2Numeric
            // 
            this.l2x2Numeric.Location = new System.Drawing.Point(237, 293);
            this.l2x2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2x2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2x2Numeric.Name = "l2x2Numeric";
            this.l2x2Numeric.Size = new System.Drawing.Size(55, 22);
            this.l2x2Numeric.TabIndex = 40;
            this.l2x2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(260, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(171, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 27);
            this.label7.TabIndex = 38;
            this.label7.Text = "Z";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(113, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 27);
            this.label8.TabIndex = 37;
            this.label8.Text = "Y";
            // 
            // l2z1Numeric
            // 
            this.l2z1Numeric.Location = new System.Drawing.Point(162, 293);
            this.l2z1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2z1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2z1Numeric.Name = "l2z1Numeric";
            this.l2z1Numeric.Size = new System.Drawing.Size(56, 22);
            this.l2z1Numeric.TabIndex = 36;
            this.l2z1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l2y1Numeric
            // 
            this.l2y1Numeric.Location = new System.Drawing.Point(103, 293);
            this.l2y1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2y1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2y1Numeric.Name = "l2y1Numeric";
            this.l2y1Numeric.Size = new System.Drawing.Size(53, 22);
            this.l2y1Numeric.TabIndex = 35;
            this.l2y1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // l2x1Numeric
            // 
            this.l2x1Numeric.Location = new System.Drawing.Point(42, 293);
            this.l2x1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.l2x1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.l2x1Numeric.Name = "l2x1Numeric";
            this.l2x1Numeric.Size = new System.Drawing.Size(55, 22);
            this.l2x1Numeric.TabIndex = 34;
            this.l2x1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(52, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(300, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 27);
            this.label10.TabIndex = 32;
            this.label10.Text = "Point2";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(90, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 27);
            this.label11.TabIndex = 31;
            this.label11.Text = "Point1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 46;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l2z2Numeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l2y2Numeric);
            this.Controls.Add(this.l2x2Numeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l2z1Numeric);
            this.Controls.Add(this.l2y1Numeric);
            this.Controls.Add(this.l2x1Numeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z2Label);
            this.Controls.Add(this.y2Label);
            this.Controls.Add(this.l1z2Numeric);
            this.Controls.Add(this.l1y2Numeric);
            this.Controls.Add(this.l1x2Numeric);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.z1Label);
            this.Controls.Add(this.y1Label);
            this.Controls.Add(this.l1z1Numeric);
            this.Controls.Add(this.l1y1Numeric);
            this.Controls.Add(this.l1x1Numeric);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.point1Btn);
            this.Name = "RelationForm";
            this.Text = "RelationForm";
            ((System.ComponentModel.ISupportInitialize)(this.l1z2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1y2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1x2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1z1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1y1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l1x1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2z2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2y2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2x2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2z1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2y1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l2x1Numeric)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label z2Label;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.NumericUpDown l1z2Numeric;
        private System.Windows.Forms.NumericUpDown l1y2Numeric;
        private System.Windows.Forms.NumericUpDown l1x2Numeric;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.Label z1Label;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.NumericUpDown l1z1Numeric;
        private System.Windows.Forms.NumericUpDown l1y1Numeric;
        private System.Windows.Forms.NumericUpDown l1x1Numeric;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label point1Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown l2z2Numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown l2y2Numeric;
        private System.Windows.Forms.NumericUpDown l2x2Numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown l2z1Numeric;
        private System.Windows.Forms.NumericUpDown l2y1Numeric;
        private System.Windows.Forms.NumericUpDown l2x1Numeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

        #endregion
    }
}