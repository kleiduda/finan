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
        public static string Saida_Cadastro(DateTime data, decimal valor, string observacao, int idSaida, int idPagamento)
        {
            DataSaida obj = new DataSaida();
            obj.Data = data;
            obj.Valor = valor;
            obj.Observacao = observacao;
            obj.IdSaida = idSaida;
            obj.IdPagamento = idPagamento;
            return obj.Saida_Cadastro(obj);
        }
        public static DataTable Saida_Lista()
        {
            return new DataSaida().Saida_Lista();
        }
        public static string Saida_Delete(int idSaida)
        {
            DataSaida obj = new DataSaida();
            obj.IdSaida = idSaida;
            return obj.Saida_Delete(obj);
        }
    }
}
