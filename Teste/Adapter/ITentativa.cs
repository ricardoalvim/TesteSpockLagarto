using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Elementos;
using Teste.Enum;

namespace Teste.Adapter
{
    public interface ITentativa
    {
        public IElemento? Equivalente(Elemento elemento);
    }
}
