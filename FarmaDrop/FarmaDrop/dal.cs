using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDrop
{
    class dal
    {
      

       public void Adicionar1(Construtor2 mo)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string adicionar = " insert into Funcionarios(id,P_nome,idade,Email,Senha,Tipo)" +
                "values ('" + mo.id + "','" + mo.P_nome + "','"  + mo.Idade + "','" + mo.Email + "','"+ mo.Senha + "','" +mo.tipo + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("erro de comandos " + ex.Message);


            }

        }

        

        public void AdicionarFunc(Construtor12 mo)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string adicionar = " insert into EntradaSaidafuncionarios(Funcionario,Data_de_Entrada_saida,EntradaSaida,Horario)" +
                "values ('" + mo.email + "','" + mo.data_entrada + "','" + mo.entradaSaida + "','" + mo.horario + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("erro de comandos " + ex.Message);


            }
        }

       

        

        public void AdicionarSite(ConstrutorSite mo1)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string adicionar = " insert into tabelasite(nome_remedio,obs,quantidade,data_entrada,Local)" +
                "values ('" + mo1.nome_remedio + "','" + mo1.obs + "','" + mo1.quantidade + "','" + mo1.data_entrada + "','" + mo1.local + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("erro de comandos " + ex.Message);


            }
        }

        public void AdicionarEntradaSaida(ConstrutorEntradaSaida mo2)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string adicionar = " insert into entradasaidaremedios(nome_remedio,quantidade,data_entrada_saida,EntradaSaida,Local)" +
                "values ('" + mo2.nome_remedio + "','"  + mo2.quantidade + "','" + mo2.data_entrada + "','" +mo2.entradaSaida + "','" + mo2.local + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("erro de comandos " + ex.Message);


            }
        }

        

       

        public void Deletar(ConstrutorExcluir mo)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string delete = "delete from tabelasite where id='" + mo.id + "';";
                MySqlCommand command = new MySqlCommand(delete, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comando " + ex.Message);
            }
        }

        public void Alterar(ConstrutorEditar mo1)
        {

            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string alterar = "update tabelasite set  nome_remedio = '" + mo1.nome_remedio + "',quantidade='" + mo1.quantidade + "',obs='" + mo1.obs + "'where id='" + mo1.id + "';";
                MySqlCommand command = new MySqlCommand(alterar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comando " + ex.Message);
            }
        }

        public void Alterar1(ConstrutorRetirada mo)
        {
            String caminhobd = "Server = 127.0.0.1;DATABASE=farmdrop;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhobd);
                conexao.Open();

                string alterar = "update tabelasite set  quantidade='" + mo.quantidade + "'where id='" + mo.id + "';";
                MySqlCommand command = new MySqlCommand(alterar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comando " + ex.Message);
            }
        }
    }
    }
