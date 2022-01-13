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
    public partial class Atendente : Form
    {
        public Atendente()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
            dal da2 = new dal();
            mo2.quantidade = (txtQuantidadeR.Text);
            mo2.nome_remedio = txtNomeR.Text;
            mo2.data_entrada = dateTimePicker2.Text;
            mo2.local = comboBox4.Text;
            mo2.entradaSaida = bunifuMetroTextbox3.Text;
            da2.AdicionarEntradaSaida(mo2);

            if (Convert.ToInt16(bunifuMetroTextbox1.Text) > Convert.ToInt16(txtQuantidadeR.Text))
            {
                ConstrutorRetirada mo = new ConstrutorRetirada();
                dal da = new dal();
                mo.id = Convert.ToInt16(txtCodigoR.Text);
                mo.quantidade = Convert.ToInt16(bunifuMetroTextbox1.Text) - Convert.ToInt16(txtQuantidadeR.Text);
                da.Alterar1(mo);

                if (comboBox4.Text == "" || txtQuantidadeR.Text == "")
                {

                    MensagemBranco OutroForm = new MensagemBranco();
                    OutroForm.ShowDialog();

                }
                else
                {

                    String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
                    MySqlConnection con = new MySqlConnection(caminhobanco);
                    con.Open();

                    string pesquisa = "select id, nome_remedio, quantidade, obs, data_entrada,Local from tabelasite where Local like @valor and nome_remedio like @valor2";
                    MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                    ad.SelectCommand.Parameters.AddWithValue("valor", comboBox4.Text + "%");
                    ad.SelectCommand.Parameters.AddWithValue("valor2", bunifuMetroTextbox2.Text + "%");
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    bunifuCustomDataGrid2.DataSource = table;
                    con.Close();







                    txtNomeR.Text = ("");
                    txtCodigoR.Text = ("");
                    txtQuantidadeR.Text = ("");
                    bunifuMetroTextbox1.Text = ("");

                    RetiradoComSucesso OutroForm = new RetiradoComSucesso();
                    OutroForm.ShowDialog();
                }
            }
            else
            {
                if (Convert.ToInt16(bunifuMetroTextbox1.Text) < Convert.ToInt16(txtQuantidadeR.Text))
                {
                    MensagemLimite OutroForm = new MensagemLimite();
                    OutroForm.ShowDialog();
                }
                else
                {

                    if (Convert.ToInt16(bunifuMetroTextbox1.Text) == Convert.ToInt16(txtQuantidadeR.Text))
                    {
                        ConstrutorExcluir mo = new ConstrutorExcluir();
                        dal da = new dal();
                        mo.id = Convert.ToInt16(txtCodigoR.Text);
                        da.Deletar(mo);

                        if (comboBox4.Text == "")
                        {

                            MensagemBranco OutroForm = new MensagemBranco();
                            OutroForm.ShowDialog();

                        }
                        else
                        {

                            String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
                            MySqlConnection con = new MySqlConnection(caminhobanco);
                            con.Open();

                            string pesquisa = "select id, nome_remedio, quantidade, obs, data_entrada,Local from tabelasite where Local like @valor and nome_remedio like @valor2";
                            MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                            ad.SelectCommand.Parameters.AddWithValue("valor", comboBox4.Text + "%");
                            ad.SelectCommand.Parameters.AddWithValue("valor2", bunifuMetroTextbox2.Text + "%");
                            DataTable table = new DataTable();
                            ad.Fill(table);
                            bunifuCustomDataGrid2.DataSource = table;
                            con.Close();

                            txtNomeR.Text = ("");
                            txtCodigoR.Text = ("");
                            txtQuantidadeR.Text = ("");
                            bunifuMetroTextbox1.Text = ("");

                            RetiradoComSucesso OutroForm = new RetiradoComSucesso();
                            OutroForm.ShowDialog();

                        }

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNomeR.Text = ("");
            txtCodigoR.Text = ("");
            txtQuantidadeR.Text = ("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {

                MensagemBranco OutroForm = new MensagemBranco();
                OutroForm.ShowDialog();

            }
            else
            {

                String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobanco);
                con.Open();

                string pesquisa = "select id, nome_remedio, quantidade, obs, data_entrada,Local from tabelasite where Local like @valor and nome_remedio like @valor2";
                MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox4.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", bunifuMetroTextbox2.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid2.DataSource = table;
                con.Close();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

                MensagemBranco OutroForm = new MensagemBranco();
                OutroForm.ShowDialog();

            }
            else
            {

                String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
                MySqlConnection con = new MySqlConnection(caminhobanco);
                con.Open();

                string pesquisa = "select id, nome_remedio, quantidade, obs, data_entrada,Local from tabelasite where Local like @valor and nome_remedio like @valor2";
                MySqlDataAdapter ad = new MySqlDataAdapter(pesquisa, con);
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox1.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisar.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid1.DataSource = table;
                con.Close();

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel12.Visible = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            panel6.Visible = false;
           
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
         
            panel12.Visible = false;
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo;
            codigo = Convert.ToString(bunifuCustomDataGrid2.CurrentRow.Cells[0].Value);

            String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobanco);
            con.Open();

            MySqlCommand cmd2 = new MySqlCommand("select id,nome_remedio,quantidade from tabelasite where id= '" + codigo + "'", con);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                bunifuMetroTextbox1.Text = reader.GetString(2);
                txtNomeR.Text = reader.GetString(1);
                txtCodigoR.Text = reader.GetString(0);
            }
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}