using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Domain.Model
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }

        public IEnumerable<Venda> ListagemVendasMocada()
        {
            var venda1 = new Venda { Id = 1, DataVenda = DateTime.Now, Produto = "A", Valor = 20 };
            var venda2 = new Venda { Id = 1, DataVenda = DateTime.Now, Produto = "B", Valor = 30 };
            var venda3 = new Venda { Id = 1, DataVenda = DateTime.Now, Produto = "C", Valor = 45 };
            var venda4 = new Venda { Id = 1, DataVenda = DateTime.Now.AddDays(-1), Produto = "D", Valor = 10 };
            var venda5 = new Venda { Id = 1, DataVenda = DateTime.Now.AddDays(-1), Produto = "E", Valor = 3 };
            var venda6 = new Venda { Id = 1, DataVenda = DateTime.Now.AddDays(-2), Produto = "F", Valor = 2 };
            var venda7 = new Venda { Id = 1, DataVenda = DateTime.Now.AddDays(-2), Produto = "G", Valor = 25 };

            var vendas = new List<Venda>();
            vendas.Add(venda1);
            vendas.Add(venda2);
            vendas.Add(venda3);
            vendas.Add(venda4);
            vendas.Add(venda5);
            vendas.Add(venda6);
            vendas.Add(venda7);

            return vendas;
        }

    }
}
