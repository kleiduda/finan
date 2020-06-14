using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataSaida : Connection
    {
        public int IdSaida { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public int IdPagamento { get; set; }
        public DataSaida()
        {

        }
        public DataSaida(int idSaida, DateTime data, decimal valor, string observacao, int idPagamento)
        {
            IdSaida = IdSaida;
            Data = data;
            Valor = valor;
            Observacao = observacao;
            IdPagamento = idPagamento;
        }
        private SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        public string Saida_Cadastro(DataSaida Saida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_saida (data_saida, valor, observacao, id_tipo_saida, id_forma_pagamento) VALUES (@data_entrada, @valor, @observacao, @id_tipo_entrada, @id_forma_pagamento)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@data_entrada", Saida.Data);
                    command.Parameters.AddWithValue("@valor", Saida.Valor);
                    command.Parameters.AddWithValue("@observacao", Saida.Observacao);
                    command.Parameters.AddWithValue("@id_tipo_entrada", Saida.IdSaida);
                    command.Parameters.AddWithValue("@id_forma_pagamento", Saida.IdPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable Saida_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM View_Saidas";
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
        //delete
        public string Saida_Delete(DataSaida SAIDA)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "delete from tb_saida Where id=@id_saida";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_saida", SAIDA.IdSaida);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
    }
}
