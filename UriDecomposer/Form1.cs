using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imanami.TroubleshootingUtility.Common;

namespace UriDecomposer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDecompse_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtQueryBox.Text))
                {
                    throw new Exception("No query entered in query box.");
                }

                var query = TxtQueryBox.Text;
                var parameters = Utility.DecomposeQueryParameters(query, true);
                TxtResult.Clear();
                var sb = new StringBuilder();
                parameters.Select(kv => $"{kv.Key}: {kv.Value}").ToList().ForEach(p => sb.AppendLine(p).AppendLine());
                TxtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnDecompse.PerformClick();
        }

        private void TxtQueryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnDecompse.PerformClick();
            }
        }

        private void TxtQueryBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
