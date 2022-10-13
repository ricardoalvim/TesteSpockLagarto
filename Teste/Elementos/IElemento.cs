using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Elementos
{
    public interface IElemento
    {
        public IElemento Jogar(IElemento elemento);
    }
}
