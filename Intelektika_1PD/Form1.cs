using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelektika_1PD
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateInterface();
           
        }
        
        private void Calculate_Click(object sender, EventArgs e)
        {

            var s = new Stopwatch();
            bool method = (radioMethod1.Checked || radioMethod2.Checked);
            if (method == false)
            {
                MessageBox.Show("Please select a method you want to calculate with");
                return;
            }
            if (string.IsNullOrEmpty(neibCombo.Text))
            {
                MessageBox.Show("Please select number of neighbour");
                return;
            }
            if (string.IsNullOrEmpty(pointCombo.Text))
            {
                MessageBox.Show("Please select a point to calculate");
                return;
            }
            if (radioMethod1.Checked == true)
            {
                string asd = pointCombo.Text;
                string[] split = asd.Split(':');
                Method1 method1 = new Method1();
                
                s.Start();
                List<Data> res = method1.calculateData(split[1], split[3], neibCombo.Text);
                s.Stop();
                
                timeLabel.Text = "Calculation time: " + s.ElapsedMilliseconds + " ms";
                
                if (res[0].klass == "no")
                {
                    MessageBox.Show("With this number of neighbour the is no valid result");
                }
                else if (res[0].klass == "+")
                {
                    DialogResult dr = MessageBox.Show("This points class is a + do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.addPoint(res[0].X.ToString(), res[0].Y.ToString(), res[0].klass);
                        database.deleteFromPointsTo(res[0].X.ToString(), res[0].Y.ToString());
                        updateInterface();
                    }
                }
                else if (res[0].klass == "-")
                {
                    DialogResult dr = MessageBox.Show("This points class is a - do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.addPoint(res[0].X.ToString(), res[0].Y.ToString(), res[0].klass);
                        database.deleteFromPointsTo(res[0].X.ToString(), res[0].Y.ToString());
                        updateInterface();
                    }
                }
            }
            if (radioMethod2.Checked==true)
            {
                Method2 method2 = new Method2();
                string asd = pointCombo.Text;
                string[] split = asd.Split(':');
                s.Start();
                List<Data> res = method2.calculateData(split[1], split[3], neibCombo.Text);
                s.Stop();

                timeLabel.Text = "Calculation time: " + s.ElapsedMilliseconds + " ms";
                if (res[0].klass == "no")
                {
                    MessageBox.Show("With this number of neighbour the is no valid result");
                }
                else if (res[0].klass == "+")
                {
                    DialogResult dr = MessageBox.Show("This points class is a + do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.addPoint(res[0].X.ToString(), res[0].Y.ToString(), res[0].klass);
                        database.deleteFromPointsTo(res[0].X.ToString(), res[0].Y.ToString());
                        updateInterface();
                    }
                }
                else if (res[0].klass == "-")
                {
                    DialogResult dr = MessageBox.Show("This points class is a - do you want to save it ?", "Result", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Database database = new Database();
                        database.addPoint(res[0].X.ToString(), res[0].Y.ToString(), res[0].klass);
                        database.deleteFromPointsTo(res[0].X.ToString(), res[0].Y.ToString());
                        updateInterface();
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxX.Text))
            {
                MessageBox.Show("Please fill in X value");
                return;
            }
            if (string.IsNullOrEmpty(textBoxY.Text))
            {
                MessageBox.Show("Please fill in Y value");
                return;
            }
            Database database = new Database();
            database.addToPoints(textBoxX.Text,textBoxY.Text);
            updateInterface();
        }
        public void updateInterface()
        {
            AllPoints.Items.Clear();
            PointsTo.Items.Clear();
            pointCombo.Items.Clear();
            neibCombo.Items.Clear();
            pointCombo.Text = null;
            neibCombo.Text = null;
            Database database = new Database();
            List<string> data = database.getDataPoints();
            for (int i = 0; i < data.Count; i = i + 2)
            {
                string point = "X: " + data[i] + ": " + "Y: " + data[i + 1];
                pointCombo.Items.Add(point);
            }
            List<string> count = database.getData();
            int c = count.Count / 3;
            for (int i = 1; i <= c; i++)
            {
                neibCombo.Items.Add(i);
            }
            for (int i = 0; i<count.Count;i=i+3)
            {
                if (i==0)
                {
                    AllPoints.Items.Add(count[i]);
                    AllPoints.Items[i].SubItems.Add(count[i+1]);
                    AllPoints.Items[i].SubItems.Add(count[i + 2]);
                }
                else
                {
                    AllPoints.Items.Add(count[i]);
                    AllPoints.Items[i/3].SubItems.Add(count[i + 1]);
                    AllPoints.Items[i/3].SubItems.Add(count[i + 2]);
                }
            }
            for (int i = 0; i<data.Count;i=i+2)
            {
                if (i == 0)
                {
                    PointsTo.Items.Add(data[i]);
                    PointsTo.Items[i].SubItems.Add(data[i + 1]);
                }
                else
                {
                    PointsTo.Items.Add(data[i]);
                    PointsTo.Items[i/2].SubItems.Add(data[i + 1]);
                }
            }
            List<ChartPoints> chartPoints = new List<ChartPoints>();
            for (int i=0; i<count.Count;i=i+3)
            {
                chartPoints.Add(new ChartPoints { X = Int32.Parse(count[i]), Y = Int32.Parse(count[i + 1])});
            }
            foreach(ChartPoints f in chartPoints)
            {
                chart1.Series["Series1"].Points.AddXY(f.X, f.Y);
            }
        }
    }
}
