using DVLD_Buisness;
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
    public partial class frmSendMail : Form
    {
       public int Id;
        public frmSendMail(int id)
        {
            InitializeComponent();
            Id=id;
        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {
          clsPerson Person  = clsPerson.Find(Id);
            txt_To.Text = Person.Email;
            txt_To.Enabled=false;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Subject.Text.Length == 0 || txt_Body.Text.Length == 0)
            {
                MessageBox.Show("any feild not must be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                EmailService.Send(
               txt_To.Text,
               txt_Subject.Text,
               txt_Body.Text
           );

                MessageBox.Show("send successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
