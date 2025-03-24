using System;

namespace tabuleiro.exceptions
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) 
        { 
        }
    }
}
