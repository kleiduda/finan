using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

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
        #endregion CENTRO CUSTO
        //
        #region CATEGORIAS e SUBCATEGORIAS
        public static string Categoria_Cadastro(string nomeCategoria, int idCentroCusto, string nomeSubCategoria)
        {
            DataCadastros obj = new DataCadastros();
            obj.NomeCategoria = nomeCategoria;
            obj.IdCentroCusto = idCentroCusto;
            obj.NomeSubCategoria = nomeSubCategoria;
            return obj.Categoria_Cadastro(obj);
        }
        public static string Categoria_Delete(int idCategoria)
        {
            DataCadastros obj = new DataCadastros();
            obj.IdCategoria = idCategoria;
            return obj.Categoria_Delete(obj);
        }
        public static DataTable Categori_Lista()
        {
            return new DataCadastros().Categoria_Lista();
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
        public static string Pagamento_Update(string descricao)
        {
            DataCadastros obj = new DataCadastros();
            obj.DescricaoPagamento = descricao;
            return obj.Pagamento_Update(obj);
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
        public static string TipoEntrada_Update(string descricao)
        {
            DataCadastros obj = new DataCadastros();
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
        public static string TipoSaida_Update(string descricao)
        {
            DataCadastros obj = new DataCadastros();
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
        #endregion TIPO ENTRADA
    }


}


