using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        string FilterColumn = "";
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            if(FilterColumn=="PersonID") ctrlPersonInfo1.LoadPersonInfo(Convert.ToInt32(txtFilterValue.Text));
            else ctrlPersonInfo1.LoadPersonInfo(txtFilterValue.Text);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Person ID") FilterColumn = "PersonID";
            else if (cbFilterBy.Text == "National No") FilterColumn = "NationalNo";
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
