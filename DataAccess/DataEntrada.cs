using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataEntrada : Connection
    {
        public int IdEntrada { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public int IdPagamento { get; set; }
        public DataEntrada()
        {

        }
        public DataEntrada(int idEntrada, DateTime data, decimal valor, string observacao, int idPagamento)
        {
            IdEntrada = idEntrada;
            Data = data;
            Valor = valor;
            Observacao = observacao;
            IdPagamento = idPagamento;
        }
        private SqlCommand command = new SqlCommand();
        SqlDataReader dr;
        public string CadastroEntrada(DataEntrada Entrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_entrada (data_entrada, valor, observacao, id_tipo_entrada, id_forma_pagamento) VALUES (@data_entrada, @valor, @observacao, @id_tipo_entrada, @id_forma_pagamento)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@data_entrada", Entrada.Data);
                    command.Parameters.AddWithValue("@valor", Entrada.Valor);
                    command.Parameters.AddWithValue("@observacao", Entrada.Observacao);
                    command.Parameters.AddWithValue("@id_tipo_entrada", Entrada.IdEntrada);
                    command.Parameters.AddWithValue("@id_forma_pagamento", Entrada.IdPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable ListEntradas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select * from View_Entradas";
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
    }
}
