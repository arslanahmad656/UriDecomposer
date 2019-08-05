namespace UriDecomposer
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
            this.TxtQueryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDecompse = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtQueryBox
            // 
            this.TxtQueryBox.Location = new System.Drawing.Point(111, 28);
            this.TxtQueryBox.Name = "TxtQueryBox";
            this.TxtQueryBox.Size = new System.Drawing.Size(526, 20);
            this.TxtQueryBox.TabIndex = 0;
            this.TxtQueryBox.Enter += new System.EventHandler(this.TxtQueryBox_Enter);
            this.TxtQueryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQueryBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url or Query String:";
            // 
            // BtnDecompse
            // 
            this.BtnDecompse.Location = new System.Drawing.Point(643, 25);
            this.BtnDecompse.Name = "BtnDecompse";
            this.BtnDecompse.Size = new System.Drawing.Size(75, 23);
            this.BtnDecompse.TabIndex = 2;
            this.BtnDecompse.Text = "Decompose";
            this.BtnDecompse.UseVisualStyleBackColor = true;
            this.BtnDecompse.Click += new System.EventHandler(this.BtnDecompse_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(15, 68);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResult.Size = new System.Drawing.Size(703, 267);
            this.TxtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 347);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDecompse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQueryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "URI Decomposer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQueryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDecompse;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

