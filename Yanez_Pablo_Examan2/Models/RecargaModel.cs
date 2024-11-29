using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanez_Pablo_Examan2.Models
{
    public class RecargaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }  
    }
}
