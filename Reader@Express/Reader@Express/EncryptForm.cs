using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Reader_Express
{
    public partial class EncryptForm : DevExpress.XtraEditors.XtraForm
    {
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CipherAlgorithm ca = new CipherAlgorithm();
            tbCipherText.Text = ca.Encrypt(tbPlainText.Text, "sblw-3hn8-sqoy19");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CipherAlgorithm ca = new CipherAlgorithm();
            tbPT.Text = ca.Decrypt(tbCT.Text, "sblw-3hn8-sqoy19");
        }
    }
}