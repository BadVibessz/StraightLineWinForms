using System;
using System.Windows.Forms;
using StraightLineLibrary;

namespace WinForms
{
    public partial class RelationForm : Form
    {
        public RelationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var line1 = new StraightLine(
                new Point((double)l1x1Numeric.Value, (double)l1y1Numeric.Value, (double)l1z1Numeric.Value),
                new Point((double)l1x2Numeric.Value, (double)l1y2Numeric.Value, (double)l1z2Numeric.Value));
            var line2 = new StraightLine(
                new Point((double)l2x1Numeric.Value, (double)l2y1Numeric.Value, (double)l2z1Numeric.Value),
                new Point((double)l2x2Numeric.Value, (double)l2y2Numeric.Value, (double)l2z2Numeric.Value));

            var str = StraightLine.RelationBetweenLines(line1, line2);

            MessageBox.Show(str);

        }
    }
}