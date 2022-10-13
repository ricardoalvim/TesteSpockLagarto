using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Elementos;
using Teste.Enum;

namespace Teste.Adapter
{
    public class Tentativa : ITentativa
    {
        public IElemento? Equivalente(Elemento elemento)
        {
            if (elemento.Equals(Elemento.PAPEL))
                return new Papel();
            else if (elemento.Equals(Elemento.SPOCK))
                return new Spock();
            else if (elemento.Equals(Elemento.TESOURA))
                return new Tesoura();
            else if (elemento.Equals(Elemento.PEDRA))
                return new Pedra();
            else if (elemento.Equals(Elemento.LAGARTO))
                return new Lagarto();
            return null;
        }
    }
}
