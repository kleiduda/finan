using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Domain
{
    public class DoEntrada
    {
        public static string CadastroEntrada(DateTime data, decimal valor, string observacao, int idEntrada, int idPagamento)
        {
            DataEntrada obj = new DataEntrada();
            obj.Data = data;
            obj.Valor = valor;
            obj.Observacao = observacao;
            obj.IdEntrada = idEntrada;
            obj.IdPagamento = idPagamento;
            return obj.CadastroEntrada(obj);
        }
        public static DataTable ListEntradas()
        {
            return new DataEntrada().ListEntradas();
        }
        public static string Entrada_UpdateSaldoFinal(decimal saldoFinal, DateTime data)
        {
            DataEntrada obj = new DataEntrada();
            obj.SaldoFinal = saldoFinal;
            obj.Data = data;
            return obj.UpdateSaldo(obj);
        }
    }
}
