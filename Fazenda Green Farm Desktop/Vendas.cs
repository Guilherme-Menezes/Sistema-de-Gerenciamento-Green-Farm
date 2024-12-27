using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda4
{
    internal class Vendas
    {
        DB db = new DB();
        public String Setor { get; set; }
        public int Ano { get; set; }
        public Decimal Valor { get; set; }

        public Vendas()
        {

        }
        public Vendas(int ano, String setor, Decimal valor)
        {
            Ano = ano;
            Setor = setor;
            Valor = valor;
        }

        public List<Vendas> VendasMensais(int ano, int mes, String emailUsu)
        {
            Formularios fm = new Formularios();
            int id = fm.EncontrarIDUsuario(fm.EncontrarcpfUsuario(emailUsu));
            var VendasSetor = new List<Vendas>();


            db.OpenConnection();
            string query = "SELECT descricaoCategoria, SUM(ValorPedido) AS ValorTotal FROM tbVenda inner join tbItensVenda on tbItensVenda.idVenda = tbVenda.idVenda inner join tbProduto on tbProduto.idProduto = tbItensVenda.idProduto inner join tbCategoria on tbProduto.idCategoria = tbCategoria.idCategoria WHERE MONTH(DtVenda) =@Mes  AND YEAR(DtVenda) = @Ano AND idUsuario = @id GROUP BY descricaoCategoria";

            using (SqlCommand cmd = new SqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Ano", ano);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string setor = reader["descricaoCategoria"].ToString();
                    decimal valor = Convert.ToDecimal(reader["ValorTotal"]);

                    VendasSetor.Add(new Vendas( ano, setor, valor));
                }
            }
            return VendasSetor;

        }



    public String[] getNomeSetores(List<Vendas> vendas)
        {
            string[] setores = new string[vendas.Count];

            for(int i = 0; i< vendas.Count; i++)
            {
                setores[i] = vendas[i].Setor;
            }

            return setores;
        }

        public decimal[] getValoresSetores(List<Vendas> vendas)
        {
            decimal[] valores = new decimal[vendas.Count];

            for (int i = 0; i < vendas.Count; i++)
            {
                valores[i] = vendas[i].Valor;
            }

            return valores;
        }
    }
}
