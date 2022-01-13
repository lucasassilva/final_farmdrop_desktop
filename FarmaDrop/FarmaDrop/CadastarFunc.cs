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
    public partial class CadastarFunc : Form
    {
        public CadastarFunc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCadastarFunc_Click(object sender, EventArgs e)
        {
           

                    if (txtPriNome.Text == "" ||  txtIdade.Text == "" ||  txtEmail.Text == "" || txtSenhaCadast.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {
                        Construtor2 mo = new Construtor2();
                        dal da = new dal();
                        mo.P_nome = (txtPriNome.Text);
                        mo.Idade = Convert.ToInt16(txtIdade.Text);
                        mo.Senha = txtSenhaCadast.Text;
                        mo.Email = txtEmail.Text;
                        mo.tipo = comboBox3.Text;




                        da.Adicionar1(mo);


                        txtPriNome.Text = ("");
                        txtIdade.Text = ("");
                        txtSenhaCadast.Text = ("");
                        txtEmail.Text = ("");
                        txtConfirmarSenhaCadast.Text = ("");

                         MensagenSucesso OutroForm = new MensagenSucesso();
                         OutroForm.ShowDialog();



            }
                    

               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPriNome.Text = ("");
            txtIdade.Text = ("");
            txtSenhaCadast.Text = ("");
            txtEmail.Text = ("");
            txtConfirmarSenhaCadast.Text = ("");
        }
    }
}