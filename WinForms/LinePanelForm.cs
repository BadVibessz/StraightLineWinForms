using System;
using System.Windows.Forms;
using StraightLineLibrary;

namespace WinForms
{
    public partial class LinePanelForm : Form
    {
        public LinePanelForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var p1 = new StraightLineLibrary.Point((double)x1Numeric.Value, (double)y1Numeric.Value, (double)z1Numeric.Value);
            var p2 = new StraightLineLibrary.Point((double)x2Numeric.Value, (double)y2Numeric.Value, (double)z2Numeric.Value);

            var line = new StraightLineLibrary.StraightLine(p1, p2);
            var plane = new Plane((double)aNumeric.Value, (double)bNumeric.Value, (double)cNumeric.Value, (double)dNumeric.Value);

            var point = StraightLine.Intersect(line, plane);

            MessageBox.Show("{" + point.X + ";" + point.Y + ";" + point.Z + "}");
        }
    }
}