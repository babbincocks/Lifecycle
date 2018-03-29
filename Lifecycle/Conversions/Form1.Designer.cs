namespace Conversions
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
            this.btnRToA = new System.Windows.Forms.Button();
            this.btnAToR = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRToA
            // 
            this.btnRToA.Location = new System.Drawing.Point(12, 225);
            this.btnRToA.Name = "btnRToA";
            this.btnRToA.Size = new System.Drawing.Size(79, 36);
            this.btnRToA.TabIndex = 0;
            this.btnRToA.Text = "Roman To Arabic";
            this.btnRToA.UseVisualStyleBackColor = true;
            this.btnRToA.Click += new System.EventHandler(this.btnRToA_Click);
            // 
            // btnAToR
            // 
            this.btnAToR.Location = new System.Drawing.Point(201, 225);
            this.btnAToR.Name = "btnAToR";
            this.btnAToR.Size = new System.Drawing.Size(79, 36);
            this.btnAToR.TabIndex = 1;
            this.btnAToR.Text = "Arabic To Roman";
            this.btnAToR.UseVisualStyleBackColor = true;
            this.btnAToR.Click += new System.EventHandler(this.btnAToR_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(65, 49);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(156, 20);
            this.inputText.TabIndex = 2;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(65, 128);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(156, 20);
            this.outputText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.btnAToR);
            this.Controls.Add(this.btnRToA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRToA;
        private System.Windows.Forms.Button btnAToR;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

