using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    internal class Modalidade
    {
        private String Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modalidade()
        {

        }
        public Modalidade (String descricao)
        {
            this.Descricao = descricao;
        }
        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public bool CadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert to Modalidade (descricao, preco, alunos, aulas) values ("+ Descricao+"','"+Preco+"','"+qtde_alunos+"','"+qtde_aulas+")"+DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
        public bool excluir()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("delete * into Modalidade where descricao like" + Descricao+";" + DAO_Conexao.con);
                insere.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
        public MySqlDataReader consultarTodasModalidades()
        {
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("select * from Modalidade");
                MySqlDataReader buscar = insere.ExecuteReader();
                return buscar;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }
        public bool atualizar()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update into Estudio_Modalidade (descricao, preco, qtdAlunos, qtdAulas) values (" +Descricao + "','" + Preco + "','" + qtde_alunos + "','" + qtde_aulas + ")" + DAO_Conexao.con);
                //deve ter erro nessa linha de SQL
                atualiza.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
    }
}
