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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bunifuMetroTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }

        private void bunifuMetroTextbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }



        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            String caminhobanco = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(caminhobanco);
            MySqlCommand cmd = new MySqlCommand("SELECT Tipo FROM funcionarios WHERE Email=?email and Senha=?senha", con);
            cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = bunifuMetroTextbox2.Text;
            cmd.Parameters.Add("?senha", MySqlDbType.VarChar).Value = bunifuMetroTextbox3.Text;
            con.Open();
            MySqlDataReader le = null;
            le = cmd.ExecuteReader();
            if (le.Read())
            {

                String tipo = le.GetString(0);
                if (tipo == "Administrador")
                {

                    Construtor12 mo = new Construtor12();
                    dal da = new dal();
                    mo.email = bunifuMetroTextbox2.Text;
                    mo.entradaSaida = bunifuMetroTextbox1.Text;
                    mo.data_entrada = dateTimePicker1.Text;
                    mo.horario = dateTimePicker2.Text;


                    da.AdicionarFunc(mo);

                    this.Hide();



                    Principal OutroForm = new Principal();
                    OutroForm.ShowDialog();
                }
                else
                {
                    if (tipo == "Atendente")
                    {

                        Construtor12 mo = new Construtor12();
                        dal da = new dal();
                        mo.email = bunifuMetroTextbox2.Text;
                        mo.entradaSaida = bunifuMetroTextbox1.Text;
                        mo.data_entrada = dateTimePicker1.Text;
                        mo.horario = dateTimePicker2.Text;


                        da.AdicionarFunc(mo);

                        this.Hide();
                        Atendente OutroForm = new Atendente();
                        OutroForm.ShowDialog();
                    }
                }

            }


            else
            {
                Mensagem OutroForm = new Mensagem();
                OutroForm.ShowDialog();

            }

        }
    }


}
        
    

