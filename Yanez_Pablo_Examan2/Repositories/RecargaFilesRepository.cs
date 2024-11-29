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
            try
            {
                var recargas = ObtenerRecargas();
                var index = recargas.FindIndex(r => r.Id == recarga.Id);
                
                if (index != -1)
                {
                    recargas[index] = recarga;
                    string recargasJson = JsonConvert.SerializeObject(recargas);
                    File.WriteAllText(_fileName, recargasJson);
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }
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
            try
            {
                var recargas = ObtenerRecargas();
                recargas.RemoveAll(r => r.Id == Id);

                string recargasJson = JsonConvert.SerializeObject(recargas);
                File.WriteAllText(_fileName, recargasJson);
                return true;
            }
            catch { return false; }
        }

        public RecargaModel ObtenerRecargaPorId(int Id)
        {
            var recargas = ObtenerRecargas();
            return recargas.Find(r => r.Id == Id);
        }

        public List<RecargaModel> ObtenerRecargas()
        {
            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);
                return JsonConvert.DeserializeObject<List<RecargaModel>>(data) ?? new List<RecargaModel>();
            }
            return new List<RecargaModel>();
        }
    }
}
