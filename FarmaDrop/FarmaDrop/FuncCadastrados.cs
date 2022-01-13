using MySql.Data.MySqlClient;
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
    public partial class FuncCadastrados : Form
    {
        public FuncCadastrados()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {

                MensagemBranco OutroForm = new MensagemBranco();
                OutroForm.ShowDialog();

            }
            else
            {

                String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobanco);
                con.Open();

                string pesquisa = "select id, P_nome, idade,tipo from funcionarios where Tipo like @valor and P_nome like @valor2";
                MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox3.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisar.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid2.DataSource = table;
                con.Close();

            }
        }
    }
}
