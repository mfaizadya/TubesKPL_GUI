using System.Text.Json;
namespace SoalLibrary
{
    public enum JenisSoal { Esai, PilihanGanda }


    public static class SoalManager
    {
        private static string filePath = "data_level.json";

        public static List<Soal> Load()
        {
            if (!File.Exists(filePath)) return new List<Soal>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Soal>>(json) ?? new List<Soal>();
        }

        public static void Save(List<Soal> soalList)
        {
            string json = JsonSerializer.Serialize(soalList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void Add(Soal soal)
        {
            var data = Load();
            soal.Id = data.Count > 0 ? data.Max(s => s.Id) + 1 : 1;
            data.Add(soal);
            Save(data);
        }

        public static void Edit(Soal soalBaru)
        {
            var data = Load();
            var index = data.FindIndex(s => s.Id == soalBaru.Id);
            if (index != -1)
            {
                data[index] = soalBaru;
                Save(data);
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
        }
    }
}

