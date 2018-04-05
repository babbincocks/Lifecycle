namespace Conversions
{
    partial class frmList
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
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblValueList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(16, 18);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(260, 173);
            this.lbOutput.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblValueList
            // 
            this.lblValueList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValueList.Location = new System.Drawing.Point(285, 37);
            this.lblValueList.Name = "lblValueList";
            this.lblValueList.Size = new System.Drawing.Size(79, 96);
            this.lblValueList.TabIndex = 4;
            this.lblValueList.Text = "I = 1 \r\nV = 5\r\nX = 10\r\nL = 50\r\nC = 100\r\nD = 500\r\nM = 1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic Values";
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValueList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbOutput);
            this.Name = "frmList";
            this.Text = "Conversion List";
            this.Load += new System.EventHandler(this.ListTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblValueList;
        private System.Windows.Forms.Label label1;
    }
}