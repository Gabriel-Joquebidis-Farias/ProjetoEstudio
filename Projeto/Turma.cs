using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    internal class Turma
        {
            private String professor, dia, hora, alunosMatriculados;
            private int modalidade;

            public string Professor { get => professor; set => professor = value; }
            public string Dia { get => dia; set => dia = value; }
            public string Hora { get => hora; set => hora = value; }
            public int Modalidade { get => modalidade; set => modalidade = value; }
            public string AlunosMatriculados { get => alunosMatriculados; set => alunosMatriculados = value; }

            public Turma(int modalidade, string professor, string dia, string hora, string alunosMatriculados)
            {
                this.professor = professor;
                this.dia = dia;
                this.hora = hora;
                this.modalidade = modalidade;
                this.alunosMatriculados = alunosMatriculados;
            }

            public Turma(int modalidade)
            {
                this.modalidade = modalidade;
            }

            public Turma(int modalidade, String dia, String hora)
            {
                this.modalidade = modalidade;
                this.dia = dia;
                this.hora = hora;
            }

            public Turma(string dia, int modalidade)
            {
                this.dia = dia;
                this.modalidade = modalidade;
            }

            public bool cadastrarTurma()
            {
                bool cad = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand cadastra = new MySqlCommand("INSERT INTO Estudio_Turma (idModalidade, professor, diasemanaTurma, hora, alunosMatriculados, ativo) VALUES ('" + modalidade + "','" + professor + "','" + dia + "','" + hora + "','" + alunosMatriculados + "','" + 0 + "')", DAO_Conexao.con);
                    cadastra.ExecuteNonQuery();
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

            public bool excluirTurma()
            {
                bool exc = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Turma SET ativa=1 WHERE idModalidade =" + modalidade + " AND diasemanaTurma ='" + dia + "' AND horaTurma ='" + hora + "'", DAO_Conexao.con);
                    exclui.ExecuteNonQuery();
                    exc = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
                return exc;
            }

            public MySqlDataReader consultaTodasTurma()
            {
                MySqlDataReader buscar = null;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand busca = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE ativa=0", DAO_Conexao.con);
                    buscar = busca.ExecuteReader();
                    return buscar;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
                finally
                {
                    /*DAO_Conexao.con.Close();*/
                }
            }

            public MySqlDataReader consultaTurma()
            {
                //pelo idModalidade
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE ativa=0 AND idModalidade = " + modalidade + "", DAO_Conexao.con);
                    MySqlDataReader resultado = buscar.ExecuteReader();
                    return resultado;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
                finally
                {
                    /*DAO_Conexao.con.Close();*/
                }
            }

            public MySqlDataReader consultaTurmaDia()
            {
                //pelo idModalidade
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand buscar = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE ativa=0 AND idModalidade = " + modalidade + " AND  diasemanaTurma = '" + dia + "'", DAO_Conexao.con);
                    MySqlDataReader resultado = buscar.ExecuteReader();
                    return resultado;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
                finally
                {
                    /*DAO_Conexao.con.Close();*/
                }
            }
        }
    }


