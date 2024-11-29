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
        Boolean CrearRecarga(RecargaModel recarga);
        Boolean ActualizarRecarga(RecargaModel recarga);
        Boolean EliminarRecarga(int Id);

    }
}
