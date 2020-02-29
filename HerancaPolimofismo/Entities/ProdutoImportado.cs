using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimofismo.Entities
{
    public class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }


        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            this.TaxaAlfandega = taxaAlfandega;
        }


        public override string EtiquetaPreco()
        {
            return "Produto Importado - " + this.Nome + ", $ " + this.Preco.ToString("F2", CultureInfo.InvariantCulture) + " Taxa da alfandega - " + this.TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture) + "\n" + "Preco Total: " + TotalProdImp().ToString();
        }


        public double TotalProdImp()
        {
            double total = 0.0;

            total += Preco + TaxaAlfandega;

            return total;
        }
    }
}
