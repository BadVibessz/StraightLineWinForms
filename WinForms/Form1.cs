using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinePlaneBtn_Click(object sender, EventArgs e)
        {
            var form = new LinePanelForm();
            form.Show();
        }

        private void RelationBtn_Click(object sender, EventArgs e)
        {
            var form = new RelationForm();
            form.Show();
        }
    }
}