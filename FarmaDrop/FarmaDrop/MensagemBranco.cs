using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaDrop
{
    public partial class MensagemBranco : Form
    {
        public MensagemBranco()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
