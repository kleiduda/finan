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
        public decimal SaldoFinal { get; set; }

        public DataEntrada()
        {

        }
        public DataEntrada(int idEntrada, DateTime data, decimal valor, string observacao, int idPagamento, decimal saldoFinal)
        {
            IdEntrada = idEntrada;
            Data = data;
            Valor = valor;
            Observacao = observacao;
            IdPagamento = idPagamento;
            saldoFinal = saldoFinal;
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
                    command.CommandText = "CadastroEntrada";
                    command.CommandType = CommandType.StoredProcedure;
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
        public string CadastroPc(DataEntrada Entrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "CadastroPc";
                    command.CommandType = CommandType.StoredProcedure;
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
        public string UpdateSaldo(DataEntrada SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_saldo_inicial SET saldo_final=@saldo_final WHERE data_entrada=@data";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@saldo_final", SALDO.SaldoFinal);
                    command.Parameters.AddWithValue("@data", SALDO.Data);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Error";
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
        public string Entrada_Delete(DataEntrada ENTRADA)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "delete from tb_entrada Where id=@id_entrada";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_entrada", ENTRADA.IdEntrada);
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
