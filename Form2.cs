using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ContractsList
{
    public partial class recordCard : Form
    {
        public recordCard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void contractNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void downloadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            contractFilename.Text = filename;
            MessageBox.Show("Файл сохранен");
        }

        private void contractFilename_Click(object sender, EventArgs e)
        {
            if (contractFilename.Text != "")
                Process.Start(contractFilename.Text);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            contractNumber.Enabled = true;
            contractPlace.Enabled = true;
            contractExecutor.Enabled = true;
            contractDateCreate.Enabled = true;
            contractDuration.Enabled = true;
            contractOmsu.Enabled = true;
            contractMo.Enabled = true;
            contractPrice.Enabled = true;
            contractExecutorPrice.Enabled = true;
            contractSubvenceYear.Enabled = true;
            contractSubvencePricePart.Enabled = true;
            contractSubvenceExecutorPart.Enabled = true;
            changeButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            contractNumber.Enabled = false;
            contractPlace.Enabled = false;
            contractExecutor.Enabled = false;
            contractDateCreate.Enabled = false;
            contractDuration.Enabled = false;
            contractOmsu.Enabled = false;
            contractMo.Enabled = false;
            contractPrice.Enabled = false;
            contractExecutorPrice.Enabled = false;
            contractSubvenceYear.Enabled = false;
            contractSubvencePricePart.Enabled = false;
            contractSubvenceExecutorPart.Enabled = false;
            changeButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
        }
    }
}
