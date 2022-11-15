using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formAddTwoNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTwoNumber_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            {
                int iA = Int32.Parse(txtA.Text);
                int iB = Int32.Parse(txtB.Text);
                Wrapper.WrapperForCaculatorTwoNumber wrapperAddTwoNumber = new Wrapper.WrapperForCaculatorTwoNumber();
                txtResult.Text = wrapperAddTwoNumber.GetSumInCaculatorClass(iA, iB).ToString();
            }
        }
    }
}
