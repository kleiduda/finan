using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataCategoria : Connection
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public int IdCentroCusto { get; set; }
        public int IdSubCategoria { get; set; }
        public string NomeSubCategoria { get; set; }
        public DataCategoria()
        {

        }
        public DataCategoria(int idCategoria, string nomeCategoria, int idCentroCusto, int idSubCategoria, string nomeSubCategoria)
        {
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
            IdCentroCusto = idCentroCusto;
            IdSubCategoria = idSubCategoria;
            NomeSubCategoria = nomeSubCategoria;
        }
        private SqlCommand command = new SqlCommand();
        public string CadastroCategoria(DataCategoria valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "CadastroCategoria";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nome_categoria", valor.NomeCategoria);
                    command.Parameters.AddWithValue("@id_centro_custo", valor.IdCentroCusto);
                    command.Parameters.AddWithValue("@nome_sub_categoria", valor.NomeSubCategoria);
                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao cadastrar";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable ListCategorias()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM View_Categoria";
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
        public DataTable ListSubCategorias()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_sub_categoria";
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
        public string DeleteCategoria(DataCategoria valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM categoria WHERE id=@id_categoria";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_categoria", valor.IdCategoria);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao tentar excluir";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public bool Valida(DataCategoria valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_categoria WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", valor.NomeCategoria);
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
        public bool ValidaSub(DataCategoria valor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_sub_categoria WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", valor.NomeSubCategoria);
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
