using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataPagamento : Connection
    {
        public int IdPagamento { get; set; }
        public string Descricao { get; set; }
        public DataPagamento()
        {

        }
        public DataPagamento(int idPagamento, string descricao)
        {
            IdPagamento = idPagamento;
            Descricao = descricao;
        }
        private SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        #region TipoPagamento
        public string CadastroPagamento(DataPagamento TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_forma_pagamento (descricao) VALUES (@descricao)";
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
        public string UpdatePagamento(DataPagamento TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_forma_pagamento SET descricao=@descricao WHERE descricao=@descricao";
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
        public bool ValidaPagamento(DataPagamento TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_forma_pagamento WHERE descricao=@descricao";
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
        public DataTable ListaDePagamento()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_forma_pagamento";
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
        public string DeletePagamento(DataPagamento TIPO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_forma_pagamento WHERE id=@id_pagamento";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_pagamento", TIPO.IdPagamento);
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
