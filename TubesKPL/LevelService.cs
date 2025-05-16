using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SoalLibrary;

namespace TubesKPL
{
    public class LevelService
    {
        private readonly string filePath;

        public LevelService(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Level> LoadLevels()
        {
            if (!File.Exists(filePath))
                return new List<Level>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Level>>(json);
        }

        public void SaveLevels(List<Level> levels)
        {
            var json = JsonSerializer.Serialize(levels, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public Level AddLevel(List<Level> levels, string namaLevel)
        {
            int newId = levels.Any() ? levels.Max(lv => lv.IdLevel) + 1 : 1;
            var newLevel = new Level
            {
                IdLevel = newId,
                NamaLevel = namaLevel,
                SoalList = new List<Soal>()
            };
            levels.Add(newLevel);
            return newLevel;
        }

        public void EditLevel(Level level, string newName)
        {
            level.NamaLevel = newName;
        }

        public void DeleteLevel(List<Level> levels, Level toDelete)
        {
            levels.Remove(toDelete);
        }
    }
}

