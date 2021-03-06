using System.ComponentModel;

namespace WinForms
{
    partial class LinePanelForm
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
            this.point1Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.x1Label = new System.Windows.Forms.Label();
            this.x1Numeric = new System.Windows.Forms.NumericUpDown();
            this.y1Numeric = new System.Windows.Forms.NumericUpDown();
            this.z1Numeric = new System.Windows.Forms.NumericUpDown();
            this.y1Label = new System.Windows.Forms.Label();
            this.z1Label = new System.Windows.Forms.Label();
            this.z2Label = new System.Windows.Forms.Label();
            this.y2Label = new System.Windows.Forms.Label();
            this.z2Numeric = new System.Windows.Forms.NumericUpDown();
            this.y2Numeric = new System.Windows.Forms.NumericUpDown();
            this.x2Numeric = new System.Windows.Forms.NumericUpDown();
            this.x2Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cNumeric = new System.Windows.Forms.NumericUpDown();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.aNumeric = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.dNumeric = new System.Windows.Forms.NumericUpDown();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // point1Btn
            // 
            this.point1Btn.Location = new System.Drawing.Point(70, 56);
            this.point1Btn.Name = "point1Btn";
            this.point1Btn.Size = new System.Drawing.Size(55, 27);
            this.point1Btn.TabIndex = 0;
            this.point1Btn.Text = "Point1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Point2";
            // 
            // x1Label
            // 
            this.x1Label.Location = new System.Drawing.Point(32, 83);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(32, 27);
            this.x1Label.TabIndex = 3;
            this.x1Label.Text = "X";
            // 
            // x1Numeric
            // 
            this.x1Numeric.Location = new System.Drawing.Point(22, 113);
            this.x1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.x1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.x1Numeric.Name = "x1Numeric";
            this.x1Numeric.Size = new System.Drawing.Size(55, 22);
            this.x1Numeric.TabIndex = 4;
            this.x1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // y1Numeric
            // 
            this.y1Numeric.Location = new System.Drawing.Point(83, 113);
            this.y1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.y1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.y1Numeric.Name = "y1Numeric";
            this.y1Numeric.Size = new System.Drawing.Size(53, 22);
            this.y1Numeric.TabIndex = 5;
            this.y1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // z1Numeric
            // 
            this.z1Numeric.Location = new System.Drawing.Point(142, 113);
            this.z1Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.z1Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.z1Numeric.Name = "z1Numeric";
            this.z1Numeric.Size = new System.Drawing.Size(56, 22);
            this.z1Numeric.TabIndex = 6;
            this.z1Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // y1Label
            // 
            this.y1Label.Location = new System.Drawing.Point(93, 83);
            this.y1Label.Name = "y1Label";
            this.y1Label.Size = new System.Drawing.Size(32, 27);
            this.y1Label.TabIndex = 7;
            this.y1Label.Text = "Y";
            // 
            // z1Label
            // 
            this.z1Label.Location = new System.Drawing.Point(151, 83);
            this.z1Label.Name = "z1Label";
            this.z1Label.Size = new System.Drawing.Size(32, 27);
            this.z1Label.TabIndex = 8;
            this.z1Label.Text = "Z";
            // 
            // z2Label
            // 
            this.z2Label.Location = new System.Drawing.Point(359, 83);
            this.z2Label.Name = "z2Label";
            this.z2Label.Size = new System.Drawing.Size(32, 27);
            this.z2Label.TabIndex = 14;
            this.z2Label.Text = "Z";
            // 
            // y2Label
            // 
            this.y2Label.Location = new System.Drawing.Point(303, 83);
            this.y2Label.Name = "y2Label";
            this.y2Label.Size = new System.Drawing.Size(32, 27);
            this.y2Label.TabIndex = 13;
            this.y2Label.Text = "Y";
            // 
            // z2Numeric
            // 
            this.z2Numeric.Location = new System.Drawing.Point(341, 113);
            this.z2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.z2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.z2Numeric.Name = "z2Numeric";
            this.z2Numeric.Size = new System.Drawing.Size(57, 22);
            this.z2Numeric.TabIndex = 12;
            this.z2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // y2Numeric
            // 
            this.y2Numeric.Location = new System.Drawing.Point(280, 113);
            this.y2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.y2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.y2Numeric.Name = "y2Numeric";
            this.y2Numeric.Size = new System.Drawing.Size(55, 22);
            this.y2Numeric.TabIndex = 11;
            this.y2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // x2Numeric
            // 
            this.x2Numeric.Location = new System.Drawing.Point(217, 113);
            this.x2Numeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.x2Numeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.x2Numeric.Name = "x2Numeric";
            this.x2Numeric.Size = new System.Drawing.Size(55, 22);
            this.x2Numeric.TabIndex = 10;
            this.x2Numeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // x2Label
            // 
            this.x2Label.Location = new System.Drawing.Point(240, 83);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(32, 27);
            this.x2Label.TabIndex = 9;
            this.x2Label.Text = "X";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "LINE";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "PLANE";
            // 
            // cLabel
            // 
            this.cLabel.Location = new System.Drawing.Point(142, 240);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(32, 27);
            this.cLabel.TabIndex = 22;
            this.cLabel.Text = "C";
            // 
            // bLabel
            // 
            this.bLabel.Location = new System.Drawing.Point(80, 240);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(32, 27);
            this.bLabel.TabIndex = 21;
            this.bLabel.Text = "B";
            // 
            // cNumeric
            // 
            this.cNumeric.Location = new System.Drawing.Point(132, 270);
            this.cNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.cNumeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.cNumeric.Name = "cNumeric";
            this.cNumeric.Size = new System.Drawing.Size(51, 22);
            this.cNumeric.TabIndex = 20;
            this.cNumeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // bNumeric
            // 
            this.bNumeric.Location = new System.Drawing.Point(70, 270);
            this.bNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.bNumeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(55, 22);
            this.bNumeric.TabIndex = 19;
            this.bNumeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // aNumeric
            // 
            this.aNumeric.Location = new System.Drawing.Point(9, 270);
            this.aNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.aNumeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.aNumeric.Name = "aNumeric";
            this.aNumeric.Size = new System.Drawing.Size(55, 22);
            this.aNumeric.TabIndex = 18;
            this.aNumeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // aLabel
            // 
            this.aLabel.Location = new System.Drawing.Point(19, 240);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(32, 27);
            this.aLabel.TabIndex = 17;
            this.aLabel.Text = "A";
            // 
            // dLabel
            // 
            this.dLabel.Location = new System.Drawing.Point(204, 240);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(32, 27);
            this.dLabel.TabIndex = 23;
            this.dLabel.Text = "D";
            // 
            // dNumeric
            // 
            this.dNumeric.Location = new System.Drawing.Point(194, 270);
            this.dNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.dNumeric.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.dNumeric.Name = "dNumeric";
            this.dNumeric.Size = new System.Drawing.Size(57, 22);
            this.dNumeric.TabIndex = 24;
            this.dNumeric.Value = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(154, 348);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(118, 42);
            this.submitBtn.TabIndex = 25;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // LinePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.dNumeric);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.cNumeric);
            this.Controls.Add(this.bNumeric);
            this.Controls.Add(this.aNumeric);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z2Label);
            this.Controls.Add(this.y2Label);
            this.Controls.Add(this.z2Numeric);
            this.Controls.Add(this.y2Numeric);
            this.Controls.Add(this.x2Numeric);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.z1Label);
            this.Controls.Add(this.y1Label);
            this.Controls.Add(this.z1Numeric);
            this.Controls.Add(this.y1Numeric);
            this.Controls.Add(this.x1Numeric);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.point1Btn);
            this.Name = "LinePanelForm";
            this.Text = "LinePanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.x1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.NumericUpDown cNumeric;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.NumericUpDown aNumeric;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Button submitBtn;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label point1Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.NumericUpDown x1Numeric;
        private System.Windows.Forms.NumericUpDown y1Numeric;
        private System.Windows.Forms.NumericUpDown z1Numeric;
        private System.Windows.Forms.Label y1Label;
        private System.Windows.Forms.Label z1Label;
        private System.Windows.Forms.Label z2Label;
        private System.Windows.Forms.Label y2Label;
        private System.Windows.Forms.NumericUpDown z2Numeric;
        private System.Windows.Forms.NumericUpDown y2Numeric;
        private System.Windows.Forms.NumericUpDown x2Numeric;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}