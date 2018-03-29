namespace Conversions
{
    partial class ListTest
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
            this.btnAToR = new System.Windows.Forms.Button();
            this.btnRToA = new System.Windows.Forms.Button();
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
            // btnAToR
            // 
            this.btnAToR.Location = new System.Drawing.Point(201, 225);
            this.btnAToR.Name = "btnAToR";
            this.btnAToR.Size = new System.Drawing.Size(79, 36);
            this.btnAToR.TabIndex = 3;
            this.btnAToR.Text = "Arabic To Roman";
            this.btnAToR.UseVisualStyleBackColor = true;
            this.btnAToR.Click += new System.EventHandler(this.btnAToR_Click);
            // 
            // btnRToA
            // 
            this.btnRToA.Location = new System.Drawing.Point(12, 225);
            this.btnRToA.Name = "btnRToA";
            this.btnRToA.Size = new System.Drawing.Size(79, 36);
            this.btnRToA.TabIndex = 2;
            this.btnRToA.Text = "Roman To Arabic";
            this.btnRToA.UseVisualStyleBackColor = true;
            this.btnRToA.Click += new System.EventHandler(this.btnRToA_Click);
            // 
            // ListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnAToR);
            this.Controls.Add(this.btnRToA);
            this.Controls.Add(this.lbOutput);
            this.Name = "ListTest";
            this.Text = "ListTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnAToR;
        private System.Windows.Forms.Button btnRToA;
    }
}