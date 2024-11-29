using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yanez_Pablo_Examan2.Models;

namespace Yanez_Pablo_Examan2.Interfaces
{
    public interface IRecargaRepository
    {
        List<RecargaModel> ObtenerRecargas();
        RecargaModel ObtenerRecargaPorId(int Id);
        bool CrearRecarga(RecargaModel recarga);
        bool ActualizarRecarga(RecargaModel recarga);
        bool EliminarRecarga(int Id);

    }
}
