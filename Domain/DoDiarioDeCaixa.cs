using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Domain
{
    public class DoDiarioDeCaixa
    {
        public static DataTable DiarioDeCaixa_ResultadoEntrada()
        {
            return new DataDiarioDeCaixa().DiarioDeCaixaResultadoEntrada();
        }
        public static DataTable DiarioDeCaixaResultadoSaida()
        {
            return new DataDiarioDeCaixa().DiarioDeCaixaResultadoSaida();
        }
        public static DataTable DiarioCaixa_SaldoInicial()
        {
            return new DataDiarioDeCaixa().DiarioCaixa_SaldoInicial();
        }
    }
}
