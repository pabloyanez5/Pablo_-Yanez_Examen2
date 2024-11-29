using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yanez_Pablo_Examan2.Interfaces;
using Yanez_Pablo_Examan2.Models;

namespace Yanez_Pablo_Examan2.Repositories
{
    public class RecargaAPIRepository : IRecargaRepository
    {
        public HttpClient _httpClient;
        public string _endpoint = "https://api.ejemplo.com/recargas";

        public RecargaAPIRepository()
        {
            _httpClient = new HttpClient();
        }
        public bool ActualizarRecarga(RecargaModel recarga)
        {
            throw new NotImplementedException();
        }

        public bool CrearRecarga(RecargaModel recarga)
        {
            throw new NotImplementedException();
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
            var respuesta = _httpClient.GetAsync(_endpoint).Result;
            var json = respuesta.Content.ReadAsStringAsync().Result;

            var recargas = JsonConvert.DeserializeObject<List<RecargaModel>>(json);
            return recargas ?? new List<RecargaModel>();
        }
    }
}
