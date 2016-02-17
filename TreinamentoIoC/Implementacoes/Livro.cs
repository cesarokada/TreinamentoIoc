using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoIoC.Implementacoes
{
    public class Livro
    {
        public string Nome { get; set; }
        public DateTime Publicacao { get; set; }
        public int Versao { get; set; }


        public override string ToString()
        {
            StringBuilder b = new StringBuilder();

            b.AppendLine("Nome:" + Nome);
            b.AppendLine("Publicacao:" + Publicacao);
            b.AppendLine("Versao:" + Versao);

            return b.ToString();
        }
    }
}

