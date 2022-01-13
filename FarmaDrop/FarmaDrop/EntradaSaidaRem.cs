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
    public partial class EntradaSaidaRem : Form
    {
        public EntradaSaidaRem()
        {
            InitializeComponent();
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

                string pesquisa = "select id, nome_remedio, quantidade, data_entrada_saida,EntradaSaida,Local from entradasaidaremedios where Local like @valor and nome_remedio like @valor2";
                MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox3.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisar.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid1.DataSource = table;
                con.Close();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
