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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void customImageButton4_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel12.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel3.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
            panel12.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel3.Visible = false;
            panel6.Visible = false;
            panel10.Visible = false;
            panel12.Visible = false;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel6.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
            panel12.Visible = false;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparE_Click(object sender, EventArgs e)
        {
            txtNomeE.Text = "";
            txtObservaçaoE.Text = "";
            txtQuantidadeE.Text = "";
            txtPesquisar.Text = "";
            txtPesquisarE.Text = "";
            

        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            CadastarFunc OutroForm = new CadastarFunc();
            OutroForm.ShowDialog();
        }

        private void btnEnSa_Click(object sender, EventArgs e)
        {
            EntradaSaidaFunc OutroForm = new EntradaSaidaFunc();
            OutroForm.ShowDialog();
        }

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            FuncCadastrados OutroForm = new FuncCadastrados();
            OutroForm.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel6.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
            panel12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntradaSaidaRem OutroForm = new EntradaSaidaRem();
            OutroForm.ShowDialog();
        }

        private void txtCadastrar_Click(object sender, EventArgs e)
        {
            String op = (String)comboBox3.SelectedItem;
            switch (op)
            {
                case "CILLOS":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);



                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "MATHIENSEN":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);



                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "JARDIM IPIRANGA":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "CARIOBINHA":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "PARQUE GRAMADO":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "SÃO LUIZ":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);


                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");


                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();

                    }
                    break;
                case "SÃO DOMINGOS":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");


                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();

                    }
                    break;
                case "SÃO JOSÉ":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
                case "PARQUE DAS NAÇÕES":

                    if (txtNomeC.Text == "" || txtQuantidadeC.Text == "")
                    {

                        MensagemBranco OutroForm = new MensagemBranco();
                        OutroForm.ShowDialog();

                    }
                    else
                    {


                        ConstrutorSite mo1 = new ConstrutorSite();
                        dal da1 = new dal();
                        mo1.quantidade = (txtQuantidadeC.Text);
                        mo1.nome_remedio = txtNomeC.Text;
                        mo1.obs = txtObservaçaoC.Text;
                        mo1.data_entrada = dateTimePicker1.Text;
                        mo1.local = comboBox3.Text;
                        da1.AdicionarSite(mo1);

                        ConstrutorEntradaSaida mo2 = new ConstrutorEntradaSaida();
                        dal da2 = new dal();
                        mo2.quantidade = (txtQuantidadeC.Text);
                        mo2.nome_remedio = txtNomeC.Text;
                        mo2.obs = txtObservaçaoC.Text;
                        mo2.data_entrada = dateTimePicker1.Text;
                        mo2.local = comboBox3.Text;
                        mo2.entradaSaida = bunifuMetroTextbox5.Text;
                        da2.AdicionarEntradaSaida(mo2);

                        txtQuantidadeC.Text = ("");
                        txtNomeC.Text = ("");
                        txtObservaçaoC.Text = ("");

                        MensagenSucesso OutroForm = new MensagenSucesso();
                        OutroForm.ShowDialog();


                    }
                    break;
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

        private void btnPesquisarE_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
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
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox2.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisarE.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid3.DataSource = table;
                con.Close();

            }
        }

        private void bunifuCustomDataGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            String codigo;
            codigo = Convert.ToString(bunifuCustomDataGrid3.CurrentRow.Cells[0].Value);

            String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobanco);
            con.Open();

            MySqlCommand cmd2 = new MySqlCommand("select id,nome_remedio,quantidade,obs from tabelasite where id= '" + codigo + "'", con);
            MySqlDataReader reader = null;
            reader = cmd2.ExecuteReader();

            if (reader.Read())
            {
                txtQuantidadeE.Text = reader.GetString(2);
                txtNomeE.Text = reader.GetString(1);
                txtObservaçaoE.Text = reader.GetString(3);
                txtid.Text = reader.GetString(0);
            }


        }

        private void btnEditarE_Click(object sender, EventArgs e)
        {
            ConstrutorEditar mo1 = new ConstrutorEditar();
            dal da1 = new dal();
            mo1.id = Convert.ToInt16(txtid.Text);
            mo1.quantidade = (txtQuantidadeE.Text);
            mo1.nome_remedio = txtNomeE.Text;
            mo1.obs = txtObservaçaoE.Text;
            da1.Alterar(mo1);

            if (comboBox2.Text == "" || txtNomeE.Text == ""|| txtQuantidadeE.Text=="")
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
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox2.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisarE.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid3.DataSource = table;
                con.Close();

                txtNomeE.Text = ("");
                txtObservaçaoE.Text = ("");
                txtQuantidadeE.Text = ("");

                MensagemEditadoSucesso OutroForm = new MensagemEditadoSucesso();
                OutroForm.ShowDialog();


            }



        }

        private void btnExcluirE_Click(object sender, EventArgs e)
        {
            ConstrutorExcluir mo = new ConstrutorExcluir();
            dal da = new dal();
            mo.id = Convert.ToInt16(txtid.Text);
            da.Deletar(mo);

            if (comboBox2.Text == "")
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
                ad.SelectCommand.Parameters.AddWithValue("valor", comboBox2.Text + "%");
                ad.SelectCommand.Parameters.AddWithValue("valor2", txtPesquisarE.Text + "%");
                DataTable table = new DataTable();
                ad.Fill(table);
                bunifuCustomDataGrid3.DataSource = table;
                con.Close();

            }
        }

        private void txtQuantidadeE_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNomeR.Text = ("");
            txtCodigoR.Text = ("");
            txtQuantidadeR.Text = ("");
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
        
        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}