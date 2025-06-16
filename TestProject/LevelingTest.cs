using SoalLibrary;
using TubesKPL;

namespace TestProject;

[TestClass]
public class LevelingTest
{
    private const string testFilePath = "data_level.json";
    private LevelService service;

    [TestInitialize]
    public void Setup()
    {
        if (File.Exists(testFilePath))
            File.Delete(testFilePath);

        service = new LevelService(testFilePath);
    }

    [TestMethod]
    public void LoadLevels1()
    {
        var levels = service.LoadLevels();
        Assert.AreEqual(0, levels.Count);
    }

    [TestMethod]
    public void AddLevel1()
    {
        var levels = new List<Level>();
        var level = service.AddLevel(levels, "Level 1");

        Assert.AreEqual(1, levels.Count);
        Assert.AreEqual("Level 1", level.NamaLevel);
        Assert.AreEqual(1, level.IdLevel);
    }

    [TestMethod]
    public void EditLevel1()
    {
        var level = new Level { IdLevel = 1, NamaLevel = "level 1" };
        service.EditLevel(level, "Level 1");

        Assert.AreEqual("Level 1", level.NamaLevel);
    }

    [TestMethod]
    public void DeleteLevel1()
    {
        var level = new Level { IdLevel = 1, NamaLevel = "Delete" };
        var levels = new List<Level> { level };

        service.DeleteLevel(levels, level);

        Assert.AreEqual(0, levels.Count);
    }

    [TestMethod]
    public void SaveAndLoadLevels1()
    {
        var levelsToSave = new List<Level>
            {
                new Level { IdLevel = 1, NamaLevel = "Saved", SoalList = new List<Soal>() }
            };

        service.SaveLevels(levelsToSave);

        var loadedLevels = service.LoadLevels();

        Assert.AreEqual(1, loadedLevels.Count);
        Assert.AreEqual("Saved", loadedLevels[0].NamaLevel);
    }
}

