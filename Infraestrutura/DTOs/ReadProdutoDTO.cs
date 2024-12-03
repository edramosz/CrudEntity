using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.DTOs
{
    public class ReadProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double preco { get; set; }
        public int PessoaId { get; set; }
    }
}
