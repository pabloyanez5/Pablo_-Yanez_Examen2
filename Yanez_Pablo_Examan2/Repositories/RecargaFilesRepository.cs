using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Yanez_Pablo_Examan2.Interfaces;
using Yanez_Pablo_Examan2.Models;

namespace Yanez_Pablo_Examan2.Repositories
{
    internal class RecargaFilesRepository : IRecargaRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "recargas.txt");
        public bool ActualizarRecarga(RecargaModel recarga)
        {
            throw new NotImplementedException();
        }

        public bool CrearRecarga(RecargaModel recarga)
        {
            try
            {
                var recargas = ObtenerRecargas();
                recarga.Id = recargas.Count + 1;
                recargas.Add(recarga);

                string recargasJson = JsonConvert.SerializeObject(recargas);
                File.WriteAllText(_fileName, recargasJson);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRecarga(int Id)
        {
            throw new NotImplementedException();
        }

        public RecargaModel ObtenerRecargaPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<RecargaModel> ObtenerRecargas()
        {
            throw new NotImplementedException();
        }
    }
}
