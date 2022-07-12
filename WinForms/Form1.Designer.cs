namespace WinForms
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
            this.LinePlaneBtn = new System.Windows.Forms.Button();
            this.RelationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinePlaneBtn
            // 
            this.LinePlaneBtn.Location = new System.Drawing.Point(46, 49);
            this.LinePlaneBtn.Name = "LinePlaneBtn";
            this.LinePlaneBtn.Size = new System.Drawing.Size(182, 33);
            this.LinePlaneBtn.TabIndex = 0;
            this.LinePlaneBtn.Text = "Intersect line with plane";
            this.LinePlaneBtn.UseVisualStyleBackColor = true;
            this.LinePlaneBtn.Click += new System.EventHandler(this.LinePlaneBtn_Click);
            // 
            // RelationBtn
            // 
            this.RelationBtn.Location = new System.Drawing.Point(46, 101);
            this.RelationBtn.Name = "RelationBtn";
            this.RelationBtn.Size = new System.Drawing.Size(182, 33);
            this.RelationBtn.TabIndex = 1;
            this.RelationBtn.Text = "Relation between lines";
            this.RelationBtn.UseVisualStyleBackColor = true;
            this.RelationBtn.Click += new System.EventHandler(this.RelationBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 272);
            this.Controls.Add(this.RelationBtn);
            this.Controls.Add(this.LinePlaneBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button LinePlaneBtn;
        private System.Windows.Forms.Button RelationBtn;

        #endregion
    }
}