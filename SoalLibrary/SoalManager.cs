using System.Text.Json;
namespace SoalLibrary
{
    // Enumerasi untuk mendefinisikan jenis soal
    public enum JenisSoal { Esai, PilihanGanda }

    // Static class untuk manajemen soal (CRUD)
    public static class SoalManager
    {
        public static string filePath = "data_level.json";

        // Memuat data soal dari file JSON
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

        // Menyimpan list soal ke file JSON
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

        // Menambah soal baru ke dalam file
        public static void Add(Soal soal)
        {
            if (soal == null) return;

            var data = Load();

            // Menetapkan ID secara otomatis
            soal.Id = data.Count > 0 ? data.Max(s => s.Id) + 1 : 1;

            data.Add(soal);
            Save(data);
        }

        // Mengedit soal yang sudah ada berdasarkan ID
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

        // Menghapus soal berdasarkan ID
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

