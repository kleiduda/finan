using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class DataCentroCusto : Connection
    {
        public int IdCentroCusto { get; set; }
        public string Descricao { get; set; }
        public DataCentroCusto()
        {

        }
        public DataCentroCusto(int idCentroCusto, string descricao)
        {
            IdCentroCusto = idCentroCusto;
            Descricao = descricao;
        }
        private SqlCommand command = new SqlCommand();
        public string CadastroCentroCusto(DataCentroCusto Entrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_centro_custo (descricao) VALUES (@descricao)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", Entrada.Descricao);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable ListCentroCusto()
        {
            using (var connection =  GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_centro_custo";
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
        public string DeleteCentroCusto(DataCentroCusto Entrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_centro_custo WHERE id=@id_centro_custo";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_centro_custo", Entrada.IdCentroCusto);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao tentar excluir";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public bool Valida(DataCentroCusto valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_centro_custo WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", valor.Descricao );
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
    }
}
