using System.Text.Json;
namespace SoalLibrary
{
    public enum JenisSoal { Esai, PilihanGanda }


    public static class SoalManager
    {
        public static string filePath = "data_level.json";

        public static List<Soal> Load()
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Soal>>(json) ?? new List<Soal>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SoalManager.Load] Gagal load: {ex.Message}");
                return new List<Soal>();
            }
        }

        public static void Save(List<Soal> soalList)
        {
            try
            {
                string json = JsonSerializer.Serialize(soalList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SoalManager.Save] Gagal simpan: {ex.Message}");
            }
        }

        public static void Add(Soal soal)
        {
            if (soal == null) return;

            var data = Load();
            soal.Id = data.Count > 0 ? data.Max(s => s.Id) + 1 : 1;
            data.Add(soal);
            Save(data);
        }

        public static void Edit(Soal soalBaru)
        {
            if (soalBaru == null) return;
            var data = Load();
            var index = data.FindIndex(s => s.Id == soalBaru.Id);
            if (index != -1)
            {
                data[index] = soalBaru;
                Save(data);
            }
            else
            {
                Console.WriteLine($"[SoalManager.Edit] Soal ID {soalBaru.Id} tidak ditemukan.");
            }
        }

        public static void Delete(int id)
        {
            var data = Load();
            var soal = data.FirstOrDefault(s => s.Id == id);
            if (soal != null)
            {
                data.Remove(soal);
                Save(data);
            }
            else
            {
                Console.WriteLine($"[SoalManager.Delete] Soal ID {id} tidak ditemukan.");
            }
        }
    }
}

