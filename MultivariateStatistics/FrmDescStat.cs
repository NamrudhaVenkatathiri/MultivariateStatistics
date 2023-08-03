using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MultivariateStatistics
{
    public partial class FrmDescStat : Form
    {
        private static FrmDescStat instance = null;

        public static FrmDescStat Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public FrmDescStat()
        {
            InitializeComponent();
        }

        

        public void GetVList(string[] vl)
        {
            lstV.DataSource = vl;
        }

       
        int FindIndex(string s)
        {
            for (int i = 0; i < lstV.Items.Count; i++)
            {
                if (s == lstV.Items[i].ToString())
                    return i;
            }
            return -1;
        }

        private void btnToX_Click(object sender, EventArgs e)
        {
            vx.Text = lstV.SelectedItem.ToString();
        }

        private void btnToY_Click(object sender, EventArgs e)
        {
            vy.Text = lstV.SelectedItem.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int intX = FindIndex(vx.Text);
            int intY = FindIndex(vy.Text);
            if (intX >= 0 && intY >= 0)
            {
                FrmMain.Instance.GetDescriptiveStat(intX, intY);
                FrmMain.Instance.Refresh();
                FrmDescStat.instance.Close();
            }
        }

        private void lstV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
