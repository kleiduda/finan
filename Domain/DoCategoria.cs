using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class DoCategoria
    {
        public static string CadastroCategoria(string nomeCategoria, int idCentroCusto, string nomeSubCategoria)
        {
            DataCategoria obj = new DataCategoria();
            obj.NomeCategoria = nomeCategoria;
            obj.IdCentroCusto = idCentroCusto;
            obj.NomeSubCategoria = nomeSubCategoria;
            return obj.CadastroCategoria(obj);
        }
        public static string DeleteCategoria(int idCategoria)
        {
            DataCategoria obj = new DataCategoria();
            obj.IdCategoria = idCategoria;
            return obj.DeleteCategoria(obj);
        }
        public static DataTable ListCategoria()
        {
            return new DataCategoria().ListCategorias();
        }
        public static DataTable ListSubCategoria()
        {
            return new DataCategoria().ListSubCategorias();
        }
        public static bool Valida(string descricao)
        {
            DataCategoria obj = new DataCategoria();
            obj.NomeCategoria = descricao;
            return obj.Valida(obj);
        }
        public static bool ValidaSub(string descricao)
        {
            DataCategoria obj = new DataCategoria();
            obj.NomeSubCategoria = descricao;
            return obj.ValidaSub(obj);
        }
    }
}
