using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using DeMaria.src.controllers;

namespace DeMaria.src.database
{
    class Database
    {
        private static SQLiteConnection sqliteConnection;

        public Database() {
            CriarTabelaSQLite();
        }

        private static SQLiteConnection DBConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=C:\\sqlite\\db\\demaria.db; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS 'registros'( " +
                        " 'ID'    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                        " 'LIVRO' TEXT NOT NULL," +
                        " 'NUM_LIVRO' INTEGER NOT NULL," +
                        " 'NUM_PAGINA'    INTEGER NOT NULL," +
                        " 'NUM_REGISTRO'  INTEGER NOT NULL," +
                        " 'DATA_REGISTRO' TEXT NOT NULL," +
                        " 'NOME_REGISTRADO'   TEXT NOT NULL," +
                        " 'SEXO'  TEXT NOT NULL," +
                        " 'DATA_NASCIMENTO'   TEXT NOT NULL," +
                        " 'HORA_NASCIMENTO'   TEXT NOT NULL," +
                        " 'NOME_PAI'  TEXT NOT NULL," +
                        " 'NASCIMENTO_PAI'    TEXT NOT NULL," +
                        " 'IDADE_PAI'     TEXT NOT NULL," +
                        " 'CIDADE_PAI'    TEXT NOT NULL," +
                        " 'UF_PAI'    TEXT NOT NULL," +
                        " 'NOME_MAE'  TEXT NOT NULL," +
                        " 'NASCIMENTO_MAE'    TEXT NOT NULL," +
                        " 'IDADE_MAE'     TEXT NOT NULL," +
                        " 'CIDADE_MAE'    TEXT NOT NULL," +
                        " 'UF_MAE'    TEXT NOT NULL," +
                        " 'DNV_DO'    TEXT NOT NULL," +
                        " 'NO_PRAZO'  TEXT NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRegistros()
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT DATA_REGISTRO 'Data Reg.', NOME_REGISTRADO Nascido, SEXO Sexo, DATA_NASCIMENTO 'Data Nasc.'," +
                        "HORA_NASCIMENTO 'Hora Nasc.', NOME_PAI Pai, IDADE_PAI 'Idade Pai', NOME_MAE Mãe, IDADE_MAE 'Idade Mãe', DNV_DO 'DNV / DO', NO_PRAZO 'No Prazo?' FROM Registros";
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Adicionar(Registro registro)
        {
            try
            {
                using (var cmd = DBConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO registros(LIVRO,NUM_LIVRO,NUM_PAGINA,NUM_REGISTRO,DATA_REGISTRO," +
                        "NOME_REGISTRADO,SEXO,DATA_NASCIMENTO,HORA_NASCIMENTO,NOME_PAI,IDADE_PAI,NASCIMENTO_PAI,CIDADE_PAI,UF_PAI," +
                        "NOME_MAE,NASCIMENTO_MAE,IDADE_MAE,CIDADE_MAE,UF_MAE,DNV_DO,NO_PRAZO) VALUES (@livro,@numlivro,@numpagina," +
                        "@numregistro,@dataregistro,@nomeregistrado,@sexo,@datanascimento,@horanascimento,@nomepai,@nascimentopai," +
                        "@idadepai,@cidadepai,@ufpai,@nomemae,@nascimentomae,@idademae,@cidademae,@ufmae,@dnvdo,@noprazo)";

                    cmd.Parameters.AddWithValue("@livro", registro.Livro);
                    cmd.Parameters.AddWithValue("@numlivro", registro.NumLivro);
                    cmd.Parameters.AddWithValue("@numpagina", registro.NumPagina);
                    cmd.Parameters.AddWithValue("@numregistro", registro.NumRegistro);
                    cmd.Parameters.AddWithValue("@dataregistro", registro.DataRegistro);
                    cmd.Parameters.AddWithValue("@nomeregistrado", registro.NomeRegistrado);
                    cmd.Parameters.AddWithValue("@sexo", registro.SexoRegistrado);
                    cmd.Parameters.AddWithValue("@datanascimento", registro.DataNascimento);
                    cmd.Parameters.AddWithValue("@horanascimento", registro.HoraNascimento);
                    cmd.Parameters.AddWithValue("@nomepai", registro.NomePai);
                    cmd.Parameters.AddWithValue("@nascimentopai", registro.NascPai);
                    cmd.Parameters.AddWithValue("@idadepai", registro.IdadePai);
                    cmd.Parameters.AddWithValue("@cidadepai", registro.CidadePai);
                    cmd.Parameters.AddWithValue("@ufpai", registro.UFPai);
                    cmd.Parameters.AddWithValue("@nomemae", registro.NomeMae);
                    cmd.Parameters.AddWithValue("@nascimentomae", registro.NascMae);
                    cmd.Parameters.AddWithValue("@idademae", registro.IdadeMae);
                    cmd.Parameters.AddWithValue("@cidademae", registro.CidadeMae);
                    cmd.Parameters.AddWithValue("@ufmae", registro.UFMae);
                    cmd.Parameters.AddWithValue("@dnvdo", registro.DNVDO);
                    cmd.Parameters.AddWithValue("@noprazo", registro.Prazo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
