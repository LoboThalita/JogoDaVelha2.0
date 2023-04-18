using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha2._0.Interfaces
{
    public interface IJogador
    {
        public char peca { get; set; }
        public string nome { get; set; }

        public void Jogar();
    }
}
