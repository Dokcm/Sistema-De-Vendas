using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.BLL
{
    internal class transacaodetalhesBLL
    {
        public int id { get; set; }
        public int produto_id { get; set; }
        public decimal avaliacao { get; set; }
        public decimal qti { get; set; }
        public decimal total { get; set;}
        public int cli_id { get; set; }
        public DateTime add_data { get; set; }
        public int add_por { get; set; }

    }
}
