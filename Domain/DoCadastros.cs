using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using DataAccess;
using Support;

namespace Domain
{
    public class DoCadastros
    {
        #region EMPRESA
        public static string EmpresaCadastro(string nomeFantasia, string cnpj)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeFantasia = nomeFantasia;
            obj.Cnpj = cnpj;
            return obj.EmpresaCadastro(obj);
        }
        public static DataTable EmpresaLista()
        {
            return new DataCadastros().EmpresaLista();
        }
        public static bool EmpresaValida(string cnpj)
        {
            DataCadastros obj = new DataCadastros();
            obj.Cnpj = cnpj;
            return obj.EmpresaValida(obj);
        }
        public static string Empresa_Delete(int idEmpresa)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdEmpresa = idEmpresa;
            return obj.EmpresaDelete(obj);
        }
        #endregion EMPRESA
        //
        #region CENTRO CUSTO
        public static string CentroCusto_Cadastro(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoCentroCusto = descricao;
            return obj.CentroCusto_Cadastro(obj);
        }
        public static string CentroCusto_Delete(int idCentroCusto)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCentroCusto = idCentroCusto;
            return obj.CentroCusto_Delete(obj);
        }
        public static DataTable CentroCusto_Lista()
        {
            return new DataCadastros().CentroCusto_Lista();
        }
        public static bool CentroCusto_Valida(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoCentroCusto = descricao;
            return obj.CentroCusto_Valida(obj);
        }
        public static DataTable CentroCusto_ListaPorID(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCentroCusto = id;
            return obj.CentroCusto_ListaPorID(obj);
        }
        public static string CentroCusto_Update(int id, string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCentroCusto = id;
            obj.DescricaoCentroCusto = descricao;
            return obj.CentroCusto_Update(obj);
        }
        #endregion CENTRO CUSTO
        //
        #region CATEGORIAS e SUBCATEGORIAS
        public static string Categoria_Cadastro(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeCategoria = descricao;
            return obj.Categoria_Cadastro(obj);
        }
        public static string Categoria_Agrupamento(string descricaoCategoria, int idCentroCusto, int idCategoria, string descricaoSub)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeCategoria = descricaoCategoria;
            obj.IdCentroCusto = idCentroCusto;
            obj.IdCategoria = idCategoria;
            obj.NomeSubCategoria = descricaoSub;
            return obj.Categoria_Cadastro(obj);
        }
        public static string SubCategoria_Cadastro(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeSubCategoria = descricao;
            return obj.SubCategoria_Cadastro(obj);
        }
        public static string Categoria_Delete(int idCategoria)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCategoria = idCategoria;
            return obj.Categoria_Delete(obj);
        }
        public static DataTable Categoria_Lista()
        {
            return new DataCadastros().Categoria_Lista();
        }
        public static DataTable Categoria_Lista2()
        {
            return new DataCadastros().Categoria_Lista2();
        }
        public static DataTable Categoria_ListaPorID(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCategoria = id;
            return obj.Categoria_ListaPorID(obj);
        }
        public static DataTable Categoria_ListaSubCategoria()
        {
            return new DataCadastros().Categoria_ListaSubCategoria();
        }
        public static bool Categoria_Valida(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeCategoria = descricao;
            return obj.Categoria_Valida(obj);
        }
        public static bool Categoria_ValidaSubCategoria(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeSubCategoria = descricao;
            return obj.Categoria_ValidaSubCategoria(obj);
        }
        #endregion CATEGORIAS e SUBCATEGORIAS
        //
        #region FORMA DE PAGAMENTO
        public static string Pagamento_Cadastro(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoPagamento = descricao;
            return obj.Pagamento_Cadastro(obj);
        }
        public static bool Pagamento_Valida(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoPagamento = descricao;
            return obj.Pagamento_Valida(obj);
        }
        public static string Pagamento_Update(int id,string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdPagamento = id;
            obj.DescricaoPagamento = descricao;
            return obj.Pagamento_Update(obj);
        }
        public static DataTable Pagamento_ListaPorID(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdPagamento = id;
            return obj.Pagamento_ListaPorID(obj);
        }
        //listar cadastros
        public static DataTable Pagamento_Lista()
        {
            return new DataCadastros().Pagamento_Lista();
        }
        public static string Pagamento_Delete(int idPagamento)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdPagamento = idPagamento;
            return obj.Pagamento_Delete(obj);
        }
        #endregion
        //
        #region TIPO ENTRADA
        public static string TipoEntrada_Cadastro(string descricao, int especie)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoEntrada = descricao;
            obj.EspecieEntrada = especie;
            return obj.TipoEntrada_Cadastro(obj);
        }
        public static bool TipoEntrada_Valida(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoEntrada = descricao;
            return obj.TipoEntrada_Valida(obj);
        }
        public static string TipoEntrada_Update(int id,string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoEntrada = id;
            obj.DescricaoEntrada = descricao;
            return obj.TipoEntrada_Update(obj);
        }
        //listar cadastros
        public static DataTable TipoEntrada_Lista()
        {
            return new DataCadastros().TipoEntrada_Lista();
        }
        public static string TipoEntrada_Delete(int idTipoEntrada)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoEntrada = idTipoEntrada;
            return obj.TipoEntrada_Delete(obj);
        }
        public static DataTable TipoEntrada_ListaPorID(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoEntrada = id;
            return obj.TipoEntrada_ListaPorID(obj);
        }
        #endregion TIPO ENTRADA
        #region TIPO SAIDA
        public static string TipoSaida_Cadastro(string descricao, int especie)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoSaida = descricao;
            obj.EspecieSaida = especie;
            return obj.TipoSaida_Cadastro(obj);
        }
        public static bool TipoSaida_Valida(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoSaida = descricao;
            return obj.TipoSaida_Valida(obj);
        }
        public static string TipoSaida_Update(int id, string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoSaida = id;
            obj.DescricaoSaida = descricao;
            return obj.TipoSaida_Update(obj);
        }
        //listar cadastros
        public static DataTable TipoSaida_Lista()
        {
            return new DataCadastros().TipoSaida_Lista();
        }
        public static string TipoSaida_Delete(int idTipoEntrada)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoSaida = idTipoEntrada;
            return obj.TipoSaida_Delete(obj);
        }
        public static DataTable TipoSaida_ListaPorID(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdTipoSaida = id;
            return obj.TipoSaida_ListaPorID(obj);
        }
        #endregion TIPO ENTRADA
        //
        #region SALDO INICIAL
        public static string SaldoInicial_Cadastro(decimal saldoInicial, decimal saldoFinal, DateTime data)
        {
            DataCadastros obj = new DataCadastros();
            obj.SaldoInicial = saldoInicial;
            obj.Troco = saldoFinal;
            obj.Data = data;
            return obj.SaldoInicial_Cadastro(obj);
        }
        public static DataTable SaldoInicial_Lista()
        {
            return new DataCadastros().SaldoInicial_Lista();
        }
        public static string SaldoInicial_Delete(int id)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdSaldoInicial = id;
            return obj.SaldoInicial_Delete(obj);
        }
        public static bool SaldoInicial_Valida(DateTime data)
        {
            DataCadastros obj = new DataCadastros();
            obj.Data = data;
            return obj.SaldoInicial_Valida(obj);
        }
        public static string SaldoInicial_Update(decimal saldoInicial, DateTime data)
        {
            DataCadastros obj = new DataCadastros();
            obj.SaldoInicial = saldoInicial;
            obj.Data = data;
            return obj.SaldoInicial_Update(obj);
        }
        //troco
        public static string SaldoInicial_Troco(decimal troco, DateTime data)
        {
            DataCadastros obj = new DataCadastros();
            obj.Troco = troco;
            obj.Data = data;
            return obj.SaldoInicial_Troco(obj);
        }
        //saldo inicial quando novo dia
        public static string SaldoInicial_NovoDia(DateTime data)
        {
            DataCadastros obj = new DataCadastros();;
            obj.Data = data;
            return obj.SaldoInicial_NovoDia(obj);
        }
        #endregion
        //
        #region PLANO CONTAS
        public static string PlanoContas_Cadastro(string descricao, decimal valor, DateTime data, int status, int pagamento, string doc, string parcela, 
            int empresa, int subCategoria, string observacao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoPlano = descricao;
            obj.ValorPlano = valor;
            obj.DataPlano = data;
            obj.IDStatus = status;
            obj.IdPagamento = pagamento;
            obj.Doc = doc;
            obj.Parcela = parcela;
            obj.IdEmpresa = empresa;
            obj.IdSubCategoria = subCategoria;
            //obj.IdTipoEntrada = tipoEntrada;
            //obj.IdTipoSaida = tipoSaida;
            obj.ObsPlano = observacao;
            return obj.PlanoContas_Cadastro(obj);
        }
        public static DataTable PlanoContas_Lista()
        {
            return new DataCadastros().PlanoContas_Lista();
        }
        public static DataTable PlanoContas_FiltroData(DateTime inicio, DateTime fim, string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DataPlano = inicio;
            obj.DataFim = fim;
            obj.DescricaoPlano = descricao;
            return obj.PlanoContas_FiltroData(obj);
        }
        public static DataTable Status_Lista()
        {
            return new DataCadastros().Status_Lista();
        }
        //consolidado
        public static DataTable PlanoContas_Consolidado()
        {
            return new DataCadastros().PlanoContas_Consolidado();
        }
        public static DataTable PlanoContas_Pesquisa(string texto)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoPlano = texto;
            return obj.PlanoContas_Pesquisa(obj);
        }
        #endregion 
    }


}


