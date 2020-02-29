using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaPolimofismo.Entities
{
    public class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }


        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }


        public virtual string EtiquetaPreco()
        {
           return "Produto Comum - " + Nome + ", Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
