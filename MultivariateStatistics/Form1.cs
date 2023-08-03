using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace MultivariateStatistics
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string[] lines;
        string[] colnames;
        string[][] strValues;
        double[][] dblValues;
        string fileName;
        Chart chart1 = new Chart();

        private static FrmMain instance = null;
        

        public static FrmMain Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private void CorrelationCoefficientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                string q = "No data is loaded. Load data?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show(q, "Missing Data", b);
                if (r == DialogResult.Yes)
                    LoadData();
            }
            else
            {
                FrmCoef.Instance = new FrmCoef();
                FrmCoef.Instance.GetVList(colnames);
                FrmCoef.Instance.Show();
            }
        }

        private void LinearRegressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                string q = "No data is loaded. Load data?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show(q, "Missing Data", b);
                if (r == DialogResult.Yes)
                    LoadData();
            }
            else
            {
                FrmLinReg.Instance = new FrmLinReg();
                FrmLinReg.Instance.GetVList(colnames);
                FrmLinReg.Instance.Show();
            }
        }

        private void ScatterPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                string q = "No data is loaded. Load data?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show(q, "Missing Data", b);
                if (r == DialogResult.Yes)
                    LoadData();
            }
            else
            {
                FrmScatterPlot.Instance = new FrmScatterPlot();
                FrmScatterPlot.Instance.GetVList(colnames);
                FrmScatterPlot.Instance.Show();
            }
        }

        private void DescriptivestatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtStat.Text=null;
            if (dgvData.Rows.Count == 0)
            {
                string q = "No data is loaded. Load data?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show(q, "Missing Data", b);
                if (r == DialogResult.Yes)
                    LoadData();
            }
            else
            {
                FrmDescStat.Instance = new FrmDescStat();
                FrmDescStat.Instance.GetVList(colnames);
                FrmDescStat.Instance.Show();
            }
        }
        
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;

            //update dblValues from data grid
            dblValues[r][c] = Convert.ToDouble(dgvData.Rows[r].Cells[c].Value);
            
            //update originally read data lines
            lines[r+1] = dblValues[r][0].ToString();
            for (int i = 1; i < dblValues[r].Length; i++)
                lines[r+1] += "\t" + dblValues[r][i];

            //New By HKKR
            List<double[]> datalist = new List<double[]>();
            for (int i = 0; i < dblValues.GetLength(0); i++)
            {
                double[] temp = new double[dblValues.GetLength(1)];
                for (int n = 0; n < temp.Length; n++)
                {
                    temp[n] = dblValues[i][n];
                }
                datalist.Add(temp);
            }
            Console.WriteLine(datalist);
        }

        public void GetCoefficient(int i, int j)
        {
            double result = Mathtool.GetCoefficient(dblValues, i, j);
            txtStat.Text = "Correlation Coefficient between " + colnames[i] + " and " + colnames[j] + " is: " + result.ToString("#.##");
            tcStat.SelectedTab = tp2;
        }

        public void GetDescriptiveStat(int i, int j)
        {
            var colIndexes = new List<int>();
            colIndexes.Add(i);
            colIndexes.Add(j);

            foreach (int m in colIndexes)
            {
                List<double> columnValues = new List<double>();

                for (int k = 0; k < dblValues.Length; k++)
                {
                    double value = dblValues[k][m];
                    columnValues.Add(value);
                }

                DescriptiveStat result = Mathtool.GetDescriptiveStat(columnValues);

                string output = $"Column Name: {colnames[m]}{Environment.NewLine}"
                                + $"Sum: {result.sum}{Environment.NewLine}"
                                + $"Max: {result.max}{Environment.NewLine}"
                                + $"Min: {result.min}{Environment.NewLine}"
                                + $"Average: {result.avg}{Environment.NewLine}"
                                + $"Variance: {result.var}{Environment.NewLine}"
                                + $"Std Dev: {result.stddev}{Environment.NewLine}"
                                + $"Range: {result.range}{Environment.NewLine}"
                                + $"Median: {result.median}{Environment.NewLine}"
                                + $"{Environment.NewLine}";

                txtStat.AppendText(output);
            }

            tcStat.SelectedTab = tp2;
        }

        public void GetLinearRegression(int i, int j)
        {
            LinearRegression result = Mathtool.GetLinearRegression(dblValues, i, j);
            txtStat.Text = "Regression Coefficients for " + colnames[i] + " and " + colnames[j] + " are: " + Environment.NewLine
                + "a = " + result.a + Environment.NewLine
                + "b = " + result.b;
            tcStat.SelectedTab = tp2;
        }

        public void GetScatterPlot(int i, int j)
        {
            Mathtool.scatterPlot(dblValues, i, j, chart1);
            chart1.ChartAreas["Default"].AxisX.Title = colnames[i];
            chart1.ChartAreas["Default"].AxisY.Title = colnames[j];
            tcStat.SelectedTab = tp3;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string q = "Do you want to save data?";
            MessageBoxButtons b = MessageBoxButtons.YesNo;
            DialogResult r = MessageBox.Show(q, "Save Data?", b);

            //write lines to the original text file
            if (r == DialogResult.Yes)
            {
                if (lines!=null)
                    File.WriteAllLines(fileName, lines);
            }
            Application.Exit();
        }

        public void LoadData()
        {
            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.InitialDirectory = @"c:\";
            mydialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                fileName = mydialog.FileName;
                lines = File.ReadAllLines(fileName);

            }


            //use Linq to remove blank lines
            //lines = lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            //use list as intermediate step to remove blank lines
            List<string> temp = new List<string>();

            foreach (string x in lines)
            {
                if (!string.IsNullOrEmpty(x))
                    temp.Add(x);
            }
            lines = temp.ToArray();

            //get total lines in the file
            int h = lines.Length;

            //put invidual data item into strValues
            strValues = new string[h - 1][];
            //the first row makes up column names
            colnames = lines[0].Split('\t');

            foreach (string x in colnames)
                dgvData.Columns.Add(x, x);

            for (int i = 1; i < h; i++)
            {
                strValues[i - 1] = lines[i].Split('\t');
            }

            int w = colnames.Length;
            dblValues = new double[h - 1][];

            dgvData.ColumnCount = w;
            for (int i = 0; i < h - 1; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvData);
                dblValues[i] = new double[w];
                for (int j = 0; j < strValues[i].Length; j++)
                {
                    r.Cells[j].Value = strValues[i][j];
                    dblValues[i][j] = Convert.ToDouble(strValues[i][j]);
                }
                dgvData.Rows.Add(r);

            }
            tcStat.SelectedTab = tp1;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tp1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
