using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DataAccess
{
   public class DataTipoEntrada : Connection
    {
        public int IdTipoEntrada { get; set; }
        public string Descricao { get; set; }
        public DataTipoEntrada()
        {

        }
        public DataTipoEntrada(int idTipoEntrada, string descricao)
        {
            IdTipoEntrada = idTipoEntrada;
            Descricao = descricao;
        }
        private SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        #region TipoEntrada
        public string CadastroTipoEntrada(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_tipo_entrada (descricao) VALUES (@descricao)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public string UpdateTipoEntrada(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_tipo_entrada SET descricao=@descricao WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        //verificando se ja tem algum cadastro com mesmo nome
        public bool ValidaTipo(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_entrada WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    var result = command.ExecuteScalar();
                    if (result !=null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //listar cadastros
        public DataTable ListaDeTipoEntrada()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_entrada";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        public string DeleteTipoEntrada(DataTipoEntrada TIPO)
        {
            using (var connection=GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_tipo_entrada WHERE id=@id_tipo_entrada";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_tipo_entrada", TIPO.IdTipoEntrada);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        #endregion tipo entrada
        #region TipoSaida
        public string CadastroTipoSaida(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_tipo_saida (descricao) VALUES (@descricao)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public string UpdateTipoSaida(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_tipo_saida SET descricao=@descricao WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message + ex.StackTrace;
                }
                return rpta;
            }
        }
        //verificando se ja tem algum cadastro com mesmo nome
        public bool ValidaTipoSaida(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_saida WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TIPO.Descricao);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {

                }
                return false;
            }
        }
        //listar cadastros
        public DataTable ListaDeTipoSaida()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_saida";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                    SqlDat.Fill(dt);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
                return dt;
            }
        }
        public string DeleteTipoSaida(DataTipoEntrada TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_tipo_saida WHERE id=@id_tipo_saida";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_tipo_saida", TIPO.IdTipoEntrada);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        #endregion tipo entrada
    }
}
