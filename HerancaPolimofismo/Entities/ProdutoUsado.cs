using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaPolimofismo.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }


        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabr) : base(nome, preco)
        {
            this.DataFabricacao = dataFabr;
        }


        public override string EtiquetaPreco()
        {
          return this.Nome + " (Usado) $ " + this.Preco.ToString("F2", CultureInfo.InvariantCulture) + " (Data de fabricação - " + this.DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
