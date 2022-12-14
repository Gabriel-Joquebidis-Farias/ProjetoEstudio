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
        public Modalidade(String descricao)
        {
            this.Descricao = descricao;
        }
        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas) { 
            Descricao1 = descricao;
            Preco1 = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public bool CadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Modalidade (descricao, preco, Alunos, Aula)"+" values ('" + Descricao + "','" + Preco + "','" + qtde_alunos + "','" + qtde_aulas + "')" ,DAO_Conexao.con);
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
                MySqlCommand insere = new MySqlCommand("update Modalidade set Ativo=1 where descricao='" + Descricao + "'", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                exc = true;
                }
                catch (MySqlException ex)
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
            MySqlDataReader buscar = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("SELECT * FROM Modalidade WHERE ativo = 0 ORDER BY descricao", DAO_Conexao.con);
                buscar = insere.ExecuteReader();
                return buscar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return buscar;
        }
        public bool atualizar()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update into Modalidade (descricao, preco, qtdAlunos, qtdAulas) values (" + Descricao + "','" + Preco + "','" + qtde_alunos + "','" + qtde_aulas + ")" + DAO_Conexao.con);
                
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
        public MySqlDataReader consultarModalidade()
        {
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand busca = new MySqlCommand("SELECT * FROM Modalidade WHERE ativo = 0 and descricao like '" + Descricao + "'", DAO_Conexao.con);
                MySqlDataReader buscar = busca.ExecuteReader();
                return buscar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
               // DAO_Conexao.con.Close();
            }
        }
    }
 }
