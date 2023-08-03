namespace MultivariateStatistics
{
    partial class FrmMain
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
            this.tcStat = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptiveStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correlationCoefficientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearRegressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scatterPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcStat.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStat
            // 
            this.tcStat.Controls.Add(this.tp1);
            this.tcStat.Controls.Add(this.tp2);
            this.tcStat.Controls.Add(this.tp3);
            this.tcStat.Location = new System.Drawing.Point(2, 27);
            this.tcStat.Name = "tcStat";
            this.tcStat.SelectedIndex = 0;
            this.tcStat.Size = new System.Drawing.Size(1025, 573);
            this.tcStat.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.dgvData);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1017, 547);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Data";
            this.tp1.UseVisualStyleBackColor = true;
            this.tp1.Click += new System.EventHandler(this.Tp1_Click);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.txtStat);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1017, 547);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Result";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(4, 7);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(1017, 544);
            this.txtStat.TabIndex = 0;
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.chart1);
            this.tp3.Location = new System.Drawing.Point(4, 22);
            this.tp3.Margin = new System.Windows.Forms.Padding(4);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(4);
            this.tp3.Size = new System.Drawing.Size(1017, 547);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Scatter Plot";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(500, 500);
            this.chart1.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 395);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 102;
            this.dgvData.Size = new System.Drawing.Size(1015, 148);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellValueChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1039, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptiveStatisticsToolStripMenuItem,
            this.correlationCoefficientToolStripMenuItem,
            this.linearRegressionToolStripMenuItem,
            this.scatterPlotToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // descriptiveStatisticsToolStripMenuItem
            // 
            this.descriptiveStatisticsToolStripMenuItem.Name = "descriptiveStatisticsToolStripMenuItem";
            this.descriptiveStatisticsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.descriptiveStatisticsToolStripMenuItem.Text = "Descriptive Statistics";
            this.descriptiveStatisticsToolStripMenuItem.Click += new System.EventHandler(this.DescriptivestatisticsToolStripMenuItem_Click);
            // 
            // correlationCoefficientToolStripMenuItem
            // 
            this.correlationCoefficientToolStripMenuItem.Name = "correlationCoefficientToolStripMenuItem";
            this.correlationCoefficientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.correlationCoefficientToolStripMenuItem.Text = "Correlation Coefficient";
            this.correlationCoefficientToolStripMenuItem.Click += new System.EventHandler(this.CorrelationCoefficientToolStripMenuItem_Click);
            // 
            // linearRegressionToolStripMenuItem
            // 
            this.linearRegressionToolStripMenuItem.Name = "linearRegressionToolStripMenuItem";
            this.linearRegressionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.linearRegressionToolStripMenuItem.Text = "Linear Regression";
            this.linearRegressionToolStripMenuItem.Click += new System.EventHandler(this.LinearRegressionToolStripMenuItem_Click);
            // 
            // scatterPlotToolStripMenuItem
            // 
            this.scatterPlotToolStripMenuItem.Name = "scatterPlotToolStripMenuItem";
            this.scatterPlotToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.scatterPlotToolStripMenuItem.Text = "Scatter Plot";
            this.scatterPlotToolStripMenuItem.Click += new System.EventHandler(this.ScatterPlotToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 604);
            this.Controls.Add(this.tcStat);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Multivariate Statistics Toolkit";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcStat.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.tp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcStat;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptiveStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correlationCoefficientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearRegressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scatterPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

