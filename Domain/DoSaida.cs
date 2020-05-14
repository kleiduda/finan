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
    public class DoSaida
    {
        public static string CadastroSaida(DateTime data, decimal valor, string observacao, int idSaida, int idPagamento)
        {
            DataSaida obj = new DataSaida();
            obj.Data = data;
            obj.Valor = valor;
            obj.Observacao = observacao;
            obj.IdSaida = idSaida;
            obj.IdPagamento = idPagamento;
            return obj.CadastroSaida(obj);
        }
        public static DataTable ListSaida()
        {
            return new DataSaida().ListSaida();
        }
    }
}
