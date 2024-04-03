using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClass
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string sobreNome { get; set; }
        public string endereco { get; set; }
        public bool sexo { get; set; }
        public int situacao { get; set; }
        public bool serasa { get; set; }
        public DateTime dataCadastro { get; set; }
    }
}
