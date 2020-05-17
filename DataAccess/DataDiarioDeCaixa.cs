using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataDiarioDeCaixa : Connection
    {
        public DataDiarioDeCaixa()
        {

        }
        private SqlCommand command = new SqlCommand();
        public DataTable DiarioDeCaixaResultadoEntrada()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select te.descricao, te.dinheiro, SUM(valor) as Valor, CONVERT(varchar(10), e.data_entrada, 103) as Data, " +
                        "MONTH(e.data_entrada) as Mes from tb_entrada e INNER JOIN tb_tipo_entrada te ON e.id_tipo_entrada = te.id " +
                        "GROUP BY te.descricao, e.data_entrada, te.dinheiro ORDER BY e.data_entrada asc";
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
        public DataTable DiarioDeCaixaResultadoSaida()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select ts.descricao, ts.dinheiro, SUM(valor) as Valor, CONVERT(varchar(10), s.data_saida, 103) as Data," +
                        "MONTH(s.data_saida) as Mes from tb_saida s INNER JOIN tb_tipo_saida ts ON s.id_tipo_saida = ts.id " +
                        "GROUP BY ts.descricao, s.data_saida, ts.dinheiro " +
                        "ORDER BY s.data_saida asc";
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
        //saldo inicial
        public DataTable DiarioCaixa_SaldoInicial()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select valor, CONVERT(varchar(10), si.data_entrada, 103) as Data from tb_saldo_inicial si";
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
