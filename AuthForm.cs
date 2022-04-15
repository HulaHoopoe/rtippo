using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractsList
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form f2 = new RecordCardForm
            {
                Owner = this
            };
            f2.Show();
            this.Hide();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
