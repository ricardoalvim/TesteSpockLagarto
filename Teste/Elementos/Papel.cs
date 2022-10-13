using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Elementos
{
    public class Papel : IElemento
    {
        public IElemento Jogar(IElemento elemento)
        {
            if (elemento.GetType().Equals(this.GetType()))
            {
                return this;
            }

            else if (elemento.GetType() == typeof(Spock) || elemento.GetType() == typeof(Pedra))
            {
                return this;
            }
            return elemento;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
