using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Diagnostics;
using Support;

namespace DataAccess
{
    public class DataCadastros: Connection
    {
        //empresa
        public int IdEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        //centro de custo
        public int IdCentroCusto { get; set; }
        public string DescricaoCentroCusto { get; set; }
        //categorias
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public string NomeSubCategoria { get; set; }
        //pagamento
        public int IdPagamento { get; set; }
        public string DescricaoPagamento { get; set; }
        //tipo entrada
        public int IdTipoEntrada { get; set; }
        public string DescricaoEntrada { get; set; }
        public int EspecieEntrada { get; set; }
        //tipo saida
        public int IdTipoSaida { get; set; }
        public string DescricaoSaida { get; set; }
        public int EspecieSaida { get; set; }
        //saldo inicial
        public int IdSaldoInicial { get; set; }
        public DateTime Data { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal Troco { get; set; }
        //status
        public int IDStatus { get; set; }
        //plano de contas
        public string DescricaoPlano { get; set; }
        public decimal ValorPlano { get; set; }
        public DateTime DataPlano { get; set; }
        public string Doc { get; set; }
        public string Parcela { get; set; }
        public string ObsPlano { get; set; }


        public DataCadastros()
        {

        }

        public DataCadastros(int idEmpresa, string nomeFantasia, string cnpj, int idCentroCusto, string descricaoCentroCusto, int idCategoria, 
            string nomeCategoria, int idSubCategoria, string nomeSubCategoria, int idPagamento, string descricaoPagamento, int idTipoEntrada, 
            string descricaoEntrada, int especieEntrada, int idTipoSaida, string descricaoSaida, int especieSaida, int idSaldoInicial, 
            DateTime data, decimal saldoInicial, decimal troco, int status, string descricaoPlano, decimal valorPlano, 
            DateTime dataPlano, string doc, string parcela, string obsPlano)
        {
            IdEmpresa = idEmpresa;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            IdCentroCusto = idCentroCusto;
            DescricaoCentroCusto = descricaoCentroCusto;
            IdCategoria = idCategoria;
            NomeCategoria = nomeCategoria;
            IdSubCategoria = idSubCategoria;
            NomeSubCategoria = nomeSubCategoria;
            IdPagamento = idPagamento;
            DescricaoPagamento = descricaoPagamento;
            IdTipoEntrada = idTipoEntrada;
            DescricaoEntrada = descricaoEntrada;
            EspecieEntrada = especieEntrada;
            IdTipoSaida = idTipoSaida;
            DescricaoSaida = descricaoSaida;
            EspecieSaida = especieSaida;
            IdSaldoInicial = idSaldoInicial;
            Data = data;
            SaldoInicial = saldoInicial;
            Troco = troco;
            IDStatus = status;
            DescricaoPlano = descricaoPlano;
            ValorPlano = valorPlano;
            DataPlano = dataPlano;
            Doc = doc;
            Parcela = parcela;
            ObsPlano = obsPlano;
        }

        private SqlCommand command = new SqlCommand();
        #region EMPRESA
        public string EmpresaCadastro(DataCadastros Empresa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_empresa (nome_fantasia, cnpj) values (@nome_fantasia, @cnpj)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nome_fantasia", Empresa.NomeFantasia);
                    command.Parameters.AddWithValue("@cnpj", Empresa.Cnpj);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar empresa";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }

        }
        public DataTable EmpresaLista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_empresa";
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
        public bool EmpresaValida(DataCadastros Empresa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_empresa WHERE cnpj=@cnpj";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@cnpj", Empresa.Cnpj);
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
        public string EmpresaDelete(DataCadastros Empresa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_empresa WHERE id=@idEmpresa";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idEmpresa", Empresa.IdEmpresa);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        #endregion EMPRESA
        //
        #region CENTRO DE CUSTO
        public string CentroCusto_Cadastro(DataCadastros Custo)
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
                    command.Parameters.AddWithValue("@descricao", Custo.DescricaoCentroCusto);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable CentroCusto_Lista()
        {
            using (var connection = GetConnection())
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
        public string CentroCusto_Delete(DataCadastros Custo)
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
                    command.Parameters.AddWithValue("@id_centro_custo", Custo.IdCentroCusto);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao tentar excluir";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public bool CentroCusto_Valida(DataCadastros Custo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_centro_custo WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", Custo.DescricaoCentroCusto);
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
        #endregion CENTRO DE CUSTO
        //
        #region CATEGORIAS
        public string Categoria_Cadastro(DataCadastros Categoria)
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
                    command.Parameters.AddWithValue("@nome_categoria", Categoria.NomeCategoria);
                    command.Parameters.AddWithValue("@id_centro_custo", Categoria.IdCentroCusto);
                    command.Parameters.AddWithValue("@nome_sub_categoria", Categoria.NomeSubCategoria);
                    rpta = command.ExecuteNonQuery() == 2 ? "OK" : "Erro ao cadastrar";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable Categoria_Lista()
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
        public DataTable Categoria_ListaSubCategoria()
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
        public string Categoria_Delete(DataCadastros Categoria)
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
                    command.Parameters.AddWithValue("@id_categoria", Categoria.IdCategoria);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao tentar excluir";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public bool Categoria_Valida(DataCadastros Categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_categoria WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", Categoria.NomeCategoria);
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
        public bool Categoria_ValidaSubCategoria(DataCadastros Categoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SElECT * FROM tb_sub_categoria WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", Categoria.NomeSubCategoria);
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
        #endregion CATEGORIAS
        //
        #region FORMAS DE PAGAMENTO
        public string Pagamento_Cadastro(DataCadastros Pagto)
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
                    command.Parameters.AddWithValue("@descricao", Pagto.DescricaoPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public string Pagamento_Update(DataCadastros Pagto)
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
                    command.Parameters.AddWithValue("@descricao", Pagto.DescricaoPagamento);
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
        public bool Pagamento_Valida(DataCadastros Pagto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_forma_pagamento WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", Pagto.DescricaoPagamento);
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
        public DataTable Pagamento_Lista()
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
        public string Pagamento_Delete(DataCadastros Pagto)
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
                    command.Parameters.AddWithValue("@id_pagamento", Pagto.IdPagamento);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        #endregion FORMA DE PAGAMENTO
        //
        #region TIPO ENTRADA e SAIDA
        public string TipoSaida_Cadastro(DataCadastros TSaida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_tipo_saida (descricao, dinheiro) VALUES (@descricao, @dinheiro)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TSaida.DescricaoSaida);
                    command.Parameters.AddWithValue("@dinheiro", TSaida.EspecieSaida);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public string TipoSaida_Update(DataCadastros TSaida)
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
                    command.Parameters.AddWithValue("@descricao", TSaida.DescricaoSaida);
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
        public bool TipoSaida_Valida(DataCadastros TSaida)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_saida WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TSaida.DescricaoSaida);
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
        public DataTable TipoSaida_Lista()
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
        public string TipoSaida_Delete(DataCadastros TSaida)
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
                    command.Parameters.AddWithValue("@id_tipo_saida", TSaida.IdTipoSaida);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //entrada
        public string TipoEntrada_Cadastro(DataCadastros TEntrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO tb_tipo_entrada (descricao, dinheiro) VALUES (@descricao, @dinheiro)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TEntrada.DescricaoEntrada);
                    command.Parameters.AddWithValue("@dinheiro", TEntrada.EspecieEntrada);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "erro ao cadastrar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public string TipoEntrada_Update(DataCadastros TEntrada)
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
                    command.Parameters.AddWithValue("@descricao", TEntrada.DescricaoEntrada);
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
        public bool TipoEntrada_Valida(DataCadastros TEntrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_tipo_entrada WHERE descricao=@descricao";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@descricao", TEntrada.DescricaoEntrada);
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
        public DataTable TipoEntrada_Lista()
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
        public string TipoEntrada_Delete(DataCadastros TEntrada)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM tb_tipo_entrada WHERE id=@id_tipo_entrada";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_tipo_entrada", TEntrada.IdTipoEntrada);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        #endregion
        //
        #region SALDO INICIAL
        public string SaldoInicial_Cadastro(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "OpeningBalance";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@saldo_inicial", SALDO.SaldoInicial);
                    command.Parameters.AddWithValue("@saldo_final", SALDO.Troco);
                    command.Parameters.AddWithValue("@data", SALDO.Data);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao realizar cadastro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable SaldoInicial_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id, saldo_inicial, saldo_final, Convert(varchar(10), data_entrada, 103) as data_entrada FROM tb_saldo_inicial";
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
        public string SaldoInicial_Delete(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE tb_saldo_inicial WHERE id=@id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", SALDO.IdSaldoInicial);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao deletar";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public bool SaldoInicial_Valida(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select id, valor, CONVERT(varchar(10), data_entrada, 103) as data_entrada " +
                        "from tb_saldo_inicial WHERE data_entrada = @data_entrada";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@data_entrada", SALDO.Data);
                    var resultado = command.ExecuteScalar();
                    if (resultado !=null)
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
        public string SaldoInicial_Update(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE tb_saldo_inicial SET valor=@valor WHERE data_entrada=@data_entrada";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@valor", SALDO.SaldoInicial);
                    command.Parameters.AddWithValue("@data_entrada", SALDO.Data);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        //Troco
        public string SaldoInicial_Troco(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "CashBalance";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@saldo", SALDO.Troco);
                    command.Parameters.AddWithValue("@data", SALDO.Data);
                    rpta = command.ExecuteNonQuery() == 1 ? "OK" : "Erro ao atualizar saldo";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }

        }
        //saldo inicial quando dia novo
        public string SaldoInicial_NovoDia(DataCadastros SALDO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "NewOpeningBalance";
                    command.CommandType = CommandType.StoredProcedure;
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

        #endregion
        //
        #region PLANO CONTAS
        public string PlanoContas_Cadastro(DataCadastros PLANO)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string rpta = "";
                try
                {
                    command.Connection = connection;
                    command.CommandText = "PlanoContas";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@descricao", PLANO.DescricaoPlano);
                    command.Parameters.AddWithValue("@valor", PLANO.ValorPlano);
                    command.Parameters.AddWithValue("@data", PLANO.DataPlano);
                    command.Parameters.AddWithValue("@id_status", PLANO.IDStatus);
                    command.Parameters.AddWithValue("@id_pagamento", PLANO.IdPagamento);
                    command.Parameters.AddWithValue("@doc", PLANO.Doc);
                    command.Parameters.AddWithValue("@parcela", PLANO.Parcela);
                    command.Parameters.AddWithValue("@id_empresa", PLANO.IdEmpresa);
                    command.Parameters.AddWithValue("@id_sub_categoria", PLANO.IdSubCategoria);
                    //command.Parameters.AddWithValue("@id_tipo_entrada", PLANO.IdTipoEntrada);
                    //command.Parameters.AddWithValue("@id_tipo_saida", PLANO.IdTipoSaida);
                    command.Parameters.AddWithValue("@observacao", PLANO.ObsPlano);
                    rpta = command.ExecuteNonQuery() == 1 ?  "OK" : "Error";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                return rpta;
            }
        }
        public DataTable PlanoContas_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_plano_contas";
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
        public DataTable Status_Lista()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM tb_status";
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
        //plano consolidado
        public DataTable PlanoContas_Consolidado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                DataTable dt = new DataTable();
                try
                {
                    command.Connection = connection;
                    command.CommandText = "select pc.descricao, SUM(pc.valor) as Valor, Convert(varchar(10), pc.data_pagamento, 103) as Data, Month(pc.data_pagamento)as Mes " +
                        "from tb_plano_contas pc GROUP BY pc.descricao, pc.valor, pc.data_pagamento ORDER BY pc.data_pagamento asc";
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

        #endregion PLANO CONTAS
    }
}
