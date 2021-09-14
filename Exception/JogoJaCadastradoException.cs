using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exception
{
    public class JogoJaCadastradoException : FormatException
    {
        public JogoJaCadastradoException()
                : base("Este já jogo está cadastrado")
        { }
    }
}

