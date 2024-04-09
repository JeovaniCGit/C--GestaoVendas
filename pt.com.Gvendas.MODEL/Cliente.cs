using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__GestaoVendas.pt.com.Gvendas.MODEL
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Nif { get; set; }
        public string Profissao { get; set; }
        public string Empresa { get; set; }
        public string Pos { get; set;}
        public string Email { get; set;}
        public string Telem { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set;}
        public string Freguesia { get; set; }
        public string Pais { get; set; }
        public Cliente () { }
    }
}
