using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
   public class DoPagamento
    {
        #region TIPO PAGAMENTO
        public static string CadastroPagamento(string descricao)
        {
            DataPagamento obj = new DataPagamento();
            obj.Descricao = descricao;
            return obj.CadastroPagamento(obj);
        }
        public static bool ValidaTipo(string descricao)
        {
            DataPagamento obj = new DataPagamento();
            obj.Descricao = descricao;
            return obj.ValidaPagamento(obj);
        }
        public static string UpdatePagamento(string descricao)
        {
            DataPagamento obj = new DataPagamento();
            obj.Descricao = descricao;
            return obj.UpdatePagamento(obj);
        }
        //listar cadastros
        public static DataTable ListaPagamento()
        {
            return new DataPagamento().ListaDePagamento();
        }
        public static string DeletePagamento(int idPagamento)
        {
            DataPagamento obj = new DataPagamento();
            obj.IdPagamento = idPagamento;
            return obj.DeletePagamento(obj);
        }
        #endregion TIPO ENTRADA
    }
}
