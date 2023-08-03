namespace MultivariateStatistics
{
    partial class FrmDescStat
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
            this.lstV = new System.Windows.Forms.ListBox();
            this.vx = new System.Windows.Forms.TextBox();
            this.vy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToX = new System.Windows.Forms.Button();
            this.btnToY = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstV
            // 
            this.lstV.FormattingEnabled = true;
            this.lstV.ItemHeight = 16;
            this.lstV.Location = new System.Drawing.Point(33, 43);
            this.lstV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(159, 372);
            this.lstV.TabIndex = 0;
            this.lstV.SelectedIndexChanged += new System.EventHandler(this.lstV_SelectedIndexChanged);
            // 
            // vx
            // 
            this.vx.Location = new System.Drawing.Point(347, 80);
            this.vx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vx.Name = "vx";
            this.vx.Size = new System.Drawing.Size(405, 22);
            this.vx.TabIndex = 1;
            // 
            // vy
            // 
            this.vy.Location = new System.Drawing.Point(347, 174);
            this.vy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vy.Name = "vy";
            this.vy.Size = new System.Drawing.Size(405, 22);
            this.vy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X Variable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y Variable:";
            // 
            // btnToX
            // 
            this.btnToX.Location = new System.Drawing.Point(221, 76);
            this.btnToX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToX.Name = "btnToX";
            this.btnToX.Size = new System.Drawing.Size(100, 28);
            this.btnToX.TabIndex = 5;
            this.btnToX.Text = "===>";
            this.btnToX.UseVisualStyleBackColor = true;
            this.btnToX.Click += new System.EventHandler(this.btnToX_Click);
            // 
            // btnToY
            // 
            this.btnToY.Location = new System.Drawing.Point(221, 171);
            this.btnToY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToY.Name = "btnToY";
            this.btnToY.Size = new System.Drawing.Size(100, 28);
            this.btnToY.TabIndex = 6;
            this.btnToY.Text = "===>";
            this.btnToY.UseVisualStyleBackColor = true;
            this.btnToY.Click += new System.EventHandler(this.btnToY_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(420, 278);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmDescStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 437);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnToY);
            this.Controls.Add(this.btnToX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vy);
            this.Controls.Add(this.vx);
            this.Controls.Add(this.lstV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDescStat";
            this.Text = "FrmDescStat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstV;
        private System.Windows.Forms.TextBox vx;
        private System.Windows.Forms.TextBox vy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToX;
        private System.Windows.Forms.Button btnToY;
        private System.Windows.Forms.Button btnOK;
    }
}