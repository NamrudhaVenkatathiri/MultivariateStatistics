using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;

namespace MultivariateStatistics
{
    public struct DescriptiveStat
    {
        public double max, min, sum, avg, var, stddev, median;
        public string range;
    }

    public struct LinearRegression
    {
        public double a, b;
    }

    public static class Mathtool
    {

        public static DescriptiveStat GetDescriptiveStat(List<double> data)
        {
            DescriptiveStat result = new DescriptiveStat();
            double sum = 0, sqSum = 0, max = data[0], min = data[0];
            foreach (double x in data)
            {
                sum += x;
                sqSum += Math.Pow(x, 2);
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            int n = data.Count;
            result.sum = sum;
            result.max = max;
            result.min = min;
            result.avg = sum / n;
            result.var = (sqSum - n * Math.Pow(result.avg, 2)) / n;
            result.stddev = Math.Sqrt(result.var);
            result.range = "(" + min + ", " + max + ")";
            data.Sort();
            if (data.Count%2==0)
            {
                result.median = (data[data.Count / 2 - 1] + data[data.Count / 2]) / 2;
            }
            else
            {
                result.median = data[data.Count / 2];
            }
            return result;
        }

        public static double GetCoefficient(double[][] data, int i, int j)
        {
            double sumX = 0, sumY = 0, sumXY = 0, sqSumX = 0, sqSumY = 0;
            int h = data.Length;
            int w = data[0].Length;
            if (i >= w || j >= w)
                throw new Exception("Variables are incorrect");
            for (int k = 0; k < h; k++)
            {
                sumX += data[k][i];
                sqSumX += Math.Pow(data[k][i], 2);
                sumY += data[k][j];
                sqSumY += Math.Pow(data[k][j], 2);
                sumXY += data[k][i] * data[k][j];
            }
            return (h * sumXY - sumX * sumY) / (Math.Sqrt(h * sqSumX - Math.Pow(sumX, 2)) * Math.Sqrt(h * sqSumY - Math.Pow(sumY, 2)));
        }

        public static LinearRegression GetLinearRegression(double[][] data, int i, int j)
        {
            LinearRegression result = new LinearRegression();
            double sumX = 0, sumY = 0, sumXY = 0, sqSumX = 0, sqSumY = 0;
            int h = data.Length;
            int w = data[0].Length;
            if (i >= w || j >= w)
                throw new Exception("Variables are incorrect");
            for (int k = 0; k < h; k++)
            {
                sumX += data[k][i];
                sqSumX += Math.Pow(data[k][i], 2);
                sumY += data[k][j];
                sqSumY += Math.Pow(data[k][j], 2);
                sumXY += data[k][i] * data[k][j];
            }
            double avgX = sumX / h;
            double avgY = sumY / h;
            result.b = (h*sumXY - sumX * sumY) / (h*sqSumX - Math.Pow(sumX, 2));
            result.a = avgY - result.b * avgX;
            return result;
        }

        public static void scatterPlot(double[][] data, int i, int j, Chart chart)
        {
            List<double> xValues = new List<double>();
            LinearRegression result_lr = Mathtool.GetLinearRegression(data, i, j);
            double a, b, xmax, xmin;
            // Create a default chart area and series if none exist
            if (chart.ChartAreas.Count == 0)
            {
                chart.ChartAreas.Add(new ChartArea("Default"));
            }
            if (chart.Series.Count == 0)
            {
                chart.Series.Add(new Series("Data"));
                chart.Series.Add(new Series("Regression"));
            }

            // Clear any existing data points from the series
            chart.Series["Data"].Points.Clear();
            chart.Series["Regression"].Points.Clear();

            // Set the chart type to a scatter plot
            chart.Series["Data"].ChartType = SeriesChartType.Point;

            // Add the data points to the series
            for (int k = 0; k < data.Length; k++)
            {
                double x = data[k][i];
                double y = data[k][j];
                xValues.Add(x);
                chart.Series["Data"].Points.AddXY(x, y);
            }
            a = result_lr.a;
            b = result_lr.b;

            xmax = xValues.Max();
            xmin = xValues.Min();
            
            //Add the regression line to the plot
            double x1 = xmin; //chart.ChartAreas["Default"].AxisX.Minimum;
            double x2 = xmax; //chart.ChartAreas["Default"].AxisX.Maximum;
            double y1 = b * x1 + a;
            double y2 = b * x2 + a;
            
            chart.Series["Regression"].ChartType = SeriesChartType.Line;
            chart.Series["Regression"].Points.AddXY(x1, y1);
            chart.Series["Regression"].Points.AddXY(x2, y2);

            // Set the chart title and axis labels
            chart.Titles.Clear();
            chart.Titles.Add("Scatter Plot");
            chart.ChartAreas["Default"].AxisY.IsStartedFromZero = false;
        }

    }
}
