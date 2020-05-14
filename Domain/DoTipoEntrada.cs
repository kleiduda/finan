using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class DoTipoEntrada
    {
        #region TIPO ENTRADa
        public static string CadastroTipoEntrada(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.CadastroTipoEntrada(obj);
        }
        public static bool ValidaTipo(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.ValidaTipo(obj);
        }
        public static string UpdateTipoEntrada(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.UpdateTipoEntrada(obj);
        }
        //listar cadastros
        public static DataTable ListaTipoEntrada()
        {
            return new DataTipoEntrada().ListaDeTipoEntrada();
        }
        public static string DeleteTipoEntrega(int idTipoEntrada)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.IdTipoEntrada = idTipoEntrada;
            return obj.DeleteTipoEntrada(obj);
        }
        #endregion TIPO ENTRADA
        #region TIPO SAIDA
        public static string CadastroTipoSaida(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.CadastroTipoSaida(obj);
        }
        public static bool ValidaTipoSaida(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.ValidaTipoSaida(obj);
        }
        public static string UpdateTipoSaida(string descricao)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.Descricao = descricao;
            return obj.UpdateTipoSaida(obj);
        }
        //listar cadastros
        public static DataTable ListaTipoSaida()
        {
            return new DataTipoEntrada().ListaDeTipoSaida();
        }
        public static string DeleteTipoSaida(int idTipoEntrada)
        {
            DataTipoEntrada obj = new DataTipoEntrada();
            obj.IdTipoEntrada = idTipoEntrada;
            return obj.DeleteTipoSaida(obj);
        }
        #endregion TIPO ENTRADA
    }
}
