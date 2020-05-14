using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace Domain
{
    public class DoCentroCusto
    {
        public static string CadastroCentroCusto(string descricao)
        {
            DataCentroCusto obj = new DataCentroCusto();
            obj.Descricao = descricao;
            return obj.CadastroCentroCusto(obj);
        }
        public static string DeleteCentroCusto(int idCentroCusto)
        {
            DataCentroCusto obj = new DataCentroCusto();
            obj.IdCentroCusto = idCentroCusto;
            return obj.DeleteCentroCusto(obj);
        }
        public static DataTable ListCentroCusto()
        {
            return new DataCentroCusto().ListCentroCusto();
        }
        public static bool Valida(string descricao)
        {
            DataCentroCusto obj = new DataCentroCusto();
            obj.Descricao = descricao;
            return obj.Valida(obj);
        }
    }
}
