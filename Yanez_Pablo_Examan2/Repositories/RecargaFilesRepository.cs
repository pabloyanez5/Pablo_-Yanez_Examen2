using Newtonsoft.Json;
using Yanez_Pablo_Examan2.Interfaces;
using Yanez_Pablo_Examan2.Models;

namespace Yanez_Pablo_Examan2.Repositories;

internal class RecargaFilesRepository : IRecargaRepository
{
    private readonly string _fileName = Path.Combine(FileSystem.AppDataDirectory, "recargas.txt");

    public bool ActualizarRecarga(RecargaModel recarga)
    {
        try
        {
            var recargas = ObtenerRecargas();
            var index = recargas.FindIndex(r => r.Id == recarga.Id);
            if (index != -1)
            {
                recargas[index] = recarga;
                GuardarRecargas(recargas);
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
            GuardarRecargas(recargas);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool EliminarRecarga(int id)
    {
        try
        {
            var recargas = ObtenerRecargas();
            recargas.RemoveAll(r => r.Id == id);
            GuardarRecargas(recargas);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public RecargaModel? ObtenerRecargaPorId(int id)
    {
        return ObtenerRecargas().FirstOrDefault(r => r.Id == id);
    }

    public List<RecargaModel> ObtenerRecargas()
    {
        if (File.Exists(_fileName))
        {
            var data = File.ReadAllText(_fileName);
            return JsonConvert.DeserializeObject<List<RecargaModel>>(data) ?? new List<RecargaModel>();
        }
        return new List<RecargaModel>();
    }

    private void GuardarRecargas(List<RecargaModel> recargas)
    {
        var recargasJson = JsonConvert.SerializeObject(recargas, Formatting.Indented);
        File.WriteAllText(_fileName, recargasJson);
    }
}
