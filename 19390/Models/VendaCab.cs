using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19390.Models
{
    internal class VendaCab
    {
        public int Id { get; set; }
        public int idCliente { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
    }
}
